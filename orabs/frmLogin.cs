using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtUserName.Text.Contains("'") || txtPassword.Text.Contains("'"))
            {
                MessageBox.Show("User Name or Password Textbox contains single quote.");
                return;
            }

            string queryString = "select * from User where Name='" + txtUserName.Text.ToLower() + "' and Password='" + txtPassword.Text + "'";
            DataTable dataTable = DatabaseOperation.GetDataTableByQuery(queryString, "User");

            if (dataTable.Rows.Count > 0)
            {
                GlobalStatus.login = true;
                GlobalStatus.userId = int.Parse(dataTable.Rows[0]["User_ID"].ToString());
                GlobalStatus.userName = dataTable.Rows[0]["Name"].ToString();

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
