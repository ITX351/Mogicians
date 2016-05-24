using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orabs.Meeting
{
    public partial class frmMeetingDetails : Form
    {
        private int Meeting_ID;

        public frmMeetingDetails(int Meeting_ID)
        {
            InitializeComponent();
            this.Meeting_ID = Meeting_ID;
        }

        private void frmMeetingDetails_Load(object sender, EventArgs e)
        {
            lblMeetingID.Text = Meeting_ID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
