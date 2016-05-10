using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace orabs
{
    class DatabaseOperation
    {
        private static MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        private static MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        private static DataTable dataTable;
        private static MySqlCommand mySqlCommand;

        public static void OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }

        public static void CloseConnection()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static DataTable GetDataTableByQuery(string queryString, string tableName)
        {
            dataTable = new DataTable(tableName);
            dataTable.Clear();

            try
            {
                mySqlDataAdapter.SelectCommand = new MySqlCommand(queryString, mySqlConnection);
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }

        public static int ExecuteSQLQuery(string queryString)
        {
            try
            {
                mySqlCommand = new MySqlCommand(queryString, mySqlConnection);
                int ret = mySqlCommand.ExecuteNonQuery();
                return ret;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }
    }
}
