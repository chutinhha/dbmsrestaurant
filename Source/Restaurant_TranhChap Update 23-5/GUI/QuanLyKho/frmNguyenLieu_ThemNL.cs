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
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        VNguyenLieu_BUS busNguyenLieu;
        VNguyenLieu_DTO _nguyenlieu;
        public VNguyenLieu_DTO NguyenLieu
        {
            get { return _nguyenlieu; }
            set { _nguyenlieu = value; }
        }
        public frmNguyenLieu_ThemNL()
        {
            InitializeComponent();

            busNguyenLieu = new VNguyenLieu_BUS();
            _nguyenlieu = new VNguyenLieu_DTO();
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
                    DevExpress.Utils.WaitDialogForm frmWailt = new DevExpress.Utils.WaitDialogForm("...", "Đang thêm nguyên liệu mới ");
                    frmWailt.LookAndFeel.SetSkinStyle("Seven Classic");
                    frmWailt.Show();
                    if (busNguyenLieu.InsertNguyenLieu(mode, NguyenLieu) == 1)
                    {
                        frmWailt.Close();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frmWailt.Close();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }      
        }
    }
}