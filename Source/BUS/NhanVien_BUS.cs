using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVien_BUS
    {
        public static DataTable DocNhanVien()
        {
            return NhanVien_DAO.DocNhanVien();
        }

        public static DataTable LayLoaiNhanVien()
        {
            return NhanVien_DAO.LayLoaiNhanVien();
        }

        public static DataTable LayNhaHang()
        {
            return NhanVien_DAO.LayNhaHang();
        }

        public static int ThemNhanVien(NhanVien_DTO NhanVien)
        {
            return NhanVien_DAO.ThemNhanVien(NhanVien);
        }

        public static int CapNhatNhanVien(NhanVien_DTO NhanVien, int MaNV)
        {
            return NhanVien_DAO.CapNhatNhanVien(NhanVien, MaNV);
        }

        public static int XoaNhanVien(int MaNV)
        {
            return NhanVien_DAO.XoaNhanVien(MaNV);
        }
    }
}
