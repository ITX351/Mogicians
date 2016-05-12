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
    public partial class frmPatientQuery : Form
    {
        public frmPatientQuery()
        {
            InitializeComponent();
        }

        private void frmPatientQuery_Load(object sender, EventArgs e)
        {
            // Add not required field in cboSex, cboSex cannot be null now -> Bug
        }

        public string PatientName
        {
            get
            {
                return txtName.Text;
            }
        }

        public int Sex
        {
            get
            {
                return (int)cboSex.SelectedValue;
            }
        }

        public string Phone
        {
            get
            {
                return txtPhone.Text;
            }
        }

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
        }

        public string IdentityNumber
        {
            get
            {
                return txtIdentityNumber.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
