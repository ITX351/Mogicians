using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingRegister : Form
    {
        private DataTable dataTable;

        public frmMeetingRegister()
        {
            InitializeComponent();
        }

        private void frmMeetingRegister_Load(object sender, EventArgs e)
        {
            Global.setComboBoxByTableName("DoctorGroup", cboGroup, false);
            Global.setComboBoxByTableName("Department", cboDepartment, false);
            cboDoctorName.DataSource = dataTable;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MySqlTransaction transaction = DatabaseOperation.mySqlConnection.BeginTransaction();
            try
            {
                string Patient_ID_str = Global.patientId.ToString();
                string Doctor_ID_str = cboDoctorName.SelectedValue.ToString();

                string exeStr = "insert into Meeting(Patient_ID, Doctor_ID, Status) Values( " +
                    Patient_ID_str + " , " + Doctor_ID_str + " , " + " 'C');";
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);
                int Meeting_ID = DatabaseOperation.GetLastInsertID();

                string queryStr = "select * from DoctorGroup where DoctorGroup_ID = " + cboGroup.SelectedValue.ToString();
                double totalPrice = double.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0]["Charge"].ToString());

                exeStr = "insert into PaymentList(isRegistration, Paid, TotalPrice, Meeting_ID, " +
                    " Doctor_ID, Patient_ID) values(1, 0, " + totalPrice.ToString() +
                    " , " + Meeting_ID.ToString() +
                    " , " + Doctor_ID_str +
                    " , " + Patient_ID_str + ")";
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                transaction.Commit();  
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error occurred during meeting registration." + exception.ToString());
                transaction.Rollback();
                return;
            }
   
            MessageBox.Show("Register successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.SelectedValue == null || cboDepartment.SelectedValue == null)
            {
                return;
            }
            string exeStr = " select Doctor.Doctor_ID as Doctor_ID, Doctor.Name as DoctorName from Doctor " +
                " join Department on Department.Department_ID = Doctor.Department_ID " +
                " join DoctorGroup on DoctorGroup.DoctorGroup_ID = Doctor.DoctorGroup_ID " +
                " where DoctorGroup.DoctorGroup_ID = " + ((int)cboGroup.SelectedValue).ToString() +
                " and Department.Department_ID = " + ((int)cboDepartment.SelectedValue).ToString();

            dataTable = DatabaseOperation.GetDataTableByQuery(exeStr);
            cboDoctorName.DisplayMember = "DoctorName";
            cboDoctorName.ValueMember = "Doctor_ID";
            cboDoctorName.DataSource = dataTable;
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDepartment_SelectedIndexChanged(sender, e);
        }

        private void cboDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctorName.SelectedValue != null)
            {
                int Doctor_ID = int.Parse(cboDoctorName.SelectedValue.ToString());
                string queryStr = "select count(*) as `count` from Meeting where Status = 'W' and " +
                    " Doctor_ID = " + Doctor_ID.ToString();
                DataRow dr = DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0];
                lblWaiting.Text = dr[0].ToString();
            }
            else
            {
                lblWaiting.Text = "--";
            }
        }
    }
}
