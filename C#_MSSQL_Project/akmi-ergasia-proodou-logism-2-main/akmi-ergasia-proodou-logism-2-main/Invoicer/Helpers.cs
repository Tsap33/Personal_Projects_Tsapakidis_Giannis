using SQL;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace Exam04 {
	public class Ref {
		public object Value { get; set; }
		public Ref(object value) { Value = value; }
	}

	public class ItemID {
		public string Name { get; set; }
		public object ID { get; set; }
		public ItemID(object lt, object rt) {
			Name = lt?.ToString();
			ID   = rt;
		}
		public override string ToString() {
			if (Name == null) { return "N/A"; }
			if (ID   == null) { return Name; }
#if DEBUG
			return $"{Name} ({ID})";
#else
			return Name;
#endif
		}
	}

	public static class Converter {
		public static T ToType<T>(this object input, T defval = default) {
			if (input == null || input is DBNull) { return defval; }
			try { return (T)Convert.ChangeType(input, typeof(T)); }
			catch { return defval; }
		}
	}

	public static class Common {
		public static string GetItemName(this object obj) {
			return (obj is ItemID ret) ? ret.Name : default;
		}

		public static T GetItemName<T>(this System.Windows.Forms.ComboBox obj, T defval = default) {
			return (obj?.SelectedItem is ItemID ret) ? Converter.ToType<T>(ret.Name) : defval;
		}

		public static object GetItemID(this object obj) {
			return (obj is ItemID ret) ? ret.ID : default;
		}

		public static T GetItemID<T>(this object obj, T defval = default) {
			return (obj is ItemID ret) ? Converter.ToType<T>(ret.ID) : defval;
		}

		public static T GetItemID<T>(this System.Windows.Forms.ComboBox obj, T defval = default) {
			return (obj?.SelectedItem is ItemID ret) ? Converter.ToType<T>(ret.ID) : defval;
		}

		/* --------------------------------------------------------------------------------------------------- */

		private static T DataTableNullTest<T>(object Input, T DefaultValue) {
			return Input != DBNull.Value ? Converter.ToType(Input, DefaultValue) : DefaultValue;
		}

		public static T GetSafeValue<T>(this DataRow DataRow, string ColumnName, T DefaultValue = default) {
			if (!(DataRow?.Table.Columns.Contains(ColumnName ?? "") ?? false)) { return DefaultValue; }
			return DataTableNullTest(DataRow[ColumnName], DefaultValue);
		}

		public static T GetSafeValue<T>(this DataTable DataTable, int RowIndex = 0, int ColumnIndex = 0, T DefaultValue = default) {
			if (RowIndex >= (DataTable?.Rows.Count ?? 0) || ColumnIndex >= (DataTable?.Columns.Count ?? 0)) { return DefaultValue; }
			return DataTableNullTest(DataTable.Rows[RowIndex][ColumnIndex], DefaultValue);
		}

		public static T GetSafeValue<T>(this DataTable DataTable, int RowIndex, string ColumnName, T DefaultValue = default) {
			if (RowIndex >= (DataTable?.Rows.Count ?? 0) || !(DataTable?.Columns.Contains(ColumnName ?? "") ?? false)) { return DefaultValue; }
			return DataTableNullTest(DataTable.Rows[RowIndex][ColumnName], DefaultValue);
		}

		/* --------------------------------------------------------------------------------------------------- */

		public static T GetSafeValue<T>(this DataGridViewRow GridViewRow, int ColumnIndex = 0, T DefaultValue = default) {
			if (ColumnIndex >= (GridViewRow?.Cells.Count ?? 0)) { return DefaultValue; }
			return Converter.ToType(GridViewRow.Cells[ColumnIndex].Value, DefaultValue);
		}

		public static void SetSafeValue(this DataGridViewRow GridViewRow, int ColumnIndex, object NewValue) {
			if (ColumnIndex >= (GridViewRow?.Cells.Count ?? 0)) { return; }
			GridViewRow.Cells[ColumnIndex].Value = NewValue;
		}

		public static T GetSafeValue<T>(this DataGridViewRow GridViewRow, string CellName, T DefaultValue = default) {
			if (!(GridViewRow?.DataGridView?.Columns.Contains(CellName ?? "") ?? false)) { return DefaultValue; }
			return Converter.ToType(GridViewRow.Cells[CellName].Value, DefaultValue);
		}

		public static void SetSafeValue(this DataGridViewRow GridViewRow, string CellName, object NewValue) {
			if (!(GridViewRow?.DataGridView?.Columns.Contains(CellName ?? "") ?? false)) { return; }
			GridViewRow.Cells[CellName].Value = NewValue;
		}

		public static T GetSafeValue<T>(this DataGridView GridView, int RowIndex = 0, int ColumnIndex = 0, T DefaultValue = default) {
			if (RowIndex >= (GridView?.Rows.Count ?? 0) || ColumnIndex >= (GridView?.Columns.Count ?? 0)) { return DefaultValue; }
			return Converter.ToType(GridView.Rows[RowIndex].Cells[ColumnIndex].Value, DefaultValue);
		}

		public static void SetSafeValue(this DataGridView GridView, int RowIndex, int ColumnIndex, object NewValue) {
			if (RowIndex >= (GridView?.Rows.Count ?? 0) || ColumnIndex >= (GridView?.Columns.Count ?? 0)) { return; }
			GridView.Rows[RowIndex].Cells[ColumnIndex].Value = NewValue;
		}

		public static T GetSafeValue<T>(this DataGridView GridView, int RowIndex, string ColumnName, T DefaultValue = default) {
			if (RowIndex >= (GridView?.Rows.Count ?? 0) || !(GridView?.Columns.Contains(ColumnName ?? "") ?? false)) { return DefaultValue; }
			return Converter.ToType(GridView.Rows[RowIndex].Cells[ColumnName].Value, DefaultValue);
		}

		public static void SetSafeValue(this DataGridView GridView, int RowIndex, string ColumnName, object NewValue) {
			if (RowIndex >= (GridView?.Rows.Count ?? 0) || !(GridView?.Columns.Contains(ColumnName ?? "") ?? false)) { return; }
			GridView.Rows[RowIndex].Cells[ColumnName].Value = NewValue;
		}

		public static T GetSelectedSafeValue<T>(this DataGridView GridView, int RowIndex = 0, int ColumnIndex = 0, T DefaultValue = default) {
			if (RowIndex >= (GridView?.SelectedRows.Count ?? 0) || ColumnIndex >= (GridView?.Columns.Count ?? 0)) { return DefaultValue; }
			return Converter.ToType(GridView.SelectedRows[RowIndex].Cells[ColumnIndex].Value, DefaultValue);
		}

		public static void SetSelectedSafeValue(this DataGridView GridView, int RowIndex, int ColumnIndex, object NewValue) {
			if (RowIndex >= (GridView?.SelectedRows.Count ?? 0) || ColumnIndex >= (GridView?.Columns.Count ?? 0)) { return; }
			GridView.SelectedRows[RowIndex].Cells[ColumnIndex].Value = NewValue;
		}

		public static T GetSelectedSafeValue<T>(this DataGridView GridView, int RowIndex, string ColumnName, T DefaultValue = default) {
			if (RowIndex >= (GridView?.SelectedRows.Count ?? 0) || !(GridView?.Columns.Contains(ColumnName ?? "") ?? false)) { return DefaultValue; }
			return Converter.ToType(GridView.SelectedRows[RowIndex].Cells[ColumnName].Value, DefaultValue);
		}

		public static void SetSelectedSafeValue(this DataGridView GridView, int RowIndex, string ColumnName, object NewValue) {
			if (RowIndex >= (GridView?.SelectedRows.Count ?? 0) || !(GridView?.Columns.Contains(ColumnName ?? "") ?? false)) { return; }
			GridView.SelectedRows[RowIndex].Cells[ColumnName].Value = NewValue;
		}

		/* --------------------------------------------------------------------------------------------------- */

		public static bool CheckRequired(this System.Windows.Forms.TextBox textbox) {
			bool required = string.IsNullOrWhiteSpace(textbox.Text);
			textbox.BackColor = required ? Color.FromArgb(0xB0, 0xD6, 0xFF) : SystemColors.Window;
			return required;
		}

		public static bool CheckEmptyFields(params System.Windows.Forms.TextBox[] textboxes) {
			bool empty = false;

			foreach (var field in textboxes) {
				if (field.CheckRequired()) { empty = true; }
			}
			return empty;
		}

		public static void Populate(
			this System.Windows.Forms.ComboBox combobox,
			SQL_Connector sql, string primary, string secondary,
			string query, params SqlParameter[] parameters
		) {
			combobox.Items.Clear();
			combobox.Text = string.Empty;

			string fixedquery = (!string.IsNullOrEmpty(primary) && !string.IsNullOrEmpty(secondary))
				? query.Replace("{}", $"{primary}, {secondary}")
				: query.Replace("{}", primary ?? secondary ?? "*");

			var comboDataTable = sql.CreateFilledDataTable(fixedquery, parameters).Value;
			if ((comboDataTable?.Rows.Count ?? 0) > 0) {
				foreach (DataRow row in comboDataTable.Rows) {
					combobox.Items.Add(new ItemID(
						row.GetSafeValue<string>(primary),
						row.GetSafeValue<string>(secondary)
					));
				}
				combobox.SelectedIndex =  0;
				combobox.Enabled = true;
			} else {
				combobox.Items.Add(string.Empty); // required to trigger SelectedIndexChanged
				combobox.SelectedIndex = 0;
				combobox.Enabled = false;
			}
		}
	}
}
