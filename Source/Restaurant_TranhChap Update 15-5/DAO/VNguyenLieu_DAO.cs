using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class VNguyenLieu_DAO:VProvider
    {
        public List<VNguyenLieu_DTO> SelectNguyenLieu(int mode, String MaNH)
        {
            String store = "SelectNguyenLieu";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return ConvertToList(ExecSelectCommand());
        }
        public DataTable SelectNguyenLieu_toDataTable(int mode, String MaNH)
        {
            String store = "SelectNguyenLieu";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return ExecSelectCommand();
        }
        public int InsertNguyenLieu(int mode, VNguyenLieu_DTO nl)
        {
            String store = "InsertNguyenLieu";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cm.Parameters.Add("@DonVi", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoLuongTon", SqlDbType.Int);

            cm.Parameters["@MaNH"].Value = nl.MaNH;
            cm.Parameters["@TenNL"].Value = nl.TenNL;
            cm.Parameters["@DonVi"].Value = nl.DonVi;
            cm.Parameters["@SoLuongTon"].Value = nl.SoLuongTon;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        public int UpdateNguyenLieu(int mode, VNguyenLieu_DTO nl)
        {
            String store = "UpdateNguyenLieu";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cm.Parameters.Add("@DonVi", SqlDbType.NVarChar);
            cm.Parameters.Add("@SoLuongTon", SqlDbType.Int);

            cm.Parameters["@MaNL"].Value = nl.MaNL;
            cm.Parameters["@MaNH"].Value = nl.MaNH;
            cm.Parameters["@TenNL"].Value = nl.TenNL;
            cm.Parameters["@DonVi"].Value = nl.DonVi;
            cm.Parameters["@SoLuongTon"].Value = nl.SoLuongTon;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        public int DeleteNguyenLieu(int mode, int MaNL, String MaNH)
        {
            String store = "DeleteNguyenLieu";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            
            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNH"].Value = MaNH;
            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }


        public DataSet SelectNguyenLieu_NCC(int mode, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_NCC";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;

            return   FillDataSet(); 
        }
        public DataTable SelectNguyenLieu_In_NCC(int mode, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_In_NCC";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;
            return ExecSelectCommand();
        }
        public DataTable SelectNguyenLieu_NotIn_NCC(int mode, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_NCC";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@maNH"].Value = MaNH;
            return ExecSelectCommand();
        }

        public DataSet SelectNguyenLieu_DatHang(int mode, int MaHoaDon, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_DatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;

            return FillDataSet();
        }
        public DataTable SelectNguyenLieu_NotIn_DatHang(int mode, int MaHoaDon, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_DatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@MaNH"].Value = MaNH;
            return ExecSelectCommand();
        }

        private List<VNguyenLieu_DTO> ConvertToList(DataTable dt)
        {
            List<VNguyenLieu_DTO> ls = new List<VNguyenLieu_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                VNguyenLieu_DTO nguyenlieu =new VNguyenLieu_DTO();
                nguyenlieu.MaNL = (int)row.ItemArray[0];
                nguyenlieu.MaNH = row.ItemArray[1].ToString();
                nguyenlieu.TenNL = row.ItemArray[2].ToString();
                nguyenlieu.DonVi = row.ItemArray[3].ToString();
                nguyenlieu.SoLuongTon = (int)row.ItemArray[4];
                try
                {
                    nguyenlieu.Gia = (double)row.ItemArray[5];
                }
                catch (Exception){}
                ls.Add(nguyenlieu);
            }
            return ls;
        }
        
    }
}
