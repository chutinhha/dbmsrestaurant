using System;
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
        DatBan_DTO banDat = new DatBan_DTO();
        int chon;
        int[] ArrayMaMon;
        public UCtrlQLThucDon()
        {
            InitializeComponent();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
            gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn();

            DataTable dt = MonAn_BUS.DocMonAn();
            if (dt.Rows.Count > 0)
            {
                ArrayMaMon = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ArrayMaMon[i] = (int)dr[0];
                }
            }
        }

        private void btnThemLoaiMA_Click(object sender, EventArgs e)
        {
            ThemLoaiMonAn();
        }
        private void btnCapNhatLoaiMA_Click(object sender, EventArgs e)
        {
            CapNhatLoaiMonAn();
            gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
        }
        private void btnXoaLoaiMA_Click(object sender, EventArgs e)
        {
            XoaLoaiMonAn();
            gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
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
                gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
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
                    chon = index[0];
                    int maMon = ArrayMaMon[chon];
                    flag = MonAn_BUS.XoaMonAn(maMon);

                    
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại món ăn khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            ThemMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn();
        }

        public void ThemMonAn()
        {
            Form_ThemMonAn openf = new Form_ThemMonAn();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                MonAn_BUS.ThemMonAn(openf.MonAn);
                gridMonAn.DataSource = MonAn_BUS.DocMonAn();
            }

        }

        private void btnCapNhatMonAn_Click(object sender, EventArgs e)
        {
            CapNhatMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn();
        }

        public void CapNhatMonAn()
        {
            int flag = 0;
            int[] index = gridView_MonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenMon = gridView_MonAn.GetRowCellValue(index[0], "TenMon").ToString();
                //  string maloai = gridView_MonAn.GetRowCellValue(index[0], "LoaiMon").ToString();
                string gia = gridView_MonAn.GetRowCellValue(index[0], "Gia").ToString();
                string donvitinh = gridView_MonAn.GetRowCellValue(index[0], "DonViTinh").ToString();
                //  string maNH = gridView_MonAn.GetRowCellValue(index[0], "MaNH").ToString();

                if (tenMon != null)
                {
                    DTO.MonAn_DTO MonAn = new MonAn_DTO();
                    MonAn.tenmon = tenMon;
                    //  MonAn.MaLoai = maloai;
                    MonAn.Gia =double.Parse( gia);
                    MonAn.Dvtinh= donvitinh;
                    //  MonAn.MaNhaHang = maNH;        dang can nhac

                    chon = index[0];
                    int tt = ArrayMaMon[chon];
                    flag = MonAn_BUS.CapNhatMonAn(MonAn, tt);
                }
            }
            if (flag != 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
