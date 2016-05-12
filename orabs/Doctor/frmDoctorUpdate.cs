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
            string exeStr = "update Doctor set Name = '" + Global.EscapeSingleQuotes(txtName.Text) + "'," + 
                " Department_ID = " + cboDepartment.SelectedValue.ToString() + "," + 
                " DoctorGroup_ID = " + cboGroup.SelectedValue.ToString() + "," +
                " Description = '" + Global.EscapeSingleQuotes(txtDescription.Text) + "'" + 
                " where Doctor_ID = " + Doctor_ID.ToString();
            int success = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (success > 0)
            {
                MessageBox.Show("Update succeeded.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occured.");
            }
        }

        private void frmDoctorUpdate_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, false);
            Global.setComboBoxByTableName("Department", cboDepartment, false);

            string queryStr = "select * from Doctor where Doctor_ID = " + Doctor_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            DataRow dr = dt.Rows[0];
            txtName.Text = (string)dr["Name"];
            cboDepartment.SelectedValue = (int)dr["Department_ID"];
            cboGroup.SelectedValue = (int)dr["DoctorGroup_ID"];
            txtDescription.Text = (string)dr["Description"];
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
