﻿using System;
using System.Data;
using System.Windows.Forms;

namespace orabs
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("User Name cannot be empty.");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be empty.");
                txtPassword.Focus();
                return;
            }

            string queryString = "select * from User where" + 
                " Name='" + Global.EscapeSingleQuotes(txtUserName.Text.ToLower()) + "'" +
                " and Password='" + Global.SHA1(txtPassword.Text) + "'";
            DataTable dataTable = DatabaseOperation.GetDataTableByQuery(queryString);

            if (dataTable.Rows.Count > 0)
            {
                Global.login = true;
                Global.userId = (int)dataTable.Rows[0]["User_ID"];
                Global.userName = (string)dataTable.Rows[0]["Name"];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your UserName and Password.");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
