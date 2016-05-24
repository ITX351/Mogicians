using MySql.Data.MySqlClient;
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

            MySqlTransaction transaction = DatabaseOperation.mySqlConnection.BeginTransaction();
            try
            {
                string exeStr = "insert into Doctor(Name, Department_ID, DoctorGroup_ID, Description) values('" 
                    + Global.EscapeSingleQuotes(txtName.Text) + "'," +
                   "'" + cboDepartment.SelectedValue.ToString() + "'," +
                   "'" + cboGroup.SelectedValue.ToString() + "'," +
                   "'" + Global.EscapeSingleQuotes(txtDescription.Text) + "')";
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);
                int doctor_id = DatabaseOperation.GetLastInsertID();

                string queryStr = "select count(*) from Doctor where Name = '" + Global.EscapeSingleQuotes(txtName.Text) + "'";
                int count = int.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0][0].ToString());

                exeStr = " insert into User(Name, Password, Doctor_ID) values(' " +
                    Global.EscapeSingleQuotes(txtName.Text) + "_" + count.ToString() + "','" +
                    Global.SHA1("123456") + "' , " + doctor_id.ToString() + ")";

                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error has occurred during adding the doctor.\n" + exception.ToString());
                transaction.Rollback();
                return;
            }

            MessageBox.Show("Added succeefully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
