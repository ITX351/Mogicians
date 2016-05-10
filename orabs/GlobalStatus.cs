using System.Data;
using System.Windows.Forms;

namespace orabs
{
    class GlobalStatus
    {
        public static bool login = false;
        public static string userName = "";
        public static int userId = -1;

        public static string AppendPercent(string str)
        {
            return "%" + str + "%";
        }

        public static DataTable setComboAndDataTableByTableName(string TableName, ComboBox comboBox)
        {
            string queryStr = "select * from " + TableName;
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            if (comboBox != null)
                foreach (DataRow dr in dt.Rows)
                    comboBox.Items.Add((string)dr["Name"]);
            return dt;
        }
    }
}
