using System;
using System.Windows.Forms;
using orabs.Doctor;
using orabs.Department;

namespace orabs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void doctorGroupControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorGroupControl frmDoctorGroupControlEntity = new frmDoctorGroupControl();
            frmDoctorGroupControlEntity.Show();
        }

        private void departmentControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartmentControl frmDepartmentControlEntity = new frmDepartmentControl();
            frmDepartmentControlEntity.Show();
        }
    }
}
