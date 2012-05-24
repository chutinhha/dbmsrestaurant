using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class BanAn_DAO
    {
        Provider provider;
        DataTable tbBanAn;

        public BanAn_DAO()
        {
            provider = new Provider();
            tbBanAn = new DataTable();
        }

        public List<BanAn_DTO> SelectBanAnTheoTrangThai(int trangthai, int manh, int mode)
        {
            String store = "sp_selectBanAn_0";
            switch (mode)
            {
                case 0:
                    store = "sp_selectBanAn_0";
                    break;
                case 3:
                    store = "sp_selectBanAn_3";
                    break;
            }

            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@trangthai", SqlDbType.Int);
            cm.Parameters.Add("@manh", SqlDbType.Int);

            cm.Parameters["@trangthai"].Value = trangthai;
            cm.Parameters["@manh"].Value = manh;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }

        public void UpdateTrangThaiBanAn(int maban, int trangthai)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_UpdateTrangThaiBanAn");
            cm.Parameters.Add("@maban", SqlDbType.Int);
            cm.Parameters.Add("@trangthai", SqlDbType.Int);
            cm.Parameters["@maban"].Value = maban;
            cm.Parameters["@trangthai"].Value = trangthai;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        private List<BanAn_DTO> ConvertToList(DataTable dt)
        {
            List<BanAn_DTO> ls = new List<BanAn_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                BanAn_DTO banan = new BanAn_DTO();
                banan.MaBan = (int)row.ItemArray[0];
                banan.MaKhuVuc = (int)row.ItemArray[1];
                banan.LoaiBan = (String)row.ItemArray[2];
                banan.MaNH = (String)row.ItemArray[3];
                banan.TrangThai = (int)row.ItemArray[4];
                ls.Add(banan);
            }
            return ls;
        }

        public static DataTable DocBanAn(string maNH)
        {
            Provider provider = new Provider();
            string sql = "select MaBan,TenKhuVuc,SucChua,TenNH,case(TrangThai) when 0 then N'Chưa đến ăn' else N'Đã đến ăn' end as TrangThai";
            sql += " from BanAn ba,KhuVuc kv,LoaiBan lb,NhaHang nh";
            sql += " where ba.MaKhuVuc=kv.MaKhuVuc and ba.LoaiBan=lb.Maloai and ba.MaNH=nh.MaNH and nh.MaNH=" + maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }

        public static int ThemBanAn(BanAn_DTO BanAn, string maNH)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into BanAn values ({0},'{1}','{2}',{3})", BanAn.MaKhuVuc, BanAn.LoaiBan, maNH, BanAn.TrangThai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int CapNhatBanAn(BanAn_DTO BanAn)
        {
            Provider provider = new Provider();
            string sql = string.Format("update BanAn set TrangThai={0} where MaBan={1}", BanAn.TrangThai, BanAn.MaBan);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaBanAn(string maBan)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete BanAn where MaBan={0}", maBan);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}