﻿using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Department
{
    public partial class frmDepartmentUpdate : Form
    {
        private int Department_ID;

        public frmDepartmentUpdate(int Department_ID)
        {
            InitializeComponent();
            this.Department_ID = Department_ID;
        }

        private void frmDepartmentUpdate_Load(object sender, EventArgs e)
        {
            DataRow dr = DatabaseOperation.GetDataRowByID("Department", Department_ID);
            txtDepartmentName.Text = (string)dr["Name"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Length == 0)
            {
                MessageBox.Show("Department Name cannot be empty");
                return;
            }
            string exeStr = "update Department set Name = '" + Global.EscapeSingleQuotes(txtDepartmentName.Text) + 
                "' where Department_ID = " + Department_ID.ToString();
            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Department updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when updating.");
            }
        }
    }
}
