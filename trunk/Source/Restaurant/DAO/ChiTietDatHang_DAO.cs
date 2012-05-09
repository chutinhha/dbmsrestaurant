using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietDatHang_DAO
    {
        Provider provider;
        public ChiTietDatHang_DAO()
        {
            provider = new Provider();
        }
        public List<ChiTietDatHang_DTO> SelectChiTietDatDang(int MaHoaDon)
        {
            String store = "SelectChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        private List<ChiTietDatHang_DTO> ConvertToList(DataTable dt)
        {
            List<ChiTietDatHang_DTO> ls = new List<ChiTietDatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietDatHang_DTO ct = new ChiTietDatHang_DTO();
                ct.MaHoaDon = (int)row.ItemArray[0];
                ct.MaNL = (int)row.ItemArray[1];
                ct.SoLuong = (int)row.ItemArray[2];
                ct.Gia = (Double)row.ItemArray[3];
                ct.TenNL = row.ItemArray[4].ToString();
                ls.Add(ct);
            }
            return ls;
        }
    }
}
