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
        private int patientIdToOperate;

        public frmPatientUpdate(int patientIdToOperate)
        {
            InitializeComponent();
            this.patientIdToOperate = patientIdToOperate;
        }

        private void frmPatientUpdate_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Global.GetSexDataTable();
            cboSex.ValueMember = "SexCode";
            cboSex.DisplayMember = "SexStr";

            if (patientIdToOperate != -1)
            {
                DataRow dr = DatabaseOperation.GetDataRowByID("Patient", patientIdToOperate);
                txtName.Text = (string)dr["Name"];
                txtPhone.Text = (string)dr["Phone"];
                txtAddress.Text = (string)dr["Address"];
                txtIdentityNumber.Text = (string)dr["Identity_Number"];
                if (false == (bool)dr["Sex"])
                    cboSex.SelectedValue = 0;
                else
                    cboSex.SelectedValue = 1;
            }
            else
            {
                cboSex.SelectedValue = 0;
            }
        }

      private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtIdentityNumber.Text.Length == 0)
            {
                MessageBox.Show("Patient Name and Identity Number cannot be empty.");
                return;
            }

            if (!Global.testRegax(txtPhone.Text, @"^([0-9\-+]*)$"))
            {
                MessageBox.Show("Phone Number can only contain digit, plus sign and dash.");
                txtPhone.Focus();
                return;
            }

            string exeStr;
            if (Global.authority == Global.Identity.Patient && patientIdToOperate == -1)
            {
                exeStr = "insert into Patient(Name, Sex, Phone, Address, Identity_Number) values('" +
                    txtName.Text + "', '" + cboSex.SelectedValue + "', '" +
                    txtPhone.Text + "', '" + txtAddress.Text + "', '" +
                    txtIdentityNumber.Text + "')";
            }
            else
            {
                exeStr = "update Patient set Name = '" + txtName.Text +
                    "', Sex = " + cboSex.SelectedValue +
                    ", Phone = '" + txtPhone.Text +
                    "', Address = '" + txtAddress.Text +
                    "', Identity_Number = '" + txtIdentityNumber.Text +
                    "' where Patient_ID = " + patientIdToOperate;
            }    

            int result = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (result > 0)
            {
                MessageBox.Show("Updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occurred while complementing patient information.");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
