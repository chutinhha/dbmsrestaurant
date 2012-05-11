using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDon_BUS
    {
        public static int SelectMaHoaDonTheoBan(int maban)
        {
            HoaDon_DAO dao = new HoaDon_DAO();
            return dao.SelectMaHoaDonTheoBan(maban);
        }

        public static void UpdateKetThucHoaDon(int mahd, float tongtien, DateTime tgkt)
        {
            HoaDon_DAO dao = new HoaDon_DAO();
            dao.UpdateKetThucHoaDon(mahd, tongtien, tgkt);
        }

        public static void UpdateMaBan(int mahd, int mabannew)
        {
            HoaDon_DAO dao = new HoaDon_DAO();
            dao.UpdateMaBan(mahd, mabannew);
        }
        public static DataTable SelectHoaDonTrong()
        {
            HoaDon_DAO dao = new HoaDon_DAO();
            return dao.SelectHoaDonTrong();
        }
        public static void DeleteHoaDon(int mahd)
        {
            HoaDon_DAO dao = new HoaDon_DAO();
            dao.DeleteHoaDon(mahd);
        }
    }
}
