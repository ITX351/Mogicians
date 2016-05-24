using System;
using System.Windows.Forms;

namespace orabs.Doctor
{
    public partial class frmDoctorQuery : Form
    {
        public frmDoctorQuery()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string DoctorName
        {
            get
            {
                return txtName.Text;
            }
        }

        public int Department_ID
        {
            get
            {
                return (int)cboDepartment.SelectedValue;
            }
        }

        public int DoctorGroup_ID
        {
            get
            {
                return (int)cboGroup.SelectedValue;
            }
        }

        private void frmDoctorQuery_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, true);
            Global.setComboBoxByTableName("Department", cboDepartment, true);
        }
    }
}
