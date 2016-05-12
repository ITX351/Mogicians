using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.DoctorGroup
{
    public partial class frmDoctorGroupControl : Form
    {
        private DataTable showTable;

        public frmDoctorGroupControl()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            string queryStr = "select * from DoctorGroup";
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvDoctorGroup.DataSource = showTable;
        
        }

        private int getGroupID()
        {
            return (int)showTable.Rows[dgvDoctorGroup.CurrentRow.Index]["DoctorGroup_ID"];
        }

        private void frmDoctorGroupControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDoctorGroupAdd frmDoctorGroupAddEntity = new frmDoctorGroupAdd();
            frmDoctorGroupAddEntity.ShowDialog();

            if (frmDoctorGroupAddEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDoctorGroupUpdate frmDoctorGroupUpdateEntity = new frmDoctorGroupUpdate(getGroupID());
            frmDoctorGroupUpdateEntity.ShowDialog();

            if (frmDoctorGroupUpdateEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm delete this group?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int group_id = getGroupID();

                string queryStr = "select count(*) from Doctor where DoctorGroup_ID = " + group_id.ToString();
                int remainDoctors = int.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0][0].ToString());
                if (remainDoctors > 0)
                {
                    MessageBox.Show(remainDoctors.ToString() + 
                        " remaining doctors belong to this Group. The delete operation has been interrupted.");
                    return;
                }

                string exeStr = "delete from DoctorGroup where DoctorGroup_ID = " + group_id.ToString();
                int ret = DatabaseOperation.ExecuteSQLQuery(exeStr);

                if (ret > 0)
                {
                    MessageBox.Show("Group has been deleted.");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Some error has occurred while deleting.");
                }
            }
        }

        private void dgvDoctorGroup_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
