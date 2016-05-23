using System;
using System.Data;
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
            DataTable dataTable = Global.GetSexDataTable();
            DataRow dr = dataTable.NewRow();
            dr["SexCode"] = -1;
            dr["SexStr"] = "Not required";
            dataTable.Rows.Add(dr);
            cboSex.DataSource = dataTable;
            cboSex.DisplayMember = "SexStr";
            cboSex.ValueMember = "SexCode";
            cboSex.SelectedValue = -1;
        }

        public string PatientName
        {
            get
            {
                return txtName.Text;
            }
        }

        public SByte Sex
        {
            get
            {
                return (SByte)cboSex.SelectedValue;
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
