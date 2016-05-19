using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Patient
{
    public partial class frmPatientUpdate : Form
    {
        private int Patient_ID;

        public frmPatientUpdate(int Patient_ID)
        {
            InitializeComponent();
            this.Patient_ID = Patient_ID;
        }

        private void frnPatientUpdate_Load(object sender, EventArgs e)
        {
            DataRow dr = DatabaseOperation.GetDataRowByID("Patient", Patient_ID);

            txtName.Text = (string)dr["Name"];
            txtPhone.Text = (string)dr["Phone"];
            txtAddress.Text = (string)dr["Address"];
            txtIdentityNumber.Text = (string)dr["Identity_Number"];
            cboSex.DataSource = Global.dtSex;
            cboSex.ValueMember = "SexCode";
            cboSex.DisplayMember = "SexStr";
            if (false == (bool)dr["Sex"])
                cboSex.SelectedValue = 0;
            else
                cboSex.SelectedValue = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "update Patient set Name = '" + txtName.Text +
                "', Sex = " + cboSex.SelectedValue +
                ", Phone = '" + txtPhone.Text +
                "', Address = '" + txtAddress.Text +
                "', Identity_Number = '" + txtIdentityNumber.Text +
                "' where Patient_ID = " + Patient_ID.ToString();

            int result = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (result > 0)
            {
                MessageBox.Show("Updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occurred while updating.");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
