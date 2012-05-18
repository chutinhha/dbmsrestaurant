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

        public NhanVien_DTO NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        public int flag;
        public frmLogin()
        {
            InitializeComponent();
            flag = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiem tra tai khoang dang nhap
            flag = QLNguoiDung_BUS.SelectUser(txtTaiKhoan.Text, txtMatKhau.Text);
            if (flag == 1)
            {
                DataTable dtnhanvien = NhanVien_BUS.DocNhanVienTheoUsername(txtTaiKhoan.Text);
                nhanVien = new NhanVien_DTO();
                nhanVien.MaNV = (int)dtnhanvien.Rows[0].ItemArray[0];
                nhanVien.TenNV = (string)dtnhanvien.Rows[0].ItemArray[1];
                nhanVien.MaNH = (string)dtnhanvien.Rows[0].ItemArray[2];
                nhanVien.MaLoaiNhanVien = (string)dtnhanvien.Rows[0].ItemArray[3];
                nhanVien.Cmnd = (int)dtnhanvien.Rows[0].ItemArray[4];
                nhanVien.Sdt = (int)dtnhanvien.Rows[0].ItemArray[5];
                nhanVien.Username = (string)dtnhanvien.Rows[0].ItemArray[6];
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng!");
            }

        }
    }
}