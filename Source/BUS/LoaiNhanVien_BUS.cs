using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class LoaiNhanVien_BUS
    {
        public static DataTable DocLoaiNV()
        {
            return LoaiNhanVien_DAO.DocLoaiNV();
        }

        public static int ThemLoaiNV(LoaiNhanVien_DTO loaiNV)
        {
            return LoaiNhanVien_DAO.ThemLoaiNV(loaiNV);
        }

        public static int KiemTraMaLoai(string maLoai)
        {
            return LoaiNhanVien_DAO.KiemTraMaLoai(maLoai);
        }

        public static int KiemTraTenLoai(string tenLoai)
        {
            return LoaiNhanVien_DAO.KiemTraTenLoai(tenLoai);
        }

        public static int CapNhatLoaiNhanVien(LoaiNhanVien_DTO loaiNV)
        {
            return LoaiNhanVien_DAO.CapNhatLoaiNhanVien(loaiNV);
        }

        public static int XoaLoaiNhanVien(string maLoai)
        {
            return LoaiNhanVien_DAO.XoaLoaiNhanVien(maLoai);
        }

    }
}
