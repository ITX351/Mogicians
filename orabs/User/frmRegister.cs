using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.User
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtConfirmPassword.Text.Length == 0)
            {
                MessageBox.Show("Confirm password cannot be empty.");
                txtConfirmPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Two passwords must be consistent.");
                txtPassword.Focus();
                return;
            }
            if (!Global.testRegax(txtUserName.Text, @"^([A-Za-z0-9_]+)$"))
            {
                MessageBox.Show("User Name can only contain upper/lower case, digit and underline.");
                txtUserName.Focus();
                return;
            }

            string queryStr = "select count(*) from User where Name = '" + Global.EscapeSingleQuotes(txtUserName.Text) + "'";
            int count = int.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0][0].ToString());

            if (count > 0)
            {
                MessageBox.Show("This User Name has been used. Try another one.");
                txtUserName.Focus();
                return;
            }

            string exeStr = "insert into User(Name, Password, isAdmin) values('" +
                Global.EscapeSingleQuotes(txtUserName.Text) + "', '" + Global.SHA1(txtPassword.Text) + "', 0)";
            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Registration succeeded.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when registrating.");
            }
        }
    }
}
