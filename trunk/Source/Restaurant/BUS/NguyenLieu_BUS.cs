using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu_DTO> SelectNguyenLieu(String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu(maNH);
        }
        public static int InsertNguyenLieu(NguyenLieu_DTO nl)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.InsertNguyenLieu(nl);
        }
        public static void DeleteNguyenLieu(int MaNL, String MaNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            nguyenlieuDAO.DeleteNguyenLieu(MaNL, MaNH);
        }
        public static int UpdateNguyenLieu(String TenNL,NguyenLieu_DTO nl)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.UpdateNguyenLieu(TenNL,nl);
        }
    }
}
