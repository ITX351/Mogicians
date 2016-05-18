using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingRegister : Form
    {
        private DataTable dataTable;
        private int Patient_ID;

        public frmMeetingRegister()
        {
            InitializeComponent();
        }

        private void frmMeetingRegister_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, false);
            Global.setComboBoxByTableName("Department", cboDepartment, false);
            cboDoctorName.DataSource = dataTable;
            string exeStr = "select Patient_ID from User where User_ID = " + Global.userId;
            DataTable dt = DatabaseOperation.GetDataTableByQuery(exeStr);
            if (dt.Rows.Count > 0)
                Patient_ID = (int)dt.Rows[0]["Patient_ID"];
            else
                Patient_ID = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Patient_ID == -1)
            {
                MessageBox.Show("Only patients can register.");
                return;
            }
            string exeStr = "insert into Meeting(Patient_ID, Doctor_ID, Status, StatusAt, CreatedAt) Values( " +
                Patient_ID.ToString() + " , " + cboDoctorName.SelectedValue.ToString() + " , " +
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
            string exeStr = " select Doctor.Doctor_ID as Doctor_ID, Doctor.Name as DoctorName form Doctor " +
                " join Department on Department.Department_ID = Doctor.Department_ID " +
                " join DoctorGroup on DoctorGroup.DoctorGroup_ID = Doctor.DoctorGroup_ID " +
                " where DoctorGroup.DoctorGroup_ID = " + ((int)cboGroup.SelectedValue).ToString() +
                " where Department.Department_ID = " + ((int)cboDepartment.SelectedValue).ToString();

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
