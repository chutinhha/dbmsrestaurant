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
        public static DataTable DocNhanVien(string maNH)
        {
            return NhanVien_DAO.DocNhanVien(maNH);
        }

        public static DataTable LayLoaiNhanVien()
        {
            return NhanVien_DAO.LayLoaiNhanVien();
        }

        public static DataTable DocLoaiNhanVien_commit()
        {
            return NhanVien_DAO.DocLoaiNhanVien_commit();
        }
        public static DataTable LayNhaHang()
        {
            return NhanVien_DAO.LayNhaHang();
        }

        public static int ThemNhanVien(NhanVien_DTO NhanVien, string maNH)
        {
            return NhanVien_DAO.ThemNhanVien(NhanVien, maNH);
        }

        public static int CapNhatNhanVien(NhanVien_DTO NhanVien, int MaNV)
        {
            return NhanVien_DAO.CapNhatNhanVien(NhanVien, MaNV);
        }

        public static int XoaNhanVien(int MaNV)
        {
            return NhanVien_DAO.XoaNhanVien(MaNV);
        }
        public static DataTable DocNhanVienTheoUsername(string username)
        {
            return NhanVien_DAO.DocNhanVienTheoUsername(username);
        }
    }
}
