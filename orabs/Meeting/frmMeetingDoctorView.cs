using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingDoctorView : Form
    {
        DataTable MeetingPatientTable;
        int now;

        public frmMeetingDoctorView()
        {
            InitializeComponent();
        }

        private void frmMeetingDoctorView_Load(object sender, EventArgs e)
        {
            // get Doctor Name
            DataRow dr = DatabaseOperation.GetDataRowByID("Doctor", Global.doctorId);
            lblDoctor.Text += (string)dr["Name"];

            doQuery();
        }

        private void doQuery()
        {
            // get Patient Meeting
            string queryStr = "select Patient.Patient_ID, Patient.`Name`, sexToString(Patient.Sex) as Sex," +
                " Patient.Phone, Patient.Address, Patient.Identity_Number, Meeting.Meeting_ID, Meeting.`Status`," + 
                " Meeting.StatusAt, Meeting.CreatedAt from Meeting join Patient on Patient.Patient_ID = Meeting.Patient_ID" +
                " where Meeting.Doctor_ID = " + Global.doctorId.ToString() + " order by Meeting.CreatedAt asc";
            MeetingPatientTable = DatabaseOperation.GetDataTableByQuery(queryStr);

            if (MeetingPatientTable.Rows.Count == 0)
            {
                MessageBox.Show("No meeting information found!");
                lblPatientID.Text = "";
                lblName.Text = "";
                lblSex.Text = "";
                lblPhone.Text = "";
                lblAddress.Text = "";
                lblIdentityNumber.Text = "";
                lblStatus.Text = "";
                lblCreatedAt.Text = "";
                lblStatusAt.Text = "";
                lblQueueLocation.Text = "0 / 0";
                return;
            }
            
            now = 0;
            showInformation();
        }

        private void showInformation()
        {
            DataRow dr = MeetingPatientTable.Rows[now];
            lblPatientID.Text = dr["Patient_ID"].ToString();
            lblName.Text = dr["Name"].ToString();
            lblSex.Text = dr["Sex"].ToString();
            lblPhone.Text = dr["Phone"].ToString();
            lblAddress.Text = dr["Address"].ToString();
            lblIdentityNumber.Text = dr["Identity_Number"].ToString();
            lblCreatedAt.Text = dr["CreatedAt"].ToString();
            lblStatusAt.Text = dr["StatusAt"].ToString();
            lblQueueLocation.Text = (now + 1).ToString() + "/" + MeetingPatientTable.Rows.Count.ToString();

            string status = "ERROR";
            switch (dr["Status"].ToString())
            {
                case "C":
                    status = "Created";
                    break;
                case "W":
                    status = "Waiting";
                    break;
                case "H":
                    status = "Hang Up";
                    break;
                case "F":
                    status = "Finished";
                    break;
                case "S":
                    status = "Skipped";
                    break;
            }
            lblStatus.Text = status;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (MeetingPatientTable.Rows.Count > 0)
            {
                now = 0;
                showInformation();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (MeetingPatientTable.Rows.Count > 0 && now > 0)
            {
                now--;
                showInformation();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MeetingPatientTable.Rows.Count > 0 && now < MeetingPatientTable.Rows.Count - 1)
            {
                now++;
                showInformation();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (MeetingPatientTable.Rows.Count > 0)
            {
                now = MeetingPatientTable.Rows.Count - 1;
                showInformation();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setStatus(string status, string hint)
        {
            if (MessageBox.Show("Confirm " + hint + " this meeting?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int Meeting_ID = (int)MeetingPatientTable.Rows[now]["Meeting_ID"];
            string exeStr = "update Meeting set Status = '" + status + "' where Meeting_ID = " + Meeting_ID.ToString();
            int ret = DatabaseOperation.ExecuteSQLQuery(exeStr);

            if (ret <= 0)
            {
                MessageBox.Show("Some error has occured.");
                return;
            }

            doQuery();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            setStatus("S", "Skip");
        }

        private void btnHangUp_Click(object sender, EventArgs e)
        {
            setStatus("H", "Hang Up");
        }
    }
}
