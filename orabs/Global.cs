using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace orabs
{
    class Global
    {
        public static bool login = false;
        public static string userName = "";
        public static int userId = -1;
        public static Dictionary<string, string> userIdentityMap = new Dictionary<string,string>();
        public static DataTable dtSex = new DataTable();

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


        public static string SHA1(string text)
        {
            byte[] cleanBytes = Encoding.Default.GetBytes(text);
            byte[] hashedBytes = System.Security.Cryptography.SHA1.Create().ComputeHash(cleanBytes);
            return System.BitConverter.ToString(hashedBytes).Replace("-", "");
        }

        public static bool testRegax(string str, string regax)
        {
            Regex rgx = new Regex(regax);
            return rgx.IsMatch(str);
        }

        public static bool IsNum(string pstr)
        {
            return testRegax(pstr, @"^(\d+)$");
        }

        public static void getUserIdentity()
        {
            string fetchUserSQLStr = "select * from User where User_ID = " + Global.userId.ToString();
            DataTable showTable = DatabaseOperation.GetDataTableByQuery(fetchUserSQLStr);
            string isAdmin = showTable.Rows[0]["isAdmin"].ToString();        //return "True" if admin
            string linkedDoctor_ID = showTable.Rows[0]["Doctor_ID"].ToString();
            string linkedPatient_ID = showTable.Rows[0]["Patient_ID"].ToString();

            userIdentityMap.Clear();
            userIdentityMap.Add("isAdmin", isAdmin);
            userIdentityMap.Add("Doctor_ID", linkedDoctor_ID);
            userIdentityMap.Add("Patient_ID", linkedPatient_ID);
        }

        public static bool canBePatient()
        {
            getUserIdentity();
            if (userIdentityMap["isAdmin"] == "True" || userIdentityMap["Doctor_ID"] != null)
                return false;
            else
                return true;
        }

        public static bool canBeDoctor()
        {
            getUserIdentity();
            if (userIdentityMap["isAdmin"] == "True" || userIdentityMap["Patient_ID"] != null)
                return false;
            else
                return true;
        }

        public static bool isDoctor()
        {
            getUserIdentity();
            if (userIdentityMap["Doctor_ID"] != null)
                return true;
            else
                return false;
        }

        public static bool isPatient()
        {
            getUserIdentity();
            if (userIdentityMap["Patient_ID"] != null)
                return true;
            else
                return false;
        }

        public static void initDataTableSex()
        {
            dtSex.Columns.Add("SexCode",System.Type.GetType("System.Boolean"));
            dtSex.Columns.Add("SexStr", System.Type.GetType("System.String"));

            DataRow dr0 = dtSex.NewRow();
            dr0["SexCode"] = 0;
            dr0["SexStr"] = "Male";
            dtSex.Rows.Add(dr0);        // 0 - Male

            DataRow dr1 = dtSex.NewRow();
            dr1["SexCode"] = 1;
            dr1["SexStr"] = "Female";   // 1 - Female
            dtSex.Rows.Add(dr1);     
        }
    }
}
