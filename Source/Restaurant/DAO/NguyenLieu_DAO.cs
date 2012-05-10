using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NguyenLieu_DAO
    {
        Provider provider ;
        public NguyenLieu_DAO()
        {
            provider = new Provider();
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu(String MaNH)
        {
            String store = "SelectNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_fromNCC(int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_fromNCC";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietNCC(int MaNCC,String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_ChiTietNCC";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@maNH"].Value = MaNH;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietDatHang(int MaHoaDon,int MaNCC,String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_ChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
             cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public int InsertNguyenLieu(NguyenLieu_DTO nl)
        {
            String store = "InsertNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cm.Parameters.Add("@DonVi", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoLuongTon", SqlDbType.Int);

            cm.Parameters["@MaNH"].Value = nl.MaNH;
            cm.Parameters["@TenNL"].Value = nl.TenNL;
            cm.Parameters["@DonVi"].Value = nl.DonVi;
            cm.Parameters["@SoLuongTon"].Value = nl.SoLuongTon;

            provider.ExecuteInsertUpdateDelete(cm);
            return (int)cm.Parameters["@Flag"].Value;
        }
        public void DeleteNguyenLieu(int MaNL,String MaNH)
        {
            String store = "DeleteNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNL",SqlDbType.Int);
            cm.Parameters.Add("@MaNH",SqlDbType.NChar);

            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNH"].Value = MaNH;
            provider.ExecuteInsertUpdateDelete(cm);
        }
        public int UpdateNguyenLieu(String TenNL,NguyenLieu_DTO nl)
        {
            String store = "UpdateNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@TenNL_old", SqlDbType.NVarChar);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cm.Parameters.Add("@DonVi", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoLuongTon", SqlDbType.Int);

            cm.Parameters["@TenNL_old"].Value = TenNL;
            cm.Parameters["@MaNL"].Value = nl.MaNL;
            cm.Parameters["@MaNH"].Value = nl.MaNH;
            cm.Parameters["@TenNL"].Value = nl.TenNL;
            cm.Parameters["@DonVi"].Value = nl.DonVi;
            cm.Parameters["@SoLuongTon"].Value = nl.SoLuongTon;

           provider.ExecuteInsertUpdateDelete(cm);
           return (int)cm.Parameters["@Flag"].Value;
        }
        private List<NguyenLieu_DTO> ConvertToList(DataTable dt)
        {
            List<NguyenLieu_DTO> ls = new List<NguyenLieu_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                NguyenLieu_DTO nguyenlieu =new NguyenLieu_DTO();
                nguyenlieu.MaNL = (int)row.ItemArray[0];
                nguyenlieu.MaNH = row.ItemArray[1].ToString();
                nguyenlieu.TenNL = row.ItemArray[2].ToString();
                nguyenlieu.DonVi = row.ItemArray[3].ToString();
                nguyenlieu.SoLuongTon = (int)row.ItemArray[4];
                try
                {
                    nguyenlieu.Gia = (double)row.ItemArray[5];
                }
                catch (Exception)
                {
                    nguyenlieu.Gia = 0;
                }
                ls.Add(nguyenlieu);
            }
            return ls;
        }
        
    }
}
