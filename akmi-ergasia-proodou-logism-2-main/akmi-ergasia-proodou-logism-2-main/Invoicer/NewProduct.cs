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
using static Exam04.ItemID;
using static Exam04.Converter;

namespace Exam04 {
	public partial class NewProduct : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;

		public NewProduct(SQL_Connector sql) {
			InitializeComponent();
			this.sql = sql;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}

		~NewProduct() {
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

		private void CheckSQL_Click(object sender, EventArgs e) {
			FormStatusCheckSQL(this, EventArgs.Empty);
		}

		private void NewProduct_Load(object sender, EventArgs e) {
			ProductCategoryDropdown.Populate(sql, "Name", null, @"
				SELECT {} FROM Production.ProductCategory;");

			ProductSizeField_Leave(this, EventArgs.Empty);

			ManufacturingStatusDropdown.Items.Add(new ItemID("Purchased",       "0"));
			ManufacturingStatusDropdown.Items.Add(new ItemID("In-house Manuf.", "1"));
			ManufacturingStatusDropdown.SelectedIndex = 0;

			ProductStatusDropdown.Items.Add(new ItemID("Not Saleable", "0"));
			ProductStatusDropdown.Items.Add(new ItemID("Saleable",     "1"));
			ProductStatusDropdown.SelectedIndex = 0;

			SizeUnityCodeDropdown.Items.Add(new ItemID("cm", "CM"));
			SizeUnityCodeDropdown.Items.Add(new ItemID("in", "IN"));
			SizeUnityCodeDropdown.Items.Add(new ItemID("ft", "FT"));
			SizeUnityCodeDropdown.SelectedIndex = 0;

			WeightUnitCodeDropdown.Items.Add(new ItemID("kg",  "KG"));
			WeightUnitCodeDropdown.Items.Add(new ItemID("lbs", "LB"));
			WeightUnitCodeDropdown.Items.Add(new ItemID("oz",  "OZ"));
			WeightUnitCodeDropdown.SelectedIndex = 0;

			ProductLineDropdown.Items.Add(new ItemID("Road",     "R"));
			ProductLineDropdown.Items.Add(new ItemID("Mountain", "M"));
			ProductLineDropdown.Items.Add(new ItemID("Touring",  "T"));
			ProductLineDropdown.Items.Add(new ItemID("Standard", "S"));
			ProductLineDropdown.SelectedIndex = 0;

			ProductClassDropdown.Items.Add(new ItemID("High",   "H"));
			ProductClassDropdown.Items.Add(new ItemID("Medium", "M"));
			ProductClassDropdown.Items.Add(new ItemID("Low",    "L"));
			ProductClassDropdown.SelectedIndex = 0;

			StyleCategoryDropdown.Items.Add(new ItemID("Women's",   "W"));
			StyleCategoryDropdown.Items.Add(new ItemID("Men's",     "M"));
			StyleCategoryDropdown.Items.Add(new ItemID("Universal", "U"));
			StyleCategoryDropdown.SelectedIndex = 0;
		}

		private void BackButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void InsertButton_Click(object sender, EventArgs e) {
			if (CheckEmptyFields(ProductNameField, ProductNumberField)) { return; }

			var (_, cat_error) = sql.ExecuteNonQuery(@"
				BEGIN TRY
					BEGIN TRANSACTION;

					INSERT INTO Production.ProductSubcategory (ProductCategoryID, Name, rowguid, ModifiedDate)
						VALUES (@ProductCategoryID, @SubcategoryName, NEWID(), GETDATE());

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@ProductCategoryID", ProductCategoryDropdown.SelectedIndex + 1),
				new SqlParameter("@SubcategoryName",   ProductNameField.Text)
			);

			if (cat_error != 0) { return; }


			var (_, prod_error) = sql.ExecuteNonQuery(@"
				BEGIN TRY
					BEGIN TRANSACTION;
					DECLARE @ProductID INT;

					-- Production.Product
					INSERT INTO Production.Product (
						Name, ProductNumber, MakeFlag, FinishedGoodsFlag, Color,
						SafetyStockLevel, ReorderPoint, StandardCost, ListPrice,
						Size, SizeUnitMeasureCode, WeightUnitMeasureCode, Weight,
						DaysToManufacture, ProductLine, Class, Style,
						ProductSubcategoryID, ProductModelID,
						SellStartDate, SellEndDate, DiscontinuedDate,
						rowguid, ModifiedDate
					)
					VALUES (
						@Name, @ProductNumber, @MakeFlag, @FinishedGoodsFlag, @Color,
						@SafetyStockLevel, @ReorderPoint, @StandardCost, @ListPrice,
						@Size, @SizeUnitMeasureCode, @WeightUnitMeasureCode, @Weight,
						@DaysToManufacture, @ProductLine, @Class, @Style,
						NULL, NULL,
						GETDATE(), NULL, NULL,
						NEWID(), GETDATE()
					);
					
					SET @ProductID = SCOPE_IDENTITY();

					-- Production.ProductInventory
					INSERT INTO Production.ProductInventory (ProductID, LocationID, Shelf, Bin, Quantity, rowguid, ModifiedDate)
					VALUES (@ProductID, @LocationID, @Shelf, @Bin, @Quantity, NEWID(), GETDATE());


					-- Production.ProductListPriceHistory
					INSERT INTO Production.ProductListPriceHistory (ProductID, StartDate, EndDate, ListPrice, ModifiedDate)
					VALUES (@ProductID, GETDATE(), NULL, @ListPrice, GETDATE());


					-- Production.ProductCostHistory
					INSERT INTO Production.ProductCostHistory (ProductID, StartDate, EndDate, StandardCost, ModifiedDate)
					VALUES (@ProductID, GETDATE(), NULL, @StandardCost, GETDATE());

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@Name",                  ProductNameField.Text),
				new SqlParameter("@ProductNumber",         ProductNumberField.Text),
				new SqlParameter("@MakeFlag",              ManufacturingStatusDropdown.GetItemID(0)),
				new SqlParameter("@FinishedGoodsFlag",     ProductStatusDropdown.GetItemID(false)),
				new SqlParameter("@Color",                 ProductColorField.Text),
				new SqlParameter("@SafetyStockLevel",      SafetyStockLevelSpinbox.Value.ToType(0)),
				new SqlParameter("@ReorderPoint",          InventoryReorderSpinbox.Value.ToType(0)),
				new SqlParameter("@StandardCost",          ProductCostSpinbox.Value.ToType(0.0m)),
				new SqlParameter("@ListPrice",             ProductListPriceSpinbox.Value.ToType(0.0m)),
				new SqlParameter("@Size",                  ProductSizeField.Text.ToType(0)),
				new SqlParameter("@SizeUnitMeasureCode",   SizeUnityCodeDropdown.GetItemID("N/A")),
				new SqlParameter("@WeightUnitMeasureCode", WeightUnitCodeDropdown.GetItemID("N/A")),
				new SqlParameter("@Weight",                ProductWeightSpinbox.Value.ToType(0.0m)),
				new SqlParameter("@DaysToManufacture",     ManufactoryDaysSpinbox.Value.ToType(0)),
				new SqlParameter("@ProductLine",           ProductLineDropdown.GetItemID("NO")),
				new SqlParameter("@Class",                 ProductClassDropdown.GetItemID("NO")),
				new SqlParameter("@Style",                 StyleCategoryDropdown.GetItemID("NO")),

				// Production.ProductInventory
				new SqlParameter("@LocationID", 1),
				new SqlParameter("@Shelf",    'A'),
				new SqlParameter("@Bin",        1),
				new SqlParameter("@Quantity", 100)
			);

			if (prod_error == 0) {
				MessageBox.Show("Product successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void ProductSizeField_Leave(object sender, EventArgs e) {
			ProductSizeField.Text = ProductSizeField.Text.ToType(0).ToString();
		}
	}
}
