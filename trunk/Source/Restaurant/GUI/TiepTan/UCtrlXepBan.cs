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

namespace GUI.TiepTan
{
    public partial class UCtrlXepBan : DevExpress.XtraEditors.XtraUserControl
    {
        int maNH = 1;
        DataTable tbBanAn = new DataTable();
        DateTime timeNow = new DateTime();
        DataTable tbBanDatTrongNgay = new DataTable();
        DataRow rowSelect ;//lay thong tin dong duoc chon
        string khuvuc = "";
        string succhua = "";
        DatBan_BUS DatBan_BUS = new DatBan_BUS();
      //  int flag = 0;//1: ban an dc chon,2: dat ban dc chon
        public UCtrlXepBan()
        {
            InitializeComponent();
        }
        
        private void UCtrlXepBan_Load(object sender, EventArgs e)
        {
            DocKhuVuc();
            DocSucChua();
            dateNow.Text = DateTime.Now.ToString();
            LoadForm();
        }
        public void LoadForm()
        {
            tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay_OpenConnection(maNH, timeNow);
            tbBanAn = DatBan_BUS.DocBanAn_CloseConnection (maNH,khuvuc,succhua);
           
            LoadDuLieuListView();
           
        }
        private void DocKhuVuc()
        {
            cbbKhuVuc.Items.Clear();
            cbbKhuVuc.Items.Add("Tất cả");
            DataTable tb = DatBan_BUS.DocKhuVuc(maNH);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    cbbKhuVuc.Items.Add(tb.Rows[i]["TenKhuVuc"]);
                }
            }
            cbbKhuVuc.SelectedIndex = 0;
        }
        private void DocSucChua()
        {
            cbbSucChua.Items.Clear();
            cbbSucChua.Items.Add("Tất cả");
            DataTable tb = DatBan_BUS.DocSucChua(maNH);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                    cbbSucChua.Items.Add(tb.Rows[i]["SucChua"]);
            }
            cbbSucChua.SelectedIndex = 0;
        }
        private void LoadDuLieuListView()
        {
            lv_BanAn.Items.Clear();
            lv_BanDat.Items.Clear();
            if (tbBanAn.Rows.Count > 0)
            {
               // if (timeNow.Date == DateTime.Now.Date)
               // {
                    for (int i = 0; i < tbBanAn.Rows.Count; i++)
                    {
                        DataRow row = tbBanAn.Rows[i];
                        ListViewItem item = new ListViewItem();
                        string maban = row["MaBan"].ToString();
                        //neu co dsBanDat
                        item.Text = "Bàn " + maban;
                        item.Tag = row;
                        int flag = 0;
                        if (tbBanDatTrongNgay.Rows.Count > 0)
                        {
                            for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                            {
                                if (maban == tbBanDatTrongNgay.Rows[j]["MaBan"].ToString())
                                {
                                    if (row["TrangThai"].ToString() == "0")
                                    {
                                        flag = 1;
                                        break;
                                    }
                                }
                            }
                        }
                        if (flag == 0)
                        {
                            item.ImageIndex = int.Parse(row["TrangThai"].ToString());
                            lv_BanAn.Items.Add(item);
                        }
                        else
                        {
                            item.ImageIndex = 2;//Ban Dang duoc dat trong thoi gian Hien Tai
                                                        
                            lv_BanDat.Items.Add(item);
                        }
                      
                    }
               // }
              //  else//neu Chon ngay khac se hien thong tin DatBan cua ngay do.Neu co
              //  {
                //    if (tbBanDatTrongNgay.Rows.Count > 0)
                //    {
                //        for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                //        {
                //            string maban = tbBanDatTrongNgay.Rows[j]["MaBan"].ToString();
                //            ListViewItem item = new ListViewItem();
                //            item.Text = "Bàn " + maban;
                //            item.ImageIndex = 2;//Ban Dang duoc dat trong thoi gian Hien Tai
                //            item.Tag = tbBanDatTrongNgay.Rows[j];
                //            lvBanDat.Items.Add(item);
                //        }
                //    }
                    
                //}
            }
        }
        private void dateNow_EditValueChanged(object sender, EventArgs e)
        {
            timeNow = DateTime.Parse(dateNow.Text);
            LoadForm();
        }
        private void XemThongTin(DataRow row)
        {
            for (int i = 0; i < tbBanAn.Rows.Count; i++)
            {
                if ( int.Parse( row["MaBan"].ToString()) == int.Parse(tbBanAn.Rows[i]["MaBan"].ToString()))
                {
                    row = tbBanAn.Rows[i];
                    txtBanAn.Text="Bàn " + row["MaBan"];
                    txtKhuVuc.Text = row["TenKhuVuc"].ToString();
                    txtNhaHang.Text = row["TenNH"].ToString();
                    txtSucChua.Text = row["SucChua"].ToString();
                    txtViTri.Text = row["ViTri"].ToString();
                    break;
                }
            }
        }
        private void lv_BanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_BanAn.SelectedIndices.Count > 0)
            {
                rowSelect = (DataRow)lv_BanAn.SelectedItems[0].Tag;
                XemThongTin(rowSelect);
               // flag = 1;
            }
           
        }
        private void lv_BanDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_BanDat.SelectedIndices.Count > 0)
            {
                rowSelect = (DataRow)lv_BanDat.SelectedItems[0].Tag;
                XemThongTin(rowSelect);
               // flag = 2;
            }
        }
        private void btnXepBanAn_Click(object sender, EventArgs e)
        {
            if (rowSelect != null)
            {
                for (int i = 0; i < tbBanAn.Rows.Count; i++)
                {
                    if (int.Parse(rowSelect["MaBan"].ToString()) == int.Parse(tbBanAn.Rows[i]["MaBan"].ToString()))
                    {
                        DataRow row = tbBanAn.Rows[i];
                        if (int.Parse(row["TrangThai"].ToString()) != 1 && timeNow.Date == DateTime.Now.Date)
                        {
                            //cap nhat tinh trang xuong csdl
                            DatBan_BUS.UpdateTrangThaiBanAn(int.Parse(row["MaBan"].ToString()), 1);

                            //neu co trong bang Datban thi cap nhat lai Tinh trang
                            if (tbBanDatTrongNgay.Rows.Count > 0)
                            {
                                for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                                    if (int.Parse(row["MaBan"].ToString()) == int.Parse(tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()))
                                    {
                                        DatBan_BUS.UpdateTrangThaiDatBan(maNH, int.Parse(tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()), 1, DateTime.Now);
                                    }
                            }
                            //
                            LoadForm();
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bàn này không thể Xếp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
        }

        private void cbbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhuVuc.SelectedIndex == 0)
                khuvuc = " ";
            else
            {
                khuvuc = " and tenkhuvuc=N'" + cbbKhuVuc.Text+"'" ;
            }
            tbBanAn = DatBan_BUS.DocBanAn(maNH, khuvuc, succhua);
            LoadDuLieuListView();
        }

        private void cbbSucChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSucChua.SelectedIndex == 0)
                succhua = " ";
            else
                succhua = " and succhua="+cbbSucChua.Text;
            tbBanAn = DatBan_BUS.DocBanAn(maNH, khuvuc, succhua);
            LoadDuLieuListView();
        }

        private void btnDocBanAn_Click(object sender, EventArgs e)
        {
            tbBanAn = DatBan_BUS.DocBanAn_CloseConnection2(maNH, khuvuc, succhua);
           // tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay_CloseConnection(maNH, timeNow);
           lv_BanAn.Items.Clear();
            if (tbBanAn.Rows.Count > 0)
            {
                // if (timeNow.Date == DateTime.Now.Date)
                // {
                for (int i = 0; i < tbBanAn.Rows.Count; i++)
                {
                    DataRow row = tbBanAn.Rows[i];
                    ListViewItem item = new ListViewItem();
                    string maban = row["MaBan"].ToString();
                    //neu co dsBanDat
                    item.Text = "Bàn " + maban;
                    item.Tag = row;
                    item.ImageIndex = int.Parse(row["TrangThai"].ToString());
                    lv_BanAn.Items.Add(item);
       
                }
            }
        }
        private void btnDocDatBan_Click(object sender, EventArgs e)
        {
           // tbBanAn = DatBan_BUS.DocBanAn_OpenConnection(maNH, khuvuc, succhua);
            tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay_OpenConnection(maNH, timeNow);
            lv_BanAn.Items.Clear();
            lv_BanDat.Items.Clear();
            if (tbBanDatTrongNgay.Rows.Count > 0)
            {
                // if (timeNow.Date == DateTime.Now.Date)
                // {
                for (int i = 0; i < tbBanDatTrongNgay.Rows.Count; i++)
                {
                    DataRow row = tbBanDatTrongNgay.Rows[i];
                    ListViewItem item = new ListViewItem();
                    string maban = row["MaBan"].ToString();
                    //neu co dsBanDat
                    item.Text = "Bàn " + maban;
                    item.Tag = row;
                    item.ImageIndex = 2;
                    lv_BanDat.Items.Add(item);

                }
            }
        }
        private void btnDocBanAn_begin_Click(object sender, EventArgs e)
        {
           // tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay(maNH, timeNow);
            tbBanAn = DatBan_BUS.DocBanAn_OpenConnection(maNH, khuvuc, succhua);
            LoadDuLieuListView();
        }

        private void btnXepBanAn_Commit_Click(object sender, EventArgs e)
        {
            if (rowSelect != null)
            {
                for (int i = 0; i < tbBanAn.Rows.Count; i++)
                {
                    if (int.Parse(rowSelect["MaBan"].ToString()) == int.Parse(tbBanAn.Rows[i]["MaBan"].ToString()))
                    {
                        DataRow row = tbBanAn.Rows[i];
                        if (int.Parse(row["TrangThai"].ToString()) != 1 && timeNow.Date == DateTime.Now.Date)
                        {
                            //cap nhat tinh trang xuong csdl
                            DatBan_BUS.UpdateTrangThaiBanAn_CommitTran(int.Parse(row["MaBan"].ToString()), 1);

                            //neu co trong bang Datban thi cap nhat lai Tinh trang
                            //if (tbBanDatTrongNgay.Rows.Count > 0)
                            //{
                            //    for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                            //        if (int.Parse(row["MaBan"].ToString()) == int.Parse(tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()))
                            //        {
                            //            DatBan_BUS.UpdateTrangThaiDatBan(maNH, int.Parse(tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()), 1, DateTime.Now);
                            //        }
                            //}
                            //
                            LoadForm();
                           
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bàn này không thể Xếp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay_OpenConnection(maNH, timeNow);
            lv_BanAn.Items.Clear();
            lv_BanDat.Items.Clear();
            if (tbBanDatTrongNgay.Rows.Count > 0)
            {
                // if (timeNow.Date == DateTime.Now.Date)
                // {
                for (int i = 0; i < tbBanDatTrongNgay.Rows.Count; i++)
                {
                    DataRow row = tbBanDatTrongNgay.Rows[i];
                    ListViewItem item = new ListViewItem();
                    string maban = row["MaBan"].ToString();
                    //neu co dsBanDat
                    item.Text = "Bàn " + maban;
                    item.Tag = row;
                    item.ImageIndex = 2;
                    lv_BanDat.Items.Add(item);

                }
            }

            tbBanAn = DatBan_BUS.DocBanAn_CloseConnection2(maNH, khuvuc, succhua);
            // tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay_CloseConnection(maNH, timeNow);
            lv_BanAn.Items.Clear();
            if (tbBanAn.Rows.Count > 0)
            {
                // if (timeNow.Date == DateTime.Now.Date)
                // {
                for (int i = 0; i < tbBanAn.Rows.Count; i++)
                {
                    DataRow row = tbBanAn.Rows[i];
                    ListViewItem item = new ListViewItem();
                    string maban = row["MaBan"].ToString();
                    //neu co dsBanDat
                    item.Text = "Bàn " + maban;
                    item.Tag = row;
                    item.ImageIndex = int.Parse(row["TrangThai"].ToString());
                    lv_BanAn.Items.Add(item);

                }
            }

        }
    }
}
