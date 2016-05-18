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
    public partial class frmPatientAdd : Form
    {
        public frmPatientAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtIdentityNumber.Text.Length == 0)
            {
                MessageBox.Show("Patient Name and Identity Number cannot be empty.");
                return;
            }
            //Check length of Indentity Number == 18 ? 371323 ........ .... (18)

            if (!Global.testRegax(txtPhone.Text, @"^([0-9\-+]*)$"))
            {
                MessageBox.Show("Phone Number can only contain digit, plus sign and dash.");
                txtPhone.Focus();
                return;
            }

            string exeStr = "insert into Patient(Name, Sex, Phone, Address, Identity_Number) values('" +
                txtName.Text + "', '" + cboSex.SelectedValue + "', '" +
                txtPhone.Text + "', '" + txtAddress.Text + "', '" +
                txtIdentityNumber.Text + "')";

            int ret = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (ret > 0)
            {
                MessageBox.Show("Patient Information Complemented");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occurred complementing patient information");
            }
        }

        private void frmPatientAdd_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Global.initDataTableSex();
            cboSex.DisplayMember = "SexStr";
            cboSex.ValueMember = "SexCode";
        }
    }
}
