using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingControl : Form
    {
        private DataTable dataTable;

        private string patientName;
        private string doctorName;
        private string status;

        //MySQL displays and retrieves values in 'YYYY-MM-DD HH:MM:SS'
        private string statusAtDateStr;          
        private string createdAtDateStr;
        private const string dateForSkipStr = "2000-01-01";

        public frmMeetingControl()
        {
            InitializeComponent();
        }

        private void frmMeetingControl_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(sender, e);          
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            doQuery("", "", "L", dateForSkipStr, dateForSkipStr);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmMeetingQuery frmMeetingQueryEntity = new frmMeetingQuery();
            frmMeetingQueryEntity.ShowDialog();
            if (frmMeetingQueryEntity.DialogResult == DialogResult.OK)
            {
                doQuery(frmMeetingQueryEntity.DoctorName, frmMeetingQueryEntity.PatientName,
                    frmMeetingQueryEntity.Status, frmMeetingQueryEntity.StatusAtDateStr, 
                    frmMeetingQueryEntity.CreatedAtDateStr);
            }
        }

        private void doQuery(string doctorName, string patientName, string status, 
             string statusAtStr, string createdAtStr)
        {
            this.doctorName = doctorName;
            this.patientName = patientName;
            this.status = status;
            this.statusAtDateStr = statusAtStr;
            this.createdAtDateStr = createdAtStr;
            showQuery();
        }

        private void showQuery()
        {
            //status not required -> pass in "L"
            string exeStr = "select Meeting_ID, PatientName, " +
                " DoctorName, DepartmentName, DoctorGroupName, Status, StatusAt, CreatedAt " +
                " from MeetingAll " +
                " where (DoctorName like '" + Global.AppendPercent(doctorName) + "') " +
                " and (PatientName like '" + Global.AppendPercent(patientName) + "') " +
                " and (Status = '" + status + "' or '" + status + "' = 'L' )" +
                " and (Date(StatusAt) = '" + statusAtDateStr + "' or '" +
                        statusAtDateStr + "' = '" + dateForSkipStr + "' ) " +
                " and (Date(CreatedAt) = '" + createdAtDateStr + "' or '" +
                        createdAtDateStr + "' = '" + dateForSkipStr + "' ) ";
            if (Global.authority == Global.Identity.Patient)
                exeStr += " and Patient.Patient_ID = " + Global.patientId.ToString();
            exeStr += " order by CreatedAt desc";

            dataTable = DatabaseOperation.GetDataTableByQuery(exeStr);
            dgvMeeting.DataSource = dataTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getMeetingId()
        {
            return (int)dataTable.Rows[dgvMeeting.CurrentRow.Index]["Meeting_ID"];
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmMeetingDetails frmMeetingDetailsEntity = new frmMeetingDetails(getMeetingId());
            frmMeetingDetailsEntity.ShowDialog();
        }

        private void dgvMeeting_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetail_Click(sender, e);
        }
    }
}
