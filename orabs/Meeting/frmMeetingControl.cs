﻿using System;
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
        private string statusAtStr;          
        private string createdAtStr;
        private const string dateTimeForSkipStr = "2000-01-01 01:00:00";

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
            doQuery("", "", "C", dateTimeForSkipStr, dateTimeForSkipStr);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmMeetingQuery frmMeetingQueryEntity = new frmMeetingQuery();
            frmMeetingQueryEntity.ShowDialog();
            if (frmMeetingQueryEntity.DialogResult == DialogResult.OK)
            {
                doQuery(frmMeetingQueryEntity.DoctorName, frmMeetingQueryEntity.PatientName,
                    frmMeetingQueryEntity.Status, Global.FormatDateTime(frmMeetingQueryEntity.StatusAt), 
                    Global.FormatDateTime(frmMeetingQueryEntity.CreatedAt));
            }
        }

        private void doQuery(string doctorName, string patientName, string status, 
             string statusAtStr, string createdAtStr)
        {
            this.doctorName = doctorName;
            this.patientName = patientName;
            this.status = status;
            this.statusAtStr = statusAtStr;
            this.createdAtStr = createdAtStr;
            showQuery();
        }

        private void showQuery()
        {
            //status not required -> pass in "C"
            string exeStr = "select Meeting.Meeting_ID, Patient.Name as PatientName, " +
                " Doctor.Name as DoctorName, Meeting.Status, Meeting.StatusAt, Meeting.CreatedAt " +
                " from Meeting " +
                " join Doctor on Doctor.Doctor_ID = Meeting.Doctor_ID " +
                " join Patient on Patient.Patient_ID = Meeting.Patient_ID " +
                " where (Doctor.Name like '" + Global.AppendPercent(doctorName) + "') " +
                " and (Patient.Name like '" + Global.AppendPercent(patientName) + "') " +
                " and (Meeting.Status = '" + status + "' or '" + status + "' = 'C' )" +
                " and (Meeting.StatusAt = '" + statusAtStr + "' or '" +
                        statusAtStr + "' = '" + dateTimeForSkipStr + "' ) " +
                " and (Meeting.CreatedAt = '" + createdAtStr + "' or '" +
                        createdAtStr + "' = '" + dateTimeForSkipStr + "' ) ";

            dataTable = DatabaseOperation.GetDataTableByQuery(exeStr);
            dgvMeeting.DataSource = dataTable;
        }
    }
}
