using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace orabs
{
    class Global
    {
        public enum Identity
        {
            Doctor, Patient, Admin
        };

        public static bool login = false;
        public static string userName = "";
        public static int userId = -1;
        public static int patientId = -1;
        public static int doctorId = -1;
        public static Identity authority = Identity.Patient;

        public static string AppendPercent(string str)
        {
            return "%" + EscapeSingleQuotes(str) + "%";
        }

        public static int StringToInt(object str)
        {
            if (str == null || str.ToString().Length == 0)
                return -1;
            return int.Parse(str.ToString());
        }

        public static string EscapeSingleQuotes(object str)
        {
            return str.ToString().Replace("'", "''");
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd hh:mm:ss");
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

        public static DataTable GetSexDataTable()
        {
            DataTable dtSex = new DataTable();
            dtSex.Columns.Add("SexCode",System.Type.GetType("System.SByte"));   
                   //System.Sbyte : signed byte -128 ~ 127, 
                   //corresponding to tinyint in MySQL, to which bool and Boolean will be converted 
            dtSex.Columns.Add("SexStr", System.Type.GetType("System.String"));
            dtSex.Rows.Add(0, "Male");
            dtSex.Rows.Add(1, "Female");
            return dtSex;
        }
        
        public static DataTable getEmptyListTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ShowText", System.Type.GetType("System.String"));
            dt.Columns.Add("Value", System.Type.GetType("System.Int32"));
            return dt;
        }
    }
}
