﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Patient
{
    public partial class frmPatientUpdate : Form
    {
        private int patientIdToOperate;

        public frmPatientUpdate(int patientIdToOperate)
        {
            InitializeComponent();
            this.patientIdToOperate = patientIdToOperate;
        }

        private void frmPatientUpdate_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Global.GetSexDataTable();
            cboSex.ValueMember = "SexCode";
            cboSex.DisplayMember = "SexStr";

            if (patientIdToOperate != -1)
            {
                DataRow dr = DatabaseOperation.GetDataRowByID("Patient", patientIdToOperate);
                txtName.Text = dr["Name"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtIdentityNumber.Text = dr["Identity_Number"].ToString();
                if (false == (bool)dr["Sex"])
                    cboSex.SelectedValue = 0;
                else
                    cboSex.SelectedValue = 1;
            }
            else
            {
                cboSex.SelectedValue = 0;
            }
        }

      private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtIdentityNumber.Text.Length == 0)
            {
                MessageBox.Show("Patient Name and Identity Number cannot be empty.");
                return;
            }

            if (!Global.testRegax(txtPhone.Text, @"^([0-9\-+]*)$"))
            {
                MessageBox.Show("Phone Number can only contain digit, plus sign and dash.");
                txtPhone.Focus();
                return;
            }

            string exeStr;
            if (Global.authority == Global.Identity.Patient && patientIdToOperate == -1)
            {
                MySqlTransaction transaction = DatabaseOperation.mySqlConnection.BeginTransaction();
                try
                {
                    exeStr = "insert into Patient(Name, Sex, Phone, Address, Identity_Number) values('" +
                        txtName.Text + "', '" + cboSex.SelectedValue + "', '" +
                        txtPhone.Text + "', '" + txtAddress.Text + "', '" +
                        txtIdentityNumber.Text + "')";
                    DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);
                    int Patient_ID = DatabaseOperation.GetLastInsertID();

                    exeStr = "update User set Patient_ID = " + Patient_ID.ToString() + " where User_ID = " + Global.userId.ToString();
                    DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                    transaction.Commit();
                    Global.patientId = Patient_ID;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Some error has occurred.." + exception.ToString());
                    transaction.Rollback();
                    return;
                }
            }
            else
            {
                exeStr = "update Patient set Name = '" + txtName.Text +
                    "', Sex = " + cboSex.SelectedValue +
                    ", Phone = '" + txtPhone.Text +
                    "', Address = '" + txtAddress.Text +
                    "', Identity_Number = '" + txtIdentityNumber.Text +
                    "' where Patient_ID = " + patientIdToOperate;
                int result = DatabaseOperation.ExecuteSQLQuery(exeStr);
                if (result <= 0)
                {
                    MessageBox.Show("Error occurred while complementing patient information.");
                    return;
                }
            }

            MessageBox.Show("Updated successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
