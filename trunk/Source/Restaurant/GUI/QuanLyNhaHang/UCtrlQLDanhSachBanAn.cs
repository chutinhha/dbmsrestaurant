using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlQLDanhSachBanAn : DevExpress.XtraEditors.XtraUserControl
    {
        public string[] ArrayMaBan;
        public UCtrlQLDanhSachBanAn()
        {
            InitializeComponent();
        }

        private void UCtrlQLDanhSachBanAn_Load(object sender, EventArgs e)
        {
            gridLoaiBA.DataSource = LoaiBanAn_BUS.DocLoaiBanAn();
            gridKhuVuc.DataSource = KhuVuc_BUS.DocKhuVuc();
            gridBanAn.DataSource = BanAn_BUS.DocBanAn();

            DataTable dt = LoaiBanAn_BUS.DocLoaiBanAn();
            if (dt.Rows.Count > 0)
            {
                ArrayMaBan = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ArrayMaBan[i] = dr[0].ToString(); ;

                }
            }
        }

        private void btnThemLoaiBA_Click(object sender, EventArgs e)
        {
            ThemLoaiBanAn();
        }

        public void ThemLoaiBanAn()
        {
            Form_ThemLoaiBanAn openf = new Form_ThemLoaiBanAn();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                LoaiBanAn_BUS.ThemLoaiBanAn(openf.LoaiBA);
                gridLoaiBA.DataSource = LoaiBanAn_BUS.DocLoaiBanAn();
            }
        }

        private void btnCapNhatLoaiBA_Click(object sender, EventArgs e)
        {
            CapNhatLoaiBA();
            gridLoaiBA.DataSource = LoaiBanAn_BUS.DocLoaiBanAn();
        }

        public void CapNhatLoaiBA()
        {
            int flag = 0;
            int[] index = gridView_LoaiBanAn.GetSelectedRows();
            if (index.Length > 0)
            {
                
                string maloai = gridView_LoaiBanAn.GetRowCellValue(index[0], "Maloai").ToString();
                string sucChua = gridView_LoaiBanAn.GetRowCellValue(index[0], "SucChua").ToString();
                if (maloai != null)
                {
                    DTO.LoaiBanAn_DTO loaiBA = new DTO.LoaiBanAn_DTO();
                    loaiBA.MaLoai = maloai;
                    loaiBA.SucChua =int.Parse(sucChua);
                    flag = LoaiBanAn_BUS.CapNhatLoaiBA(loaiBA);
                }
            }
            if (flag != 0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaLoaiBA_Click(object sender, EventArgs e)
        {
            XoaLoaiBanAn();
            gridLoaiBA.DataSource= LoaiBanAn_BUS.DocLoaiBanAn();
        }

        public void XoaLoaiBanAn()
        {
            int flag = 0;
            int[] index = gridView_LoaiBanAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maloai = gridView_LoaiBanAn.GetRowCellValue(index[0], "Maloai").ToString();
                    flag = LoaiBanAn_BUS.XoaLoaiBanAn(maloai);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại Bàn Ăn khi còn Bàn Ăn trong Loại Bàn Ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            Form_ThemKhuVuc openf = new Form_ThemKhuVuc();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                KhuVuc_BUS.ThemKhuVuc(openf.KhuVuc);
                gridKhuVuc.DataSource = KhuVuc_BUS.DocKhuVuc();
            }
        }

        private void btnCapNhatKhuVuc_Click(object sender, EventArgs e)
        {
            CapNhatKhuVuc();
            gridKhuVuc.DataSource = KhuVuc_BUS.DocKhuVuc();
        }

        public void CapNhatKhuVuc()
        {
            int flag = 0;
            int[] index = gridView_KhuVuc.GetSelectedRows();
            if (index.Length > 0)
            {

                string maKhuVuc = gridView_KhuVuc.GetRowCellValue(index[0], "MaKhuVuc").ToString();
                string tenKhuVuc = gridView_KhuVuc.GetRowCellValue(index[0], "TenKhuVuc").ToString();
                string viTri = gridView_KhuVuc.GetRowCellValue(index[0], "ViTri").ToString();
                if (maKhuVuc != null)
                {
                    DTO.KhuVuc_DTO KhuVuc = new DTO.KhuVuc_DTO();
                    KhuVuc.MaKhuVuc = int.Parse(maKhuVuc);
                    KhuVuc.TenKhuVuc = tenKhuVuc;
                    KhuVuc.ViTri = viTri;
                    flag = KhuVuc_BUS.CapNhatKhuVuc(KhuVuc);
                }
            }
            if (flag != 0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaKhuVuc_Click(object sender, EventArgs e)
        {
            XoaKhuVuc();
            gridKhuVuc.DataSource = KhuVuc_BUS.DocKhuVuc();
        }

        public void XoaKhuVuc()
        {
            int flag = 0;
            int[] index = gridView_KhuVuc.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maKhuVuc = gridView_KhuVuc.GetRowCellValue(index[0], "MaKhuVuc").ToString();
                    flag = KhuVuc_BUS.XoaKhuVuc(maKhuVuc);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Khu Vực khi còn Bàn Ăn thuộc Khu Vực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            Form_ThemBanAn openf = new Form_ThemBanAn();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                BanAn_BUS.ThemBanAn(openf.BanAn);
                gridBanAn.DataSource = BanAn_BUS.DocBanAn();
            }
        }

        private void btnCapNhatBanAn_Click(object sender, EventArgs e)
        {
            CapNhaBanAn();
            gridBanAn.DataSource = BanAn_BUS.DocBanAn();
        }

        public void CapNhaBanAn()
        {
            int flag = 0;
            int[] index = gridView_BanAn.GetSelectedRows();
            if (index.Length > 0)
            {

                string maBanAn = gridView_BanAn.GetRowCellValue(index[0], "MaBan").ToString();
               // string maKV = gridView_BanAn.GetRowCellValue(index[0], "MaKhuVuc").ToString();
                string TrangThai = gridView_BanAn.GetRowCellValue(index[0], "TrangThai").ToString();
                if (maBanAn != null)
                {
                    DTO.BanAn_DTO BanAn = new DTO.BanAn_DTO();
                   BanAn.MaBan = int.Parse(maBanAn);
                  // BanAn.MaKhuVuc = int.Parse(maKV);
                   BanAn.TrangThai = int.Parse(TrangThai);
                    flag = BanAn_BUS.CapNhatBanAn(BanAn);
                }
            }
            if (flag != 0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaBanAn_Click(object sender, EventArgs e)
        {
            XoaBanAn();
            gridBanAn.DataSource = BanAn_BUS.DocBanAn();
        }

        public void XoaBanAn()
        {
            int flag = 0;
            int[] index = gridView_BanAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maBanAn = gridView_BanAn.GetRowCellValue(index[0], "MaBan").ToString();
                    flag = BanAn_BUS.XoaBanAn(maBanAn);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Khu Vực khi còn Bàn Ăn thuộc Khu Vực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
    }
}
