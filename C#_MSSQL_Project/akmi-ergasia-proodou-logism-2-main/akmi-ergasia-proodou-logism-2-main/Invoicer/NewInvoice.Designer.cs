namespace Exam04
{
	partial class NewInvoice
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CheckSQL = new System.Windows.Forms.RadioButton();
			this.InvoiceOnDatePick = new System.Windows.Forms.DateTimePicker();
			this.StoreAddress1Field = new System.Windows.Forms.TextBox();
			this.StoreCityField = new System.Windows.Forms.TextBox();
			this.InvoiceNoPrintLabel = new System.Windows.Forms.Label();
			this.InvoiceDateOnLabel = new System.Windows.Forms.Label();
			this.InvoiceNoLabel = new System.Windows.Forms.Label();
			this.CustomerBillingAddress2Field = new System.Windows.Forms.TextBox();
			this.StoreAddress2Field = new System.Windows.Forms.TextBox();
			this.CustomerDropdown = new System.Windows.Forms.ComboBox();
			this.SalesPersonDropdown = new System.Windows.Forms.ComboBox();
			this.CustomerBillingPostalCodeField = new System.Windows.Forms.TextBox();
			this.CustomerBillingAddress1Field = new System.Windows.Forms.TextBox();
			this.CustomerBillingCityField = new System.Windows.Forms.TextBox();
			this.StorePostalCodeField = new System.Windows.Forms.TextBox();
			this.InsertButton = new System.Windows.Forms.Button();
			this.SelectProductLabel = new System.Windows.Forms.Label();
			this.ProductDropdown = new System.Windows.Forms.ComboBox();
			this.ProductQtyLabel = new System.Windows.Forms.Label();
			this.QtyAddButton = new System.Windows.Forms.Button();
			this.QtyDelButton = new System.Windows.Forms.Button();
			this.ProductListGrid = new System.Windows.Forms.DataGridView();
			this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxFrac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscountFrac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalCostsGrid = new System.Windows.Forms.DataGridView();
			this.TotalTaxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQtySpinbox = new System.Windows.Forms.NumericUpDown();
			this.InvoiceDetailsGroupbox = new System.Windows.Forms.GroupBox();
			this.InvoiceShippingDatePick = new System.Windows.Forms.DateTimePicker();
			this.InvoiceDateShippingLabel = new System.Windows.Forms.Label();
			this.InvoiceDueDatePick = new System.Windows.Forms.DateTimePicker();
			this.InvoiceDateDueLabel = new System.Windows.Forms.Label();
			this.SalesPersonGroupBox = new System.Windows.Forms.GroupBox();
			this.StoreLabel = new System.Windows.Forms.Label();
			this.StoreDropdown = new System.Windows.Forms.ComboBox();
			this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
			this.EditPersonButton = new System.Windows.Forms.Button();
			this.NewPersonButton = new System.Windows.Forms.Button();
			this.CustomerShippingLabel = new System.Windows.Forms.Label();
			this.CustomerShippingDropdown = new System.Windows.Forms.ComboBox();
			this.CustomerShippingAddress2Field = new System.Windows.Forms.TextBox();
			this.CustomerShippingPostalCodeField = new System.Windows.Forms.TextBox();
			this.CustomerShippingCityField = new System.Windows.Forms.TextBox();
			this.CustomerShippingAddress1Field = new System.Windows.Forms.TextBox();
			this.CustomerBillingLabel = new System.Windows.Forms.Label();
			this.CustomerBillingDropdown = new System.Windows.Forms.ComboBox();
			this.ProductListGroupBox = new System.Windows.Forms.GroupBox();
			this.ProductInventoryDropdown = new System.Windows.Forms.ComboBox();
			this.invLabel = new System.Windows.Forms.Label();
			this.ProductStockField = new System.Windows.Forms.TextBox();
			this.ProductStockLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ProductListGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCostsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductQtySpinbox)).BeginInit();
			this.InvoiceDetailsGroupbox.SuspendLayout();
			this.SalesPersonGroupBox.SuspendLayout();
			this.CustomerGroupBox.SuspendLayout();
			this.ProductListGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckSQL
			// 
			this.CheckSQL.AutoSize = true;
			this.CheckSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.CheckSQL.Location = new System.Drawing.Point(24, 633);
			this.CheckSQL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CheckSQL.Name = "CheckSQL";
			this.CheckSQL.Size = new System.Drawing.Size(206, 24);
			this.CheckSQL.TabIndex = 46;
			this.CheckSQL.TabStop = true;
			this.CheckSQL.Text = "SQL Connection Status";
			this.CheckSQL.UseVisualStyleBackColor = true;
			// 
			// InvoiceOnDatePick
			// 
			this.InvoiceOnDatePick.CustomFormat = "";
			this.InvoiceOnDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceOnDatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.InvoiceOnDatePick.Location = new System.Drawing.Point(346, 23);
			this.InvoiceOnDatePick.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.InvoiceOnDatePick.Name = "InvoiceOnDatePick";
			this.InvoiceOnDatePick.Size = new System.Drawing.Size(140, 27);
			this.InvoiceOnDatePick.TabIndex = 48;
			// 
			// StoreAddress1Field
			// 
			this.StoreAddress1Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.StoreAddress1Field.Location = new System.Drawing.Point(9, 114);
			this.StoreAddress1Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.StoreAddress1Field.Name = "StoreAddress1Field";
			this.StoreAddress1Field.ReadOnly = true;
			this.StoreAddress1Field.Size = new System.Drawing.Size(327, 27);
			this.StoreAddress1Field.TabIndex = 58;
			this.StoreAddress1Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// StoreCityField
			// 
			this.StoreCityField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.StoreCityField.Location = new System.Drawing.Point(9, 178);
			this.StoreCityField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.StoreCityField.Name = "StoreCityField";
			this.StoreCityField.ReadOnly = true;
			this.StoreCityField.Size = new System.Drawing.Size(327, 27);
			this.StoreCityField.TabIndex = 60;
			this.StoreCityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// InvoiceNoPrintLabel
			// 
			this.InvoiceNoPrintLabel.AutoSize = true;
			this.InvoiceNoPrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceNoPrintLabel.Location = new System.Drawing.Point(112, 28);
			this.InvoiceNoPrintLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.InvoiceNoPrintLabel.Name = "InvoiceNoPrintLabel";
			this.InvoiceNoPrintLabel.Size = new System.Drawing.Size(23, 20);
			this.InvoiceNoPrintLabel.TabIndex = 80;
			this.InvoiceNoPrintLabel.Text = "--";
			// 
			// InvoiceDateOnLabel
			// 
			this.InvoiceDateOnLabel.AutoSize = true;
			this.InvoiceDateOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceDateOnLabel.Location = new System.Drawing.Point(250, 28);
			this.InvoiceDateOnLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.InvoiceDateOnLabel.Name = "InvoiceDateOnLabel";
			this.InvoiceDateOnLabel.Size = new System.Drawing.Size(86, 20);
			this.InvoiceDateOnLabel.TabIndex = 79;
			this.InvoiceDateOnLabel.Text = "Dated On:";
			// 
			// InvoiceNoLabel
			// 
			this.InvoiceNoLabel.AutoSize = true;
			this.InvoiceNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceNoLabel.Location = new System.Drawing.Point(9, 28);
			this.InvoiceNoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.InvoiceNoLabel.Name = "InvoiceNoLabel";
			this.InvoiceNoLabel.Size = new System.Drawing.Size(91, 20);
			this.InvoiceNoLabel.TabIndex = 78;
			this.InvoiceNoLabel.Text = "Invoice No.";
			// 
			// CustomerBillingAddress2Field
			// 
			this.CustomerBillingAddress2Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerBillingAddress2Field.Location = new System.Drawing.Point(9, 146);
			this.CustomerBillingAddress2Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerBillingAddress2Field.Name = "CustomerBillingAddress2Field";
			this.CustomerBillingAddress2Field.ReadOnly = true;
			this.CustomerBillingAddress2Field.Size = new System.Drawing.Size(327, 27);
			this.CustomerBillingAddress2Field.TabIndex = 81;
			this.CustomerBillingAddress2Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// StoreAddress2Field
			// 
			this.StoreAddress2Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.StoreAddress2Field.Location = new System.Drawing.Point(9, 146);
			this.StoreAddress2Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.StoreAddress2Field.Name = "StoreAddress2Field";
			this.StoreAddress2Field.ReadOnly = true;
			this.StoreAddress2Field.Size = new System.Drawing.Size(327, 27);
			this.StoreAddress2Field.TabIndex = 80;
			this.StoreAddress2Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerDropdown
			// 
			this.CustomerDropdown.FormattingEnabled = true;
			this.CustomerDropdown.Location = new System.Drawing.Point(9, 33);
			this.CustomerDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CustomerDropdown.Name = "CustomerDropdown";
			this.CustomerDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CustomerDropdown.Size = new System.Drawing.Size(327, 28);
			this.CustomerDropdown.TabIndex = 79;
			this.CustomerDropdown.SelectedIndexChanged += new System.EventHandler(this.CustomerDropdown_SelectedIndexChanged);
			// 
			// SalesPersonDropdown
			// 
			this.SalesPersonDropdown.FormattingEnabled = true;
			this.SalesPersonDropdown.Location = new System.Drawing.Point(9, 33);
			this.SalesPersonDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.SalesPersonDropdown.Name = "SalesPersonDropdown";
			this.SalesPersonDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SalesPersonDropdown.Size = new System.Drawing.Size(327, 28);
			this.SalesPersonDropdown.TabIndex = 78;
			this.SalesPersonDropdown.SelectedIndexChanged += new System.EventHandler(this.SalesPersonDropdown_SelectedIndexChanged);
			// 
			// CustomerBillingPostalCodeField
			// 
			this.CustomerBillingPostalCodeField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerBillingPostalCodeField.Location = new System.Drawing.Point(9, 210);
			this.CustomerBillingPostalCodeField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerBillingPostalCodeField.Name = "CustomerBillingPostalCodeField";
			this.CustomerBillingPostalCodeField.ReadOnly = true;
			this.CustomerBillingPostalCodeField.Size = new System.Drawing.Size(327, 27);
			this.CustomerBillingPostalCodeField.TabIndex = 77;
			this.CustomerBillingPostalCodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerBillingAddress1Field
			// 
			this.CustomerBillingAddress1Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerBillingAddress1Field.Location = new System.Drawing.Point(9, 114);
			this.CustomerBillingAddress1Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerBillingAddress1Field.Name = "CustomerBillingAddress1Field";
			this.CustomerBillingAddress1Field.ReadOnly = true;
			this.CustomerBillingAddress1Field.Size = new System.Drawing.Size(327, 27);
			this.CustomerBillingAddress1Field.TabIndex = 72;
			this.CustomerBillingAddress1Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerBillingCityField
			// 
			this.CustomerBillingCityField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerBillingCityField.Location = new System.Drawing.Point(9, 178);
			this.CustomerBillingCityField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerBillingCityField.Name = "CustomerBillingCityField";
			this.CustomerBillingCityField.ReadOnly = true;
			this.CustomerBillingCityField.Size = new System.Drawing.Size(327, 27);
			this.CustomerBillingCityField.TabIndex = 73;
			this.CustomerBillingCityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// StorePostalCodeField
			// 
			this.StorePostalCodeField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.StorePostalCodeField.Location = new System.Drawing.Point(9, 210);
			this.StorePostalCodeField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.StorePostalCodeField.Name = "StorePostalCodeField";
			this.StorePostalCodeField.ReadOnly = true;
			this.StorePostalCodeField.Size = new System.Drawing.Size(327, 27);
			this.StorePostalCodeField.TabIndex = 65;
			this.StorePostalCodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// InsertButton
			// 
			this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InsertButton.Location = new System.Drawing.Point(411, 633);
			this.InsertButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(282, 43);
			this.InsertButton.TabIndex = 79;
			this.InsertButton.Text = "Confirm Invoice Details";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// SelectProductLabel
			// 
			this.SelectProductLabel.AutoSize = true;
			this.SelectProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.SelectProductLabel.Location = new System.Drawing.Point(9, 35);
			this.SelectProductLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.SelectProductLabel.Name = "SelectProductLabel";
			this.SelectProductLabel.Size = new System.Drawing.Size(79, 20);
			this.SelectProductLabel.TabIndex = 80;
			this.SelectProductLabel.Text = "Selected:";
			this.SelectProductLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ProductDropdown
			// 
			this.ProductDropdown.FormattingEnabled = true;
			this.ProductDropdown.Location = new System.Drawing.Point(88, 32);
			this.ProductDropdown.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.ProductDropdown.Name = "ProductDropdown";
			this.ProductDropdown.Size = new System.Drawing.Size(177, 28);
			this.ProductDropdown.TabIndex = 81;
			this.ProductDropdown.SelectedIndexChanged += new System.EventHandler(this.ProductDropdown_SelectedIndexChanged);
			// 
			// ProductQtyLabel
			// 
			this.ProductQtyLabel.AutoSize = true;
			this.ProductQtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.ProductQtyLabel.Location = new System.Drawing.Point(649, 35);
			this.ProductQtyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.ProductQtyLabel.Name = "ProductQtyLabel";
			this.ProductQtyLabel.Size = new System.Drawing.Size(76, 20);
			this.ProductQtyLabel.TabIndex = 82;
			this.ProductQtyLabel.Text = "Quantity:";
			this.ProductQtyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// QtyAddButton
			// 
			this.QtyAddButton.Location = new System.Drawing.Point(817, 33);
			this.QtyAddButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.QtyAddButton.Name = "QtyAddButton";
			this.QtyAddButton.Size = new System.Drawing.Size(100, 25);
			this.QtyAddButton.TabIndex = 84;
			this.QtyAddButton.Text = "Add";
			this.QtyAddButton.UseVisualStyleBackColor = true;
			this.QtyAddButton.Click += new System.EventHandler(this.QtyAddButton_Click);
			// 
			// QtyDelButton
			// 
			this.QtyDelButton.Location = new System.Drawing.Point(927, 33);
			this.QtyDelButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.QtyDelButton.Name = "QtyDelButton";
			this.QtyDelButton.Size = new System.Drawing.Size(100, 25);
			this.QtyDelButton.TabIndex = 85;
			this.QtyDelButton.Text = "Remove";
			this.QtyDelButton.UseVisualStyleBackColor = true;
			this.QtyDelButton.Click += new System.EventHandler(this.QtyDelButton_Click);
			// 
			// ProductListGrid
			// 
			this.ProductListGrid.AllowUserToAddRows = false;
			this.ProductListGrid.AllowUserToDeleteRows = false;
			this.ProductListGrid.AllowUserToResizeRows = false;
			this.ProductListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProductListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProductListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ID,
            this.ProductNo,
            this.ProductDescription,
            this.Quantity,
            this.Price,
            this.Subtotal,
            this.Tax,
            this.TaxFrac,
            this.Discount,
            this.DiscountFrac,
            this.Total});
			this.ProductListGrid.Location = new System.Drawing.Point(9, 76);
			this.ProductListGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.ProductListGrid.MultiSelect = false;
			this.ProductListGrid.Name = "ProductListGrid";
			this.ProductListGrid.ReadOnly = true;
			this.ProductListGrid.RowHeadersVisible = false;
			this.ProductListGrid.RowHeadersWidth = 51;
			this.ProductListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProductListGrid.Size = new System.Drawing.Size(1018, 195);
			this.ProductListGrid.TabIndex = 90;
			this.ProductListGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductListGrid_MouseDoubleClick);
			// 
			// Index
			// 
			this.Index.HeaderText = "Product Index";
			this.Index.MinimumWidth = 6;
			this.Index.Name = "Index";
			this.Index.ReadOnly = true;
			this.Index.Visible = false;
			// 
			// ID
			// 
			this.ID.HeaderText = "Product ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.Visible = false;
			// 
			// ProductNo
			// 
			this.ProductNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ProductNo.HeaderText = "Product No.";
			this.ProductNo.MinimumWidth = 6;
			this.ProductNo.Name = "ProductNo";
			this.ProductNo.ReadOnly = true;
			this.ProductNo.Width = 140;
			// 
			// ProductDescription
			// 
			this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProductDescription.HeaderText = "Description";
			this.ProductDescription.MinimumWidth = 6;
			this.ProductDescription.Name = "ProductDescription";
			this.ProductDescription.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Quantity.HeaderText = "Qty";
			this.Quantity.MinimumWidth = 6;
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Quantity.Width = 64;
			// 
			// Price
			// 
			this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Price.HeaderText = "Unit Price";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 112;
			// 
			// Subtotal
			// 
			this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Subtotal.HeaderText = "Subtotal";
			this.Subtotal.MinimumWidth = 6;
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.ReadOnly = true;
			this.Subtotal.Width = 99;
			// 
			// Tax
			// 
			this.Tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Tax.HeaderText = "Tax";
			this.Tax.MinimumWidth = 6;
			this.Tax.Name = "Tax";
			this.Tax.ReadOnly = true;
			this.Tax.Width = 65;
			// 
			// TaxFrac
			// 
			this.TaxFrac.HeaderText = "TaxFrac";
			this.TaxFrac.MinimumWidth = 6;
			this.TaxFrac.Name = "TaxFrac";
			this.TaxFrac.ReadOnly = true;
			this.TaxFrac.Visible = false;
			// 
			// Discount
			// 
			this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Discount.HeaderText = "Discount";
			this.Discount.MinimumWidth = 6;
			this.Discount.Name = "Discount";
			this.Discount.ReadOnly = true;
			this.Discount.Width = 105;
			// 
			// DiscountFrac
			// 
			this.DiscountFrac.HeaderText = "DiscountFrac";
			this.DiscountFrac.MinimumWidth = 6;
			this.DiscountFrac.Name = "DiscountFrac";
			this.DiscountFrac.ReadOnly = true;
			this.DiscountFrac.Visible = false;
			// 
			// Total
			// 
			this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Total.HeaderText = "Total";
			this.Total.MinimumWidth = 6;
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			this.Total.Width = 75;
			// 
			// TotalCostsGrid
			// 
			this.TotalCostsGrid.AllowUserToAddRows = false;
			this.TotalCostsGrid.AllowUserToDeleteRows = false;
			this.TotalCostsGrid.AllowUserToResizeRows = false;
			this.TotalCostsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TotalCostsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalTaxes,
            this.TotalPrice});
			this.TotalCostsGrid.Location = new System.Drawing.Point(703, 633);
			this.TotalCostsGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.TotalCostsGrid.MultiSelect = false;
			this.TotalCostsGrid.Name = "TotalCostsGrid";
			this.TotalCostsGrid.ReadOnly = true;
			this.TotalCostsGrid.RowHeadersVisible = false;
			this.TotalCostsGrid.RowHeadersWidth = 51;
			this.TotalCostsGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TotalCostsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TotalCostsGrid.Size = new System.Drawing.Size(339, 69);
			this.TotalCostsGrid.TabIndex = 91;
			// 
			// TotalTaxes
			// 
			this.TotalTaxes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TotalTaxes.HeaderText = "Total Taxes";
			this.TotalTaxes.MinimumWidth = 6;
			this.TotalTaxes.Name = "TotalTaxes";
			this.TotalTaxes.ReadOnly = true;
			// 
			// TotalPrice
			// 
			this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TotalPrice.HeaderText = "Total Price";
			this.TotalPrice.MinimumWidth = 6;
			this.TotalPrice.Name = "TotalPrice";
			this.TotalPrice.ReadOnly = true;
			// 
			// ProductQtySpinbox
			// 
			this.ProductQtySpinbox.Location = new System.Drawing.Point(726, 33);
			this.ProductQtySpinbox.Margin = new System.Windows.Forms.Padding(0, 6, 5, 5);
			this.ProductQtySpinbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ProductQtySpinbox.Name = "ProductQtySpinbox";
			this.ProductQtySpinbox.Size = new System.Drawing.Size(81, 27);
			this.ProductQtySpinbox.TabIndex = 82;
			this.ProductQtySpinbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// InvoiceDetailsGroupbox
			// 
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceShippingDatePick);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceDateShippingLabel);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceDueDatePick);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceDateDueLabel);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceOnDatePick);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceDateOnLabel);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceNoPrintLabel);
			this.InvoiceDetailsGroupbox.Controls.Add(this.InvoiceNoLabel);
			this.InvoiceDetailsGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceDetailsGroupbox.Location = new System.Drawing.Point(15, 13);
			this.InvoiceDetailsGroupbox.Margin = new System.Windows.Forms.Padding(4);
			this.InvoiceDetailsGroupbox.Name = "InvoiceDetailsGroupbox";
			this.InvoiceDetailsGroupbox.Padding = new System.Windows.Forms.Padding(4);
			this.InvoiceDetailsGroupbox.Size = new System.Drawing.Size(1036, 64);
			this.InvoiceDetailsGroupbox.TabIndex = 92;
			this.InvoiceDetailsGroupbox.TabStop = false;
			this.InvoiceDetailsGroupbox.Text = "Details";
			// 
			// InvoiceShippingDatePick
			// 
			this.InvoiceShippingDatePick.CustomFormat = "";
			this.InvoiceShippingDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceShippingDatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.InvoiceShippingDatePick.Location = new System.Drawing.Point(887, 23);
			this.InvoiceShippingDatePick.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.InvoiceShippingDatePick.Name = "InvoiceShippingDatePick";
			this.InvoiceShippingDatePick.Size = new System.Drawing.Size(140, 27);
			this.InvoiceShippingDatePick.TabIndex = 83;
			// 
			// InvoiceDateShippingLabel
			// 
			this.InvoiceDateShippingLabel.AutoSize = true;
			this.InvoiceDateShippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceDateShippingLabel.Location = new System.Drawing.Point(773, 28);
			this.InvoiceDateShippingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.InvoiceDateShippingLabel.Name = "InvoiceDateShippingLabel";
			this.InvoiceDateShippingLabel.Size = new System.Drawing.Size(105, 20);
			this.InvoiceDateShippingLabel.TabIndex = 84;
			this.InvoiceDateShippingLabel.Text = "Shipping On:";
			// 
			// InvoiceDueDatePick
			// 
			this.InvoiceDueDatePick.CustomFormat = "";
			this.InvoiceDueDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceDueDatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.InvoiceDueDatePick.Location = new System.Drawing.Point(591, 23);
			this.InvoiceDueDatePick.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.InvoiceDueDatePick.Name = "InvoiceDueDatePick";
			this.InvoiceDueDatePick.Size = new System.Drawing.Size(140, 27);
			this.InvoiceDueDatePick.TabIndex = 81;
			// 
			// InvoiceDateDueLabel
			// 
			this.InvoiceDateDueLabel.AutoSize = true;
			this.InvoiceDateDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.InvoiceDateDueLabel.Location = new System.Drawing.Point(511, 28);
			this.InvoiceDateDueLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.InvoiceDateDueLabel.Name = "InvoiceDateDueLabel";
			this.InvoiceDateDueLabel.Size = new System.Drawing.Size(70, 20);
			this.InvoiceDateDueLabel.TabIndex = 82;
			this.InvoiceDateDueLabel.Text = "Due By:";
			// 
			// SalesPersonGroupBox
			// 
			this.SalesPersonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SalesPersonGroupBox.Controls.Add(this.StoreLabel);
			this.SalesPersonGroupBox.Controls.Add(this.StoreDropdown);
			this.SalesPersonGroupBox.Controls.Add(this.SalesPersonDropdown);
			this.SalesPersonGroupBox.Controls.Add(this.StoreAddress2Field);
			this.SalesPersonGroupBox.Controls.Add(this.StoreCityField);
			this.SalesPersonGroupBox.Controls.Add(this.StoreAddress1Field);
			this.SalesPersonGroupBox.Controls.Add(this.StorePostalCodeField);
			this.SalesPersonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.SalesPersonGroupBox.Location = new System.Drawing.Point(15, 85);
			this.SalesPersonGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.SalesPersonGroupBox.Name = "SalesPersonGroupBox";
			this.SalesPersonGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.SalesPersonGroupBox.Size = new System.Drawing.Size(346, 247);
			this.SalesPersonGroupBox.TabIndex = 93;
			this.SalesPersonGroupBox.TabStop = false;
			this.SalesPersonGroupBox.Text = "Sales Person";
			// 
			// StoreLabel
			// 
			this.StoreLabel.AutoSize = true;
			this.StoreLabel.Location = new System.Drawing.Point(9, 79);
			this.StoreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.StoreLabel.Name = "StoreLabel";
			this.StoreLabel.Size = new System.Drawing.Size(54, 20);
			this.StoreLabel.TabIndex = 84;
			this.StoreLabel.Text = "Store:";
			// 
			// StoreDropdown
			// 
			this.StoreDropdown.FormattingEnabled = true;
			this.StoreDropdown.Location = new System.Drawing.Point(86, 76);
			this.StoreDropdown.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.StoreDropdown.Name = "StoreDropdown";
			this.StoreDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StoreDropdown.Size = new System.Drawing.Size(250, 28);
			this.StoreDropdown.TabIndex = 83;
			this.StoreDropdown.SelectedIndexChanged += new System.EventHandler(this.StoreDropdown_SelectedIndexChanged);
			// 
			// CustomerGroupBox
			// 
			this.CustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.CustomerGroupBox.Controls.Add(this.EditPersonButton);
			this.CustomerGroupBox.Controls.Add(this.NewPersonButton);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingLabel);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingDropdown);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingAddress2Field);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingPostalCodeField);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingCityField);
			this.CustomerGroupBox.Controls.Add(this.CustomerShippingAddress1Field);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingLabel);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingDropdown);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingAddress2Field);
			this.CustomerGroupBox.Controls.Add(this.CustomerDropdown);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingPostalCodeField);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingCityField);
			this.CustomerGroupBox.Controls.Add(this.CustomerBillingAddress1Field);
			this.CustomerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.CustomerGroupBox.Location = new System.Drawing.Point(369, 85);
			this.CustomerGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.CustomerGroupBox.Name = "CustomerGroupBox";
			this.CustomerGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.CustomerGroupBox.Size = new System.Drawing.Size(682, 247);
			this.CustomerGroupBox.TabIndex = 94;
			this.CustomerGroupBox.TabStop = false;
			this.CustomerGroupBox.Text = "Customer";
			// 
			// EditPersonButton
			// 
			this.EditPersonButton.Location = new System.Drawing.Point(513, 32);
			this.EditPersonButton.Name = "EditPersonButton";
			this.EditPersonButton.Size = new System.Drawing.Size(160, 25);
			this.EditPersonButton.TabIndex = 91;
			this.EditPersonButton.Text = "Edit Customer";
			this.EditPersonButton.UseVisualStyleBackColor = true;
			this.EditPersonButton.Click += new System.EventHandler(this.EditPersonButton_Click);
			// 
			// NewPersonButton
			// 
			this.NewPersonButton.Location = new System.Drawing.Point(346, 33);
			this.NewPersonButton.Name = "NewPersonButton";
			this.NewPersonButton.Size = new System.Drawing.Size(160, 25);
			this.NewPersonButton.TabIndex = 90;
			this.NewPersonButton.Text = "New Customer";
			this.NewPersonButton.UseVisualStyleBackColor = true;
			this.NewPersonButton.Click += new System.EventHandler(this.NewPersonButton_Click);
			// 
			// CustomerShippingLabel
			// 
			this.CustomerShippingLabel.AutoSize = true;
			this.CustomerShippingLabel.Location = new System.Drawing.Point(346, 79);
			this.CustomerShippingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.CustomerShippingLabel.Name = "CustomerShippingLabel";
			this.CustomerShippingLabel.Size = new System.Drawing.Size(78, 20);
			this.CustomerShippingLabel.TabIndex = 89;
			this.CustomerShippingLabel.Text = "Shipping:";
			// 
			// CustomerShippingDropdown
			// 
			this.CustomerShippingDropdown.FormattingEnabled = true;
			this.CustomerShippingDropdown.Location = new System.Drawing.Point(423, 76);
			this.CustomerShippingDropdown.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.CustomerShippingDropdown.Name = "CustomerShippingDropdown";
			this.CustomerShippingDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CustomerShippingDropdown.Size = new System.Drawing.Size(250, 28);
			this.CustomerShippingDropdown.TabIndex = 88;
			this.CustomerShippingDropdown.SelectedIndexChanged += new System.EventHandler(this.CustomerShippingDropdown_SelectedIndexChanged);
			// 
			// CustomerShippingAddress2Field
			// 
			this.CustomerShippingAddress2Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerShippingAddress2Field.Location = new System.Drawing.Point(346, 146);
			this.CustomerShippingAddress2Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerShippingAddress2Field.Name = "CustomerShippingAddress2Field";
			this.CustomerShippingAddress2Field.ReadOnly = true;
			this.CustomerShippingAddress2Field.Size = new System.Drawing.Size(327, 27);
			this.CustomerShippingAddress2Field.TabIndex = 87;
			this.CustomerShippingAddress2Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerShippingPostalCodeField
			// 
			this.CustomerShippingPostalCodeField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerShippingPostalCodeField.Location = new System.Drawing.Point(346, 210);
			this.CustomerShippingPostalCodeField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerShippingPostalCodeField.Name = "CustomerShippingPostalCodeField";
			this.CustomerShippingPostalCodeField.ReadOnly = true;
			this.CustomerShippingPostalCodeField.Size = new System.Drawing.Size(327, 27);
			this.CustomerShippingPostalCodeField.TabIndex = 86;
			this.CustomerShippingPostalCodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerShippingCityField
			// 
			this.CustomerShippingCityField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerShippingCityField.Location = new System.Drawing.Point(346, 178);
			this.CustomerShippingCityField.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerShippingCityField.Name = "CustomerShippingCityField";
			this.CustomerShippingCityField.ReadOnly = true;
			this.CustomerShippingCityField.Size = new System.Drawing.Size(327, 27);
			this.CustomerShippingCityField.TabIndex = 85;
			this.CustomerShippingCityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerShippingAddress1Field
			// 
			this.CustomerShippingAddress1Field.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.CustomerShippingAddress1Field.Location = new System.Drawing.Point(346, 114);
			this.CustomerShippingAddress1Field.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
			this.CustomerShippingAddress1Field.Name = "CustomerShippingAddress1Field";
			this.CustomerShippingAddress1Field.ReadOnly = true;
			this.CustomerShippingAddress1Field.Size = new System.Drawing.Size(327, 27);
			this.CustomerShippingAddress1Field.TabIndex = 84;
			this.CustomerShippingAddress1Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerBillingLabel
			// 
			this.CustomerBillingLabel.AutoSize = true;
			this.CustomerBillingLabel.Location = new System.Drawing.Point(9, 79);
			this.CustomerBillingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.CustomerBillingLabel.Name = "CustomerBillingLabel";
			this.CustomerBillingLabel.Size = new System.Drawing.Size(60, 20);
			this.CustomerBillingLabel.TabIndex = 83;
			this.CustomerBillingLabel.Text = "Billing:";
			// 
			// CustomerBillingDropdown
			// 
			this.CustomerBillingDropdown.DropDownWidth = 250;
			this.CustomerBillingDropdown.FormattingEnabled = true;
			this.CustomerBillingDropdown.Location = new System.Drawing.Point(86, 76);
			this.CustomerBillingDropdown.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.CustomerBillingDropdown.Name = "CustomerBillingDropdown";
			this.CustomerBillingDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CustomerBillingDropdown.Size = new System.Drawing.Size(250, 28);
			this.CustomerBillingDropdown.TabIndex = 82;
			this.CustomerBillingDropdown.SelectedIndexChanged += new System.EventHandler(this.CustomerBillingDropdown_SelectedIndexChanged);
			// 
			// ProductListGroupBox
			// 
			this.ProductListGroupBox.Controls.Add(this.ProductInventoryDropdown);
			this.ProductListGroupBox.Controls.Add(this.invLabel);
			this.ProductListGroupBox.Controls.Add(this.ProductStockField);
			this.ProductListGroupBox.Controls.Add(this.ProductStockLabel);
			this.ProductListGroupBox.Controls.Add(this.ProductDropdown);
			this.ProductListGroupBox.Controls.Add(this.SelectProductLabel);
			this.ProductListGroupBox.Controls.Add(this.ProductQtySpinbox);
			this.ProductListGroupBox.Controls.Add(this.ProductQtyLabel);
			this.ProductListGroupBox.Controls.Add(this.QtyAddButton);
			this.ProductListGroupBox.Controls.Add(this.ProductListGrid);
			this.ProductListGroupBox.Controls.Add(this.QtyDelButton);
			this.ProductListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.ProductListGroupBox.Location = new System.Drawing.Point(15, 340);
			this.ProductListGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.ProductListGroupBox.Name = "ProductListGroupBox";
			this.ProductListGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.ProductListGroupBox.Size = new System.Drawing.Size(1036, 283);
			this.ProductListGroupBox.TabIndex = 93;
			this.ProductListGroupBox.TabStop = false;
			this.ProductListGroupBox.Text = "Product List";
			// 
			// ProductInventoryDropdown
			// 
			this.ProductInventoryDropdown.FormattingEnabled = true;
			this.ProductInventoryDropdown.ItemHeight = 20;
			this.ProductInventoryDropdown.Location = new System.Drawing.Point(511, 32);
			this.ProductInventoryDropdown.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.ProductInventoryDropdown.Name = "ProductInventoryDropdown";
			this.ProductInventoryDropdown.Size = new System.Drawing.Size(128, 28);
			this.ProductInventoryDropdown.TabIndex = 93;
			// 
			// invLabel
			// 
			this.invLabel.AutoSize = true;
			this.invLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.invLabel.Location = new System.Drawing.Point(430, 35);
			this.invLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.invLabel.Name = "invLabel";
			this.invLabel.Size = new System.Drawing.Size(81, 20);
			this.invLabel.TabIndex = 92;
			this.invLabel.Text = "Inventory:";
			this.invLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ProductStockField
			// 
			this.ProductStockField.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.ProductStockField.Location = new System.Drawing.Point(330, 33);
			this.ProductStockField.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
			this.ProductStockField.Name = "ProductStockField";
			this.ProductStockField.ReadOnly = true;
			this.ProductStockField.Size = new System.Drawing.Size(90, 27);
			this.ProductStockField.TabIndex = 85;
			this.ProductStockField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ProductStockLabel
			// 
			this.ProductStockLabel.AutoSize = true;
			this.ProductStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.ProductStockLabel.Location = new System.Drawing.Point(276, 37);
			this.ProductStockLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.ProductStockLabel.Name = "ProductStockLabel";
			this.ProductStockLabel.Size = new System.Drawing.Size(56, 20);
			this.ProductStockLabel.TabIndex = 91;
			this.ProductStockLabel.Text = "Stock:";
			this.ProductStockLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// NewInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 721);
			this.Controls.Add(this.ProductListGroupBox);
			this.Controls.Add(this.InvoiceDetailsGroupbox);
			this.Controls.Add(this.TotalCostsGrid);
			this.Controls.Add(this.InsertButton);
			this.Controls.Add(this.CheckSQL);
			this.Controls.Add(this.CustomerGroupBox);
			this.Controls.Add(this.SalesPersonGroupBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.Name = "NewInvoice";
			this.Text = "Insert New Invoice";
			this.Load += new System.EventHandler(this.NewInvoice_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductListGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalCostsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductQtySpinbox)).EndInit();
			this.InvoiceDetailsGroupbox.ResumeLayout(false);
			this.InvoiceDetailsGroupbox.PerformLayout();
			this.SalesPersonGroupBox.ResumeLayout(false);
			this.SalesPersonGroupBox.PerformLayout();
			this.CustomerGroupBox.ResumeLayout(false);
			this.CustomerGroupBox.PerformLayout();
			this.ProductListGroupBox.ResumeLayout(false);
			this.ProductListGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton CheckSQL;
		private System.Windows.Forms.DateTimePicker InvoiceOnDatePick;
		private System.Windows.Forms.TextBox StoreAddress1Field;
		private System.Windows.Forms.TextBox StoreCityField;
		private System.Windows.Forms.Label InvoiceNoLabel;
		private System.Windows.Forms.Label InvoiceDateOnLabel;
		private System.Windows.Forms.TextBox StorePostalCodeField;
		private System.Windows.Forms.TextBox CustomerBillingPostalCodeField;
		private System.Windows.Forms.TextBox CustomerBillingAddress1Field;
		private System.Windows.Forms.TextBox CustomerBillingCityField;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.ComboBox SalesPersonDropdown;
		private System.Windows.Forms.ComboBox CustomerDropdown;
		private System.Windows.Forms.Label InvoiceNoPrintLabel;
		private System.Windows.Forms.Label SelectProductLabel;
		private System.Windows.Forms.ComboBox ProductDropdown;
		private System.Windows.Forms.Label ProductQtyLabel;
		private System.Windows.Forms.Button QtyAddButton;
		private System.Windows.Forms.Button QtyDelButton;
		private System.Windows.Forms.DataGridView ProductListGrid;
		private System.Windows.Forms.DataGridView TotalCostsGrid;
		private System.Windows.Forms.TextBox StoreAddress2Field;
		private System.Windows.Forms.TextBox CustomerBillingAddress2Field;
		private System.Windows.Forms.NumericUpDown ProductQtySpinbox;
		private System.Windows.Forms.GroupBox InvoiceDetailsGroupbox;
		private System.Windows.Forms.DateTimePicker InvoiceDueDatePick;
		private System.Windows.Forms.Label InvoiceDateDueLabel;
		private System.Windows.Forms.GroupBox SalesPersonGroupBox;
		private System.Windows.Forms.GroupBox CustomerGroupBox;
		private System.Windows.Forms.GroupBox ProductListGroupBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalTaxes;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
		private System.Windows.Forms.ComboBox CustomerBillingDropdown;
		private System.Windows.Forms.ComboBox StoreDropdown;
		private System.Windows.Forms.Label CustomerShippingLabel;
		private System.Windows.Forms.ComboBox CustomerShippingDropdown;
		private System.Windows.Forms.TextBox CustomerShippingAddress2Field;
		private System.Windows.Forms.TextBox CustomerShippingPostalCodeField;
		private System.Windows.Forms.TextBox CustomerShippingCityField;
		private System.Windows.Forms.TextBox CustomerShippingAddress1Field;
		private System.Windows.Forms.Label CustomerBillingLabel;
		private System.Windows.Forms.Label StoreLabel;
		private System.Windows.Forms.DateTimePicker InvoiceShippingDatePick;
		private System.Windows.Forms.Label InvoiceDateShippingLabel;
		private System.Windows.Forms.TextBox ProductStockField;
		private System.Windows.Forms.Label ProductStockLabel;
		private System.Windows.Forms.Button NewPersonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxFrac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountFrac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button EditPersonButton;
        private System.Windows.Forms.ComboBox ProductInventoryDropdown;
        private System.Windows.Forms.Label invLabel;
    }
}