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
    public partial class frmItemUpdate : Form
    {
        private int Item_ID;

        public frmItemUpdate(int Item_ID)
        {
            InitializeComponent();
            this.Item_ID = Item_ID;
        }

        private void frmItemUpdate_Load(object sender, EventArgs e)
        {
            DataRow dr = DatabaseOperation.GetDataRowByID("PurchaseItem", Item_ID);
            txtItemName.Text = (string)dr["Name"];
            txtItemPrice.Text = dr["Price"].ToString();
            txtItemDescription.Text = dr["Description"].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("PurchaseItem Name cannot be empty");
                return;
            }
            if (!Global.IsDecimal(txtItemPrice.Text))
            {
                MessageBox.Show("Item Price not valid.");
                return;
            }

            string exeStr = "update PurchaseItem set Name = '" + Global.EscapeSingleQuotes(txtItemName.Text) + 
                "', Description = '" + Global.EscapeSingleQuotes(txtItemDescription.Text) +
                "', Price = " + txtItemPrice.Text + 
                " where PurchaseItem_ID = " + Item_ID.ToString();

            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Item updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when updating.");
            }
        }

      
    }
}
