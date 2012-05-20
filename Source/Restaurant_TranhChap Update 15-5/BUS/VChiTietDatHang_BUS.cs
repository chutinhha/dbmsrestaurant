using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class VChiTietDatHang_BUS
    {
        VChiTietDatHang_DAO daoChiTietDatHang;
        public VChiTietDatHang_DAO DaoChiTietDatHang
        {
            get { return daoChiTietDatHang; }
            set { daoChiTietDatHang = value; }
        }
        public VChiTietDatHang_BUS()
        {
            daoChiTietDatHang = new VChiTietDatHang_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoChiTietDatHang = new VChiTietDatHang_DAO(b.Provider);
        }
        public List<VChiTietDatHang_DTO> SelectChiTietDatHang(int mode, int MaHoaDon)
        {
            return ((VChiTietDatHang_DAO)daoChiTietDatHang).SelectChiTietDatDang(mode, MaHoaDon);
        }

        public int InsertChiTietDatHang(int mode, VChiTietDatHang_DTO ctdh)
        {

            return ((VChiTietDatHang_DAO)daoChiTietDatHang).InsertChiTietDatHang(mode, ctdh);
        }
        public int DeleteChiTietDatHang(int mode, int MaHoaDon)
        {
            return daoChiTietDatHang.DeleteChiTietDatDang(mode,MaHoaDon);
        }

    }
}
