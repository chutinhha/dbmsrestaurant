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
        public int InsertChiTietDatHang(ChiTietDatHang_DTO ctdh)
        {
            String store = "InsertChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@SoLuong", SqlDbType.Int);
            cm.Parameters.Add("@ThanhTien", SqlDbType.Float);

            cm.Parameters["@MaHoaDon"].Value = ctdh.MaHoaDon;
            cm.Parameters["@MaNL"].Value = ctdh.MaNL;
            cm.Parameters["@SoLuong"].Value = ctdh.SoLuong;
            cm.Parameters["@ThanhTien"].Value = ctdh.ThanhTien;

            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public int DeleteChiTietDatDang(int MaHoaDon)
        {
            String store = "DeleteChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;

            return provider.ExecuteInsertUpdateDelete(cm);
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
                ct.ThanhTien = (Double)row.ItemArray[3];
                ct.TenNL = row.ItemArray[4].ToString();
                ct.DonVi= row.ItemArray[5].ToString();
                ls.Add(ct);
            }
            return ls;
        }
    }
}
