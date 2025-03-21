namespace Exam04 {
	partial class NewCustomer {
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
		private void InitializeComponent()
		{
			this.CheckSQL = new System.Windows.Forms.RadioButton();
			this.EmailField = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.InsertButton = new System.Windows.Forms.Button();
			this.LastNameField = new System.Windows.Forms.TextBox();
			this.FirstNameField = new System.Windows.Forms.TextBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.TitleTypeDropdown = new System.Windows.Forms.ComboBox();
			this.phoneGridView = new System.Windows.Forms.DataGridView();
			this.PhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressGridView = new System.Windows.Forms.DataGridView();
			this.AddressType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailGridView = new System.Windows.Forms.DataGridView();
			this.EmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmailName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.phoneGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// CheckSQL
			// 
			this.CheckSQL.AutoSize = true;
			this.CheckSQL.Location = new System.Drawing.Point(14, 329);
			this.CheckSQL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.CheckSQL.Name = "CheckSQL";
			this.CheckSQL.Size = new System.Drawing.Size(205, 27);
			this.CheckSQL.TabIndex = 56;
			this.CheckSQL.TabStop = true;
			this.CheckSQL.Text = "SQL Connection Status";
			this.CheckSQL.UseVisualStyleBackColor = true;
			// 
			// EmailField
			// 
			this.EmailField.Location = new System.Drawing.Point(151, 121);
			this.EmailField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.EmailField.Name = "EmailField";
			this.EmailField.Size = new System.Drawing.Size(250, 30);
			this.EmailField.TabIndex = 43;
			this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(15, 127);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(50, 23);
			this.EmailLabel.TabIndex = 42;
			this.EmailLabel.Text = "Email";
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Location = new System.Drawing.Point(15, 52);
			this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(91, 23);
			this.LastNameLabel.TabIndex = 35;
			this.LastNameLabel.Text = "Last Name";
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Location = new System.Drawing.Point(15, 18);
			this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(92, 23);
			this.FirstNameLabel.TabIndex = 34;
			this.FirstNameLabel.Text = "First Name";
			// 
			// InsertButton
			// 
			this.InsertButton.Location = new System.Drawing.Point(783, 326);
			this.InsertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(173, 33);
			this.InsertButton.TabIndex = 32;
			this.InsertButton.Text = "Insert";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// LastNameField
			// 
			this.LastNameField.Location = new System.Drawing.Point(151, 48);
			this.LastNameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LastNameField.Name = "LastNameField";
			this.LastNameField.Size = new System.Drawing.Size(250, 30);
			this.LastNameField.TabIndex = 31;
			this.LastNameField.TextChanged += new System.EventHandler(this.LastNameField_TextChanged);
			// 
			// FirstNameField
			// 
			this.FirstNameField.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FirstNameField.Location = new System.Drawing.Point(151, 12);
			this.FirstNameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.FirstNameField.Name = "FirstNameField";
			this.FirstNameField.Size = new System.Drawing.Size(250, 30);
			this.FirstNameField.TabIndex = 30;
			this.FirstNameField.TextChanged += new System.EventHandler(this.FirstNameField_TextChanged);
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(15, 90);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(40, 23);
			this.TitleLabel.TabIndex = 60;
			this.TitleLabel.Text = "Title";
			// 
			// TitleTypeDropdown
			// 
			this.TitleTypeDropdown.FormattingEnabled = true;
			this.TitleTypeDropdown.Location = new System.Drawing.Point(151, 84);
			this.TitleTypeDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TitleTypeDropdown.Name = "TitleTypeDropdown";
			this.TitleTypeDropdown.Size = new System.Drawing.Size(250, 31);
			this.TitleTypeDropdown.TabIndex = 59;
			// 
			// phoneGridView
			// 
			this.phoneGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.phoneGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneType,
            this.PhoneNumber});
			this.phoneGridView.Location = new System.Drawing.Point(431, 12);
			this.phoneGridView.MultiSelect = false;
			this.phoneGridView.Name = "phoneGridView";
			this.phoneGridView.RowHeadersVisible = false;
			this.phoneGridView.RowHeadersWidth = 51;
			this.phoneGridView.Size = new System.Drawing.Size(261, 135);
			this.phoneGridView.TabIndex = 61;
			// 
			// PhoneType
			// 
			this.PhoneType.HeaderText = "Phone Type";
			this.PhoneType.MinimumWidth = 6;
			this.PhoneType.Name = "PhoneType";
			this.PhoneType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.PhoneType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.PhoneType.Width = 110;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PhoneNumber.HeaderText = "Number";
			this.PhoneNumber.MinimumWidth = 6;
			this.PhoneNumber.Name = "PhoneNumber";
			// 
			// addressGridView
			// 
			this.addressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressType,
            this.AddressLine1,
            this.AddressLine2,
            this.City,
            this.PostalCode});
			this.addressGridView.Location = new System.Drawing.Point(19, 167);
			this.addressGridView.MultiSelect = false;
			this.addressGridView.Name = "addressGridView";
			this.addressGridView.RowHeadersVisible = false;
			this.addressGridView.RowHeadersWidth = 51;
			this.addressGridView.Size = new System.Drawing.Size(937, 142);
			this.addressGridView.TabIndex = 62;
			// 
			// AddressType
			// 
			this.AddressType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.AddressType.HeaderText = "Type";
			this.AddressType.MinimumWidth = 6;
			this.AddressType.Name = "AddressType";
			this.AddressType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.AddressType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.AddressType.Width = 76;
			// 
			// AddressLine1
			// 
			this.AddressLine1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AddressLine1.HeaderText = "Address Line 1";
			this.AddressLine1.MinimumWidth = 6;
			this.AddressLine1.Name = "AddressLine1";
			// 
			// AddressLine2
			// 
			this.AddressLine2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AddressLine2.HeaderText = "Address Line 2";
			this.AddressLine2.MinimumWidth = 6;
			this.AddressLine2.Name = "AddressLine2";
			// 
			// City
			// 
			this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.City.HeaderText = "City";
			this.City.MinimumWidth = 6;
			this.City.Name = "City";
			this.City.Width = 68;
			// 
			// PostalCode
			// 
			this.PostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PostalCode.HeaderText = "PostalCode";
			this.PostalCode.MinimumWidth = 6;
			this.PostalCode.Name = "PostalCode";
			this.PostalCode.Width = 124;
			// 
			// emailGridView
			// 
			this.emailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.emailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailID,
            this.EmailName});
			this.emailGridView.Location = new System.Drawing.Point(712, 12);
			this.emailGridView.MultiSelect = false;
			this.emailGridView.Name = "emailGridView";
			this.emailGridView.RowHeadersVisible = false;
			this.emailGridView.RowHeadersWidth = 51;
			this.emailGridView.Size = new System.Drawing.Size(244, 135);
			this.emailGridView.TabIndex = 63;
			// 
			// EmailID
			// 
			this.EmailID.HeaderText = "EmailID";
			this.EmailID.MinimumWidth = 6;
			this.EmailID.Name = "EmailID";
			this.EmailID.Visible = false;
			this.EmailID.Width = 125;
			// 
			// EmailName
			// 
			this.EmailName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EmailName.HeaderText = "Email";
			this.EmailName.MinimumWidth = 6;
			this.EmailName.Name = "EmailName";
			this.EmailName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// NewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 372);
			this.Controls.Add(this.emailGridView);
			this.Controls.Add(this.addressGridView);
			this.Controls.Add(this.phoneGridView);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.TitleTypeDropdown);
			this.Controls.Add(this.CheckSQL);
			this.Controls.Add(this.EmailField);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.LastNameLabel);
			this.Controls.Add(this.FirstNameLabel);
			this.Controls.Add(this.InsertButton);
			this.Controls.Add(this.LastNameField);
			this.Controls.Add(this.FirstNameField);
			this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NewCustomer";
			this.Text = "Insert New Customer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCustomer_FormClosing);
			this.Load += new System.EventHandler(this.NewCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.phoneGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emailGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton CheckSQL;
		private System.Windows.Forms.TextBox EmailField;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.TextBox LastNameField;
		private System.Windows.Forms.TextBox FirstNameField;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.ComboBox TitleTypeDropdown;
        private System.Windows.Forms.DataGridView addressGridView;
		private System.Windows.Forms.DataGridView phoneGridView;
		private System.Windows.Forms.DataGridView emailGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmailID;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmailName;
		private System.Windows.Forms.DataGridViewComboBoxColumn AddressType;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine1;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine2;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
		private System.Windows.Forms.DataGridViewComboBoxColumn PhoneType;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
	}
}