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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be empty.");
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Two passwords must be consistent.");
                txtNewPassword.Focus();
                return;
            }
            string queryString = "select * from User where" + " User_ID = " + Global.userId.ToString() +
                 " and Password=" + "'" + Global.SHA1(txtOldPassword.Text) + "'";
            DataTable dataTable = DatabaseOperation.GetDataTableByQuery(queryString);
            if(dataTable.Rows.Count>0)
            {
                string exeStr = "update User set Password = '" + Global.SHA1(txtNewPassword.Text)+ "'" +
                " where User_ID = " + Global.userId.ToString();

                if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Some error has occurred when updating.");
                }

            }
      
        }

    }
}
