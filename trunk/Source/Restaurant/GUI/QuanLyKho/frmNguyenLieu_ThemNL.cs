using System;
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
            this.DialogResult = DialogResult.None;
            if (txtTenNguyenLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Nguyên Liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNguyenLieu.Focus();
            } 
            else
                if (txtGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập Giá cho nguyên liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGia.Focus();
                }
                else
                    if (txtDonVi.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập đơn vị nguyên liêu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDonVi.Focus();
                    }
                    else
                    {
                        _nguyenlieu.TenNL = txtTenNguyenLieu.Text.Trim();
                        _nguyenlieu.Gia = Double.Parse(txtGia.Text.Trim());
                        _nguyenlieu.DonVi = txtDonVi.Text.Trim();
                        if (BUS.NguyenLieu_BUS.InsertNguyenLieu(NguyenLieu) == 0)
                        {
                            MessageBox.Show("Tên nguyên liệu này đã có trong danh sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTenNguyenLieu.Focus();
                            this.DialogResult = DialogResult.None;
                        }
                        else
                            this.DialogResult = DialogResult.OK;
                    }          
        }
    }
}