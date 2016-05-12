using System;
using System.Windows.Forms;

namespace orabs.Department
{
    public partial class frmDepartmentAdd : Form
    {
        public frmDepartmentAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Length == 0)
            {
                MessageBox.Show("Department Name can not be empty.");
                return;
            }
            string exeStr = "insert into Department(Name) values('" + Global.EscapeSingleQuotes(txtDepartmentName.Text) + "')";
            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Department Add successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when adding.");
            }
        }

        private void frmDepartmentAdd_Load(object sender, EventArgs e)
        {

        }

        private void lblDepartmentName_Click(object sender, EventArgs e)
        {

        }

    }
}
