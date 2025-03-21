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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using static Exam04.Common;

namespace Exam04 {
	public partial class Login : Form {
		private readonly Timer pollTimer;
		private readonly SQL_Connector sql;

		public Login(SQL_Connector sql) {
			InitializeComponent();
			this.sql = sql;

			pollTimer = new Timer { Interval = 25 };
			pollTimer.Tick += FormStatusCheckSQL;
			pollTimer.Start();
		}
		~Login() {
			pollTimer.Stop();
			pollTimer.Dispose();
			if (DialogResult != DialogResult.OK) {
				DialogResult = DialogResult.Cancel;
			}
		}

		private void Login_Load(object sender, EventArgs e) {
			if (sql.ExecuteScalarQuery(@"
				IF NOT EXISTS (
					SELECT 1 FROM INFORMATION_SCHEMA.TABLES
						WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Users'
				) BEGIN
					CREATE TABLE dbo.Users (
						ID INT IDENTITY(1,1) PRIMARY KEY,
						Username NVARCHAR(50) NOT NULL UNIQUE,
						Password NVARCHAR(50) NOT NULL
					);
				END;"
			).Error != 0) { Close(); }
			else { UsernameField.Select(); }
		}

		private void FormStatusCheckSQL(object sender, EventArgs e) {
			bool conn = sql.IsValidConnection();

			CheckSQL.Checked = LoginButton.Enabled = SignupButton.Enabled = conn;
			CheckSQL.Text = $"SQL Status: {(conn ? "Connected" : "Disconnected")}";
		}

		private void LoginButton_Click(object sender, EventArgs e) {
			if (CheckEmptyFields(UsernameField, PasswordField)) { return; }

			if (sql.ExecuteScalarQuery(@"
				SELECT COUNT(*) FROM dbo.Users WHERE Username = @Username AND Password = @Password;",
				new SqlParameter("@Username", UsernameField.Text),
				new SqlParameter("@Password", PasswordField.Text)
			).Value.ToType(0) > 0) {
				DialogResult = DialogResult.OK;
				Close();
			} else {
				MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SignupButton_Click(object sender, EventArgs e) {
			if (CheckEmptyFields(UsernameField, PasswordField)) { return; }

			if (sql.ExecuteScalarQuery(@"
				SELECT COUNT(*) FROM dbo.Users WHERE Username = @Username;",
				new SqlParameter("@Username", UsernameField.Text)
			).Value.ToType(0) > 0) {
				MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (sql.ExecuteNonQuery(@"
				INSERT INTO Users (username, password) VALUES (@username, @password);",
				new SqlParameter("@username", UsernameField.Text),
				new SqlParameter("@password", PasswordField.Text)
			).Error != 0) {
				MessageBox.Show("An unknown error has occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			} else {
				MessageBox.Show("Successfully registered user!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void CheckSQL_Click(object sender, EventArgs e) {
			FormStatusCheckSQL(this, EventArgs.Empty);
		}

		private void UsernameField_TextChanged(object sender, EventArgs e) {
			UsernameField.CheckRequired();
		}

		private void PasswordField_TextChanged(object sender, EventArgs e) {
			PasswordField.CheckRequired();
		}
	}
}
