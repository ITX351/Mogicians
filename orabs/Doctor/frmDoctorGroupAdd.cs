using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Doctor
{
    public partial class frmDoctorGroupAdd : Form
    {
        public frmDoctorGroupAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "insert into DoctorGroup(Name, Charge) values('" + txtGroupName.Text + "', " + txtCharge.Text + ")";
            int ret = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (ret > 0)
            {
                MessageBox.Show("Doctor Group Added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when adding.");
            }
        }
    }
}
