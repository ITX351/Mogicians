﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace orabs.Patient
{
    public partial class frmPatientControl : Form
    {
        private string name;
        private SByte sex;
        private string phone;
        private string address;
        private string identityNumber;

        private DataTable showTable;

        public frmPatientControl()
        {
            InitializeComponent();
            Global.initDataTableSex();
        }

        public int getPatientID()
        {
            return (int)showTable.Rows[dgvPatient.CurrentRow.Index]["Patient_ID"];
        }

        private void doQuery(string name, SByte sex, string phone, string address, string identityNumber)
        {
            this.name = name;
            this.sex = sex;
            this.phone = phone;
            this.address = address;
            this.identityNumber = identityNumber;
            showQuery();
        }

        private void showQuery()
        {
            string queryStr = "select Patient_ID, Name, Sex, Phone, Address, Identity_Number " +
                " from Patient where Name like '" + Global.AppendPercent(name) + "'" +
                " and (Sex = " + sex + " or " + sex + " = -1 )" +
                " and Phone like '" + Global.AppendPercent(phone) + "'" +
                " and Address like '" + Global.AppendPercent(address) + "'" +
                " and Identity_Number like '" + Global.AppendPercent(identityNumber) + "'";
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvPatient.DataSource = showTable;
        }

        private void frmPatientControl_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Global.isDoctor())      
            {
                MessageBox.Show("Doctor has no authority to complement patient information");
                return;
            }

            frmPatientAdd frmPatientAddEntity = new frmPatientAdd();
            frmPatientAddEntity.ShowDialog();
            if (frmPatientAddEntity.DialogResult == DialogResult.OK)
            {
                btnShowAll_Click(sender, e);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            doQuery("", -1, "", "", "");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmPatientQuery frmPatientQueryEntity = new frmPatientQuery();
            frmPatientQueryEntity.ShowDialog();

            if (frmPatientQueryEntity.DialogResult ==  DialogResult.OK)
            {
                doQuery(frmPatientQueryEntity.PatientName, frmPatientQueryEntity.Sex,
                    frmPatientQueryEntity.Phone, frmPatientQueryEntity.Address,
                    frmPatientQueryEntity.IdentityNumber);
            }
        }

        private void dgvPatient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Todo: Sex:male/female is showed by checkbox now, maybe need to change to string
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Todo: check patient can only modify his info
            if (Global.isAdmin() || Global.isPatient())   
            {
                frmPatientUpdate frmPatientUpdateEntity = new frmPatientUpdate(getPatientID());
                frmPatientUpdateEntity.ShowDialog();

                if (frmPatientUpdateEntity.DialogResult == DialogResult.OK)
                {
                    btnShowAll_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("You have no permission to do this");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Global.isDoctor())
            {
                MessageBox.Show("You have no permission to do this");
                return;
            }
            if (MessageBox.Show("Confirm delete ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int patient_id = getPatientID();

                string exeStr = "delete from Patient where Patient_ID = " + patient_id.ToString();
                if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                    btnShowAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Some error has occurred while deleting.");
                }
            }
        }
    }
}