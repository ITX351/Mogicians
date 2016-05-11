using System;
using System.Data;
using System.Windows.Forms;

namespace orabs.Department
{
    public partial class frmDepartmentControl : Form
    {
        private DataTable showTable;

        public frmDepartmentControl()
        {
            InitializeComponent();
        }


        private void refresh()
        {
            string queryStr = "select * from Department";
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvDepartment.DataSource = showTable;
        }

        private int getDepartmentID()
        {
            return (int)showTable.Rows[dgvDepartment.CurrentRow.Index]["Department_ID"];
        }

        private void frmDepartmentControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepartmentAdd frmDepartmentAddEntity = new frmDepartmentAdd();
            frmDepartmentAddEntity.ShowDialog();

            if (frmDepartmentAddEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDepartmentUpdate frmDepartmentUpdateEntity = new frmDepartmentUpdate(getDepartmentID());
            frmDepartmentUpdateEntity.ShowDialog();

            if (frmDepartmentUpdateEntity.DialogResult == DialogResult.OK)
                refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm delete this department?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int department_id = getDepartmentID();

                string queryStr = "select count(*) from Doctor where Department_ID = " + department_id.ToString();
                int remainDoctors = int.Parse(DatabaseOperation.GetDataTableByQuery(queryStr).Rows[0][0].ToString());

                if (remainDoctors > 0)
                {
                    MessageBox.Show(remainDoctors.ToString() +
                        " remaining doctors belong to this Department. The delete operation has been interrupted.");
                    return;
                }

                string exeStr = "delete from Department where Department_ID = " + department_id.ToString();
                if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
                {
                    MessageBox.Show("Department has been deleted.");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Some error has occurred while deleting.");
                }
            }
        }

        private void dgvDepartment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

    }
}
