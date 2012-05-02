﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlQLThucDon : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiMonAn_BUS loaiMonAn;
        
        public UCtrlQLThucDon()
        {
            InitializeComponent();
            loaiMonAn = new LoaiMonAn_BUS();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
            gridLoaiMonAn.DataSource = loaiMonAn.DocLoaiMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn();
        }

        private void btnThemLoaiMA_Click(object sender, EventArgs e)
        {
            ThemLoaiMonAn();
        }
        private void btnCapNhatLoaiMA_Click(object sender, EventArgs e)
        {
            CapNhatLoaiMonAn();
        }
        private void btnXoaLoaiMA_Click(object sender, EventArgs e)
        {
            XoaLoaiMonAn();
            gridLoaiMonAn.DataSource = loaiMonAn.DocLoaiMonAn();
        }
        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            XoaMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn();
        }

        #region cac Ham ThemXoaSua

        private void CapNhatLoaiMonAn()
        {
            int flag = 0;
            int[] index= gridView_LoaiMonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "TenLoai").ToString();
                string maloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "MaLoai").ToString();
               
                if (maloai != null)
                {
                    DTO.LoaiMonAn_DTO loaiMonAn = new LoaiMonAn_DTO();
                    loaiMonAn.Maloai = maloai;
                    loaiMonAn.Tenloai = tenloai;
                   flag= LoaiMonAn_BUS.CapNhatLoaiMonAn(loaiMonAn);
                }
            }
            if(flag!=0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void XoaLoaiMonAn()
        {
            int flag = 0;
            int[] index= gridView_LoaiMonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "MaLoai").ToString();
                    flag= LoaiMonAn_BUS.XoaLoaiMonAn(maloai);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại món ăn khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        private void ThemLoaiMonAn()
        {
            Form_ThemLoaiMonAn openForm = new Form_ThemLoaiMonAn();
            if (openForm.ShowDialog() == DialogResult.OK)
            {
                LoaiMonAn_BUS.ThemLoaiMonAn(openForm.loaiMonAn);
                gridLoaiMonAn.DataSource = loaiMonAn.DocLoaiMonAn();
            }
        }
        ////
        private void XoaMonAn()
        {
            int flag = 0;
            int[] index = gridView_MonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maloai = gridView_MonAn.GetRowCellValue(index[0], "MaMon").ToString();
                    
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại món ăn khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion


    }
}
