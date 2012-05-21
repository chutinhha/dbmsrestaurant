using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DatBan_BUS
    {
        DatBan_DAO DatBan_DAO;
        public DatBan_BUS(SqlCommand cm)
        {
            DatBan_DAO = new DatBan_DAO(cm);
        }
        public DatBan_BUS()
        {
            DatBan_DAO = new DatBan_DAO();
        }
        public DataTable DocBanTrong(int maNH)
        {
            return DatBan_DAO.DocBanTrong(maNH);
        }
        //public DataTable DocBanTrong_OpenConnection(int maNH)
        //{
        //    return DatBan_DAO.DocBanTrong(maNH);
        //}
        public DataTable DocBanAn(int maNH,string khuvuc,string succhua,int mode)
        {
            return DatBan_DAO.DocBanAn(maNH,khuvuc,succhua,mode);
        }

        public DataTable DocBanAn_OpenConnection(int maNH, string khuvuc, string succhua,int mode)
        {
            return DatBan_DAO.DocBanAn_BeginTran(maNH, khuvuc, succhua,mode);
        }
        public DataTable DocBanAn_OpenConnection(int maNH, string khuvuc, string succhua)
        {
            return DatBan_DAO.DocBanAn_BeginTran(maNH, khuvuc, succhua);
        }
        public DataTable DocBanAn_CloseConnection(int maNH, string khuvuc, string succhua)
        {
            return DatBan_DAO.DocBanAn_CommitTran(maNH, khuvuc, succhua);
        }
        public DataTable DocBanAn_CloseConnection2(int maNH, string khuvuc, string succhua,int mode)
        {
            return DatBan_DAO.DocBanAn_CommitTran2(maNH, khuvuc, succhua,mode);
        }

        public DataTable DocKhuVuc(int maNH)
        {
            return DatBan_DAO.DocKhuVuc(maNH);
        }

        public DataTable DSBanDatTrongNgay(int maNH, DateTime timeNow)
        {
            return DatBan_DAO.DSBanDatTrongNgay(maNH, timeNow);
        }

        public DataTable DSBanDatTrongNgay_OpenConnection(int maNH, DateTime timeNow,int mode)
        {
            return DatBan_DAO.DSBanDatTrongNgay_BeginTran(maNH, timeNow,mode);
        }

        public DataTable DSBanDatTrongNgay_OpenConnection(int maNH, DateTime timeNow)
        {
            return DatBan_DAO.DSBanDatTrongNgay_BeginTran(maNH, timeNow);
        }

        public DataTable DocSucChua(int maNH)
        {
            return DatBan_DAO.DocSucChua(maNH);
        }

        public DataTable DocLoaiBan()
        {
            return DatBan_DAO.DocLoaiBan();
        }

        public int ThemDatBan(DatBan_DTO banDat)
        {
            return DatBan_DAO.ThemDatBan(banDat);
        }

        public DataTable DocDanhSachBanDat(int maNH,string maBan,string khuVuc,string sucChua,string trangThai,int mode)
        {
            return DatBan_DAO.DocDanhSachBanDat(maNH, maBan, khuVuc, sucChua, trangThai,mode);
        }
        public DataTable DocDanhSachBanDatRefresh(int maNH, string maBan, string khuVuc, string sucChua, string trangThai,ref SqlCommand cm,int mode)
        {
            return DatBan_DAO.DocDanhSachBanDat_BeginTran(maNH, maBan, khuVuc, sucChua, trangThai,ref cm,mode);
        }

        public int UpdateDatBan(DatBan_DTO bandat,string maBan,string maNH,string thoigianden)
        {
            return DatBan_DAO.UpdateDatBan(bandat,maBan,maNH,thoigianden);
        }
        
        public int XoaDatBan(DatBan_DTO bandat)
        {
            return DatBan_DAO.XoaDatBan(bandat);
        }

        public int UpdateTrangThaiBanAn(int MaBan,int trangthai)
        {
            return DatBan_DAO.UpdateTrangThaiBanAn(MaBan,trangthai );
        }
        public int UpdateTrangThaiBanAn_CommitTran(int MaBan, int trangthai)
        {
            return DatBan_DAO.UpdateTrangThaiBanAn_CommitTran(MaBan, trangthai);
        }

        public int UpdateTrangThaiDatBan(int maNH, int MaBan, int trangthai, DateTime thoigianden)
        {
            return DatBan_DAO.UpdateTrangThaiDatBan(maNH, MaBan, trangthai, thoigianden);
        }
    }
}
