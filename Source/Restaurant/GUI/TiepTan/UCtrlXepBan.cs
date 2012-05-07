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

        public UCtrlXepBan()
        {
            InitializeComponent();
        }

        private void UCtrlXepBan_Load(object sender, EventArgs e)
        {
            dateNow.Text = DateTime.Now.ToString();
            LoadForm();
        }
        private void LoadForm()
        {
            tbBanAn = DatBan_BUS.DocBanTrong(maNH);
            tbBanDatTrongNgay = DatBan_BUS.DSBanDatTrongNgay(maNH, timeNow);
            LoadDuLieuListView();
        }
        private void LoadDuLieuListView()
        {
            lv_BanAn.Items.Clear();
            if (tbBanAn.Rows.Count > 0)
            {
                if (timeNow.Date == DateTime.Now.Date)
                {
                    for (int i = 0; i < tbBanAn.Rows.Count; i++)
                    {
                        DataRow row = tbBanAn.Rows[i];
                        ListViewItem item = new ListViewItem();
                        string maban = row["MaBan"].ToString();
                        item.Text = "Bàn " + maban;
                        item.ImageIndex = int.Parse(row["TrangThai"].ToString());
                        //neu co dsBanDat
                        if (tbBanDatTrongNgay.Rows.Count > 0)
                        {
                            for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                                if (maban == tbBanDatTrongNgay.Rows[j]["MaBan"].ToString())
                                {
                                    item.ImageIndex = 2;//Ban Dang duoc dat trong thoi gian Hien Tai
                                    break;
                                }
                        }
                        item.Tag = row;
                        lv_BanAn.Items.Add(item);
                    }
                }
                else//neu Chon ngay khac se hien thong tin DatBan cua ngay do.Neu co
                {
                    if (tbBanDatTrongNgay.Rows.Count > 0)
                    {
                        for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                        {
                            string maban = tbBanDatTrongNgay.Rows[j]["MaBan"].ToString();
                            ListViewItem item = new ListViewItem();
                            item.Text = "Bàn " + maban;
                            item.ImageIndex = 2;//Ban Dang duoc dat trong thoi gian Hien Tai
                            item.Tag = tbBanDatTrongNgay.Rows[j];
                            lv_BanAn.Items.Add(item);
                        }
                    }
                    
                }
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
            }
        }

        private void btnXepBanAn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tbBanAn.Rows.Count; i++)
            {
                if (int.Parse(rowSelect["MaBan"].ToString()) == int.Parse(tbBanAn.Rows[i]["MaBan"].ToString()))
                {
                    DataRow row = tbBanAn.Rows[i];
                    if (int.Parse(row["TrangThai"].ToString()) != 1 && timeNow.Date == DateTime.Now.Date)
                    {
                        //cap nhat tinh trang xuong csdl
                        DatBan_BUS.UpdateTrangThaiBanAn(int.Parse(row["MaBan"].ToString()),1);

                        //neu co trong bang Datban thi cap nhat lai Tinh trang
                        if (tbBanDatTrongNgay.Rows.Count > 0)
                        {
                            for (int j = 0; j < tbBanDatTrongNgay.Rows.Count; j++)
                                if (int.Parse(row["MaBan"].ToString()) == int.Parse(tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()))
                                {
                                    DatBan_BUS.UpdateTrangThaiDatBan(maNH,int.Parse( tbBanDatTrongNgay.Rows[j]["MaBan"].ToString()), 1, DateTime.Now);
                                }
                        }
                        //

                        row["TrangThai"] = 1;
                        //cap nhat len Listview
                        for (int j = 0; j < lv_BanAn.Items.Count; j++)
                        {
                            if (int.Parse(((DataRow)lv_BanAn.Items[j].Tag)["MaBan"].ToString()) ==int.Parse( row["MaBan"].ToString()))
                            {
                                lv_BanAn.Items[j].ImageIndex = 1;
                                break;
                            }
                        }
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bàn này không thể Xếp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

    }
}
