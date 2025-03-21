using SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam04 {
	internal static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			SQL_Connector sql = new SQL_Connector(@"
				Data Source = .\MSSQLSERVER2022;
				Initial Catalog = AdventureWorks2022;
				User ID = sa;
				Password = 1234;"
			);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NewInvoice(sql));
		}
	}
}
