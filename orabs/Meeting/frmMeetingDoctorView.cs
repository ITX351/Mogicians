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

        public frmMeetingDoctorView()
        {
            InitializeComponent();
        }

        private void frmMeetingDoctorView_Load(object sender, EventArgs e)
        {
            // get Doctor Name
            DataRow dr = DatabaseOperation.GetDataRowByID("Doctor", Global.doctorId);
            lblDoctor.Text += (string)dr["Name"];

            // get Patient Meeting
            string queryStr = "select Patient.Patient_ID, Patient.`Name`, sexToString(Patient.Sex) as Sex," + 
                " Patient.Phone, Patient.Address, Patient.Identity_Number, Meeting.`Status`, Meeting.StatusAt," + 
                " Meeting.CreatedAt from Meeting join Patient on Patient.Patient_ID = Meeting.Patient_ID" + 
                " where Meeting.Doctor_ID = " + Global.doctorId.ToString();
            MeetingPatientTable = DatabaseOperation.GetDataTableByQuery(queryStr);


        }
    }
}
