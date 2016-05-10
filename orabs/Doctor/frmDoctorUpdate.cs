using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Doctor
{
    public partial class frmDoctorUpdate : Form
    {
        private int Doctor_ID;

        public frmDoctorUpdate(int Doctor_ID)
        {
            InitializeComponent();
            this.Doctor_ID = Doctor_ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "update Doctor set Name = '" + txtName.Text + "', Description = '" + 
                txtDescription.Text + "' where Doctor_ID = " + Doctor_ID.ToString();
            int success = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (success > 0)
            {
                MessageBox.Show("Update succeeded.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occured.");
            }
        }

        private void frmDoctorUpdate_Load(object sender, EventArgs e)
        {
            string queryStr = "select * from Doctor where Doctor_ID = " + Doctor_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr, "Doctor");

            DataRow dr = dt.Rows[0];
            txtName.Text = (string)dr["Name"];
            txtDescription.Text = (string)dr["Description"];
        }
    }
}
