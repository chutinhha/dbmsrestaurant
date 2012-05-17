using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class VNguyenLieu_BUS:VBus
    {
        VNguyenLieu_DAO daoNguyenLieu;
        public VNguyenLieu_BUS()
        {
            daoNguyenLieu = new VNguyenLieu_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoNguyenLieu.Copy(b.Provider);
        }
        public List<VNguyenLieu_DTO> SelectNguyenLieu(String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu(maNH);
        }
        public  DataTable SelectNguyenLieu_toDataTable(String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_toDataTable(maNH);
        }
        public int InsertNguyenLieu(VNguyenLieu_DTO nl)
        {
            return daoNguyenLieu.InsertNguyenLieu(nl);
        }
        public int UpdateNguyenLieu(String TenNL, VNguyenLieu_DTO nl)
        {
            return daoNguyenLieu.UpdateNguyenLieu(TenNL, nl);
        }
        public int DeleteNguyenLieu(int MaNL, String MaNH)
        {
            return daoNguyenLieu.DeleteNguyenLieu(MaNL, MaNH);
        }
        //---------------------------------------------
        public  List<VNguyenLieu_DTO> SelectNguyenLieu_fromNCC(int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_fromNCC( MaNCC, MaNH);
        }
        public List<VNguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietNCC( int MaNCC, String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_ChiTietNCC( MaNCC, maNH);
        }
        public List<VNguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietDatHang(int MaHoaDon, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_ChiTietDatHang(MaHoaDon, MaNCC, MaNH);
        }

    }
}
