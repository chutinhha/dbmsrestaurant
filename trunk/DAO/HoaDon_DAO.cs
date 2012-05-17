using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class HoaDon_DAO
    {
        Provider provider;
        DataTable dtHoaDon;
        public HoaDon_DAO()
        {
            provider = new Provider();
            dtHoaDon = new DataTable();
        }
        public int ThemHoaDon(int maBan, int maNV)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_insertHoaDon");
            cm.Parameters.Add("@maban", SqlDbType.Int);
            cm.Parameters["@maban"].Value = maBan;
            cm.Parameters.Add("@manv", SqlDbType.Int);
            cm.Parameters["@manv"].Value = maNV;
            int t= provider.ExecuteInsertUpdateDelete(cm);
            return t;
        }
        public int SelectMaHoaDonTheoBan(int maban)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_SelectMaHoaDonTheoBan");
            cm.Parameters.Add("@maban", SqlDbType.Int);
            cm.Parameters["@maban"].Value = maban;
            dtHoaDon = provider.ExecSelectCommand(cm);
            if (dtHoaDon.Rows.Count <= 0) return -1;
            return (int)dtHoaDon.Rows[0].ItemArray[0];
        }

        public DataTable SelectHoaDonTrong()
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_SelectHoaDonTrong");
            return provider.ExecSelectCommand(cm);
        }

        public void UpdateKetThucHoaDon(int mahd, float tongtien, DateTime tgkt)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_UpdateKetThucHoaDon");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters.Add("@tongtien", SqlDbType.Float);
            cm.Parameters.Add("@tgKetThuc", SqlDbType.DateTime);

            cm.Parameters["@mahd"].Value = mahd;
            cm.Parameters["@tongtien"].Value = tongtien;
            cm.Parameters["@tgKetThuc"].Value = tgkt;

            provider.ExecuteInsertUpdateDelete(cm);
        }

        public void UpdateMaBan(int mahd, int mabannew)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_UpdateMaBan");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters.Add("@mabannew", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            cm.Parameters["@mabannew"].Value = mabannew;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        public void DeleteHoaDon(int mahd)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_DeleteHoaDon");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        public int ChuyenBan(int mabanOLD, int mabanNEW, int mahd)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_ChuyenBan");
            cm.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters.Add("@mabanOLD", SqlDbType.Int);
            cm.Parameters.Add("@mabanNEW", SqlDbType.Int);
            
            cm.Parameters["@mahd"].Value = mahd;
            cm.Parameters["@mabanOLD"].Value = mabanOLD;
            cm.Parameters["@mabanNEW"].Value = mabanNEW;
            provider.ExecuteInsertUpdateDelete(cm);
            return (int)cm.Parameters["@kq"].Value;
        }

        private List<HoaDon_DTO> ConvertToList(DataTable dt)
        {
            List<HoaDon_DTO> ls = new List<HoaDon_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = (int)row.ItemArray[0];
                hd.Tongtien = (double)row.ItemArray[1];
                hd.Thoigianlap = (DateTime)row.ItemArray[2];
                hd.ThoigianKetthuc = (DateTime)row.ItemArray[3];
                hd.Manv = (int)row.ItemArray[4];
                hd.Maban = (int)row.ItemArray[5];
                ls.Add(hd);
            }
            return ls;
        }
    }

}
