using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiBanAn_BUS
    {
        public static DataTable DocLoaiBanAn()
        {
            return LoaiBanAn_DAO.DocLoaiBanAn();
        }

        public static int ThemLoaiBanAn(LoaiBanAn_DTO LoaiBA)
        {
            return LoaiBanAn_DAO.ThemLoaiBanAn(LoaiBA);
        }

        public static int CapNhatLoaiBA(LoaiBanAn_DTO loaiBA)
        {
            return LoaiBanAn_DAO.CapNhatLoaiBA(loaiBA);
        }

        public static int XoaLoaiBanAn(string maLoai)
        {
            return LoaiBanAn_DAO.XoaLoaiBanAn(maLoai);
        }
    }
}
