using orabs.Department;
using orabs.DoctorGroup;
using orabs.Doctor;
using orabs.Patient;
using orabs.Meeting;

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

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text += Global.userName;
            switch (Global.authority)
            {
                case Global.Identity.Admin:
                    lblIdentity.Text += "Admin";
                    break;
                case Global.Identity.Doctor:
                    lblIdentity.Text += "Doctor";                
                    break;
                default:
                    lblIdentity.Text += "Patient";
                    break;
            }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patientControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientControl frmPatientControlEntity = new frmPatientControl();
            frmPatientControlEntity.Show();
        }

        private void meetingRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.patientId == -1)
            {
                MessageBox.Show("Only patients can register meetings.");
                return;
            }
            frmMeetingRegister frmMeetingRegisterEntity = new frmMeetingRegister();
            frmMeetingRegisterEntity.Show();
        }

        private void meetingControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeetingControl frmMeetingControlEntity = new frmMeetingControl();
            frmMeetingControlEntity.Show();
        }

        private void meetingHandleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Global.authority == Global.Identity.Doctor))
            {
                MessageBox.Show("You have no permission to handle meetings ");
                return;
            }
            frmMeetingDoctorView frmMeetingDoctorViewEntity = new frmMeetingDoctorView();
            frmMeetingDoctorViewEntity.Show();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientInfo frmPateintInfoEntity = new frmPatientInfo();
            frmPateintInfoEntity.Show();
        }
    }
}
