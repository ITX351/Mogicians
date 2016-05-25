using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingDoctorView : Form
    {
        private DataTable MeetingPatientTable;
        private int now;
        private bool comboBox_load_over;

        public frmMeetingDoctorView()
        {
            InitializeComponent();
        }

        private void initComboBoxStatus()
        {
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("StatusName", System.Type.GetType("System.String"));
            dtStatus.Columns.Add("StatusChar", System.Type.GetType("System.String"));

            dtStatus.Rows.Add("Created", "C");
            dtStatus.Rows.Add("Waiting", "W");
            dtStatus.Rows.Add("Hang Up", "H");
            dtStatus.Rows.Add("Waiting & Hang Up", "W,H");
            dtStatus.Rows.Add("Finished", "F");
            dtStatus.Rows.Add("Skipped", "S");
            dtStatus.Rows.Add("All", "C,W,H,F,S");

            cboStatus.DataSource = dtStatus;
            cboStatus.DisplayMember = "StatusName";
            cboStatus.ValueMember = "StatusChar";
            cboStatus.SelectedValue = "W";
        }

        private void frmMeetingDoctorView_Load(object sender, EventArgs e)
        {
            // get Doctor Name
            DataRow dr = DatabaseOperation.GetDataRowByID("Doctor", Global.doctorId);
            lblDoctor.Text += (string)dr["Name"];
            comboBox_load_over = false;

            initComboBoxStatus();
            doQuery();

            comboBox_load_over = true;
        }

        private void doQuery()
        {
            // get Patient Meeting
            string queryStr = "select Patient.Patient_ID, Patient.`Name`, sexToString(Patient.Sex) as Sex," +
                " Patient.Phone, Patient.Address, Patient.Identity_Number, Meeting.Meeting_ID, Meeting.`Status`," + 
                " Meeting.StatusAt, Meeting.CreatedAt from Meeting join Patient on Patient.Patient_ID = Meeting.Patient_ID" +
                " where Meeting.Doctor_ID = " + Global.doctorId.ToString() + 
                " and find_in_set(Meeting.`Status`, '" + cboStatus.SelectedValue.ToString() + "') > 0" +
                " order by Meeting.CreatedAt asc";
            MeetingPatientTable = DatabaseOperation.GetDataTableByQuery(queryStr);

            if (MeetingPatientTable.Rows.Count == 0)
            {
                pnlPatientInfo.Visible = false;
                lblHint.Visible = true;    
                btnFirst.Enabled = btnPrev.Enabled = btnNext.Enabled = btnLast.Enabled =
                    btnSkip.Enabled = btnHangUp.Enabled = btnConsultation.Enabled = false;
                return;
            }
            else
            {
                pnlPatientInfo.Visible = true;
                lblHint.Visible = false;            
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
            btnFirst.Enabled = btnPrev.Enabled = btnNext.Enabled = btnLast.Enabled = true;

            string status = "ERROR";
            switch (dr["Status"].ToString())
            {
                case "C":
                    status = "Created";
                    btnSkip.Enabled = btnHangUp.Enabled = btnConsultation.Enabled = true;
                    break;
                case "W":
                    status = "Waiting";
                    btnSkip.Enabled = btnHangUp.Enabled = btnConsultation.Enabled = true;
                    break;
                case "H":
                    status = "Hang Up";
                    btnSkip.Enabled = btnConsultation.Enabled = true;
                    btnHangUp.Enabled = false;
                    break;
                case "F":
                    status = "Finished";
                    btnSkip.Enabled = btnHangUp.Enabled = btnConsultation.Enabled = false;
                    break;
                case "S":
                    status = "Skipped";
                    btnSkip.Enabled = btnHangUp.Enabled = btnConsultation.Enabled = false;
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
            string exeStr = "update Meeting set Status = '" + status +
                "' where Meeting_ID = " + Meeting_ID.ToString();
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

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_load_over)
                doQuery();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            frmMeetingDiagnose frmMeetingDiagnoseEntity = new frmMeetingDiagnose((int)MeetingPatientTable.Rows[now]["Meeting_ID"]);
            frmMeetingDiagnoseEntity.ShowDialog();
            if (frmMeetingDiagnoseEntity.DialogResult == DialogResult.OK)
            {
                doQuery();
            }
        }
    }
}
