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
            this.name = name; this.group_ID = group; this.department_ID = department; this.description = description;
            showQuery();
        }

        private void showQuery() // show records fitting parameters
        {
            string queryStr = "select Doctor.Doctor_ID, Doctor.Name, DoctorGroup.Name as DoctorGroupName," + 
                " Department.Name as DepartmentName, Doctor.Description from Doctor" + 
                " join DoctorGroup on Doctor.DoctorGroup_ID = DoctorGroup.DoctorGroup_ID" + 
                " join Department on Doctor.Department_ID = Department.Department_ID" + 
                " where Doctor.Name like '" + Global.AppendPercent(name) + "'" +
                " and (Doctor.DoctorGroup_ID = " + group_ID.ToString() + " or " + group_ID.ToString() + " = -1)" +
                " and (Doctor.Department_ID = " + department_ID.ToString() + " or " + department_ID.ToString() + " = -1)" +
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
                doQuery(frmDoctorQueryEntity.DoctorName, frmDoctorQueryEntity.DoctorGroup_ID, 
                    frmDoctorQueryEntity.Department_ID, frmDoctorQueryEntity.Description);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }
    }
}
