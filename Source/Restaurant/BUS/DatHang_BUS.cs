using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DatHang_BUS
    {
        public static List<DatHang_DTO> SelectDatHang(String MaNH)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.SelectDatHang(MaNH);
        }

        public static int InsertDatHang(DatHang_DTO dh)
        {
            DatHang_DAO DatHangDAO= new DatHang_DAO();
            return DatHangDAO.InsertDatHang(dh);
        }
        public static int UpdateDatHang(DatHang_DTO dh)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.UpdatetDatHang(dh);
        }
        public static int DeleteDatHang(int MaHD)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.DeleteDatHang(MaHD);
        }
    }
}
