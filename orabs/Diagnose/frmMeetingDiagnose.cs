using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orabs.Diagnose;
using MySql.Data.MySqlClient;

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
                    txtHandle.Text + "', 0, 0)"; // TODO: Cost calculating
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);
                exeStr = "update Meeting set Status = 'F' where Meeting_ID = " + Meeting_ID.ToString();
                DatabaseOperation.ExecuteSQLQuery(exeStr, transaction);

                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error has occurred during transaction.\n" + exception.ToString());
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
