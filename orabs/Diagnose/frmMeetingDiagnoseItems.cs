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
    public partial class frmMeetingDiagnoseItems : Form
    {
        DataTable items, showItems, chosenItems;
        public frmMeetingDiagnoseItems()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMeetingDiagnoseItems_Load(object sender, EventArgs e)
        {
            string queryStr = "select * from PurchaseItem";
            items = DatabaseOperation.GetDataTableByQuery(queryStr);

            showItems = Global.getEmptyListTable();
            lstAllItems.DataSource = showItems;
            lstAllItems.DisplayMember = "ShowText";
            lstAllItems.ValueMember = "Value";

            chosenItems = Global.getEmptyListTable();
            chosenItems.Columns.Add("Number", System.Type.GetType("System.Int32"));
            lstChosenItems.DataSource = chosenItems;
            lstChosenItems.DisplayMember = "ShowText";
            lstChosenItems.ValueMember = "Value";

            txtNamePrefix_TextChanged(sender, e);
        }

        private void txtNamePrefix_TextChanged(object sender, EventArgs e)
        {
            showItems.Clear();
            for (int i = 0; i < items.Rows.Count; i++)
            {
                DataRow dr = items.Rows[i];
                string name = (string)dr["Name"];
                if (name.StartsWith(txtNamePrefix.Text))
                    showItems.Rows.Add(name + ", $" + dr["Price"].ToString(), i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO: NUMBER VALIDITY CHECK
            DataRow dr = items.Rows[(int)lstAllItems.SelectedValue];
            foreach (DataRow dr2 in chosenItems.Rows)
            {
                if ((int)dr2["Value"] == (int)dr["PurchaseItem_ID"])
                {
                    dr2["Number"] = (int)dr2["Number"] + int.Parse(txtNumber.Text);
                    dr2["ShowText"] = (string)dr["Name"] + ", " + dr2["Number"].ToString();
                    return;
                }
            }

            chosenItems.Rows.Add((string)dr["Name"] + ", " + txtNumber.Text, 
                (int)dr["PurchaseItem_ID"], int.Parse(txtNumber.Text));
            txtNumber.Text = "1";
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
