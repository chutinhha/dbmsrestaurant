using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.QuanLyNhaHang
{
    public partial class Form_ThemLoaiNhanVien : Form
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        String maNH;
        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }

        public LoaiNhanVien_DTO loaiNV = new LoaiNhanVien_DTO();
        public Form_ThemLoaiNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            loaiNV.MaLoaiNV = txtMaLoai.Text;
            loaiNV.TenLoaiNV = txtTenLoaiNV.Text;
            loaiNV.Luong =long.Parse(txtLuong.Text);
            if (LoaiNhanVien_BUS.KiemTraMaLoai(txtMaLoai.Text) == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Mã Loại Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else if (LoaiNhanVien_BUS.KiemTraTenLoai(txtTenLoaiNV.Text) == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tên Mã Loại Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
