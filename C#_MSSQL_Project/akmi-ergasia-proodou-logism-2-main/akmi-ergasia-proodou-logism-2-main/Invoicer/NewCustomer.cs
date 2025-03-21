using SQL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Exam04.Common;

namespace Exam04 {
	public partial class NewCustomer : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;
		private readonly int selectedPerson;
		private readonly DataTable newID;

		private List<ItemID> PhoneTypeCollection = new List<ItemID>();
		private List<ItemID> AddressTypeCollection = new List<ItemID>();

		public NewCustomer(SQL_Connector sql, DataTable newID, int selectedPerson = 0) {
			InitializeComponent();
			this.sql   = sql;
			this.newID = newID;
			this.selectedPerson = selectedPerson;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}

		~NewCustomer() {
			pollTimer.Stop();
			pollTimer.Dispose();
		}

		private void FormStatusCheckSQL(object sender, EventArgs e) {
			bool conn = sql.IsValidConnection();

			InsertButton.Enabled = CheckSQL.Checked = conn;
			CheckSQL.Text = $"SQL Status: {(conn ? "Connected" : "Disconnected")}";
		}

		private void NewCustomer_Load(object sender, EventArgs e) {
			TitleTypeDropdown.Populate(sql, "Title", null, @"
				SELECT DISTINCT {} FROM Person.Person WHERE {} IS NOT NULL ORDER BY {}");

			sql.FillExistingDataTable(newID, @"
				SELECT p.FirstName, p.LastName, p.Title, ea.EmailAddress
					FROM Person.Person AS p
					LEFT JOIN Person.BusinessEntityAddress AS bea
						ON p.BusinessEntityID = bea.BusinessEntityID
					LEFT JOIN Person.EmailAddress as ea
						ON p.BusinessEntityID = ea.BusinessEntityID
					WHERE p.BusinessEntityID = @BusinessEntityID;",

				new SqlParameter("@BusinessEntityID", selectedPerson)
			);

			if (selectedPerson == 0) {
				Text = "Update Customer";
				InsertButton.Text = "Update";
			}

			FirstNameField.Text            = newID.GetSafeValue(0, "FirstName", "");
			LastNameField.Text             = newID.GetSafeValue(0, "LastName", "");
			TitleTypeDropdown.SelectedItem = newID.GetSafeValue(0, "Title", "");
			EmailField.Text                = newID.GetSafeValue(0, "EmailAddress", string.Empty);

			PhoneTypeCollection.Clear();
			using (var PhoneTypes = sql.CreateFilledDataTable(@"
				SELECT Name, PhoneNumberTypeID FROM Person.PhoneNumberType;"
			).Value) {
				foreach (DataRow row in PhoneTypes.Rows) {
					PhoneTypeCollection.Add(new ItemID(row.GetSafeValue("Name", ""), row.GetSafeValue("PhoneNumberTypeID", 0)));
				}
			}

			using (var phoneTable = sql.CreateFilledDataTable(@"
				SELECT PhoneNumber, PhoneNumberTypeID FROM Person.PersonPhone
					WHERE BusinessEntityID = @BusinessEntityID;",

				new SqlParameter("@BusinessEntityID", selectedPerson)
			).Value) {
				var Collection = phoneGridView.Columns["PhoneType"].ToType<DataGridViewComboBoxColumn>();
				Collection.DataSource    = PhoneTypeCollection;
				Collection.DisplayMember = "Name";
				Collection.ValueMember   = "ID";

				foreach (DataRow row in phoneTable.Rows) {
					int rowIndex = phoneGridView.Rows.Add(
						null,
						row.GetSafeValue("PhoneNumber", "")
					);

					phoneGridView.Rows[rowIndex].Cells["PhoneType"].Value
						= row.GetSafeValue("PhoneNumberTypeID", 0);
				}
			}

			AddressTypeCollection.Clear();
			using (var AddressTypes = sql.CreateFilledDataTable(@"
				SELECT Name, AddressTypeID FROM Person.AddressType;"
			).Value) {
				foreach (DataRow row in AddressTypes.Rows) {
					AddressTypeCollection.Add(new ItemID(row.GetSafeValue("Name", ""), row.GetSafeValue("AddressTypeID", 0)));
				}
			}

			using (var AddressTable = sql.CreateFilledDataTable(@"
				SELECT a.AddressLine1, a.AddressLine2, a.City, a.PostalCode, bea.AddressTypeID
					FROM Person.BusinessEntityAddress AS bea
					INNER JOIN Person.Address AS a
						ON bea.AddressID = a.AddressID
					INNER JOIN Person.AddressType AS at
						ON bea.AddressTypeID = at.AddressTypeID
					WHERE bea.BusinessEntityID = @BusinessEntityID;",

				new SqlParameter("@BusinessEntityID", selectedPerson)
			).Value) {
				var Collection = addressGridView.Columns["AddressType"].ToType<DataGridViewComboBoxColumn>();
				Collection.DataSource    = AddressTypeCollection;
				Collection.DisplayMember = "Name";
				Collection.ValueMember   = "ID";

				foreach (DataRow row in AddressTable.Rows) {
					int rowIndex = addressGridView.Rows.Add(
						null,
						row.GetSafeValue("AddressLine1", ""),
						row.GetSafeValue("AddressLine2", ""),
						row.GetSafeValue("City", ""),
						row.GetSafeValue("PostalCode", "")
					);

					addressGridView.Rows[rowIndex].Cells["AddressType"].Value
						= row.GetSafeValue("AddressTypeID", 0);
				}
			}

			using (var EmailTable = sql.CreateFilledDataTable(@"
				SELECT EmailAddress, EmailAddressID
					FROM Person.EmailAddress
					WHERE BusinessEntityID = @BusinessEntityID;",

				new SqlParameter("@BusinessEntityID", selectedPerson)
			).Value) {
				foreach (DataRow row in EmailTable.Rows) {
					emailGridView.Rows.Add(
						row.GetSafeValue("EmailAddressID", 0),
						row.GetSafeValue("EmailAddress", "")
					);
				}
			}
		}

		private void CheckSQL_Click(object sender, EventArgs e) {
			FormStatusCheckSQL(this, EventArgs.Empty);
		}

		private void FirstNameField_TextChanged(object sender, EventArgs e) {
			FirstNameField.CheckRequired();
		}

		private void LastNameField_TextChanged(object sender, EventArgs e) {
			LastNameField.CheckRequired();
		}

		private void EmailField_TextChanged(object sender, EventArgs e) {
			EmailField.CheckRequired();
		}

		private void PhoneField_TextChanged(object sender, EventArgs e) {
		//	PhoneField.CheckRequired();
		}

		private void Address1Field_TextChanged(object sender, EventArgs e) {
		//	Address1Field.CheckRequired();
		}

		private void InsertButton_Click(object sender, EventArgs e) {
			if (CheckEmptyFields(FirstNameField, LastNameField)) return;

			if (sql.ExecuteNonQuery(@"
				BEGIN TRY
					BEGIN TRANSACTION;

					DECLARE @_BusinessEntityID INT;
					DECLARE @_AddressID INT;

					INSERT INTO Person.BusinessEntity (rowguid, ModifiedDate)
						VALUES (NEWID(), GETDATE());

					SELECT TOP 1 @_BusinessEntityID = BusinessEntityID
						FROM Person.BusinessEntity
						ORDER BY BusinessEntityID DESC;

					INSERT INTO Person.Person (BusinessEntityID, PersonType, NameStyle, Title, FirstName, LastName, EmailPromotion, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, 'IN', 4, @Title, @FirstName, @LastName, 0, NEWID(), GETDATE());

					INSERT INTO Person.EmailAddress (BusinessEntityID, EmailAddress, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, @EmailAddress, NEWID(), GETDATE());

					INSERT INTO Person.PersonPhone (BusinessEntityID, PhoneNumber, PhoneNumberTypeID, ModifiedDate)
						VALUES (@_BusinessEntityID, @PhoneNumber, @PhoneTypeID, GETDATE());

					INSERT INTO Person.Address (AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, rowguid, ModifiedDate)
						VALUES(@AddressLine1, @AddressLine2, @City, @StateProvinceID, @PostalCode, NEWID(), GETDATE());

					SELECT TOP 1 @_AddressID = AddressID
						FROM Person.Address
						WHERE StateProvinceID = @StateProvinceID

					INSERT INTO Person.BusinessEntityAddress (BusinessEntityID, AddressID, AddressTypeID, ModifiedDate)
						VALUES (@_BusinessEntityID, @_AddressID, 1, GETDATE());

					INSERT INTO Sales.Customer (PersonID, StoreID, TerritoryID, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, NULL, NULL, NEWID(), GETDATE());

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@FirstName",       FirstNameField.Text),
				new SqlParameter("@LastName",        LastNameField.Text),
				new SqlParameter("@Title",           TitleTypeDropdown.GetItemName("")),
				new SqlParameter("@EmailAddress",    EmailField.Text)
			).Error == 0) {
				//MessageBox.Show("Customer successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				sql.FillExistingDataTable(newID, @"
					SELECT TOP 1 BusinessEntityID
						FROM Person.BusinessEntity
						ORDER BY BusinessEntityID DESC;"
				);

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void NewCustomer_FormClosing(object sender, FormClosingEventArgs e) {
			if (DialogResult != DialogResult.OK) {
				DialogResult = DialogResult.Cancel;
			}
		}
	}
}
