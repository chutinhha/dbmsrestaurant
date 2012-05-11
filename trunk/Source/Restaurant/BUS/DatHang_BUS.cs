using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DatHang_BUS
    {
        DatHang_DAO _DatHangDAO;
        public DatHang_DAO DatHangDAO
        {
            get { return _DatHangDAO; }
            set { _DatHangDAO = value; }
        }
        public DatHang_BUS()
        {
            _DatHangDAO = new DatHang_DAO();
        }
        public DatHang_BUS(NguyenLieu_BUS nl)
        {
            _DatHangDAO = new DatHang_DAO();
            _DatHangDAO.Provider = nl.NguyenLieuDAO.Provider;
        }
        public static List<DatHang_DTO> SelectDatHang(String MaNH)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.SelectDatHang(MaNH);
        }

        public int InsertDatHang(int flag_connec,int flag_tran,DatHang_DTO dh)
        {
           
            return _DatHangDAO.InsertDatHang(flag_connec,flag_tran,dh);
        }
        public static int UpdateDatHang(DatHang_DTO dh)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.UpdatetDatHang(dh);
        }
        public static int DeleteDatHang(int MaHD)
        {
            DatHang_DAO DatHangDAO = new DatHang_DAO();
            return DatHangDAO.DeleteDatHang(MaHD);
        }
    }
}
