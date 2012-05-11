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

        public List<BanAn_DTO> SelectBanAnTheoTrangThai(int trangthai, int manh)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_selectBanAn");
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
    }
}