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

        public static void setComboAndDataTableByTableName(string TableName, ComboBox comboBox)
        {
            string queryStr = "select * from " + TableName;
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = TableName + "_ID";
            comboBox.DataSource = dt;
        }
    }
}
