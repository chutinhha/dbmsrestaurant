using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class VChiTietDatHang_DAO:VProvider
    {
        public List<VChiTietDatHang_DTO> SelectChiTietDatDang(int mode, int MaHoaDon)
        {
            String store = "SPoV_SelectChiTietDatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            return ConvertToList(ExecSelectCommand());
        }
        public int InsertChiTietDatHang(int mode, VChiTietDatHang_DTO ctdh)
        {
            String store = "SPoV_InsertChiTietDatHang";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@SoLuong", SqlDbType.Int);
            cm.Parameters.Add("@ThanhTien", SqlDbType.Float);

            cm.Parameters["@MaHoaDon"].Value = ctdh.MaHoaDon;
            cm.Parameters["@MaNL"].Value = ctdh.MaNL;
            cm.Parameters["@SoLuong"].Value = ctdh.SoLuong;
            cm.Parameters["@ThanhTien"].Value = ctdh.ThanhTien;

            return ExecuteInsertUpdateDelete();
        }
        public int DeleteChiTietDatDang(int mode, int MaHoaDon)
        {
            String store = "SPoV_DeleteChiTietDatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;

            return ExecuteInsertUpdateDelete();
        }
        private List<VChiTietDatHang_DTO> ConvertToList(DataTable dt)
        {
            List<VChiTietDatHang_DTO> ls = new List<VChiTietDatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                VChiTietDatHang_DTO ct = new VChiTietDatHang_DTO();
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
