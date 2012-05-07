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
        //public static List<ChiTietNCC_DTO> SelectChiTietNCC_MaNCC(int MaNCC,String MaNH)
        //{
        //    ChiTietNCC_DAO ctDAO = new ChiTietNCC_DAO();
        //    return ctDAO.SelectNhaCungCap(MaNCC,MaNH);
        //}
        public static int InsertChiTietNCC(int MaNL,int MaNCC)
        {
            ChiTietNCC_DAO ctDAO = new ChiTietNCC_DAO();
            return ctDAO.InsertChiTietNCC(MaNL, MaNCC);
        }
    }
}
