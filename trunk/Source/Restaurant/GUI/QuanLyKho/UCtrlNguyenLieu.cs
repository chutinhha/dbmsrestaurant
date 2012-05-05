using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BUS;
using DTO;
namespace GUI.QuanLyKho
{
    public partial class UCtrlNguyenLieu : DevExpress.XtraEditors.XtraUserControl
    {
        List<NguyenLieu_DTO> lsNguyenLieu;
        DataTable dtNguyenLieu ;
        int indexNL;
        public UCtrlNguyenLieu()
        {
            InitializeComponent();
            lsNguyenLieu = new List<NguyenLieu_DTO>();
            dtNguyenLieu = new DataTable();
            indexNL = -1;
        }

        private void UCtrlNguyenLieu_Load(object sender, EventArgs e)
        {
            dtNguyenLieu.Columns.Add("TenNL",System.Type.GetType("System.String"));
            dtNguyenLieu.Columns.Add("Gia", System.Type.GetType("System.Double"));
            dtNguyenLieu.Columns.Add("DonVi",System.Type.GetType("System.String"));
            dtNguyenLieu.Columns.Add("SoLuongTon", System.Type.GetType("System.Int32"));
            lsNguyenLieu = NguyenLieu_BUS.SelectNguyenLieu("1");
           
            for (int i = 0; i < lsNguyenLieu.Count; i++)
            {
                DataRow row = dtNguyenLieu.NewRow();
                row["TenNL"] = lsNguyenLieu[i].TenNL;
                row["Gia"] = lsNguyenLieu[i].Gia;
                row["DonVi"] = lsNguyenLieu[i].DonVi;
                row["SoLuongTon"] = lsNguyenLieu[i].SoLuongTon;
                dtNguyenLieu.Rows.Add(row);
            }
            gridNguyenLieu.DataSource = dtNguyenLieu;
        }
        private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            indexNL = gvNguyenLieu.GetSelectedRows()[0];
            if (indexNL != -1)
            {
                txtTenNguyenLieu.Text = lsNguyenLieu[indexNL].TenNL;
                txtDonVi.Text = lsNguyenLieu[indexNL].DonVi;
                txtGia.Text = lsNguyenLieu[indexNL].Gia.ToString();
                txtSoLuongTon.Text = lsNguyenLieu[indexNL].SoLuongTon.ToString();
            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu _frmThemNL = new frmThemNguyenLieu();
            if (_frmThemNL.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dtNguyenLieu.NewRow();
                row["TenNL"] = _frmThemNL.NguyenLieu.TenNL;
                row["Gia"] = _frmThemNL.NguyenLieu.Gia;
                row["DonVi"] = _frmThemNL.NguyenLieu.DonVi;
                row["SoLuongTon"] = 0;
                dtNguyenLieu.Rows.Add(row);
            }
            _frmThemNL.NguyenLieu.MaNH = "1";
            lsNguyenLieu.Add(_frmThemNL.NguyenLieu);
        }
    }
}
