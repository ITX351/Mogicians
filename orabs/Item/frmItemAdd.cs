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
    public partial class frmItemAdd : Form
    {
        public frmItemAdd()
        {
            InitializeComponent();
        }



        private void frmItemAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("Item Name can not be empty.");
                return;
            }

            if (!Global.IsDecimal(txtItemPrice.Text))
            {
                MessageBox.Show("Item Price not valid.");
                return;
            }

            string exeStr = "insert into PurchaseItem(Name,Description,Price) values('" +
                           Global.EscapeSingleQuotes(txtItemName.Text) + 
               "' , '" +  Global.EscapeSingleQuotes(txtItemDescription.Text) +
               "', "  + txtItemPrice.Text  +")";

            if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
            {
                MessageBox.Show("Item Add successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some error has occurred when adding.");
            }
        }
    }
}
