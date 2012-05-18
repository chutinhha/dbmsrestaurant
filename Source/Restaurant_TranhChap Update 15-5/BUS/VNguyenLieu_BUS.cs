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
        public int UpdateNguyenLieu( VNguyenLieu_DTO nl)
        {
            return daoNguyenLieu.UpdateNguyenLieu(nl);
        }
        public int DeleteNguyenLieu(int MaNL, String MaNH)
        {
            return daoNguyenLieu.DeleteNguyenLieu(MaNL, MaNH);
        }
        //---------------------------------------------
        public DataSet SelectNguyenLieu_NCC(int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NCC(MaNCC, MaNH);
        }
        public  DataTable SelectNguyenLieu_In_NCC(int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_In_NCC( MaNCC, MaNH);
        }
        public DataTable SelectNguyenLieu_NotIn_ChiTietNCC( int MaNCC, String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_NCC( MaNCC, maNH);
        }
        public DataSet SelectNguyenLieu_DatHang(int MaHoaDon,int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_DatHang(MaHoaDon,MaNCC, MaNH);
        }
        public DataTable SelectNguyenLieu_NotIn_DatHang(int MaHoaDon, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_DatHang(MaHoaDon, MaNCC, MaNH);
        }

    }
}
