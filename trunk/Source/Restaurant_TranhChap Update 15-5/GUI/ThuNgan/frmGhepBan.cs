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
using DevExpress.XtraEditors.Controls;

namespace GUI.ThuNgan
{
    public partial class frmGhepBan : DevExpress.XtraEditors.XtraForm
    {
        public frmGhepBan()
        {
            InitializeComponent();
        }
        DataTable dtBanDangAn;      //maban, tglap, mahd
        int indexBanDangAn;
        public int Mode;


        List<BanAn_DTO> lsBan;
        int indexBan;

        private void frmGhepBan_Load(object sender, EventArgs e)
        {
            indexBanDangAn = indexBan = -1;
            
            dtBanDangAn = HoaDon_BUS.SelectHoaDonTrong();
            load_Listview_BanDangDung();
            
            //thực tế thì có thể ghép các bàn đang ăn vào 1 bàn đang ăn
            //nhưng ở đây chỉ cho ghép vào 1 bàn trống => xuất hiện lost update
            lsBan = BanAn_BUS.selectBanAnTheoTrangThai(0, int.Parse(frmMain.nhanVien.MaNH.Trim()), Mode);
            load_CbboxBanTrong();
        }

        private void load_CbboxBanTrong()
        {
            ComboBoxItemCollection coll = cbboxChuyenVaoBan.Properties.Items;
            coll.BeginUpdate();

            for(int i=0; i<lsBan.Count; i++){
                String content = "Bàn " + lsBan[i].MaBan;
                coll.Add(content);
                coll.EndUpdate();
            }
        }

        private void load_Listview_BanDangDung()
        {
            listViewDSBanDangDung.Items.Clear();
            foreach (DataRow row in dtBanDangAn.Rows)
            {
                ListViewItem item = new ListViewItem("Bàn " + (int)row.ItemArray[0]);
                item.SubItems.Add(((DateTime)row.ItemArray[1]).ToString());
                listViewDSBanDangDung.Items.Add(item);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (listViewDSBanDangDung.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewDSBanDangDung.SelectedItems)
                {
                    int index = item.Index;
                    DataRow row = dtBanDangAn.Rows[index];
                    int banSeAdd = (int)row.ItemArray[0];
                    //kiem tra trong ds ben phai xem ban da duoc add qua chua
                    bool datontan = false;
                    foreach(ListViewItem item_ghep in listViewDSBanGhep.Items ){
                        if (item_ghep.Text == banSeAdd.ToString())
                        {
                            datontan = true;
                            break;
                        }
                    }
                    if (!datontan)
                    {
                        ListViewItem newitem = new ListViewItem(banSeAdd.ToString());
                        newitem.SubItems.Add(((DateTime)row.ItemArray[1]).ToString());
                        newitem.SubItems.Add(((int)row.ItemArray[2]).ToString());
                        listViewDSBanGhep.Items.Add(newitem);
                    }
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (listViewDSBanGhep.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listViewDSBanGhep.SelectedItems){
                    int index = item.Index;

                    listViewDSBanGhep.Items.RemoveAt(index);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public delegate void common_void_delegate();
        public common_void_delegate reloadListboxBanAn;
        private void btnDongY_Click(object sender, EventArgs e)
        {
            int count = listViewDSBanGhep.Items.Count;
            if (count <= 1)
            {
                MessageBox.Show("Ban phai chon it nhat 2 ban de ghep.");
                return;
            }

            if (indexBan != -1)
            {
                int mabanNew = lsBan[indexBan].MaBan;

                int maHDchon = int.Parse(listViewDSBanGhep.Items[0].SubItems[2].Text);
                int maBanchon_old = int.Parse(listViewDSBanGhep.Items[0].SubItems[0].Text);
                BanAn_BUS.UpdateTrangThaiBanAn(maBanchon_old,0);

                //doc lai cthd cua maHDchon de len danh sach kiem tra trung khoa chinh
                DataTable dtCthdChon = ChiTietHoaDon_BUS.SelectTableCTHD(maHDchon);

                for (int i = 1; i < count; i++)
                {
                    int maHDold = int.Parse(listViewDSBanGhep.Items[i].SubItems[2].Text);
                    int maBanold = int.Parse(listViewDSBanGhep.Items[i].SubItems[0].Text);

                    //giai phong cac ban cu
                    BanAn_BUS.UpdateTrangThaiBanAn(maBanold, 0);
                    
                    //voi moi maHDold, cong don chi tiet hoa don, kiem tra khoa chinh
                    DataTable dtCthdOld = ChiTietHoaDon_BUS.SelectTableCTHD(maHDold);
                    foreach (DataRow row in dtCthdOld.Rows)
                    {
                        int n = dtCthdChon.Rows.Count;
                        bool duplicate = false;
                        //chen cac dong cua cthoadon cu vao ct hoa don chung
                        //cong don so luong va thanh tien neu co mon an trung nhau
                        for (int j = 0; j < n; j++)
                        {
                            if ((int)dtCthdChon.Rows[j].ItemArray[1] == (int)row.ItemArray[1])
                            {
                                duplicate = true;
                                int tongsl = (int)dtCthdChon.Rows[j].ItemArray[2] + (int)row.ItemArray[2];
                                DataRow newRow = dtCthdChon.NewRow();
                                newRow[0] = maHDchon;
                                newRow[1] = (int)dtCthdChon.Rows[j].ItemArray[1];
                                newRow[2] = tongsl;
                                newRow[3] = 0;      //tong tien se duoc tu dong tinh lai khi insert CTHD
                                dtCthdChon.Rows.Add(newRow);
                                dtCthdChon.Rows.RemoveAt(j);
                                break;
                            }
                        }

                        if (!duplicate)
                        {
                            //chen dong
                            DataRow newRow = dtCthdChon.NewRow();
                            newRow[0] = maHDchon;
                            newRow[1] = (int)row.ItemArray[1];
                            newRow[2] = (int)row.ItemArray[2];
                            newRow[3] = (double)row.ItemArray[3];
                            dtCthdChon.Rows.Add(newRow);
                        }
                    }
                    //xoa cthd cu
                    ChiTietHoaDon_BUS.DeleteCTHDtheoMaHD(maHDold);
                    //xoa hoa don cu
                    HoaDon_BUS.DeleteHoaDon(maHDold);
                }       //ket thuc vong lap cho cac ban ghep (tru ban dau)
                //xoa cthd moi (vi dtCthdChon da chua tat ca)       ;   nhu vay toan bo CTHD da dc xoa
                ChiTietHoaDon_BUS.DeleteCTHDtheoMaHD(maHDchon);

                //cap nhat hoa don chung
                HoaDon_BUS.UpdateMaBan(maHDchon, mabanNew);
                
                BanAn_BUS.UpdateTrangThaiBanAn(mabanNew, 1);
                //insert cac cthd moi
                foreach(DataRow row in dtCthdChon.Rows ){
                    ChiTietHoaDon_BUS.insertCTHD((int)row.ItemArray[0], (int)row.ItemArray[1], (int)row.ItemArray[2], Mode);
                }

                reloadListboxBanAn();
                this.Close();
            }
            else
                MessageBox.Show("Vui long chon ban muon ghep den.");
        }

        private void cbboxChuyenVaoBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBan = cbboxChuyenVaoBan.SelectedIndex;
        }

        private void listViewDSBanDangDung_DoubleClick(object sender, EventArgs e)
        {
            simpleButton1_Click(null, null);
        }

    }
}