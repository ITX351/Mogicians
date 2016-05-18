﻿using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

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
                MessageBox.Show("Unable to connect to database. " + e.ToString());
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
                MessageBox.Show("Closing database connection error." + e.ToString());
            }
        }

        public static DataTable GetDataTableByQuery(string queryString)
        {
            dataTable = new DataTable();
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
