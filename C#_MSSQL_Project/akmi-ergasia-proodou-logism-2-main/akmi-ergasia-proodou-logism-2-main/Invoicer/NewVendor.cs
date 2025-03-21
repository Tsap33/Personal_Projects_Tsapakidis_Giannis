using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using static Exam04.Common;

namespace Exam04 {
	public partial class NewVendor : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;

		public NewVendor(SQL_Connector sql) {
			InitializeComponent();
			this.sql = sql;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}

		~NewVendor() {
			pollTimer.Stop();
			pollTimer.Dispose();
			if (DialogResult != DialogResult.OK) {
				DialogResult = DialogResult.Cancel;
			}
		}

		private void FormStatusCheckSQL(object sender, EventArgs e) {
			bool conn = sql.IsValidConnection();

			InsertButton.Enabled = CheckSQL.Checked = conn;
			CheckSQL.Text = $"SQL Status: {(conn ? "Connected" : "Disconnected")}";
		}

		private void NewSupplier_Load(object sender, EventArgs e) {
			StateProvince.Populate(sql, "Name", "StateProvinceID", @"
				SELECT {} FROM Person.StateProvince;"
			);
		}

		private void BackButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void InsertButton_Click(object sender, EventArgs e) {
			if (CheckEmptyFields(
				CompanyNameField, AccountNumField,
				CityField, Address1Field, PostalCodeField
			)) { return; }

			var (_, error) = sql.ExecuteNonQuery(@"
				BEGIN TRY
					BEGIN TRANSACTION;

					DECLARE @_BusinessEntityID INT;
					DECLARE @_AddressID INT;

					INSERT INTO Person.BusinessEntity (rowguid, ModifiedDate)
						VALUES (NEWID(), GETDATE());

					SELECT TOP 1 @_BusinessEntityID = BusinessEntityID
						FROM Person.BusinessEntity
						ORDER BY BusinessEntityID DESC;

					INSERT INTO Person.Address (AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, rowguid, ModifiedDate)
						VALUES (@AddressLine1, @AddressLine2, @City, @StateProvinceID, @PostalCode, NEWID(), GETDATE());

					SELECT TOP 1 @_AddressID = AddressID
						FROM Person.Address
						ORDER BY AddressID DESC;

					INSERT INTO Person.BusinessEntityAddress (BusinessEntityID, AddressID, AddressTypeID, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, @_AddressID, 1, NEWID(), GETDATE());

					INSERT INTO Purchasing.Vendor (BusinessEntityID, AccountNumber, Name, CreditRating, PreferredVendorStatus, ActiveFlag, PurchasingWebServiceURL, ModifiedDate)
						VALUES (@_BusinessEntityID, @AccountNumber, @CompanyName, 1, 1, 1, NULL, GETDATE());

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@CompanyName",     CompanyNameField.Text),
				new SqlParameter("@AccountNumber",   AccountNumField.Text),
				new SqlParameter("@StateProvinceID", StateProvince.SelectedIndex + 1),
				new SqlParameter("@City",            CityField.Text),
				new SqlParameter("@AddressLine1",    Address1Field.Text),
				new SqlParameter("@AddressLine2",    Address2Field.Text),
				new SqlParameter("@PostalCode",      PostalCodeField.Text)
			);

			if (error == 0) {
				MessageBox.Show("Vendor successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void CheckSQL_Click(object sender, EventArgs e) {
			FormStatusCheckSQL(this, EventArgs.Empty);
		}

		private void CompanyNameField_TextChanged(object sender, EventArgs e) {
			CompanyNameField.CheckRequired();
		}

		private void AccountNumField_TextChanged(object sender, EventArgs e) {
			AccountNumField.CheckRequired();
		}

		private void CityField_TextChanged(object sender, EventArgs e) {
			CityField.CheckRequired();
		}

		private void Address1Field_TextChanged(object sender, EventArgs e) {
			Address1Field.CheckRequired();
		}

		private void PostalCodeField_TextChanged(object sender, EventArgs e) {
			PostalCodeField.CheckRequired();
		}
	}
}
