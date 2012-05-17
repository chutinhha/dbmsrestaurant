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
    public partial class frmDatHang_ChonNCC : DevExpress.XtraEditors.XtraForm
    {
        #region " Thuoc tinh "
        VNhaCungCap_BUS busNhaCungCap;
        VNguyenLieu_BUS busNguyenLieu;

        String maNH;
        String tenNCC;
        int index_NCC;
        int sttNCC;
        int maNCC;
        List<VNhaCungCap_DTO> lsNCC;
        DataTable dtNCC;
        #endregion

        #region " properties "
        public VNhaCungCap_BUS BusNhaCungCap
        {
            get { return busNhaCungCap; }
            set { busNhaCungCap = value; }
        }
        public VNguyenLieu_BUS BusNguyenLieu
        {
            get { return busNguyenLieu; }
            set { busNguyenLieu = value; }
        }
        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
       
        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        
        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        #endregion

        #region " Khoi tao"
        public frmDatHang_ChonNCC()
        {
            InitializeComponent();
            busNhaCungCap = new VNhaCungCap_BUS();
            busNguyenLieu = new VNguyenLieu_BUS();
            
            lsNCC = new List<VNhaCungCap_DTO>();
            dtNCC = new DataTable();
            index_NCC = -1;
            dtNCC.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtNCC.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("sdt", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("DiemUuTien", System.Type.GetType("System.Int32"));

        }
        #endregion

        #region " Event control "
        private void btnDongY_Click(object sender, EventArgs e)
        {
            maNCC = lsNCC[sttNCC - 1].MaNCC;
            tenNCC = lsNCC[sttNCC - 1].TenNCC;
        }
        private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                index_NCC = gvNCC.GetSelectedRows()[0];
                sttNCC = int.Parse(gvNCC.GetDataRow(index_NCC)["STT"].ToString());
                LoadDanhSachNL(lsNCC[sttNCC - 1].MaNCC);
            }
            catch (Exception) { }
            
        }
        #endregion

        #region " Cac ham xu ly "
        public void LoadDanhSachNCC()
            {               
                gridNCC.DataSource = null;
                dtNCC.Rows.Clear();
                lsNCC = busNhaCungCap.SelectNhaCungCap_fromNH(maNH);
                for (int i = 0; i < lsNCC.Count; i++)
                {
                    DataRow row = dtNCC.NewRow();
                    row["STT"] = i + 1;
                    row["TenNCC"] = lsNCC[i].TenNCC;
                    row["sdt"] = lsNCC[i].sdt;
                    row["DiemUuTien"] = lsNCC[i].DiemUuTien;
                    dtNCC.Rows.Add(row);
                }
                gridNCC.DataSource = dtNCC;
            }
            public void LoadDanhSachNL(int MaNCC)
            {
                lvNguyenLieu.Items.Clear();
                
                DataTable dtNL = busNguyenLieu.SelectNguyenLieu_In_NCC(MaNCC, maNH);
                for (int i = 0; i < dtNL.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), dtNL.Rows[i]["TenNL"].ToString(),dtNL.Rows[i]["Gia"].ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
            }
        #endregion 

    }
}