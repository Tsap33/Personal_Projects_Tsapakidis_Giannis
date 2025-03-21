namespace Exam04
{
	partial class NewSeller
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
			this.BackButton = new System.Windows.Forms.Button();
			this.InsertButton = new System.Windows.Forms.Button();
			this.TerritoryDropdown = new System.Windows.Forms.ComboBox();
			this.TerritoryLabel = new System.Windows.Forms.Label();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.SellerNameField = new System.Windows.Forms.TextBox();
			this.TitleDropdown = new System.Windows.Forms.ComboBox();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.LastNameField = new System.Windows.Forms.TextBox();
			this.NationalIDLabel = new System.Windows.Forms.Label();
			this.NationalField = new System.Windows.Forms.TextBox();
			this.LoginIDField = new System.Windows.Forms.TextBox();
			this.LoginIDLabel = new System.Windows.Forms.Label();
			this.JobTitleLabel = new System.Windows.Forms.Label();
			this.JobTitleField = new System.Windows.Forms.TextBox();
			this.BirthDateLabel = new System.Windows.Forms.Label();
			this.BirthDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.MaritalStatusDropdown = new System.Windows.Forms.ComboBox();
			this.GenderDropdown = new System.Windows.Forms.ComboBox();
			this.HireDateLabel = new System.Windows.Forms.Label();
			this.HireDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.SalaryTypeLabel = new System.Windows.Forms.Label();
			this.SalaryTypeDropdown = new System.Windows.Forms.ComboBox();
			this.Address1Field = new System.Windows.Forms.TextBox();
			this.Address1Label = new System.Windows.Forms.Label();
			this.Address2Label = new System.Windows.Forms.Label();
			this.Address2Field = new System.Windows.Forms.TextBox();
			this.CityLabel = new System.Windows.Forms.Label();
			this.CityField = new System.Windows.Forms.TextBox();
			this.PostalCodeField = new System.Windows.Forms.TextBox();
			this.PostalCodeLabel = new System.Windows.Forms.Label();
			this.HiringDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.SystemDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.AddressDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.MiddleNameField = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.HiringDetailsGroupBox.SuspendLayout();
			this.SystemDetailsGroupBox.SuspendLayout();
			this.AddressDetailsGroupBox.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckSQL
			// 
			this.CheckSQL.AutoSize = true;
			this.CheckSQL.Location = new System.Drawing.Point(24, 464);
			this.CheckSQL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CheckSQL.Name = "CheckSQL";
			this.CheckSQL.Size = new System.Drawing.Size(205, 27);
			this.CheckSQL.TabIndex = 48;
			this.CheckSQL.TabStop = true;
			this.CheckSQL.Text = "SQL Connection Status";
			this.CheckSQL.UseVisualStyleBackColor = true;
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(817, 461);
			this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(199, 33);
			this.BackButton.TabIndex = 47;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// InsertButton
			// 
			this.InsertButton.Location = new System.Drawing.Point(611, 461);
			this.InsertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(199, 33);
			this.InsertButton.TabIndex = 46;
			this.InsertButton.Text = "Insert";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// TerritoryDropdown
			// 
			this.TerritoryDropdown.FormattingEnabled = true;
			this.TerritoryDropdown.Location = new System.Drawing.Point(113, 32);
			this.TerritoryDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.TerritoryDropdown.Name = "TerritoryDropdown";
			this.TerritoryDropdown.Size = new System.Drawing.Size(378, 31);
			this.TerritoryDropdown.TabIndex = 49;
			// 
			// TerritoryLabel
			// 
			this.TerritoryLabel.AutoSize = true;
			this.TerritoryLabel.Location = new System.Drawing.Point(7, 35);
			this.TerritoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TerritoryLabel.Name = "TerritoryLabel";
			this.TerritoryLabel.Size = new System.Drawing.Size(73, 23);
			this.TerritoryLabel.TabIndex = 50;
			this.TerritoryLabel.Text = "Territory";
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Location = new System.Drawing.Point(8, 35);
			this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(92, 23);
			this.FirstNameLabel.TabIndex = 53;
			this.FirstNameLabel.Text = "First Name";
			// 
			// SellerNameField
			// 
			this.SellerNameField.Location = new System.Drawing.Point(113, 32);
			this.SellerNameField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.SellerNameField.Name = "SellerNameField";
			this.SellerNameField.Size = new System.Drawing.Size(378, 30);
			this.SellerNameField.TabIndex = 54;
			// 
			// TitleDropdown
			// 
			this.TitleDropdown.FormattingEnabled = true;
			this.TitleDropdown.Location = new System.Drawing.Point(113, 200);
			this.TitleDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.TitleDropdown.Name = "TitleDropdown";
			this.TitleDropdown.Size = new System.Drawing.Size(71, 31);
			this.TitleDropdown.TabIndex = 58;
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Location = new System.Drawing.Point(8, 119);
			this.LastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(91, 23);
			this.LastNameLabel.TabIndex = 59;
			this.LastNameLabel.Text = "Last Name";
			// 
			// LastNameField
			// 
			this.LastNameField.Location = new System.Drawing.Point(113, 116);
			this.LastNameField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.LastNameField.Name = "LastNameField";
			this.LastNameField.Size = new System.Drawing.Size(378, 30);
			this.LastNameField.TabIndex = 60;
			// 
			// NationalIDLabel
			// 
			this.NationalIDLabel.AutoSize = true;
			this.NationalIDLabel.Location = new System.Drawing.Point(8, 78);
			this.NationalIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.NationalIDLabel.Name = "NationalIDLabel";
			this.NationalIDLabel.Size = new System.Drawing.Size(90, 23);
			this.NationalIDLabel.TabIndex = 61;
			this.NationalIDLabel.Text = "National ID";
			// 
			// NationalField
			// 
			this.NationalField.Location = new System.Drawing.Point(113, 75);
			this.NationalField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.NationalField.Name = "NationalField";
			this.NationalField.Size = new System.Drawing.Size(378, 30);
			this.NationalField.TabIndex = 62;
			// 
			// LoginIDField
			// 
			this.LoginIDField.Location = new System.Drawing.Point(113, 32);
			this.LoginIDField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.LoginIDField.Name = "LoginIDField";
			this.LoginIDField.Size = new System.Drawing.Size(378, 30);
			this.LoginIDField.TabIndex = 63;
			// 
			// LoginIDLabel
			// 
			this.LoginIDLabel.AutoSize = true;
			this.LoginIDLabel.Location = new System.Drawing.Point(8, 35);
			this.LoginIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.LoginIDLabel.Name = "LoginIDLabel";
			this.LoginIDLabel.Size = new System.Drawing.Size(70, 23);
			this.LoginIDLabel.TabIndex = 64;
			this.LoginIDLabel.Text = "Login ID";
			// 
			// JobTitleLabel
			// 
			this.JobTitleLabel.AutoSize = true;
			this.JobTitleLabel.Location = new System.Drawing.Point(8, 120);
			this.JobTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.JobTitleLabel.Name = "JobTitleLabel";
			this.JobTitleLabel.Size = new System.Drawing.Size(72, 23);
			this.JobTitleLabel.TabIndex = 65;
			this.JobTitleLabel.Text = "Job Title";
			// 
			// JobTitleField
			// 
			this.JobTitleField.Location = new System.Drawing.Point(113, 117);
			this.JobTitleField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.JobTitleField.Name = "JobTitleField";
			this.JobTitleField.Size = new System.Drawing.Size(378, 30);
			this.JobTitleField.TabIndex = 66;
			// 
			// BirthDateLabel
			// 
			this.BirthDateLabel.AutoSize = true;
			this.BirthDateLabel.Location = new System.Drawing.Point(8, 165);
			this.BirthDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.BirthDateLabel.Name = "BirthDateLabel";
			this.BirthDateLabel.Size = new System.Drawing.Size(84, 23);
			this.BirthDateLabel.TabIndex = 67;
			this.BirthDateLabel.Text = "Birth Date";
			// 
			// BirthDateDatePicker
			// 
			this.BirthDateDatePicker.Location = new System.Drawing.Point(113, 158);
			this.BirthDateDatePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.BirthDateDatePicker.Name = "BirthDateDatePicker";
			this.BirthDateDatePicker.Size = new System.Drawing.Size(378, 30);
			this.BirthDateDatePicker.TabIndex = 68;
			// 
			// MaritalStatusDropdown
			// 
			this.MaritalStatusDropdown.FormattingEnabled = true;
			this.MaritalStatusDropdown.Location = new System.Drawing.Point(327, 200);
			this.MaritalStatusDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaritalStatusDropdown.Name = "MaritalStatusDropdown";
			this.MaritalStatusDropdown.Size = new System.Drawing.Size(164, 31);
			this.MaritalStatusDropdown.TabIndex = 70;
			// 
			// GenderDropdown
			// 
			this.GenderDropdown.FormattingEnabled = true;
			this.GenderDropdown.Location = new System.Drawing.Point(194, 200);
			this.GenderDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.GenderDropdown.Name = "GenderDropdown";
			this.GenderDropdown.Size = new System.Drawing.Size(123, 31);
			this.GenderDropdown.TabIndex = 72;
			// 
			// HireDateLabel
			// 
			this.HireDateLabel.AutoSize = true;
			this.HireDateLabel.Location = new System.Drawing.Point(8, 165);
			this.HireDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.HireDateLabel.Name = "HireDateLabel";
			this.HireDateLabel.Size = new System.Drawing.Size(80, 23);
			this.HireDateLabel.TabIndex = 73;
			this.HireDateLabel.Text = "Hire Date";
			// 
			// HireDateDatePicker
			// 
			this.HireDateDatePicker.Location = new System.Drawing.Point(113, 158);
			this.HireDateDatePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.HireDateDatePicker.Name = "HireDateDatePicker";
			this.HireDateDatePicker.Size = new System.Drawing.Size(378, 30);
			this.HireDateDatePicker.TabIndex = 74;
			// 
			// SalaryTypeLabel
			// 
			this.SalaryTypeLabel.AutoSize = true;
			this.SalaryTypeLabel.Location = new System.Drawing.Point(8, 204);
			this.SalaryTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.SalaryTypeLabel.Name = "SalaryTypeLabel";
			this.SalaryTypeLabel.Size = new System.Drawing.Size(99, 23);
			this.SalaryTypeLabel.TabIndex = 75;
			this.SalaryTypeLabel.Text = "Salary Type";
			// 
			// SalaryTypeDropdown
			// 
			this.SalaryTypeDropdown.FormattingEnabled = true;
			this.SalaryTypeDropdown.Location = new System.Drawing.Point(113, 201);
			this.SalaryTypeDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.SalaryTypeDropdown.Name = "SalaryTypeDropdown";
			this.SalaryTypeDropdown.Size = new System.Drawing.Size(378, 31);
			this.SalaryTypeDropdown.TabIndex = 76;
			// 
			// Address1Field
			// 
			this.Address1Field.Location = new System.Drawing.Point(113, 29);
			this.Address1Field.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Address1Field.Name = "Address1Field";
			this.Address1Field.Size = new System.Drawing.Size(378, 30);
			this.Address1Field.TabIndex = 77;
			// 
			// Address1Label
			// 
			this.Address1Label.AutoSize = true;
			this.Address1Label.Location = new System.Drawing.Point(8, 32);
			this.Address1Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Address1Label.Name = "Address1Label";
			this.Address1Label.Size = new System.Drawing.Size(86, 23);
			this.Address1Label.TabIndex = 78;
			this.Address1Label.Text = "Address 1";
			// 
			// Address2Label
			// 
			this.Address2Label.AutoSize = true;
			this.Address2Label.Location = new System.Drawing.Point(8, 74);
			this.Address2Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Address2Label.Name = "Address2Label";
			this.Address2Label.Size = new System.Drawing.Size(86, 23);
			this.Address2Label.TabIndex = 80;
			this.Address2Label.Text = "Address 2";
			// 
			// Address2Field
			// 
			this.Address2Field.Location = new System.Drawing.Point(113, 71);
			this.Address2Field.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Address2Field.Name = "Address2Field";
			this.Address2Field.Size = new System.Drawing.Size(378, 30);
			this.Address2Field.TabIndex = 79;
			// 
			// CityLabel
			// 
			this.CityLabel.AutoSize = true;
			this.CityLabel.Location = new System.Drawing.Point(8, 116);
			this.CityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.CityLabel.Name = "CityLabel";
			this.CityLabel.Size = new System.Drawing.Size(39, 23);
			this.CityLabel.TabIndex = 81;
			this.CityLabel.Text = "City";
			// 
			// CityField
			// 
			this.CityField.Location = new System.Drawing.Point(113, 113);
			this.CityField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CityField.Name = "CityField";
			this.CityField.Size = new System.Drawing.Size(378, 30);
			this.CityField.TabIndex = 82;
			// 
			// PostalCodeField
			// 
			this.PostalCodeField.Location = new System.Drawing.Point(113, 155);
			this.PostalCodeField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.PostalCodeField.Name = "PostalCodeField";
			this.PostalCodeField.Size = new System.Drawing.Size(378, 30);
			this.PostalCodeField.TabIndex = 84;
			// 
			// PostalCodeLabel
			// 
			this.PostalCodeLabel.AutoSize = true;
			this.PostalCodeLabel.Location = new System.Drawing.Point(8, 158);
			this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.PostalCodeLabel.Name = "PostalCodeLabel";
			this.PostalCodeLabel.Size = new System.Drawing.Size(100, 23);
			this.PostalCodeLabel.TabIndex = 83;
			this.PostalCodeLabel.Text = "Postal Code";
			// 
			// HiringDetailsGroupBox
			// 
			this.HiringDetailsGroupBox.Controls.Add(this.TerritoryDropdown);
			this.HiringDetailsGroupBox.Controls.Add(this.TerritoryLabel);
			this.HiringDetailsGroupBox.Controls.Add(this.JobTitleLabel);
			this.HiringDetailsGroupBox.Controls.Add(this.JobTitleField);
			this.HiringDetailsGroupBox.Controls.Add(this.HireDateLabel);
			this.HiringDetailsGroupBox.Controls.Add(this.HireDateDatePicker);
			this.HiringDetailsGroupBox.Controls.Add(this.SalaryTypeLabel);
			this.HiringDetailsGroupBox.Controls.Add(this.SalaryTypeDropdown);
			this.HiringDetailsGroupBox.Controls.Add(this.NationalIDLabel);
			this.HiringDetailsGroupBox.Controls.Add(this.NationalField);
			this.HiringDetailsGroupBox.Location = new System.Drawing.Point(521, 12);
			this.HiringDetailsGroupBox.Name = "HiringDetailsGroupBox";
			this.HiringDetailsGroupBox.Size = new System.Drawing.Size(499, 367);
			this.HiringDetailsGroupBox.TabIndex = 88;
			this.HiringDetailsGroupBox.TabStop = false;
			this.HiringDetailsGroupBox.Text = "Hiring Details";
			// 
			// SystemDetailsGroupBox
			// 
			this.SystemDetailsGroupBox.Controls.Add(this.LoginIDField);
			this.SystemDetailsGroupBox.Controls.Add(this.LoginIDLabel);
			this.SystemDetailsGroupBox.Location = new System.Drawing.Point(521, 385);
			this.SystemDetailsGroupBox.Name = "SystemDetailsGroupBox";
			this.SystemDetailsGroupBox.Size = new System.Drawing.Size(499, 70);
			this.SystemDetailsGroupBox.TabIndex = 89;
			this.SystemDetailsGroupBox.TabStop = false;
			this.SystemDetailsGroupBox.Text = "System Details";
			// 
			// AddressDetailsGroupBox
			// 
			this.AddressDetailsGroupBox.Controls.Add(this.Address1Label);
			this.AddressDetailsGroupBox.Controls.Add(this.Address1Field);
			this.AddressDetailsGroupBox.Controls.Add(this.Address2Field);
			this.AddressDetailsGroupBox.Controls.Add(this.Address2Label);
			this.AddressDetailsGroupBox.Controls.Add(this.PostalCodeField);
			this.AddressDetailsGroupBox.Controls.Add(this.CityLabel);
			this.AddressDetailsGroupBox.Controls.Add(this.PostalCodeLabel);
			this.AddressDetailsGroupBox.Controls.Add(this.CityField);
			this.AddressDetailsGroupBox.Location = new System.Drawing.Point(16, 260);
			this.AddressDetailsGroupBox.Name = "AddressDetailsGroupBox";
			this.AddressDetailsGroupBox.Size = new System.Drawing.Size(499, 195);
			this.AddressDetailsGroupBox.TabIndex = 89;
			this.AddressDetailsGroupBox.TabStop = false;
			this.AddressDetailsGroupBox.Text = "Address Details";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.MiddleNameField);
			this.groupBox5.Controls.Add(this.textBox1);
			this.groupBox5.Controls.Add(this.SellerNameField);
			this.groupBox5.Controls.Add(this.FirstNameLabel);
			this.groupBox5.Controls.Add(this.LastNameLabel);
			this.groupBox5.Controls.Add(this.LastNameField);
			this.groupBox5.Controls.Add(this.GenderDropdown);
			this.groupBox5.Controls.Add(this.TitleDropdown);
			this.groupBox5.Controls.Add(this.BirthDateDatePicker);
			this.groupBox5.Controls.Add(this.MaritalStatusDropdown);
			this.groupBox5.Controls.Add(this.BirthDateLabel);
			this.groupBox5.Location = new System.Drawing.Point(12, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(499, 242);
			this.groupBox5.TabIndex = 90;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Personal Details";
			// 
			// MiddleNameField
			// 
			this.MiddleNameField.AutoSize = true;
			this.MiddleNameField.Location = new System.Drawing.Point(8, 77);
			this.MiddleNameField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.MiddleNameField.Name = "MiddleNameField";
			this.MiddleNameField.Size = new System.Drawing.Size(90, 23);
			this.MiddleNameField.TabIndex = 73;
			this.MiddleNameField.Text = "Mid. Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(113, 74);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(378, 30);
			this.textBox1.TabIndex = 74;
			// 
			// NewSeller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1026, 505);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.AddressDetailsGroupBox);
			this.Controls.Add(this.SystemDetailsGroupBox);
			this.Controls.Add(this.HiringDetailsGroupBox);
			this.Controls.Add(this.CheckSQL);
			this.Controls.Add(this.BackButton);
			this.Controls.Add(this.InsertButton);
			this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "NewSeller";
			this.Text = "Insert New Seller";
			this.Load += new System.EventHandler(this.NewSeller_Load);
			this.HiringDetailsGroupBox.ResumeLayout(false);
			this.HiringDetailsGroupBox.PerformLayout();
			this.SystemDetailsGroupBox.ResumeLayout(false);
			this.SystemDetailsGroupBox.PerformLayout();
			this.AddressDetailsGroupBox.ResumeLayout(false);
			this.AddressDetailsGroupBox.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton CheckSQL;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.ComboBox TerritoryDropdown;
		private System.Windows.Forms.Label TerritoryLabel;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.TextBox SellerNameField;
		private System.Windows.Forms.ComboBox TitleDropdown;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.TextBox LastNameField;
		private System.Windows.Forms.Label NationalIDLabel;
		private System.Windows.Forms.TextBox NationalField;
		private System.Windows.Forms.TextBox LoginIDField;
		private System.Windows.Forms.Label LoginIDLabel;
		private System.Windows.Forms.Label JobTitleLabel;
		private System.Windows.Forms.TextBox JobTitleField;
		private System.Windows.Forms.Label BirthDateLabel;
		private System.Windows.Forms.DateTimePicker BirthDateDatePicker;
		private System.Windows.Forms.ComboBox MaritalStatusDropdown;
		private System.Windows.Forms.ComboBox GenderDropdown;
		private System.Windows.Forms.Label HireDateLabel;
		private System.Windows.Forms.DateTimePicker HireDateDatePicker;
		private System.Windows.Forms.Label SalaryTypeLabel;
		private System.Windows.Forms.ComboBox SalaryTypeDropdown;
		private System.Windows.Forms.TextBox Address1Field;
		private System.Windows.Forms.Label Address1Label;
		private System.Windows.Forms.Label Address2Label;
		private System.Windows.Forms.TextBox Address2Field;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.TextBox CityField;
		private System.Windows.Forms.TextBox PostalCodeField;
		private System.Windows.Forms.Label PostalCodeLabel;
		private System.Windows.Forms.GroupBox HiringDetailsGroupBox;
		private System.Windows.Forms.GroupBox SystemDetailsGroupBox;
		private System.Windows.Forms.GroupBox AddressDetailsGroupBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label MiddleNameField;
		private System.Windows.Forms.TextBox textBox1;
	}
}