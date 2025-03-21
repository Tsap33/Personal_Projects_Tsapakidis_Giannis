namespace Exam04 {
	partial class Login {
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
			this.UsernameField = new System.Windows.Forms.TextBox();
			this.PasswordField = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SignupButton = new System.Windows.Forms.Button();
			this.CheckSQL = new System.Windows.Forms.RadioButton();
			this.UsernameGroupBox = new System.Windows.Forms.GroupBox();
			this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
			this.UsernameGroupBox.SuspendLayout();
			this.PasswordGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// UsernameField
			// 
			this.UsernameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UsernameField.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.UsernameField.Location = new System.Drawing.Point(8, 32);
			this.UsernameField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.UsernameField.MaxLength = 50;
			this.UsernameField.Name = "UsernameField";
			this.UsernameField.Size = new System.Drawing.Size(330, 30);
			this.UsernameField.TabIndex = 2;
			this.UsernameField.TextChanged += new System.EventHandler(this.UsernameField_TextChanged);
			// 
			// PasswordField
			// 
			this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordField.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.PasswordField.Location = new System.Drawing.Point(8, 32);
			this.PasswordField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.PasswordField.MaxLength = 50;
			this.PasswordField.Name = "PasswordField";
			this.PasswordField.Size = new System.Drawing.Size(330, 30);
			this.PasswordField.TabIndex = 3;
			this.PasswordField.UseSystemPasswordChar = true;
			this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
			this.LoginButton.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.LoginButton.ForeColor = System.Drawing.Color.White;
			this.LoginButton.Location = new System.Drawing.Point(12, 171);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(161, 44);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = "Log in";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// SignupButton
			// 
			this.SignupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SignupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
			this.SignupButton.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.SignupButton.ForeColor = System.Drawing.Color.White;
			this.SignupButton.Location = new System.Drawing.Point(198, 171);
			this.SignupButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.SignupButton.Name = "SignupButton";
			this.SignupButton.Size = new System.Drawing.Size(161, 44);
			this.SignupButton.TabIndex = 5;
			this.SignupButton.Text = "Sign up";
			this.SignupButton.UseVisualStyleBackColor = false;
			this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
			// 
			// CheckSQL
			// 
			this.CheckSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CheckSQL.AutoSize = true;
			this.CheckSQL.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.CheckSQL.Location = new System.Drawing.Point(12, 225);
			this.CheckSQL.Margin = new System.Windows.Forms.Padding(4);
			this.CheckSQL.Name = "CheckSQL";
			this.CheckSQL.Size = new System.Drawing.Size(205, 27);
			this.CheckSQL.TabIndex = 6;
			this.CheckSQL.Text = "SQL Connection Status";
			this.CheckSQL.UseVisualStyleBackColor = true;
			// 
			// UsernameGroupBox
			// 
			this.UsernameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UsernameGroupBox.Controls.Add(this.UsernameField);
			this.UsernameGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.UsernameGroupBox.Location = new System.Drawing.Point(12, 12);
			this.UsernameGroupBox.Name = "UsernameGroupBox";
			this.UsernameGroupBox.Size = new System.Drawing.Size(347, 72);
			this.UsernameGroupBox.TabIndex = 7;
			this.UsernameGroupBox.TabStop = false;
			this.UsernameGroupBox.Text = "Username";
			// 
			// PasswordGroupBox
			// 
			this.PasswordGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordGroupBox.Controls.Add(this.PasswordField);
			this.PasswordGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.PasswordGroupBox.Location = new System.Drawing.Point(12, 90);
			this.PasswordGroupBox.Name = "PasswordGroupBox";
			this.PasswordGroupBox.Size = new System.Drawing.Size(347, 72);
			this.PasswordGroupBox.TabIndex = 8;
			this.PasswordGroupBox.TabStop = false;
			this.PasswordGroupBox.Text = "Password";
			// 
			// Login
			// 
			this.AcceptButton = this.LoginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(369, 265);
			this.Controls.Add(this.PasswordGroupBox);
			this.Controls.Add(this.UsernameGroupBox);
			this.Controls.Add(this.CheckSQL);
			this.Controls.Add(this.SignupButton);
			this.Controls.Add(this.LoginButton);
			this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database Access";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Login_Load);
			this.UsernameGroupBox.ResumeLayout(false);
			this.UsernameGroupBox.PerformLayout();
			this.PasswordGroupBox.ResumeLayout(false);
			this.PasswordGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox UsernameField;
		private System.Windows.Forms.TextBox PasswordField;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button SignupButton;
		private System.Windows.Forms.RadioButton CheckSQL;
		private System.Windows.Forms.GroupBox UsernameGroupBox;
		private System.Windows.Forms.GroupBox PasswordGroupBox;
	}
}

