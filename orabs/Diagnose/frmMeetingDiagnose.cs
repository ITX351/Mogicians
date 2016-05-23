using MySql.Data.MySqlClient;
using orabs.Diagnose;
using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingDiagnose : Form
    {
        private int Meeting_ID;
        private DataTable chosenItems;
        private double TotalPrice;

        private string defaultBtnControlPurchaseItemText;

        public frmMeetingDiagnose(int Meeting_ID)
        {
            InitializeComponent();
            this.Meeting_ID = Meeting_ID;

            chosenItems = null;
            TotalPrice = .0;
        }

        private void UpdateTotalPrice()
        {
            btnControlPurchaseItem.Text = defaultBtnControlPurchaseItemText;
            if (TotalPrice > 0)
                btnControlPurchaseItem.Text += "($" + TotalPrice.ToString("F2") + ")"; // keep two decimals
        }

        private void frmMeetingDiagnose_Load(object sender, EventArgs e)
        {
            defaultBtnControlPurchaseItemText = btnControlPurchaseItem.Text;

            string queryStr = "select Patient.Name from Meeting join Patient on Meeting.Patient_ID = Patient.Patient_ID" +
                " where Meeting.Meeting_ID = " + Meeting_ID.ToString();
            DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);
            lblName.Text = (string)dt.Rows[0]["Name"];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MySqlTransaction transaction = DatabaseOperation.mySqlConnection.BeginTransaction();
            try
            {
                string exeStr = "insert into DiagnoseConclusion(Meeting_ID, Symptom, Conclusion, Handle, Cost, Paid) values(" +
                    Meeting_ID.ToString() + ", '" + txtSymptom.Text + "', '" + txtConclusion.Text + "', '" +
                    txtHandle.Text + "', " + TotalPrice.ToString() + ", 0)";
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);
                exeStr = "update Meeting set Status = 'F' and StatusAt = '"+
                    Global.FormatDateTime(DateTime.Now) + "' where Meeting_ID = " + Meeting_ID.ToString();
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                if (TotalPrice > 0)
                {
                    // Get User_ID and Patient_ID;
                    string queryStr = "select User_ID, Patient.Patient_ID from Meeting join Patient on Patient.Patient_ID = Meeting.Patient_ID" +
                        " join User on Patient.Patient_ID = User.Patient_ID where Meeting.Meeting_ID = " + Meeting_ID.ToString();
                    DataTable dt = DatabaseOperation.GetDataTableByQuery(queryStr);
                    int User_ID = (int)dt.Rows[0]["User_ID"], Patient_ID = (int)dt.Rows[0]["Patient_ID"];

                    // Insert PaymentList
                    exeStr = "insert into PaymentList(User_ID, Patient_ID, Doctor_ID, Meeting_ID, Totalprice, Paid) values" + 
                        "(" + User_ID.ToString() + ", " + Patient_ID.ToString() + ", " + Global.doctorId.ToString() + ", " +
                        Meeting_ID.ToString() + ", " + TotalPrice.ToString() + ", 0)";
                    DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                    // Get PaymentList_ID
                    queryStr = "select PaymentList_ID from PaymentList where Meeting_ID = " + Meeting_ID.ToString();
                    dt = DatabaseOperation.GetDataTableByQuery(queryStr);
                    int PaymentList_ID = (int)dt.Rows[0]["PaymentList_ID"];

                    // Insert PaymentList_PurchaseItem
                    exeStr = "insert into PaymentList_PurchaseItem(PurchaseItem_ID, PaymentList_ID, Number) values";

                    bool NotFirstInForeach = false;
                    foreach (DataRow dr in chosenItems.Rows)
                    {
                        if (NotFirstInForeach)
                            exeStr += ",";
                        NotFirstInForeach = true;

                        exeStr += "(" + dr["PurchaseItem_ID"].ToString() + ", " + PaymentList_ID.ToString() + ", " + 
                            dr["Number"].ToString() + ")";
                    }
                    DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error has occurred during transaction.\n" + exception.ToString());
                transaction.Rollback();
                return;
            }

            MessageBox.Show("Diagnose Conclusion has been submitted successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnControlPurchaseItem_Click(object sender, EventArgs e)
        {
            frmMeetingDiagnoseItems frmMeetingDiagnoseItemsEntity = new frmMeetingDiagnoseItems(chosenItems);
            frmMeetingDiagnoseItemsEntity.ShowDialog();

            if (frmMeetingDiagnoseItemsEntity.DialogResult == DialogResult.OK)
            {
                this.chosenItems = frmMeetingDiagnoseItemsEntity.resultTable;
                this.TotalPrice = frmMeetingDiagnoseItemsEntity.TotalPrice;
                UpdateTotalPrice();
            }
        }
    }
}
