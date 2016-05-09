using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DatabaseOperation.OpenConnection();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable dt = DatabaseOperation.GetDataTableByQuery("select * from User", "User");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DatabaseOperation.ExecuteSQLQuery("insert into User(Name, Password, isAdmin) values('itx351', '123456', 0)");
        }
    }
}
