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
    }
}
