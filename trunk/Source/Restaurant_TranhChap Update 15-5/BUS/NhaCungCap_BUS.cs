using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class NhaCungCap_BUS
    {
       
        NhaCungCap_DAO _NhaCungCapDAO;
        public NhaCungCap_DAO NhaCungCapDAO
        {
            get { return _NhaCungCapDAO; }
            set { _NhaCungCapDAO = value; }
        }
        public NhaCungCap_BUS()
        {
            _NhaCungCapDAO = new NhaCungCap_DAO();
        }
        public NhaCungCap_BUS(NguyenLieu_BUS nl)
        {
            _NhaCungCapDAO = new NhaCungCap_DAO();
            _NhaCungCapDAO.Provider = nl.NguyenLieuDAO.Provider;
        }
        public NhaCungCap_BUS(ChiTietNCC_BUS ctncc)
        {
            _NhaCungCapDAO = new NhaCungCap_DAO();
            _NhaCungCapDAO.Provider = ctncc.ChiTietNCCDAO.Provider;
        }
        public static List<NhaCungCap_DTO> SelectNhaCungCap()
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.SelectNhaCungCap();
        }
        public List<NhaCungCap_DTO> SelectNhaCungCap_fromNH(int flag_connec,int flag_tran,String MaNH)
        {
            return _NhaCungCapDAO.SelectNhaCungCap_fromNH(flag_connec,flag_tran, MaNH);
        }
        public int InsertNhaCungCap(int flag_connec, int flag_tran, NhaCungCap_DTO ncc)
        {
            return _NhaCungCapDAO.InsertNhaCungCap(flag_connec,flag_tran,ncc);
        }
        public int UpdatetNhaCungCap(int flag_connec, int flag_tran, String TenNCC, NhaCungCap_DTO ncc)
        {
            return _NhaCungCapDAO.UpdateNhaCungCap(flag_connec,flag_tran,TenNCC, ncc);
        }
        public static void DeleteNhaCungCap(int MaNCC)
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            NhaCungCapDAO.DeleteNhaCungCap(MaNCC);
        }
    }
}
