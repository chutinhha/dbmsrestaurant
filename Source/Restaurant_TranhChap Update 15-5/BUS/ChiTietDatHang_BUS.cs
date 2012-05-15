using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietDatHang_BUS
    {
        ChiTietDatHang_DAO _ChiTietDatHangDAO;
        public ChiTietDatHang_DAO ChiTietDatHangDAO
        {
            get { return _ChiTietDatHangDAO; }
            set { _ChiTietDatHangDAO = value; }
        }
        public ChiTietDatHang_BUS()
        {
            _ChiTietDatHangDAO = new ChiTietDatHang_DAO();
        }
        public  ChiTietDatHang_BUS(DatHang_BUS dh)
        {
            _ChiTietDatHangDAO = new ChiTietDatHang_DAO();
            _ChiTietDatHangDAO.Provider = dh.DatHangDAO.Provider;
        }
        public static List<ChiTietDatHang_DTO> SelectChiTietDatHang(int MaHoaDon)
        {
            ChiTietDatHang_DAO ct = new ChiTietDatHang_DAO();
            return ct.SelectChiTietDatDang(MaHoaDon);
        }
        public int InsertChiTietDatHang(int flag_connec, int flag_tran,ChiTietDatHang_DTO ctdh)
        {
            
            return _ChiTietDatHangDAO.InsertChiTietDatHang(flag_connec,flag_tran,ctdh);
        }
        public static int DeleteChiTietDatHang(int MaHoaDon)
        {
            ChiTietDatHang_DAO ctdh_dao = new ChiTietDatHang_DAO();
            return ctdh_dao.DeleteChiTietDatDang(MaHoaDon);
        }

    }
}
