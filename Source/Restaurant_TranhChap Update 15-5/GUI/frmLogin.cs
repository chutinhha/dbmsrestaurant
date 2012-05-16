using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        NhanVien_DTO nhanVien;
        String maNH;

        public NhanVien_DTO NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiem tra tai khoang dang nhap
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}