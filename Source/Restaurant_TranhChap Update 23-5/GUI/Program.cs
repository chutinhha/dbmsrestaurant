using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread th1 = new Thread(run);
            th1.Start();
            Thread th2 = new Thread(run);
            th2.Start();

        }
        static void run()
        {
            frmLogin frmLogin = new frmLogin();
            frmMain frmMain = new frmMain(); ;
            Thread thread = new Thread(frmMain.KhoiTaoUserControl);
            thread.Start();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {

                frmMain.NhanVien = frmLogin.NhanVien;
                //try
                //{
                Application.Run(frmMain);
                //}
                //catch (Exception) {}
            }
            else
            {
                return;
            }
        }
    }
}
