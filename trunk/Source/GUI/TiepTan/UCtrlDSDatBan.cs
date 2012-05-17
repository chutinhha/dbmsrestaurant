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
using System.Data.SqlClient;


namespace GUI.TiepTan
{
    public partial class UCtrlDSDatBan : DevExpress.XtraEditors.XtraUserControl
    {
        int maNH = 1;
        int vitri;
        DataTable tbDatBan = new DataTable();
        //Khai bao 1 delegate
        public delegate void deleDatBan();
        public deleDatBan DatBan;
        //
        public DatBan_DTO banDat = new DatBan_DTO();
        DatBan_BUS DatBan_BUS = new DatBan_BUS();
        //
        SqlCommand cm;
        string maBan;
        string khuVuc;
        string sucChua;
        string trangThai;

        public UCtrlDSDatBan()
        {
            InitializeComponent();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            //khoi dong su kien dat ban
            if(DatBan!=null)
                DatBan();
        }
        public void LoadForm()
        {
           // CreateStructTable();
            tbDatBan.Rows.Clear();
            DocDatBan();
            gridDSDatBan.DataSource = tbDatBan;
            DocKhuVuc();
            DocLoaiBan();
            DocDanhSachBan();
            DocTinhTrang();
        }
        private void UCtrlDSDatBan_Load(object sender, EventArgs e)
        {
            CreateStructTable();
            LoadForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmCapNhatBanDat frm = new FrmCapNhatBanDat();
            frm.bandat = banDat;
            frm.cm = cm;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.flag > 0)
                {
                    banDat = frm.bandat;
                    tbDatBan.Rows[vitri]["MaBan"] = banDat.MaBan;
                    tbDatBan.Rows[vitri]["TenKhachHang"] = banDat.TenKhachHang;
                    tbDatBan.Rows[vitri]["MaKhachHang"] = banDat.MaKhachHang;
                    tbDatBan.Rows[vitri]["TrangThai"] = banDat.TrangThai; ;
                    tbDatBan.Rows[vitri]["ThoiGianDen"] = banDat.ThoiGianDen;
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void gridView_DatBan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int[] index = gridView_DatBan.GetSelectedRows();
            
            if (index.Length>0)
            {
                vitri = index[0];
                banDat.MaNH = maNH.ToString();
                banDat.MaBan = gridView_DatBan.GetRowCellValue(index[0], "MaBan").ToString();
                banDat.MaKhachHang = gridView_DatBan.GetRowCellValue(index[0], "MaKhachHang").ToString();
                banDat.ThoiGianDen = gridView_DatBan.GetRowCellValue(index[0], "ThoiGianDen").ToString();
                banDat.TrangThai = gridView_DatBan.GetRowCellValue(index[0], "TrangThai").ToString();
                banDat.Tenkhuvuc = gridView_DatBan.GetRowCellValue(index[0], "TenKhuVuc").ToString();
                banDat.Vitri = gridView_DatBan.GetRowCellValue(index[0], "ViTri").ToString();
                banDat.Succhua = gridView_DatBan.GetRowCellValue(index[0], "SucChua").ToString();
                banDat.ThoiGianDat = gridView_DatBan.GetRowCellValue(index[0], "ThoiGianDat").ToString();
            }
        }
        private void CreateStructTable()
        {
            tbDatBan.Columns.Add("MaBan", Type.GetType("System.String"));
            tbDatBan.Columns.Add("TenKhachHang", Type.GetType("System.String"));
            tbDatBan.Columns.Add("MaKhachHang", Type.GetType("System.String"));
            tbDatBan.Columns.Add("TenKhuVuc", Type.GetType("System.String"));
            tbDatBan.Columns.Add("SucChua", Type.GetType("System.String"));
           // tbDatBan.Columns.Add("Sdt", Type.GetType("System.String"));
            tbDatBan.Columns.Add("ThoiGianDen", Type.GetType("System.String"));
            tbDatBan.Columns.Add("ThoiGianDat", Type.GetType("System.String"));
            tbDatBan.Columns.Add("ViTri", Type.GetType("System.String"));
            tbDatBan.Columns.Add("TrangThai", Type.GetType("System.String"));
        }
        private void DocDatBan()
        {
            DataTable tbTemp = DatBan_BUS.DocDanhSachBanDat(maNH,maBan,khuVuc,sucChua,trangThai);
            if (tbTemp.Rows.Count > 0)
            {
                
                for (int i = 0; i < tbTemp.Rows.Count; i++)
                {
                    DataRow row = tbTemp.Rows[i];
                    Them1Ban(row);
                }
            }
        }
        
        private void DocKhuVuc()
        {
            cbbKhuVuc.Items.Clear();
            cbbKhuVuc.Items.Add("All");
            DataTable tb = DatBan_BUS.DocKhuVuc(maNH); ;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cbbKhuVuc.Items.Add(tb.Rows[i]["TenKhuVuc"].ToString());
            }
            cbbKhuVuc.SelectedIndex = 0;
        }
        private void DocLoaiBan()
        {
            cbB_LoaiBan.Items.Clear();
            cbB_LoaiBan.Items.Add("All");
            DataTable tb = DatBan_BUS.DocLoaiBan();
            for (int i = 0; i < tb.Rows.Count; i++)
                cbB_LoaiBan.Items.Add(tb.Rows[i]["SucChua"].ToString());
            cbB_LoaiBan.SelectedIndex = 0;
        }
        private void DocDanhSachBan()
        {
            cbB_MaBan.Items.Clear();
            cbB_MaBan.Items.Add("All");
            DataTable tb = DatBan_BUS.DocBanTrong(maNH);
            for (int i = 0; i < tb.Rows.Count; i++)
                cbB_MaBan.Items.Add(tb.Rows[i]["MaBan"].ToString());
            cbB_MaBan.SelectedIndex = 0;
        }
        private void DocTinhTrang()
        {
            cbB_TinhTrang.Items.Clear();
            cbB_TinhTrang.Items.Add("All");
            cbB_TinhTrang.Items.Add("Chưa đến ăn");
            cbB_TinhTrang.Items.Add("Đã đến ăn");
            cbB_TinhTrang.SelectedIndex = 0;
        }
        private void Them1Ban(DataRow row)
        {
            DataRow newrow = tbDatBan.NewRow();
            newrow["MaBan"] = row["MaBan"].ToString();
            newrow["TenKhachHang"] = row["TenKhachHang"].ToString();
            newrow["MaKhachHang"] = row["MaKhachHang"].ToString();
            newrow["TenKhuVuc"] = row["TenKhuVuc"].ToString();
            newrow["SucChua"] = row["SucChua"].ToString();
           // newrow["Sdt"] = banDat.Sdt;
            newrow["ThoiGianDen"] = DateTime.Parse( row["ThoiGianDen"].ToString()).ToString("dd/MM/yyyy");
            newrow["ThoiGianDat"] = DateTime.Parse( row["ThoiGianDat"].ToString()).ToString("dd/MM/yyyy");
            newrow["ViTri"] = row["ViTri"].ToString();
            newrow["TrangThai"] = row["TrangThai"].ToString();
            tbDatBan.Rows.Add(newrow);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if(tbDatBan.Rows.Count>0)
            {
                DialogResult t = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn hủy đặt bàn số " + tbDatBan.Rows[vitri]["MaBan"].ToString(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (t == DialogResult.OK)
                {
                    banDat.MaBan = tbDatBan.Rows[vitri]["MaBan"].ToString();
                    banDat.ThoiGianDen = tbDatBan.Rows[vitri]["ThoiGianDen"].ToString();

                    if (DatBan_BUS.XoaDatBan(banDat) > 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Hủy đặt bàn số "+tbDatBan.Rows[vitri]["MaBan"].ToString()+ " thành công" , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbDatBan.Rows.RemoveAt(vitri);
                        gridDSDatBan.DataSource = tbDatBan;
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Hủy đặt bàn số " + tbDatBan.Rows[vitri]["MaBan"].ToString() + " không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Không còn bàn để xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void cbB_MaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_MaBan.Text == "All")
                maBan = "";
            else
                maBan=" and b.maban="+cbB_MaBan.Text;
            tbDatBan.Rows.Clear();
            DocDatBan();
            gridDSDatBan.DataSource = tbDatBan;
        }

        private void cbB_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_TinhTrang.SelectedIndex == 0)
                trangThai = " ";
            else if (cbB_TinhTrang.SelectedIndex == 1)
                trangThai = " and d.TrangThai=0";
            else
                trangThai = " and d.TrangThai=1";

            tbDatBan.Rows.Clear();
            DocDatBan();
            gridDSDatBan.DataSource = tbDatBan;
        }

        private void cbbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhuVuc.SelectedIndex == 0)
                khuVuc = " ";
            else
                khuVuc = " and k.TenKhuVuc=N'" + cbbKhuVuc.Text + "'";

            tbDatBan.Rows.Clear();
            DocDatBan();
            gridDSDatBan.DataSource = tbDatBan;
        }

        private void cbB_LoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_LoaiBan.SelectedIndex == 0)
                sucChua = " ";
            else
                sucChua = " and l.SucChua = "+cbB_LoaiBan.Text;

            tbDatBan.Rows.Clear();
            DocDatBan();
            gridDSDatBan.DataSource = tbDatBan;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbDatBan.Rows.Clear();
            cm = new SqlCommand();//tao va lay Comman
            DocDatBanRefresh(ref cm);

            gridDSDatBan.DataSource = tbDatBan;

        }
        private void DocDatBanRefresh(ref SqlCommand cm)
        {
            DataTable tbTemp = DatBan_BUS.DocDanhSachBanDatRefresh(maNH, maBan, khuVuc, sucChua, trangThai,ref cm);
            if (tbTemp.Rows.Count > 0)
            {

                for (int i = 0; i < tbTemp.Rows.Count; i++)
                {
                    DataRow row = tbTemp.Rows[i];
                    Them1Ban(row);
                }
            }
        }
    }
}
