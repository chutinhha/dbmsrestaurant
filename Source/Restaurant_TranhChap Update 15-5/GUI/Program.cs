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
            frmLogin frmLogin = new frmLogin();
            frmMain frmMain = new frmMain(); ;
            Thread thread = new Thread(frmMain.KhoiTaoUserControl);
            thread.Start();            
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmMain.MaNH = "1";
                //Gan gia tri dang nhap duoc cho form main o day
                //frmMain.MaNH = frmLogin.MaNH;
                //frmMain.NhanVien = frmLogin.NhanVien;
                try
                {
                    Application.Run(frmMain);
                }
                catch (Exception)
                {
                }
                
            }
        }
    }
}
