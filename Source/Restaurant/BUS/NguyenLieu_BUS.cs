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
        NguyenLieu_DAO _NguyenLieuDAO;
        public NguyenLieu_DAO NguyenLieuDAO
        {
            get { return _NguyenLieuDAO; }
            set { _NguyenLieuDAO = value; }
        }
        public NguyenLieu_BUS(NhaCungCap_BUS ncc)
        {
            _NguyenLieuDAO = new NguyenLieu_DAO();
            _NguyenLieuDAO.Provider = ncc.NhaCungCapDAO.Provider;
        }
        public NguyenLieu_BUS(NguyenLieu_BUS nl)
        {
            _NguyenLieuDAO = new NguyenLieu_DAO();
            _NguyenLieuDAO.Provider = nl._NguyenLieuDAO.Provider;
        }
        public NguyenLieu_BUS()
        {
            _NguyenLieuDAO = new NguyenLieu_DAO();
        }
        public  List<NguyenLieu_DTO> SelectNguyenLieu(int flag_connec,int flag_tran,String maNH)
        {
            return _NguyenLieuDAO.SelectNguyenLieu(flag_connec,flag_tran,maNH);
        }
        public static DataTable SelectNguyenLieu_toDataTable(String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu_toDataTable(maNH);
        }
        public  List<NguyenLieu_DTO> SelectNguyenLieu_fromNCC(int flag_connec,int flag_tran,int MaNCC, String MaNH)
        {
            return _NguyenLieuDAO.SelectNguyenLieu_fromNCC(flag_connec,flag_tran,MaNCC,MaNH);
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
