using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu_DTO> SelectNguyenLieu(String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu(maNH);
        }
        public static DataTable SelectNguyenLieu_toDataTable(String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu_toDataTable(maNH);
        }
        public static List<NguyenLieu_DTO> SelectNguyenLieu_fromNCC(int MaNCC, String MaNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu_fromNCC(MaNCC,MaNH);
        }
        public static List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietNCC(int MaNCC,String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu_NotIn_ChiTietNCC(MaNCC,maNH);
        }
        public static List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietDatHang(int MaHoaDon,int MaNCC,String MaNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu_NotIn_ChiTietDatHang(MaHoaDon,MaNCC,MaNH);
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
