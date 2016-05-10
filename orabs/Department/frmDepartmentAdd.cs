using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Department
{
    public partial class frmDepartmentAdd : Form
    {
        public frmDepartmentAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "insert into Department(Name) values('" + txtDepartmentName.Text + "')";
            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Department Add successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when adding.");
            }
        }

    }
}
