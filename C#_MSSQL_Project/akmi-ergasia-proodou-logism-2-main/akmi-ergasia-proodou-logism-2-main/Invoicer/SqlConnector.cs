using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL {
	public enum EXCEPTION : int {
		NONE = 0, CONN = 1, ELSE = 2
	}

	public class SQL_Connector {
		private SqlConnection mConnLink;
		private bool mConnValid = false;
		private int  mConnCount = 0;
		private int  mTimeOut   = 5;

		public int  ConnectionsActive => mConnCount;
		public bool HasConnection     => mConnValid;
		public int CommandTimeout {
			get => mTimeOut;
			set => mTimeOut = value < 0 ? 0 : value;
		}

		private void LogSqlError(Exception e, string caption = "") {
#if DEBUG
			MessageBox.Show(e.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
			Console.WriteLine(caption + Environment.NewLine + e.Message);
#endif
		}

		private SqlCommand CreateCommand(string query, SqlParameter[] parameters) {
			var command = new SqlCommand(query, mConnLink);
			command.Parameters.AddRange(parameters);
			command.CommandTimeout = mTimeOut;
			return command;
		}

		public SQL_Connector() { }
		public SQL_Connector(string data, int timeout = 5) {
			_ = InitConnData(data);
			mTimeOut = timeout;
		}

		public bool IsValidConnection() { return mConnValid; }

		public (bool Success, int Error) OpenConnection() {
			if (!mConnValid) { return (false, -1); }
			try {
				if (mConnLink.State != ConnectionState.Open) {
					if (mConnCount == 0) { mConnLink.Open(); }
				}
				if (mConnLink.State == ConnectionState.Open) { ++mConnCount; }
				return (mConnLink.State == ConnectionState.Open, 0);
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: OpenConnection()");
				return (false, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: OpenConnection()");
				return (false, -2);
			}
		}
		public (bool Success, int Error) CloseConnection() {
			if (!mConnValid) { return (false, -1); }
			try {
				if (mConnLink?.State != ConnectionState.Closed) {
					if (mConnCount == 1) { mConnLink?.Close(); }
					if (mConnCount >= 1) { --mConnCount; }
				}
				return (mConnLink?.State == ConnectionState.Closed, 0);
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: CloseConnection()");
				return (false, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: CloseConnection()");
				return (false, -2);
			}
		}

		public (bool Success, int Error) InitConnData(string data) {
			try {
				if (mConnLink?.State != ConnectionState.Closed) {
					mConnLink?.Close();
				}
				mConnLink?.Dispose();
				mConnLink = new SqlConnection(Regex.Replace(data, @"\s+", " "));

				mConnLink.Open();
				mConnLink.Close();
				return (true, 0);
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: InitConnData()");
				mConnLink?.Dispose();
				mConnLink = null;
				return (false, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: InitConnData()");
				mConnLink?.Dispose();
				mConnLink = null;
				return (false, -2);
			} finally {
				mConnValid = mConnLink != null;
			}
		}

		public (int Value, int Error) ExecuteNonQuery(string query, params SqlParameter[] parameters) {
			if (!mConnValid) { return (0, -1); }
			try {
				var (success, error) = OpenConnection();
				if (!success || error != 0) { return (0, error); }
				using (var command = CreateCommand(query, parameters)) {
					return (command.ExecuteNonQuery(), 0);
				}
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: ExecuteNonQuery()");
				return (0, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: ExecuteNonQuery()");
				return (0, -2);
			} finally {
				CloseConnection();
			}
		}

		public (object Value, int Error) ExecuteScalarQuery(string query, params SqlParameter[] parameters) {
			if (!mConnValid) { return (null, -1); }
			try {
				var (success, error) = OpenConnection();
				if (!success || error != 0) { return (0, error); }
				using (var command = CreateCommand(query, parameters)) {
					return (command.ExecuteScalar(), 0);
				}
			} catch (SqlException e) {
				if (e.Number == 0) { throw; }
				LogSqlError(e, "SQL :: ExecuteScalarQuery()");
				return (null, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: ExecuteScalarQuery()");
				return (null, 1);	
			} finally {
				CloseConnection();
			}
		}

		private (object, int Error) FillDataTable(DataTable table, string query, params SqlParameter[] parameters) {
			if (!mConnValid) { return (null, -1); }
			try {
				var (success, error) = OpenConnection();
				if (!success || error != 0) { return (null, error); }
				using (var command = CreateCommand(query, parameters)) {
					using (var adapter = new SqlDataAdapter(command)) {
						adapter.Fill(table);
						return (null, 0);
					}
				}
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: FillExistingDataTable()");
				return (null, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: FillExistingDataTable()");
				return (null, -2);
			} finally {
				CloseConnection();
			}
		}

		public int FillExistingDataTable(DataTable table, string query, params SqlParameter[] parameters) {
			if (table == null) { return 0; }
			return FillDataTable(table, query, parameters).Error;
		}

		public (DataTable Value, int Error) CreateFilledDataTable(string query, params SqlParameter[] parameters) {
			var table = new DataTable();
			var error = FillDataTable(table, query, parameters).Error;
			return (error == 0 ? table : null, error);
		}

		public (SqlDataReader Value, int Error) CreateDataReader(string query, params SqlParameter[] parameters) {
			if (!mConnValid) { return (null, -1); }
			try {
				var (success, error) = OpenConnection();
				if (!success || error != 0) { return (null, error); }
				using (var command = CreateCommand(query, parameters)) {
					return (command.ExecuteReader(), 0);
				}
			} catch (SqlException e) {
				LogSqlError(e, "SQL :: CreateDataReader()");
				return (null, e.Number);
			} catch (Exception e) {
				LogSqlError(e, "SQL :: CreateDataReader()");
				return (null, -2);
			}
			// no CloseConnection() here, call explicitly as
			// an active connection is required to consume!
		}
	}
}
