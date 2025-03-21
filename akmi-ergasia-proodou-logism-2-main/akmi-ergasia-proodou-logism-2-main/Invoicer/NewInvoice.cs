using SQL;
using System;
using System.Collections;
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
using static Exam04.Converter;


namespace Exam04 {
	public partial class NewInvoice : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;

		private int ProductStock = 0;

		public NewInvoice(SQL_Connector sql) {
			InitializeComponent();
			this.sql = sql;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}

		~NewInvoice() {
			pollTimer.Stop();
			pollTimer.Dispose();
			if (DialogResult != DialogResult.OK) {
				DialogResult = DialogResult.Cancel;
			}
		}

		private void ToggleInvoiceRegistrationButton() {
			if (!StoreDropdown.Enabled)            { InsertButton.Enabled = false; return; }
			if (!CustomerBillingDropdown.Enabled)  { InsertButton.Enabled = false; return; }
			if (!CustomerShippingDropdown.Enabled) { InsertButton.Enabled = false; return; }

			InsertButton.Enabled = sql.IsValidConnection();
		}

		private void FormStatusCheckSQL(object sender, EventArgs e) {
			bool conn = sql.IsValidConnection();

			CheckSQL.Checked = conn;
			CheckSQL.Text = $"SQL Status: {(conn ? "Connected" : "Disconnected")}";
		}

		private void NewInvoice_Load(object sender, EventArgs e) {
			using (var Login = new Login(sql)) {
				if (Login.ShowDialog() != DialogResult.OK) { Close(); return; }
			}

			using (var invoice = sql.CreateFilledDataTable(
				"SELECT MAX(SalesOrderID) + 1 FROM Sales.SalesOrderHeader;").Value
			) {
				InvoiceNoPrintLabel.Text  = invoice.GetSafeValue(0, 0, "UNKNOWN");
				InvoiceOnDatePick.MinDate = InvoiceDueDatePick.MinDate = DateTime.Today;
				InvoiceDueDatePick.Value  = DateTime.Today.AddDays(7);
			}

			ProductDropdown.Populate(sql, "Name", "ProductID", @"
				SELECT {} FROM Production.Product;");
			ProductDropdown.AutoCompleteMode   = AutoCompleteMode.SuggestAppend;
			ProductDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;

			SalesPersonDropdown.Populate(sql, "FullName", "BusinessEntityID", @"
				SELECT CONCAT(p.FirstName, ' ', p.LastName) AS FullName, p.BusinessEntityID
					FROM Person.Person AS p
					INNER JOIN Sales.SalesPerson AS s
						ON p.BusinessEntityID = s.BusinessEntityID
					ORDER BY FullName ASC;");
			SalesPersonDropdown.AutoCompleteMode   = AutoCompleteMode.SuggestAppend;
			SalesPersonDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;

			CustomerDropdown.Populate(sql, "FullName", "BusinessEntityID", @"
				SELECT CONCAT(FirstName, ' ', LastName) AS FullName, BusinessEntityID
					FROM Person.Person ORDER BY FullName ASC;");
			CustomerDropdown.AutoCompleteMode   = AutoCompleteMode.SuggestAppend;
			CustomerDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void CalculateTotalProductStock() {
			var ProductID = ProductDropdown.GetItemID(0);

			ProductStock = sql.CreateFilledDataTable(@"
				SELECT SUM(Quantity)
					FROM Production.ProductInventory
					WHERE ProductID = @ProductID
					GROUP BY ProductID;",

				new SqlParameter("@ProductID", ProductID)
			).Value.GetSafeValue(0, 0, 0);

			foreach (DataGridViewRow row in ProductListGrid.Rows) {
				if (row.GetSafeValue("ID", 0) == ProductID) {
					ProductStock -= row.GetSafeValue("Quantity", 0);
					break;
				}
			}

			ProductStockField.Text = ProductStock.ToString();
			QtyAddButton.Enabled = QtyDelButton.Enabled =
			ProductDropdown.SelectedIndex >= 0;
		}

		private void InsertButton_Click(object sender, EventArgs e) {

			/* WE ARE NOT PROPERLY STORING WAREHOUSE INFO TO UPDATE STOCK REMAINDERS!!!!
			 * 
			if (ProductInventoryDropdown.GetItemID(0) != 0) {
				var selectedWarehouse = ProductInventoryDropdown.GetItemName("0:?");

				var inventoryQty = selectedWarehouse.Split(':')[0].Trim().ToType(0);
				var warehouseID = ProductInventoryDropdown.GetItemID(0);

				if (sql.ExecuteNonQuery(@"
					UPDATE Production.ProductInventory
						SET Quantity = @NewQty
						WHERE LocationID = @LocationID;",

					new SqlParameter("@NewQty", inventoryQty - ),
					new SqlParameter("@LocationID", warehouseID)
				).Error != 0) {
					MessageBox.Show("Product Inventory failed to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			CalculateTotalProductStock();
			*/

			if (sql.ExecuteNonQuery(@"
				BEGIN TRY
					BEGIN TRANSACTION;

					DECLARE @_PurchaseTerritoryID INT;
					SELECT @_PurchaseTerritoryID = sp.TerritoryID
						FROM Person.Address a
						JOIN Person.StateProvince sp
							ON a.StateProvinceID = sp.StateProvinceID
						WHERE a.AddressID = @BillingAddr;

					DECLARE @_SalesPersonTerritoryID INT;
					SELECT @_SalesPersonTerritoryID = SP.TerritoryID
						FROM Sales.SalesPerson AS SP
						WHERE SP.BusinessEntityID = @SalesPersonID;

					INSERT INTO Sales.Customer (PersonID, StoreID, TerritoryID)
					VALUES (@CustomerID , @StoreID, @_PurchaseTerritoryID)
					DECLARE @_CustomerID INT = SCOPE_IDENTITY();

					DECLARE @_OrderDate DATE = CONVERT(DATE, @OrderDate, 103);
					DECLARE @_DueDate   DATE = CONVERT(DATE, @DueDate,   103);
					DECLARE @_ShipDate  DATE = CONVERT(DATE, @ShipDate,  103);

					INSERT INTO Sales.SalesOrderHeader (
						RevisionNumber, OrderDate, DueDate, ShipDate, Status, OnlineOrderFlag, CustomerID, SalesPersonID, TerritoryID,
						BillToAddressID, ShipToAddressID, ShipMethodID, SubTotal, TaxAmt, Freight)
					VALUES (
						0, @_OrderDate, @_DueDate, @_ShipDate, 1, 0, @_CustomerID, @SalesPersonID, @_SalesPersonTerritoryID ,
						@BillingAddr, @ShippingAddr, 5, @TotalPrice, @TotalTaxes, 0.00);

					COMMIT TRANSACTION;
				END TRY
				BEGIN CATCH
					ROLLBACK TRANSACTION;
					THROW;
				END CATCH;",

				new SqlParameter("@SalesPersonID", SalesPersonDropdown.GetItemID(0)),
				new SqlParameter("@StoreID",       StoreDropdown.GetItemID(0)),
				new SqlParameter("@CustomerID",    CustomerDropdown.GetItemID(0)),
				new SqlParameter("@BillingAddr",   CustomerBillingDropdown.GetItemID(0)),
				new SqlParameter("@ShippingAddr",  CustomerShippingDropdown.GetItemID(0)),
				new SqlParameter("@TotalTaxes",    TotalCostsGrid.GetSafeValue(0, 0, 0.0m)),
				new SqlParameter("@TotalPrice",    TotalCostsGrid.GetSafeValue(0, 1, 0.0m)), // we instead want a subtotal
				new SqlParameter("@OrderDate",     InvoiceOnDatePick.Value),
				new SqlParameter("@DueDate",       InvoiceDueDatePick.Value),
				new SqlParameter("@ShipDate",      InvoiceShippingDatePick.Value)
			).Error == 0) {
				MessageBox.Show("Sales order successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			var salesOrderID = sql.ExecuteScalarQuery("SELECT SCOPE_IDENTITY();").Value as int? ?? 0;
			if (salesOrderID == 0) {
				Console.WriteLine("Failed to retrieve SalesOrderID, aborting.");
				return;
			}

			foreach (DataGridViewRow row in ProductListGrid.Rows) {
				var productID = row.GetSafeValue("ID",       0);
				var orderQty  = row.GetSafeValue("Qty",      0);
				var unitPrice = row.GetSafeValue("Price",    0.0m);
				var discount  = row.GetSafeValue("Discount", 0.0m);

				if (sql.ExecuteNonQuery(@"
					INSERT INTO Sales.SalesOrderDetail (
						SalesOrderID, OrderQty, ProductID, UnitPrice, UnitPriceDiscount
					)
					VALUES (
						@SalesOrderID, @OrderQty, @ProductID, @UnitPrice, @Discount
					);",

					new SqlParameter("@SalesOrderID", salesOrderID),
					new SqlParameter("@OrderQty",     orderQty),
					new SqlParameter("@ProductID",    productID),
					new SqlParameter("@UnitPrice",    unitPrice),
					new SqlParameter("@Discount",     discount)
				).Error != 0) {
					MessageBox.Show($"Failed to insert SalesOrderDetail for ProductID {productID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SalesPersonDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			if (SalesPersonDropdown.Enabled) {
				StoreDropdown.Populate(sql, "Name", "BusinessEntityID", @"
					SELECT {} FROM Sales.Store WHERE SalesPersonID = @SalesPersonID ORDER BY Name;",

					new SqlParameter("@SalesPersonID", SalesPersonDropdown.GetItemID(0))
				);
			} else { ToggleInvoiceRegistrationButton(); }
		}

		private void CustomerDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			if (CustomerDropdown.Enabled) {
				CustomerBillingDropdown.Populate(sql, "AddressType", "AddressID", @"
					SELECT at.Name AS AddressType, a.AddressID
						FROM Person.BusinessEntityAddress AS bea
						INNER JOIN Person.Address AS a
							ON bea.AddressID = a.AddressID
						INNER JOIN Person.AddressType AS at
							ON bea.AddressTypeID = at.AddressTypeID
						WHERE bea.BusinessEntityID = @BusinessEntityID;",

					new SqlParameter("@BusinessEntityID", CustomerDropdown.GetItemID(0))
				);
				CustomerShippingDropdown.Populate(sql, "AddressType", "AddressID", @"
					SELECT at.Name AS AddressType, a.AddressID
						FROM Person.BusinessEntityAddress AS bea
						INNER JOIN Person.Address AS a
							ON bea.AddressID = a.AddressID
						INNER JOIN Person.AddressType AS at
							ON bea.AddressTypeID = at.AddressTypeID
						WHERE bea.BusinessEntityID = @BusinessEntityID;",

					new SqlParameter("@BusinessEntityID", CustomerDropdown.GetItemID(0))
				);
			} else { ToggleInvoiceRegistrationButton(); }
		}

		private void PopulateProductWarehouseQty() {
			var ProductID = ProductDropdown.GetItemID(0);

			ProductInventoryDropdown.Populate(sql, "Name", "ID", @"
				SELECT CONCAT(ppi.Quantity, ': ', pl.Name) AS Name, pl.LocationID AS ID
					FROM Production.Location AS pl
					JOIN Production.ProductInventory AS ppi
						ON pl.LocationID = ppi.LocationID
					WHERE ProductID = @ProductID;",

				new SqlParameter("@ProductID", ProductID)
			);

			ProductInventoryDropdown.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			ProductInventoryDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void QtyAddButton_Click(object sender, EventArgs e) {
			UpdateProductListing(ProductDropdown, ProductQtySpinbox.Value.ToType(0));
		}

		private void QtyDelButton_Click(object sender, EventArgs e) {
			var productRows = ProductListGrid.SelectedRows.Count;
			if (productRows == 0) { return; }

			var selectedRow = ProductListGrid.SelectedRows[0];
			var productQty  = selectedRow.GetSafeValue("Quantity", 0);
			var newRowIndex = Math.Min(selectedRow.Index, productRows - 1);

			if (newRowIndex >= 0) { ProductListGrid.Rows[newRowIndex].Selected = true; }
			ProductListGrid.Rows.RemoveAt(selectedRow.Index);

			ProductStockField.Text = (ProductStock += productQty).ToString();
			UpdateProductTotalCosts();
		}

		private void UpdateProductListing(System.Windows.Forms.ComboBox product, int qtyDelta) {
			var productID = product.GetItemID(0);

			if (productID <= 0 || qtyDelta == 0) { return; }

			var (productIndex, productQty) = (-1, 0);

			foreach (DataGridViewRow row in ProductListGrid.Rows) {
				if (row.GetSafeValue("ID", 0) == productID) {
					productIndex = row.Index;
					productQty = row.GetSafeValue("Quantity", 0);
					break;
				}
			}

			if (productIndex != -1) {
				var newQty = productQty + qtyDelta;
				if (newQty <= 0) {
					ProductListGrid.Rows.RemoveAt(productIndex);
					ProductStockField.Text = (ProductStock += productQty).ToString();
					UpdateProductTotalCosts();
				} else {
					ProductListGrid.SetSafeValue(productIndex, "Quantity", newQty);
					ProductStockField.Text = (ProductStock -= qtyDelta).ToString();
					UpdateProductCosts(productIndex, newQty);
				}
				return;
			}

			if (qtyDelta < 0) { return; }

			var productDetails = sql.CreateFilledDataTable(@"
				SELECT Name, ProductNumber, ListPrice
				FROM Production.Product
				WHERE ProductID = @ProductID;",

				new SqlParameter("@ProductID", productID)
			).Value;

			if ((productDetails?.Rows.Count ?? 0) == 0) {
				MessageBox.Show(
					"Something went wrong fetching product details, aborting insertion!",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var (productName, productNumber, productListPrice, productTaxRate) = (
				productDetails.GetSafeValue(0, 0, "N/A"),
				productDetails.GetSafeValue(0, 1, "N/A"),
				productDetails.GetSafeValue(0, 2, 0.0m),
				(CustomerShippingDropdown.GetItemID(0) != CustomerBillingDropdown.GetItemID(0))
					? sql.CreateFilledDataTable(@"
						SELECT tr.TaxRate
						FROM Person.Address AS a
						JOIN Sales.SalesTaxRate AS tr
							ON a.StateProvinceID = tr.StateProvinceID
						WHERE a.AddressID = @BillingAddressID;",

						new SqlParameter("@BillingAddressID", CustomerBillingDropdown.GetItemID(0))
					  ).Value.GetSafeValue(0, 0, 0.0m)
					: sql.CreateFilledDataTable(@"
						SELECT tr.TaxRate
						FROM Person.BusinessEntityAddress AS bea
						JOIN Person.Address AS a
							ON bea.AddressID = a.AddressID
						JOIN Sales.SalesTaxRate AS tr
							ON a.StateProvinceID = tr.StateProvinceID
						WHERE bea.BusinessEntityID = @BusinessEntityID;",

						new SqlParameter("@BusinessEntityID", StoreDropdown.GetItemID(0))
					  ).Value.GetSafeValue(0, 0, 0.0m)
			);

			var productDiscount = sql.CreateFilledDataTable(@"
				SELECT MAX(sp.DiscountPct)
				FROM Sales.SpecialOfferProduct AS sop
				INNER JOIN Sales.SpecialOffer AS sp
					ON sop.SpecialOfferID = sp.SpecialOfferID
				WHERE sop.ProductID = @ProductID;",

				new SqlParameter("@ProductID", ProductDropdown.GetItemID(0))
			).Value.GetSafeValue(0, 0, 0.0m);

			ProductStockField.Text = (ProductStock -= qtyDelta).ToString();

			UpdateProductCosts(ProductListGrid.Rows.Add(
				product.SelectedIndex, productID, productNumber, productName, qtyDelta
			), qtyDelta, productListPrice, productDiscount, productTaxRate / 100);
		}

		private void UpdateProductCosts(int Index, int Qty) {
			var ProductRow = ProductListGrid.Rows.SharedRow(Index);

			UpdateProductCosts(Index, Qty,
				ProductRow.GetSafeValue<decimal>("Price"),
				ProductRow.GetSafeValue<decimal>("DiscountFrac"),
				ProductRow.GetSafeValue<decimal>("TaxFrac"));
		}

		private void UpdateProductCosts(int Index, int Qty, decimal Price, decimal Discount, decimal Tax) {
			var ProductRow = ProductListGrid.Rows.SharedRow(Index);

			Price = Math.Round(Price, 2);
			ProductRow.SetSafeValue("Price", Price);

			var Subtotal = Math.Round(Price * Qty, 2);
			ProductRow.SetSafeValue("Subtotal", Subtotal);

			var DiscountPart = Math.Round(Price * Discount, 2);
			ProductRow.SetSafeValue("Discount", DiscountPart);
			ProductRow.SetSafeValue("DiscountFrac", Discount);

			var TaxPart = Math.Round(Price * Tax, 2);
			ProductRow.SetSafeValue("Tax", TaxPart);
			ProductRow.SetSafeValue("TaxFrac", Tax);

			var Amount = Math.Round((Price - DiscountPart + TaxPart) * Qty, 2);
			ProductRow.SetSafeValue("Total", Amount);

			UpdateProductTotalCosts();
		}

		private void UpdateProductTotalCosts() {
			var totalTaxes = 0.0m;
			var totalPrice = 0.0m;

			foreach (DataGridViewRow row in ProductListGrid.Rows) {
				totalTaxes += row.GetSafeValue("Tax", 0.0m);
				totalPrice += row.GetSafeValue("Total", 0.0m);
			}

			if (TotalCostsGrid.Rows.Count == 0) { TotalCostsGrid.Rows.Add(); }

			TotalCostsGrid.SetSafeValue(0, "TotalTaxes", totalTaxes);
			TotalCostsGrid.SetSafeValue(0, "TotalPrice", totalPrice);
		}

		private void ProductListGrid_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left && ProductListGrid.SelectedRows.Count > 0) {
				ProductDropdown.SelectedIndex = ProductListGrid.GetSelectedSafeValue(0, 0, -1);
			}
		}

		private void StoreDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			using (var address = new DataTable()) {
				if (StoreDropdown.SelectedIndex >= 0) {
					sql.FillExistingDataTable(address, @"
						SELECT A.AddressLine1, A.AddressLine2, A.City, A.PostalCode
							FROM Person.BusinessEntityAddress BEA
							JOIN Person.Address A
								ON BEA.AddressID = A.AddressID
							WHERE BEA.BusinessEntityID = @StoreID;",

						new SqlParameter("@StoreID", StoreDropdown.GetItemID(0))
					);
				}

				StoreAddress1Field.Text   = address.GetSafeValue(0, 0, "");
				StoreAddress2Field.Text   = address.GetSafeValue(0, 1, "");
				StoreCityField.Text       = address.GetSafeValue(0, 2, "");
				StorePostalCodeField.Text = address.GetSafeValue(0, 3, "");
			}
		}

		private void CustomerBillingDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			using (var address = new DataTable()) {
				if (CustomerBillingDropdown.SelectedIndex >= 0) {
					sql.FillExistingDataTable(address, @"
						SELECT AddressLine1, AddressLine2, City, PostalCode
							FROM Person.Address
							WHERE AddressID = @AddressID;",

						new SqlParameter("@AddressID", CustomerBillingDropdown.GetItemID(0))
					);
				}

				CustomerBillingAddress1Field.Text   = address.GetSafeValue(0, 0, "");
				CustomerBillingAddress2Field.Text   = address.GetSafeValue(0, 1, "");
				CustomerBillingCityField.Text       = address.GetSafeValue(0, 2, "");
				CustomerBillingPostalCodeField.Text = address.GetSafeValue(0, 3, "");
			}
		}

		private void CustomerShippingDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			using (var address = new DataTable()) {
				if (CustomerShippingDropdown.SelectedIndex >= 0) {
					sql.FillExistingDataTable(address, @"
						SELECT AddressLine1, AddressLine2, City, PostalCode
							FROM Person.Address
							WHERE AddressID = @AddressID;",

						new SqlParameter("@AddressID", CustomerShippingDropdown.GetItemID(0))
					);
				}

				CustomerShippingAddress1Field.Text   = address.GetSafeValue(0, 0, "");
				CustomerShippingAddress2Field.Text   = address.GetSafeValue(0, 1, "");
				CustomerShippingCityField.Text       = address.GetSafeValue(0, 2, "");
				CustomerShippingPostalCodeField.Text = address.GetSafeValue(0, 3, "");
			}
		}

		private void ProductDropdown_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateProductWarehouseQty();
			CalculateTotalProductStock();
		}

		private void NewPersonButton_Click(object sender, EventArgs e) {
			using (var PersonID = new DataTable()) {
				using (var NewCustomerForm = new NewCustomer(sql, PersonID)) {
					if (NewCustomerForm.ShowDialog() == DialogResult.OK) {
						MessageBox.Show($"Success, PersonID {PersonID.GetSafeValue(0, 0, "???")} was created!");
					}
				}
			}
		}

		private void EditPersonButton_Click(object sender, EventArgs e) {
			using (var PersonID = new DataTable()) {
				int selectedPerson = CustomerDropdown.GetItemID(0);

				using (var NewCustomerForm = new NewCustomer(sql, PersonID, selectedPerson)) {
					if (NewCustomerForm.ShowDialog() == DialogResult.OK) {
						MessageBox.Show($"Success, PersonID {PersonID.GetSafeValue(0, 0, "???")} was edited!");
					}
				}
			}
		}
	}
}
