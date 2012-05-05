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
        public UCtrlNguyenLieu()
        {
            InitializeComponent();
            lsNguyenLieu = new List<NguyenLieu_DTO>();
            dtNguyenLieu = new DataTable();
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
    }
}
