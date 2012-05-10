using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class MonAn_BUS
    {
        public static DataTable DocMonAn()
        {
            return MonAn_DAO.DocMonAn();
        }

        public static int ThemMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.ThemMonAn(monAn);
        }

        public static DataTable LayLoaiMon()
        {
            return MonAn_DAO.LayLoaiMon();
        }

        public static DataTable LayNhaHang()
        {
            return MonAn_DAO.LayNhaHang();
        }

        public static int CapNhatMonAn(MonAn_DTO MonAn, int maMonAn)
        {
            return MonAn_DAO.CapNhatMonAn(MonAn, maMonAn);
        }

        public static int XoaMonAn(int maMonAn)
        {
            return MonAn_DAO.XoaMonAn(maMonAn);
        }
    }
}
