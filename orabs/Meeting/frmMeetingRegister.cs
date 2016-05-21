using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingRegister : Form
    {
        private DataTable dataTable;

        public frmMeetingRegister()
        {
            InitializeComponent();
        }

        private void frmMeetingRegister_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, false);
            Global.setComboBoxByTableName("Department", cboDepartment, false);
            cboDoctorName.DataSource = dataTable;
            cboDepartment.SelectedIndex = 1;
            cboGroup.SelectedIndex = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "insert into Meeting(Patient_ID, Doctor_ID, Status, StatusAt, CreatedAt) Values( " +
                Global.patientId.ToString() + " , " + cboDoctorName.SelectedValue.ToString() + " , " +
                " C , " + DateTime.Now.ToString() + " , " + DateTime.Now.ToString() + " )";
            int success = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (success > 0)
            {
                MessageBox.Show("Register successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error occurred.");
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.SelectedValue == null || cboDepartment.SelectedValue == null)
            {
                return;
            }
            string exeStr = " select Doctor.Doctor_ID as Doctor_ID, Doctor.Name as DoctorName from Doctor " +
                " join Department on Department.Department_ID = Doctor.Department_ID " +
                " join DoctorGroup on DoctorGroup.DoctorGroup_ID = Doctor.DoctorGroup_ID " +
                " where DoctorGroup.DoctorGroup_ID = " + ((int)cboGroup.SelectedValue).ToString() +
                " and Department.Department_ID = " + ((int)cboDepartment.SelectedValue).ToString();

            dataTable = DatabaseOperation.GetDataTableByQuery(exeStr);
            cboDoctorName.DataSource = dataTable;
            cboDoctorName.DisplayMember = "DoctorName";
            cboDoctorName.ValueMember = "Doctor_ID";
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDepartment_SelectedIndexChanged(sender, e);
        }
    }
}
