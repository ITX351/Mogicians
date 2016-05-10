using System;
using System.Windows.Forms;

namespace orabs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "User: " + GlobalStatus.userName;
        }

        private void doctorControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorControl frmDoctorControlEntity = new frmDoctorControl();
            frmDoctorControlEntity.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
