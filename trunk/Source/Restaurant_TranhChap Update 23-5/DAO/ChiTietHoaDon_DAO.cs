using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class ChiTietHoaDon_DAO
    {
        Provider provider;
        DataTable dtCTHD;

        public ChiTietHoaDon_DAO()
        {
            provider = new Provider();
            dtCTHD = new DataTable();
        }


        public List<ChiTietHoaDon_DTO> SelectCTHDtheoMaHD(int mahd, int mode)
        {
            String store = "sp_SelectChiTietHD_0";
            switch (mode)
            {
                case 0:
                    store = "sp_SelectChiTietHD_0";
                    break;
                case 3:
                    store = "sp_SelectChiTietHD_3";   //unrepeatable read
                    break;
            }
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }

        public DataTable SelectTableCTHD(int mahd)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_SelectTableCTHD");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            return provider.ExecSelectCommand(cm);
        }

        public void insertCTHD(int mahd, int mamon, int soluong, int mode)
        {
            String store = "sp_insertCTHD_0";
            switch (mode)
            {
                case 0:
                    store = "sp_insertCTHD_0";
                    break;
                case 1:
                    store = "sp_insertCTHD_1";
                    break;
                case 3:
                    store = "sp_insertCTHD_3";   //unrepeatable read
                    break;
            }

            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            cm.Parameters.Add("@mamon", SqlDbType.Int);
            cm.Parameters["@mamon"].Value = mamon;
            cm.Parameters.Add("@soluong", SqlDbType.Int);
            cm.Parameters["@soluong"].Value = soluong;
           
            
            provider.ExecuteInsertUpdateDelete(cm);
            
        }

        public void DeleteCTHD(int mahd, int mamon)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_DeleteCTHD");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            cm.Parameters.Add("@mamon", SqlDbType.Int);
            cm.Parameters["@mamon"].Value = mamon;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        public void UpdateSoLuongCTHD(int mahd, int mamon, int soluong, int mode)
        {
            String store = "sp_UpdateSoLuongCTHD_0";
            switch (mode)
            {
                case 0:
                    store = "sp_UpdateSoLuongCTHD_0";
                    break;
                case 1:
                    store = "sp_UpdateSoLuongCTHD_1";   //lost update
                    break;
                case 2:
                    store = "sp_UpdateSoLuongCTHD_2";   //deadlock
                    break;
                case 3:
                    store = "sp_UpdateSoLuongCTHD_3";
                    break;
            }
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;

            cm.Parameters.Add("@mamon", SqlDbType.Int);
            cm.Parameters["@mamon"].Value = mamon;

            cm.Parameters.Add("@soluong", SqlDbType.Int);
            cm.Parameters["@soluong"].Value = soluong;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        public void DeleteCTHDtheoMaHD(int mahd)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_DeleteCTHDtheoMaHD");
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            provider.ExecuteInsertUpdateDelete(cm);
        }

        private List<ChiTietHoaDon_DTO> ConvertToList(DataTable dt)
        {
            List<ChiTietHoaDon_DTO> ls = new List<ChiTietHoaDon_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietHoaDon_DTO cthd = new ChiTietHoaDon_DTO();
                cthd.MaHD = (int)row.ItemArray[0];
                cthd.MaMon = (int)row.ItemArray[1];
                cthd.TenMon = (String)row.ItemArray[2];
                cthd.Gia = (double)row.ItemArray[3];
                cthd.Donvitinh = (String)row.ItemArray[4];
                cthd.Soluong = (int)row.ItemArray[5];
                cthd.Thanhtien = (double)row.ItemArray[6];
                ls.Add(cthd);
            }
            return ls;
        }

    }
}
