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
        ChiTietNCC_DAO _ChiTietNCCDAO;
        public ChiTietNCC_DAO ChiTietNCCDAO
        {
            get{return _ChiTietNCCDAO;}
            set{_ChiTietNCCDAO = value;}
        }
        public ChiTietNCC_BUS()
        {
            _ChiTietNCCDAO = new ChiTietNCC_DAO();
        }
        public ChiTietNCC_BUS(NhaCungCap_BUS ncc)
        {
            _ChiTietNCCDAO = new ChiTietNCC_DAO();
            _ChiTietNCCDAO.Provider = ncc.NhaCungCapDAO.Provider; 

        }
        public ChiTietNCC_BUS(NguyenLieu_BUS nl)
        {
            _ChiTietNCCDAO = new ChiTietNCC_DAO();
            _ChiTietNCCDAO.Provider = nl.NguyenLieuDAO.Provider;

        }
        public int InsertChiTietNCC(int flag_connec, int flag_tran, int MaNL, int MaNCC, double Gia)
        {
            return _ChiTietNCCDAO.InsertChiTietNCC(flag_connec,flag_tran,MaNL, MaNCC, Gia);
        }
        public int UpdateChiTietNCC(int flag_connec, int flag_tran, int MaNL, int MaNCC, double Gia)
        {
            return _ChiTietNCCDAO.UpdateChiTietNCC(flag_connec,flag_tran,MaNL, MaNCC, Gia);
        }
        public int DeleteChiTietNCC_fromNCC(int flag_connec, int flag_tran, int MaNCC)
        {
            return _ChiTietNCCDAO.DeleteChiTietNCC_fromNCC(flag_connec,flag_tran,MaNCC);
        }
        public int DeleteChiTietNCC(int flag_connec, int flag_tran,int MaNL, int MaNCC)
        {
            return _ChiTietNCCDAO.DeleteChiTietNCC(flag_connec, flag_tran,MaNL, MaNCC);
        }
    }
}
