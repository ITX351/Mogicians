using orabs.Doctor;
using System;
using System.Data;
using System.Windows.Forms;

namespace orabs
{
    public partial class frmDoctorControl : Form
    {
        private DataTable showTable;

        private string name;
        private int group_ID;
        private int department_ID;

        public frmDoctorControl()
        {
            InitializeComponent();
        }

        private void frmDoctorControl_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(sender, e); // Default show all records.
        }

        private int getDoctorID()
        {
            return (int)showTable.Rows[dgvDoctor.CurrentRow.Index]["Doctor_ID"];
        }

        private void doQuery(string name, int group, int department) // change query parameters
        {
            this.name = name; this.group_ID = group; this.department_ID = department;
            showQuery();
        }

        private void showQuery() // show records fitting parameters
        {
            string queryStr = "select Doctor_ID, DoctorName, DoctorGroupName," +
                " DepartmentName, Description from DoctorUser" +
                " where DoctorName like '" + Global.AppendPercent(name) + "'" +
                " and (DoctorGroup_ID = " + group_ID.ToString() + " or " + group_ID.ToString() + " = -1)" +
                " and (Department_ID = " + department_ID.ToString() + " or " + department_ID.ToString() + " = -1)";
                
            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvDoctor.DataSource = showTable;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmDoctorQuery frmDoctorQueryEntity = new frmDoctorQuery();
            frmDoctorQueryEntity.ShowDialog();

            if (frmDoctorQueryEntity.DialogResult == DialogResult.OK)
            {
                doQuery(frmDoctorQueryEntity.DoctorName, frmDoctorQueryEntity.DoctorGroup_ID, 
                    frmDoctorQueryEntity.Department_ID);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            doQuery("", -1, -1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDoctorUpdate frmDoctorUpdateEntity = new frmDoctorUpdate(
                (int)showTable.Rows[dgvDoctor.CurrentRow.Index]["Doctor_ID"]);
            frmDoctorUpdateEntity.ShowDialog();

            if (frmDoctorUpdateEntity.DialogResult == DialogResult.OK)
            {
                showQuery();
            }
        }

        private void dgvDoctor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { // Double click on cell calls update
            btnUpdate_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDoctorAdd frmDoctorAddEntity = new frmDoctorAdd();
            frmDoctorAddEntity.ShowDialog();
            if (frmDoctorAddEntity.DialogResult == DialogResult.OK)
            {
                showQuery();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm delete this doctor?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int doctor_id = getDoctorID();

                string exeStr = "delete from Doctor where Doctor_ID = " + doctor_id.ToString();
                if (DatabaseOperation.ExecuteSQLQuery(exeStr) > 0)
                {
                    MessageBox.Show("Doctor has been deleted.");
                    btnShowAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Some error has occurred while deleting.");
                }
            }
        }

        private void dgvDoctor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }
    }
}
