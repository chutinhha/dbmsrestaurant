using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;

namespace GUI.QuanLyKho
{
    public partial class frmThemNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        NguyenLieu_DTO _nguyenlieu;
        public NguyenLieu_DTO NguyenLieu
        {
            get { return _nguyenlieu; }
            set { _nguyenlieu = value; }
        }
        public frmThemNguyenLieu()
        {
            InitializeComponent();
            _nguyenlieu = new NguyenLieu_DTO();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            _nguyenlieu.TenNL = txtTenNguyenLieu.Text;
            _nguyenlieu.Gia = Double.Parse(txtGia.Text);
            _nguyenlieu.DonVi = txtDonVi.Text;
        }
    }
}