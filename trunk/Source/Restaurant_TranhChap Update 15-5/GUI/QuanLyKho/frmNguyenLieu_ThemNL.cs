﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace GUI.QuanLyKho
{
    public partial class frmNguyenLieu_ThemNL : DevExpress.XtraEditors.XtraForm
    {
        NguyenLieu_DTO _nguyenlieu;
        public NguyenLieu_DTO NguyenLieu
        {
            get { return _nguyenlieu; }
            set { _nguyenlieu = value; }
        }
        public frmNguyenLieu_ThemNL()
        {
            InitializeComponent();
            _nguyenlieu = new NguyenLieu_DTO();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTenNguyenLieu.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên Nguyên Liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNguyenLieu.Focus();
            } 
            else
                if (txtDonVi.Text.Trim().Length == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập đơn vị nguyên liêu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonVi.Focus();
                }
                else
                {
                    _nguyenlieu.TenNL = txtTenNguyenLieu.Text.Trim();
                    _nguyenlieu.DonVi = txtDonVi.Text.Trim();
                    if (BUS.NguyenLieu_BUS.InsertNguyenLieu(NguyenLieu) == 1)
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }          
        }
    }
}