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
    public partial class frmThemMonAn : DevExpress.XtraEditors.XtraForm
    {
        public frmThemMonAn()
        {
            InitializeComponent();
        }

        public int Mode;
        public int maHD;
        private DataTable dtLoaiMonAn;
        DataTable dtMonAn;
        public DataTable dtMonAnChon;
        private void frmThemMonAn_Load(object sender, EventArgs e)
        {
            dtLoaiMonAn = LoaiMonAn_BUS.DocLoaiMonAn();
            ComboBoxItemCollection coll = cboLoaiMonAn.Properties.Items;
            coll.BeginUpdate();
            
            foreach(DataRow row in dtLoaiMonAn.Rows ){
                coll.Add((String)row.ItemArray[1]);
                coll.EndUpdate();
            }
            //cboLoaiMonAn.SelectedIndex = 0;

            dtMonAn = new DataTable();
            dtMonAnChon = new DataTable();

            dtMonAnChon.Columns.Add("MaMon", System.Type.GetType("System.Int32"));
            dtMonAnChon.Columns.Add("TenMon", System.Type.GetType("System.String"));
            dtMonAnChon.Columns.Add("DonViTinh", System.Type.GetType("System.String"));
            dtMonAnChon.Columns.Add("SoLuong", System.Type.GetType("System.Int32"));
            dtMonAnChon.Columns.Add("Gia", System.Type.GetType("System.Double"));
        }

        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboLoaiMonAn.SelectedIndex;
            String maLoaiMonAn = (String)dtLoaiMonAn.Rows[index].ItemArray[0];

            dtMonAn = MonAn_BUS.SelectMonAnTheoLoai(maLoaiMonAn, frmMain.nhanVien.MaNH.Trim());
            listViewDSMonAn.Items.Clear();
            foreach (DataRow row in dtMonAn.Rows)
            {
                ListViewItem item = new ListViewItem((String)row.ItemArray[1]);
                item.SubItems.Add(((double)row.ItemArray[3]).ToString());
                listViewDSMonAn.Items.Add(item);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (listViewDSMonAn.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewDSMonAn.SelectedItems)
                {
                    int index = item.Index;
                    DataRow row = dtMonAn.Rows[index];

                    DataRow rownew = dtMonAnChon.NewRow();
                    rownew["MaMon"] = row.ItemArray[0];
                    rownew["TenMon"] = row.ItemArray[1];
                    rownew["DonViTinh"] = row.ItemArray[4];
                    rownew["SoLuong"] = 1;
                    rownew["Gia"] = row.ItemArray[3];
                    dtMonAnChon.Rows.Add(rownew);
                }
                gridControlChon.DataSource = dtMonAnChon;
            }
        }

        int indexSL = -1;
        private void gridViewChon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            indexSL = gridViewChon.GetSelectedRows()[0];
            if (indexSL != -1)
            {
                textEditSL.Text = dtMonAnChon.Rows[indexSL].ItemArray[3].ToString();
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //xoa va chen moi
            int SLnew = int.Parse(textEditSL.Text);

            DataRow rownew = dtMonAnChon.NewRow();
            DataRow rowold = dtMonAnChon.Rows[indexSL];
            rownew["MaMon"] = rowold["MaMon"];
            rownew["TenMon"] = rowold["TenMon"];
            rownew["DonViTinh"] = rowold["DonViTinh"];
            rownew["SoLuong"] = SLnew;
            rownew["Gia"] = rowold["Gia"];

            dtMonAnChon.Rows.Add(rownew);
            dtMonAnChon.Rows.RemoveAt(indexSL);
            gridControlChon.DataSource = dtMonAnChon;
            gridControlChon.Update();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public delegate void common_void_delegate();
        public common_void_delegate reloadGridViewCTHD;


        private void btnDongY_Click(object sender, EventArgs e)
        {
            float kq = 0;
            foreach(DataRow row in dtMonAnChon.Rows ){
                int mamon = (int)row.ItemArray[0];
                int soluong = (int)row.ItemArray[3];
                ChiTietHoaDon_BUS.insertCTHD(maHD, mamon, soluong, Mode);
            }
            reloadGridViewCTHD();
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewChon.SelectedRowsCount; i++)
            {
                int index = gridViewChon.GetSelectedRows()[i];
                dtMonAnChon.Rows.RemoveAt(index);
                gridControlChon.DataSource = dtMonAnChon;
                gridControlChon.Update();
            }
        }

        private void listViewDSMonAn_DoubleClick(object sender, EventArgs e)
        {
            simpleButton1_Click(null, null);
        }


    }
}