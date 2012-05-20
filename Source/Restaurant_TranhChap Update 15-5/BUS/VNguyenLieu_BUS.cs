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
        public List<VNguyenLieu_DTO> SelectNguyenLieu(int mode, String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu(mode, maNH);
        }
        public DataTable SelectNguyenLieu_toDataTable(int mode, String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_toDataTable(mode, maNH);
        }
        public int InsertNguyenLieu(int mode, VNguyenLieu_DTO nl)
        {
            return daoNguyenLieu.InsertNguyenLieu(mode, nl);
        }
        public int UpdateNguyenLieu(int mode, VNguyenLieu_DTO nl)
        {
            return daoNguyenLieu.UpdateNguyenLieu(mode, nl);
        }
        public int DeleteNguyenLieu(int mode, int MaNL, String MaNH)
        {
            return daoNguyenLieu.DeleteNguyenLieu(mode, MaNL, MaNH);
        }
        //---------------------------------------------
        public DataSet SelectNguyenLieu_NCC(int mode, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NCC(mode, MaNCC, MaNH);
        }
        public DataTable SelectNguyenLieu_In_NCC(int mode, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_In_NCC(mode, MaNCC, MaNH);
        }
        public DataTable SelectNguyenLieu_NotIn_ChiTietNCC(int mode, int MaNCC, String maNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_NCC(mode, MaNCC, maNH);
        }
        public DataSet SelectNguyenLieu_DatHang(int mode, int MaHoaDon, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_DatHang(mode,MaHoaDon,MaNCC, MaNH);
        }
        public DataTable SelectNguyenLieu_NotIn_DatHang(int mode, int MaHoaDon, int MaNCC, String MaNH)
        {
            return daoNguyenLieu.SelectNguyenLieu_NotIn_DatHang(mode, MaHoaDon, MaNCC, MaNH);
        }

    }
}
