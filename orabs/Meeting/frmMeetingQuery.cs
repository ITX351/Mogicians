using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingQuery : Form
    {
        private DataTable dataTable;

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

            cboStatus.DataSource = dataTable;
            cboStatus.ValueMember = "statusCode";
            cboStatus.DisplayMember = "statusStr";

            dtpCreatedAt.Value = new DateTime(2000, 1, 1, 1, 0, 0);
            dtpStatusAt.Value = new DateTime(2000, 1, 1, 1, 0, 0);
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

        public DateTime StatusAt
        {
            get
            {
                return dtpStatusAt.Value;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return dtpCreatedAt.Value;
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
