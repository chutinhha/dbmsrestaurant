using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietNCC_BUS
    {
        public static int InsertChiTietNCC(int MaNL,int MaNCC)
        {
            ChiTietNCC_DAO ctDAO = new ChiTietNCC_DAO();
            return ctDAO.InsertChiTietNCC(MaNL, MaNCC);
        }
        public static void DeleteChiTietNCC(int MaNCC)
        {
            ChiTietNCC_DAO ctDAO = new ChiTietNCC_DAO();
            ctDAO.DeleteChiTietNCC_fromNCC(MaNCC);
        }
    }
}
