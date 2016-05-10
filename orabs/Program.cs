using System;
using System.Windows.Forms;

namespace orabs
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseOperation.OpenConnection();

            frmLogin frmLoginEntity = new frmLogin();
            frmLoginEntity.ShowDialog();
            if (frmLoginEntity.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
