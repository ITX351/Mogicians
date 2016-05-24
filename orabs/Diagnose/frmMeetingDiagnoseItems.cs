using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Diagnose
{
    public partial class frmMeetingDiagnoseItems : Form
    {
        DataTable items, showItems, chosenItems, givenSituation;
        public frmMeetingDiagnoseItems(DataTable givenSituation)
        {
            InitializeComponent();
            this.givenSituation = givenSituation;
        }

        public double TotalPrice { get; set; }
        public DataTable resultTable { get; set; }

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

            if (givenSituation != null)
                for (int i = 0; i < items.Rows.Count; i++)
                {
                    DataRow dr1 = items.Rows[i];
                    foreach (DataRow dr2 in givenSituation.Rows)
                        if ((int)dr1["PurchaseItem_ID"] == (int)dr2["PurchaseItem_ID"])
                            chosenItems.Rows.Add((string)dr1["Name"] + ", " + dr2["Number"].ToString(),
                                i, (int)dr2["Number"]);
                }

            txtNamePrefix_TextChanged(sender, e);
            UpdateTotalPrice();
        }

        private void txtNamePrefix_TextChanged(object sender, EventArgs e)
        {
            showItems.Clear();
            for (int i = 0; i < items.Rows.Count; i++)
            {
                DataRow dr = items.Rows[i];
                string name = (string)dr["Name"];
                if (name.ToLower().StartsWith(txtNamePrefix.Text.ToLower()))
                    showItems.Rows.Add(name + ", $" + dr["Price"].ToString(), i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO: NUMBER VALIDITY CHECK
            int id = (int)lstAllItems.SelectedValue;
            DataRow dr = items.Rows[id];
            foreach (DataRow dr2 in chosenItems.Rows)
            {
                if ((int)dr2["Value"] == id)
                {
                    dr2["Number"] = (int)dr2["Number"] + int.Parse(txtNumber.Text);
                    dr2["ShowText"] = (string)dr["Name"] + ", " + dr2["Number"].ToString();
                    UpdateTotalPrice();
                    return;
                }
            }

            chosenItems.Rows.Add((string)dr["Name"] + ", " + txtNumber.Text, 
                id, int.Parse(txtNumber.Text));
            txtNumber.Text = "1";
            UpdateTotalPrice();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            DataRow dr = chosenItems.Rows[lstChosenItems.SelectedIndex];
            dr["Number"] = (int)dr["Number"] - 1;
            if ((int)dr["Number"] == 0)
                chosenItems.Rows.Remove(dr);
            else
                dr["ShowText"] = (string)items.Rows[(int)lstChosenItems.SelectedValue]["Name"] + ", " + dr["Number"].ToString();
            UpdateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = chosenItems.Rows[lstChosenItems.SelectedIndex];
            chosenItems.Rows.Remove(dr);
            UpdateTotalPrice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chosenItems.Rows.Clear();
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            TotalPrice = .0;
            foreach (DataRow dr in chosenItems.Rows)
                TotalPrice += double.Parse(items.Rows[(int)dr["Value"]]["Price"].ToString()) * (int)dr["Number"];
            lblTotalPrice.Text = "$" + TotalPrice.ToString("F2"); // keep two decimals
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            resultTable = new DataTable();
            resultTable.Columns.Add("PurchaseItem_ID", System.Type.GetType("System.Int32"));
            resultTable.Columns.Add("Number", System.Type.GetType("System.Int32"));

            foreach (DataRow dr in chosenItems.Rows)
                resultTable.Rows.Add((int)items.Rows[(int)dr["Value"]]["PurchaseItem_ID"], (int)dr["Number"]);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
