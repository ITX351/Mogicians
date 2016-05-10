using orabs.Doctor;
using System;
using System.Windows.Forms;

namespace orabs
{
    public partial class frmDoctorControl : Form
    {
        public frmDoctorControl()
        {
            InitializeComponent();
        }

        private void frmDoctorControl_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmDoctorQuery frmDoctorQueryEntity = new frmDoctorQuery();
            frmDoctorQueryEntity.ShowDialog();

            if (frmDoctorQueryEntity.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(frmDoctorQueryEntity.DoctorName);
            }

        }
    }
}
