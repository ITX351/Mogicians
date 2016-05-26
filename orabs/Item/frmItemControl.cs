using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Item
{
    public partial class frmItemControl : Form
    {
        private DataTable showTable;

        public frmItemControl()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            string queryStr = "select * from PurchaseItem";
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvItem.DataSource = showTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmItemAdd frmItemAddEntity = new frmItemAdd();
            frmItemAddEntity.ShowDialog();

            if (frmItemAddEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm delete this Item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Item_ID = getItemID();

                string queryStr = "select count(*) from PaymentList_PurchaseItem where PurchaseItem_ID = " + Item_ID.ToString();
                int remainNumber = int.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0][0].ToString());

                if (remainNumber > 0)
                {
                    MessageBox.Show(remainNumber.ToString() +
                        "remaining payment list(s) having this item. The delete operation has been interrupted.");
                    return;
                }

                string exeStr = "delete from PurchaseItem where PurchaseItem_ID = " + Item_ID.ToString();
                if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
                {
                    MessageBox.Show("Item has been deleted.");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Some error has occurred while deleting.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmItemUpdate frmItemUpdateEntity = new frmItemUpdate(getItemID());
            frmItemUpdateEntity.ShowDialog();

            if (frmItemUpdateEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void frmItemControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private int getItemID()
        {
            return (int)showTable.Rows[dgvItem.CurrentRow.Index]["PurchaseItem_ID"];
        }
    }
}
