using MySql.Data.MySqlClient;
using orabs.Diagnose;
using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingDetails : Form
    {
        private int Meeting_ID, Patient_ID, registration_PaymentList_ID, bill_PaymentList_ID;
        private DataRow meeting, conclusion;
        private const string PAY_FOR_REGISTRATION = "Pay For Registration";

        public frmMeetingDetails(int Meeting_ID)
        {
            InitializeComponent();
            this.Meeting_ID = Meeting_ID;
        }

        private void Load_Meeting_Information()
        {
            string queryStr = "select Meeting_ID, Patient_ID, PatientName, " +
                " DoctorName, DepartmentName, DoctorGroupName, Status, StatusAt, CreatedAt " +
                " from MeetingAll where Meeting_ID = " + Meeting_ID.ToString();
            meeting = DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0];

            Patient_ID = (int)meeting["Patient_ID"];
            if (Patient_ID != Global.patientId)
            {
                lnkPay.Visible = false;
                lnkPayForRegistration.Visible = false;
            }

            lblMeetingID.Text = meeting["Meeting_ID"].ToString();
            lblPatientName.Text = meeting["PatientName"].ToString();
            lblDoctorName.Text = meeting["DoctorName"].ToString();
            lblDepartment.Text = meeting["DepartmentName"].ToString();
            lblDoctorGroup.Text = meeting["DoctorGroupName"].ToString();
            lblStatus.Text = meeting["Status"].ToString();
            lblStatusAt.Text = meeting["StatusAt"].ToString();
            lblCreatedAt.Text = meeting["CreatedAt"].ToString();

            if (lblStatus.Text == "Finished")
            {
                queryStr = "select Symptom, Conclusion, Handle from DiagnoseConclusion where Meeting_ID = " + Meeting_ID.ToString();
                conclusion = DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0];

                lblSymptom.Text = conclusion["Symptom"].ToString();
                lblConclusion.Text = conclusion["Conclusion"].ToString();
                lblHandle.Text = conclusion["Handle"].ToString();
            }
            else
            {
                lblSymptom.Text = lblConclusion.Text = lblHandle.Text = lblCost.Text = "--";
                btnViewItems.Enabled = lblPaid.Visible = lnkPay.Visible = false;
            }

            if (lblStatus.Text != "Registration unpaid")
                lnkPayForRegistration.Visible = false;

            if (lblStatus.Text == "Waiting")
            {
                queryStr = "select count(*) from Meeting where status = 'W' and" + 
                    " CreatedAt < (select CreatedAt from Meeting where Meeting_ID = " + Meeting_ID.ToString() + ")";
                DataRow dr = DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0];
                lblQueueRank.Text = (int.Parse(dr[0].ToString()) + 1).ToString();
            }
            else
                lblQueueRank.Text = "--";

            queryStr = "select PaymentList_ID, isRegistration, Totalprice, Paid" +
                " from PaymentList where Meeting_ID = " + Meeting_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);

            foreach (DataRow dr in dt.Rows)
            {
                bool isRegistration = (bool)dr["isRegistration"], paid = (bool)dr["Paid"];

                double Totalprice = double.Parse(dr["Totalprice"].ToString());
                string priceStr = "$" + Totalprice.ToString("F2");
                if (isRegistration)
                {
                    lblRegistrationPrice.Text = priceStr;
                    if (paid)
                        lnkPayForRegistration.Visible = false;
                    else
                        lnkPayForRegistration.Text = PAY_FOR_REGISTRATION + "(" + priceStr + ")";
                    registration_PaymentList_ID = (int)dr["PaymentList_ID"];
                }
                else
                {
                    if (paid || Totalprice == 0)
                        lnkPay.Visible = false;
                    if (Totalprice == 0)
                        lblPaid.Text = "Nothing to pay";
                    else if (paid)
                        lblPaid.Text = "Paid";
                    else
                        lblPaid.Text = "Unpaid";
                    lblCost.Text = priceStr;
                    bill_PaymentList_ID = (int)dr["PaymentList_ID"];
                }
            }
        }

        private void frmMeetingDetails_Load(object sender, EventArgs e)
        {
            Load_Meeting_Information();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkPayForRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Confirm pay for registration " + lblRegistrationPrice.Text + " ?", 
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            MySqlTransaction transaction = DatabaseOperation.mySqlConnection.BeginTransaction();
            try
            {
                string exeStr = "update PaymentList set Paid = 1 where PaymentList_ID = " + registration_PaymentList_ID.ToString();
                DatabaseOperation.ExecuteSQLQuery(exeStr);
                exeStr = "update Meeting set Status = 'W' where Meeting_ID = " + Meeting_ID.ToString();
                DatabaseOperation.ExecuteSQLQuery(exeStr);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error has occurred during transaction.\n" + exception.ToString());
                transaction.Rollback();
                return;
            }
            MessageBox.Show("Payment succeeded.");
            Load_Meeting_Information();
        }

        private void lnkPay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Confirm pay for " + lblCost.Text + " ?", 
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string exeStr = "update PaymentList set Paid = 1 where PaymentList_ID = " + bill_PaymentList_ID.ToString();
            DatabaseOperation.ExecuteSQLQuery(exeStr);

            MessageBox.Show("Payment succeeded.");
            Load_Meeting_Information();
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            frmMeetingDiagnoseItemsView frmMeetingDiagnoseItemsViewEntity = new frmMeetingDiagnoseItemsView(bill_PaymentList_ID);
            frmMeetingDiagnoseItemsViewEntity.ShowDialog();
        }
    }
}
