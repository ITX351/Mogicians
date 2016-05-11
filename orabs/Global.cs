using System.Data;
using System.Windows.Forms;

namespace orabs
{
    class Global
    {
        public static bool login = false;
        public static string userName = "";
        public static int userId = -1;

        public static string AppendPercent(string str)
        {
            return "%" + EscapeSingleQuotes(str) + "%";
        }

        public static string EscapeSingleQuotes(object str)
        {
            return str.ToString().Replace("'", "''");
        }

        public static void setComboBoxByTableName(string TableName, ComboBox comboBox, bool hasNull)
        {
            string queryStr = "select " + TableName + "_ID, Name from " + TableName;
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            if (hasNull)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = "Not Required.";
                dr[TableName + "_ID"] = -1;
                dt.Rows.Add(dr);
            }

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = TableName + "_ID";
            comboBox.DataSource = dt;

            if (hasNull)
            {
                comboBox.SelectedValue = -1;
            }
        }
    }
}
