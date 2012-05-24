using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietHoaDon_BUS
    {
        public static List<ChiTietHoaDon_DTO> SelectCTHDtheoMaHD(int mahd, int mode)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            return dao.SelectCTHDtheoMaHD(mahd, mode);
        }

        public static void insertCTHD(int mahd, int mamon, int soluong, int mode)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            dao.insertCTHD(mahd, mamon, soluong, mode);
        }
        public static void DeleteCTHD(int mahd, int mamon)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            dao.DeleteCTHD(mahd, mamon);
        }

        public static void UpdateSoLuongCTHD(int mahd, int mamon, int soluong, int mode)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            dao.UpdateSoLuongCTHD(mahd, mamon, soluong, mode);
        }

        public static DataTable SelectTableCTHD(int mahd)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            return dao.SelectTableCTHD(mahd);
        }

        public static void DeleteCTHDtheoMaHD(int mahd)
        {
            ChiTietHoaDon_DAO dao = new ChiTietHoaDon_DAO();
            dao.DeleteCTHDtheoMaHD(mahd);
        }
    }
}
