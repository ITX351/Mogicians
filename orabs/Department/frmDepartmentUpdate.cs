using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string queryStr = "select Name from Department where Department_ID = " + Department_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            txtDepartmentName.Text = (string)dt.Rows[0]["Name"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string exeStr = "update Department set Name = '" + Global.EscapeSingleQuotes(txtDepartmentName.Text) + 
                "' where Department_ID = " + Department_ID.ToString();
            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Department updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when updating.");
            }
        }
    }
}
