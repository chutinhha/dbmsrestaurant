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
    public class LoaiNhanVien_BUS
    {
        LoaiNhanVien_DAO LoaiNV_DAO;

        public LoaiNhanVien_BUS(SqlCommand cm)
        {
            LoaiNV_DAO = new LoaiNhanVien_DAO(cm);
        }

        public LoaiNhanVien_BUS()
        {
            LoaiNV_DAO = new LoaiNhanVien_DAO();
        }

        public static DataTable DocLoaiNV()
        {
            return LoaiNhanVien_DAO.DocLoaiNV();
        }

        public DataTable DocLoaiNhanVien_begin()
        {
            return LoaiNV_DAO.DocLoaiNhanVien_begin();
        }

        public DataTable DocLoaiNhanVien_commit()
        {
            return LoaiNV_DAO.DocLoaiNhanVien_commit();
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
