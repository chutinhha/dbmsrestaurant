using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietDatHang_BUS
    {
        public static List<ChiTietDatHang_DTO> SelectChiTietDatHang(int MaHoaDon)
        {
            ChiTietDatHang_DAO ct = new ChiTietDatHang_DAO();
            return ct.SelectChiTietDatDang(MaHoaDon);
        }
        public static int InsertChiTietDatHang(ChiTietDatHang_DTO ctdh)
        {
            ChiTietDatHang_DAO ctdh_dao = new ChiTietDatHang_DAO();
            return ctdh_dao.InsertChiTietDatHang(ctdh);
        }
        public static int DeleteChiTietDatHang(int MaHoaDon)
        {
            ChiTietDatHang_DAO ctdh_dao = new ChiTietDatHang_DAO();
            return ctdh_dao.DeleteChiTietDatDang(MaHoaDon);
        }

    }
}
