using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Diagnose
{
    public partial class frmMeetingDiagnoseItemsView : Form
    {
        int PaymentList_ID;
        DataTable showTable;
        public frmMeetingDiagnoseItemsView(int PaymentList_ID)
        {
            InitializeComponent();
            this.PaymentList_ID = PaymentList_ID;
        }

        private void frmMeetingDiagnoseItemsView_Load(object sender, EventArgs e)
        {
            string queryStr = "select PurchaseItem.Name as `Item Name`, PurchaseItem.Price as `Price`," +
                " PurchaseItem.Description as `Item Description`, PaymentList_PurchaseItem.Number as `Number` from " + 
                " PaymentList_PurchaseItem join PurchaseItem on " + 
                " PurchaseItem.PurchaseItem_ID = PaymentList_PurchaseItem.PurchaseItem_ID " +
                " where PaymentList_PurchaseItem.PaymentList_ID = " + PaymentList_ID.ToString();
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvItems.DataSource = showTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
