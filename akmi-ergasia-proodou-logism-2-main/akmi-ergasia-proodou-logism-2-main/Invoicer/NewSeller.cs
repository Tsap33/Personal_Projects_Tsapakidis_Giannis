using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Exam04.Common;
using static Exam04.Converter;

namespace Exam04 {
	public partial class NewSeller : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;

		public NewSeller(SQL_Connector sql) {
			InitializeComponent();
			this.sql = sql;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}

		~NewSeller() {
			pollTimer.Stop();
			pollTimer.Dispose();
			if (DialogResult != DialogResult.OK) {
				DialogResult = DialogResult.Cancel;
			}
		}

		private void NewSeller_Load(object sender, EventArgs e) {
			TerritoryDropdown.Populate(sql, "Name", "TerritoryID", @"
				SELECT {} FROM Sales.SalesTerritory;");

			TitleDropdown.Populate(sql, "Title", null, @"
				SELECT DISTINCT {} FROM Person.Person WHERE {} IS NOT NULL ORDER BY {}");

			MaritalStatusDropdown.Items.Add(new ItemID("Single",  "S"));
			MaritalStatusDropdown.Items.Add(new ItemID("Married", "M"));
			MaritalStatusDropdown.SelectedIndex = 0;

			GenderDropdown.Items.Add(new ItemID("Male",   "M"));
			GenderDropdown.Items.Add(new ItemID("Female", "F"));
			GenderDropdown.SelectedIndex = 0;

			SalaryTypeDropdown.Items.Add(new ItemID("Hourly",   "0"));
			SalaryTypeDropdown.Items.Add(new ItemID("Salaried", "1"));
			SalaryTypeDropdown.SelectedIndex = 1;
		}

		private void FormStatusCheckSQL(object sender, EventArgs e) {
			bool conn = sql.IsValidConnection();

			InsertButton.Enabled = CheckSQL.Checked = conn;
			CheckSQL.Text = $"SQL Status: {(conn ? "Connected" : "Disconnected")}";
		}

		private void CheckSQL_Click(object sender, EventArgs e) {
			FormStatusCheckSQL(this, EventArgs.Empty);
		}

		private void InsertButton_Click(object sender, EventArgs e) {
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

					INSERT INTO Person.Person (BusinessEntityID,PersonType, NameStyle, FirstName, MiddleName, LastName, EmailPromotion, Title, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, 'SC', 0, @FirstName, @MiddleName, @LastName, 0, @Title, NEWID(), GETDATE());

					INSERT INTO Person.Address(AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, rowguid, ModifiedDate)
						VALUES (@AddressLine1, @AddressLine2, @City, '79', @PostalCode, NEWID(), GETDATE());

					SELECT TOP 1 @_AddressID = AddressID
						FROM Person.Address
						ORDER BY AddressID DESC;

					INSERT INTO Person.BusinessEntityAddress(BusinessEntityID, AddressID, AddressTypeID, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, @_AddressID, '1', NEWID(), GETDATE());

					INSERT INTO HumanResources.Employee (BusinessEntityID, NationalIDNumber, LoginID, JobTitle, BirthDate, MaritalStatus, Gender, HireDate, SalariedFlag, VacationHours, SickLeaveHours, CurrentFlag, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, @NationalNumber, @LoginID, @JobTitle, @BirthDate, @MaritalStatus, @Gender, @HireDate, @SalariedFlag, 0, 0, 1, NEWID(), GETDATE());
					
					INSERT INTO Sales.SalesPerson (BusinessEntityID, TerritoryID, SalesQuota, Bonus, CommissionPct, SalesYTD, SalesLastYear, rowguid, ModifiedDate)
						VALUES (@_BusinessEntityID, @TerritoryID, NULL, 0.00, 0.00, 0.00, 0.00, NEWID(), GETDATE());

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@TerritoryID",    TerritoryDropdown.GetItemID(0)),
				new SqlParameter("@FirstName",      SellerNameField.Text),
				new SqlParameter("@MiddleName",     MiddleNameField.Text),
				new SqlParameter("@LastName",       LastNameField.Text),
				new SqlParameter("@Title",          TitleDropdown.GetItemID("")),
				new SqlParameter("@NationalNumber", NationalField.Text),
				new SqlParameter("@LoginID",        LoginIDField.Text),
				new SqlParameter("@JobTitle",       JobTitleField.Text),
				new SqlParameter("@BirthDate",      BirthDateDatePicker.Value.Date),
				new SqlParameter("@MaritalStatus",  MaritalStatusDropdown.GetItemID("U")),
				new SqlParameter("@Gender",         GenderDropdown.GetItemID("U")),
				new SqlParameter("@HireDate",       HireDateDatePicker.Value.Date),
				new SqlParameter("@SalariedFlag",   SalaryTypeDropdown.GetItemID(false)),
				new SqlParameter("@AddressLine1",   Address1Field.Text),
				new SqlParameter("@AddressLine2",   Address2Field.Text),
				new SqlParameter("@City",           CityField.Text),
				new SqlParameter("@PostalCode",     PostalCodeField.Text)
			);

			if (error == 0) {
				MessageBox.Show("Seller successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void BackButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
