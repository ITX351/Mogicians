using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingQuery : Form
    {
        private DataTable dataTable;
        private string dateForSkipStr;

        public frmMeetingQuery()
        {
            InitializeComponent();
        }

        private void frmMeetingQuery_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("statusCode", typeof(string));
            dataTable.Columns.Add("statusStr", typeof(string));
            dataTable.Rows.Add("C", "Created");
            dataTable.Rows.Add("S", "Skipped");
            dataTable.Rows.Add("F", "Finished");
            dataTable.Rows.Add("H", "HangUp");
            dataTable.Rows.Add("W", "Waiting");
            dataTable.Rows.Add("L", "Not specified");

            cboStatus.DataSource = dataTable;
            cboStatus.ValueMember = "statusCode";
            cboStatus.DisplayMember = "statusStr";

            dtpStatusAt.Format = DateTimePickerFormat.Custom;
            dtpStatusAt.CustomFormat = "yyyy/MM/dd";
            dtpStatusAt.Checked = false;

            dtpCreatedAt.Format = DateTimePickerFormat.Custom;
            dtpCreatedAt.CustomFormat = "yyyy/MM/dd";
            dtpCreatedAt.Checked = false;

            dateForSkipStr = "2000-01-01";
        }

        public string PatientName
        {
            get
            {
                return txtPatientName.Text;
            }
        }

        public string DoctorName
        {
            get
            {
                return txtDoctorName.Text;
            }
        }

        public string Status
        {
            get
            {
                return (string)cboStatus.SelectedValue;
            }
        }

        public string StatusAtDateStr
        {
            get
            {
                if (dtpStatusAt.Checked)
                    return dtpStatusAt.Value.ToString("yyyy-MM-dd");
                else
                    return dateForSkipStr;
            }
        }

        public string CreatedAtDateStr
        {
            get
            {
                if (dtpCreatedAt.Checked)
                    return dtpCreatedAt.Value.ToString("yyyy-MM-dd");
                else
                    return dateForSkipStr;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
