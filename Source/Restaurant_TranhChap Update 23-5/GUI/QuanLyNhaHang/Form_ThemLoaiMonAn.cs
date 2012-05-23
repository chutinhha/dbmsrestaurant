using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;

namespace GUI.QuanLyNhaHang
{
    public partial class Form_ThemLoaiMonAn : DevExpress.XtraEditors.XtraForm
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public LoaiMonAn_DTO loaiMonAn = new LoaiMonAn_DTO();
        public Form_ThemLoaiMonAn()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loaiMonAn.Tenloai = txtTenLoai.Text;
            loaiMonAn.Maloai = txtMaLoai.Text;
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}