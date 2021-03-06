﻿using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Patient
{
    public partial class frmPatientInfo : Form
    {
        public frmPatientInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPatientUpdate frmPatientUpdateEntity = new frmPatientUpdate(Global.patientId);
            frmPatientUpdateEntity.ShowDialog();
            if (frmPatientUpdateEntity.DialogResult == DialogResult.OK)
            {
                refresh();
            }
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            if (Global.patientId != -1)
            {
                refresh();
            }
        }

        private void refresh()
        {
            string queryStr = "select Name, sexToString(Sex) as Sex, " +
                " Phone, Address, Identity_Number from Patient where Patient_ID = " + Global.patientId.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);
            DataRow dr = dt.Rows[0];

            lblNameTxt.Text = dr["Name"].ToString();
            lblPhoneTxt.Text = dr["Phone"].ToString();
            lblSexTxt.Text = dr["Sex"].ToString();
            lblIdentityNumberTxt.Text = dr["Identity_Number"].ToString();
            lblAddressTxt.Text = dr["address"].ToString();
        }
    }
}
