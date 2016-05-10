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
    public partial class frmDoctorGroupUpdate : Form
    {
        private int DoctorGroup_ID;

        public frmDoctorGroupUpdate(int DoctorGroup_ID)
        {
            InitializeComponent();
            this.DoctorGroup_ID = DoctorGroup_ID;
        }

        private void frmDoctorGroupUpdate_Load(object sender, EventArgs e)
        {
            string queryStr = "select Name, Charge from DoctorGroup where DoctorGroup_ID = " + DoctorGroup_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            txtGroupName.Text = (string)dt.Rows[0]["Name"];
            txtCharge.Text = dt.Rows[0]["Charge"].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "update DoctorGroup set Name = '" + txtGroupName.Text + "', Charge = " + txtCharge.Text + 
                " where DoctorGroup_ID = " + DoctorGroup_ID.ToString();
            int ret = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (ret > 0)
            {
                MessageBox.Show("Doctor Group updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when updating.");
            }
        }
    }
}
