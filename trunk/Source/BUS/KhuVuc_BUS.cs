using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DTO;
using DAO;
namespace BUS
{
   public class KhuVuc_BUS
    {
        public static DataTable DocKhuVuc()
        {
            return KhuVuc_DAO.DocKhuVuc();
        }

        public static DataTable LayNhaHang()
        {
            return KhuVuc_DAO.LayNhaHang();
        }

        public static int ThemKhuVuc(KhuVuc_DTO KhuVuc)
        {
            return KhuVuc_DAO.ThemKhuVuc(KhuVuc);
        }

        public static int CapNhatKhuVuc(KhuVuc_DTO KhuVuc)
        {
            return KhuVuc_DAO.CapNhatKhuVuc(KhuVuc);
        }

        public static int XoaKhuVuc(string MaKhuVuc)
        {
            return KhuVuc_DAO.XoaKhuVuc(MaKhuVuc);
        }
    }
}
