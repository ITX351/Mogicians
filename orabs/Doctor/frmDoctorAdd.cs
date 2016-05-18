using System;
using System.Windows.Forms;

namespace orabs.Doctor
{
    public partial class frmDoctorAdd : Form
    {
        public frmDoctorAdd()
        {
            InitializeComponent();
        }

        private void frmDoctorAdd_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, false);
            Global.setComboBoxByTableName("Department", cboDepartment, false);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Doctor Name cannot be empty");
                return;
            }
            string exeStr = "insert into Doctor(Name, Department_ID, DoctorGroup_ID, Description) values('" + Global.EscapeSingleQuotes(txtName.Text) + "'," +
               "'" + cboDepartment.SelectedValue.ToString() + "'," +
               "'" + cboGroup.SelectedValue.ToString() + "'," +
               "'" + Global.EscapeSingleQuotes(txtDescription.Text) + "')";
          
            int success = DatabaseOperation.ExecuteSQLQuery(exeStr);
            if (success > 0)
            {
                MessageBox.Show("Added succeefully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occured.");
            }
        }

    }
}
