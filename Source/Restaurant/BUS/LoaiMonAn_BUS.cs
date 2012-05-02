using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiMonAn_BUS
    {
        LoaiMonAn_DAO loaimonan = new LoaiMonAn_DAO();
        public DataTable DocLoaiMonAn()
        {
            return loaimonan.DocLoaiMonAn();
        }
        public static int CapNhatLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            return LoaiMonAn_DAO.CapNhatLoaiMonAn(loaiMonAn);
        }
        public static int XoaLoaiMonAn(string maLoai)
        {
            return LoaiMonAn_DAO.XoatLoaiMonAn(maLoai);
        }
        public static int ThemLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            return LoaiMonAn_DAO.ThemLoaiMonAn(loaiMonAn);
        }
    }
}
