namespace Exam04 {
	partial class NewVendor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.CompanyNameField = new System.Windows.Forms.TextBox();
			this.InsertButton = new System.Windows.Forms.Button();
			this.BackButton = new System.Windows.Forms.Button();
			this.CompanyNameLabel = new System.Windows.Forms.Label();
			this.CityField = new System.Windows.Forms.TextBox();
			this.CityLabel = new System.Windows.Forms.Label();
			this.Address1Label = new System.Windows.Forms.Label();
			this.PostalCodeLabel = new System.Windows.Forms.Label();
			this.Address1Field = new System.Windows.Forms.TextBox();
			this.PostalCodeField = new System.Windows.Forms.TextBox();
			this.ProvinceLabel = new System.Windows.Forms.Label();
			this.StateProvince = new System.Windows.Forms.ComboBox();
			this.CheckSQL = new System.Windows.Forms.RadioButton();
			this.AccountNumLabel = new System.Windows.Forms.Label();
			this.AccountNumField = new System.Windows.Forms.TextBox();
			this.Address2Field = new System.Windows.Forms.TextBox();
			this.Address2Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CompanyNameField
			// 
			this.CompanyNameField.ForeColor = System.Drawing.SystemColors.WindowText;
			this.CompanyNameField.Location = new System.Drawing.Point(154, 13);
			this.CompanyNameField.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CompanyNameField.Name = "CompanyNameField";
			this.CompanyNameField.Size = new System.Drawing.Size(250, 30);
			this.CompanyNameField.TabIndex = 2;
			this.CompanyNameField.TextChanged += new System.EventHandler(this.CompanyNameField_TextChanged);
			// 
			// InsertButton
			// 
			this.InsertButton.Location = new System.Drawing.Point(586, 223);
			this.InsertButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(182, 33);
			this.InsertButton.TabIndex = 4;
			this.InsertButton.Text = "Insert";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(776, 223);
			this.BackButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(192, 33);
			this.BackButton.TabIndex = 5;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// CompanyNameLabel
			// 
			this.CompanyNameLabel.AutoSize = true;
			this.CompanyNameLabel.Location = new System.Drawing.Point(12, 17);
			this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CompanyNameLabel.Name = "CompanyNameLabel";
			this.CompanyNameLabel.Size = new System.Drawing.Size(130, 23);
			this.CompanyNameLabel.TabIndex = 6;
			this.CompanyNameLabel.Text = "Company Name";
			// 
			// CityField
			// 
			this.CityField.Location = new System.Drawing.Point(586, 13);
			this.CityField.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CityField.Name = "CityField";
			this.CityField.Size = new System.Drawing.Size(378, 30);
			this.CityField.TabIndex = 18;
			this.CityField.TextChanged += new System.EventHandler(this.CityField_TextChanged);
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Location = new System.Drawing.Point(434, 18);
			this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(39, 23);
			this.CityLabel.TabIndex = 21;
			this.CityLabel.Text = "City";
			// 
			// Address1Label
			// 
			this.Address1Label.AutoSize = true;
			this.Address1Label.Location = new System.Drawing.Point(434, 55);
			this.Address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Address1Label.Name = "Address1Label";
			this.Address1Label.Size = new System.Drawing.Size(72, 23);
			this.Address1Label.TabIndex = 22;
			this.Address1Label.Text = "Address";
			// 
			// PostalCodeLabel
			// 
			this.PostalCodeLabel.AutoSize = true;
			this.PostalCodeLabel.Location = new System.Drawing.Point(434, 125);
			this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PostalCodeLabel.Name = "PostalCodeLabel";
			this.PostalCodeLabel.Size = new System.Drawing.Size(100, 23);
			this.PostalCodeLabel.TabIndex = 23;
			this.PostalCodeLabel.Text = "Postal Code";
			// 
			// Address1Field
			// 
			this.Address1Field.Location = new System.Drawing.Point(586, 49);
			this.Address1Field.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Address1Field.Name = "Address1Field";
			this.Address1Field.Size = new System.Drawing.Size(378, 30);
			this.Address1Field.TabIndex = 24;
			this.Address1Field.TextChanged += new System.EventHandler(this.Address1Field_TextChanged);
			// 
			// PostalCodeField
			// 
			this.PostalCodeField.Location = new System.Drawing.Point(586, 121);
			this.PostalCodeField.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PostalCodeField.Name = "PostalCodeField";
			this.PostalCodeField.Size = new System.Drawing.Size(378, 30);
			this.PostalCodeField.TabIndex = 25;
			this.PostalCodeField.TextChanged += new System.EventHandler(this.PostalCodeField_TextChanged);
			// 
			// ProvinceLabel
			// 
			this.ProvinceLabel.AutoSize = true;
			this.ProvinceLabel.Location = new System.Drawing.Point(434, 163);
			this.ProvinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ProvinceLabel.Name = "ProvinceLabel";
			this.ProvinceLabel.Size = new System.Drawing.Size(75, 23);
			this.ProvinceLabel.TabIndex = 26;
			this.ProvinceLabel.Text = "Province";
			// 
			// StateProvince
			// 
			this.StateProvince.FormattingEnabled = true;
			this.StateProvince.Location = new System.Drawing.Point(586, 156);
			this.StateProvince.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.StateProvince.Name = "StateProvince";
			this.StateProvince.Size = new System.Drawing.Size(378, 31);
			this.StateProvince.TabIndex = 27;
			// 
			// CheckSQL
			// 
			this.CheckSQL.AutoSize = true;
			this.CheckSQL.Location = new System.Drawing.Point(16, 226);
			this.CheckSQL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CheckSQL.Name = "CheckSQL";
			this.CheckSQL.Size = new System.Drawing.Size(205, 27);
			this.CheckSQL.TabIndex = 28;
			this.CheckSQL.TabStop = true;
			this.CheckSQL.Text = "SQL Connection Status";
			this.CheckSQL.UseVisualStyleBackColor = true;
			this.CheckSQL.Click += new System.EventHandler(this.CheckSQL_Click);
			// 
			// AccountNumLabel
			// 
			this.AccountNumLabel.AutoSize = true;
			this.AccountNumLabel.Location = new System.Drawing.Point(12, 53);
			this.AccountNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AccountNumLabel.Name = "AccountNumLabel";
			this.AccountNumLabel.Size = new System.Drawing.Size(135, 23);
			this.AccountNumLabel.TabIndex = 12;
			this.AccountNumLabel.Text = "Account Number";
			// 
			// AccountNumField
			// 
			this.AccountNumField.Location = new System.Drawing.Point(154, 48);
			this.AccountNumField.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.AccountNumField.Name = "AccountNumField";
			this.AccountNumField.Size = new System.Drawing.Size(250, 30);
			this.AccountNumField.TabIndex = 29;
			this.AccountNumField.TextChanged += new System.EventHandler(this.AccountNumField_TextChanged);
			// 
			// Address2Field
			// 
			this.Address2Field.Location = new System.Drawing.Point(586, 85);
			this.Address2Field.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Address2Field.Name = "Address2Field";
			this.Address2Field.Size = new System.Drawing.Size(378, 30);
			this.Address2Field.TabIndex = 31;
			// 
			// Address2Label
			// 
			this.Address2Label.AutoSize = true;
			this.Address2Label.Location = new System.Drawing.Point(434, 91);
			this.Address2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Address2Label.Name = "Address2Label";
			this.Address2Label.Size = new System.Drawing.Size(86, 23);
			this.Address2Label.TabIndex = 30;
			this.Address2Label.Text = "Address 2";
			// 
			// NewVendor
			// 
			this.AcceptButton = this.InsertButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 267);
			this.Controls.Add(this.Address2Field);
			this.Controls.Add(this.Address2Label);
			this.Controls.Add(this.AccountNumField);
			this.Controls.Add(this.CheckSQL);
			this.Controls.Add(this.StateProvince);
			this.Controls.Add(this.ProvinceLabel);
			this.Controls.Add(this.PostalCodeField);
			this.Controls.Add(this.Address1Field);
			this.Controls.Add(this.PostalCodeLabel);
			this.Controls.Add(this.Address1Label);
			this.Controls.Add(this.CityLabel);
			this.Controls.Add(this.CityField);
			this.Controls.Add(this.AccountNumLabel);
			this.Controls.Add(this.CompanyNameLabel);
			this.Controls.Add(this.BackButton);
			this.Controls.Add(this.InsertButton);
			this.Controls.Add(this.CompanyNameField);
			this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "NewVendor";
			this.Text = "Insert New Vendor";
			this.Load += new System.EventHandler(this.NewSupplier_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox CompanyNameField;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Label CompanyNameLabel;
		private System.Windows.Forms.TextBox CityField;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.Label Address1Label;
		private System.Windows.Forms.Label PostalCodeLabel;
		private System.Windows.Forms.TextBox Address1Field;
		private System.Windows.Forms.TextBox PostalCodeField;
		private System.Windows.Forms.Label ProvinceLabel;
		private System.Windows.Forms.ComboBox StateProvince;
		private System.Windows.Forms.RadioButton CheckSQL;
		private System.Windows.Forms.Label AccountNumLabel;
		private System.Windows.Forms.TextBox AccountNumField;
		private System.Windows.Forms.TextBox Address2Field;
		private System.Windows.Forms.Label Address2Label;
	}
}