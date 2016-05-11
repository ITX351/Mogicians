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
        private int group;
        private int department;
        private string description;

        public frmDoctorControl()
        {
            InitializeComponent();
        }

        private void frmDoctorControl_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(sender, e); // Default show all records.
        }

        private void doQuery(string name, int group, int department, string description) // change query parameters
        {
            this.name = name; this.group = group; this.department = department; this.description = description;
            showQuery();
        }

        private void showQuery() // show records fitting parameters
        {
            string queryStr = "select Doctor.Doctor_ID, Doctor.Name, DoctorGroup.Name as DoctorGroupName," + 
                " Department.Name as DepartmentName, Doctor.Description from Doctor" + 
                " join DoctorGroup on Doctor.DoctorGroup_ID = DoctorGroup.DoctorGroup_ID" + 
                " join Department on Doctor.Department_ID = Department.Department_ID" + 
                " where Doctor.Name like '" + Global.AppendPercent(name) + "'" +
                " and (Doctor.DoctorGroup_ID = " + group.ToString() + " or " + group.ToString() + " = -1)" +
                " and (Doctor.Department_ID = " + department.ToString() + " or " + department.ToString() + " = -1)" +
                " and Doctor.Description like '" + Global.AppendPercent(description) + "'";

            showTable = DatabaseOperation.GetDataTableByQuery(queryStr);
            dgvDoctor.DataSource = showTable;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmDoctorQuery frmDoctorQueryEntity = new frmDoctorQuery();
            frmDoctorQueryEntity.ShowDialog();

            if (frmDoctorQueryEntity.DialogResult == DialogResult.OK)
            {
                doQuery(frmDoctorQueryEntity.DoctorName, -1, -1, frmDoctorQueryEntity.Description);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            doQuery("", -1, -1, "");
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
    }
}
