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
        Provider_Vu _provider;
        public Provider_Vu Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public NguyenLieu_DAO()
        {
            provider = new Provider();
            _provider = new Provider_Vu();
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu(int flag_connec,int flag_tran,String MaNH)
        {
            String store = "SelectNguyenLieu";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@maNH", SqlDbType.NChar);

            _provider.Command.Parameters["@maNH"].Value = MaNH;
            return ConvertToList(_provider.ExecSelectCommand(flag_connec,flag_tran));
        }
        public DataTable SelectNguyenLieu_toDataTable(String MaNH)
        {
            String store = "SelectNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return provider.ExecSelectCommand(cm);
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_fromNCC(int flag_connec,int flag_tran,int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_fromNCC";
            if(flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNH", SqlDbType.NChar);

            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;
            _provider.Command.Parameters["@MaNH"].Value = MaNH;
            return ConvertToList(_provider.ExecSelectCommand(flag_connec,flag_tran));
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietNCC(int flag_connec, int flag_tran, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_ChiTietNCC";
            if(flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@maNH", SqlDbType.NChar);

            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;
            _provider.Command.Parameters["@maNH"].Value = MaNH;
            return ConvertToList(_provider.ExecSelectCommand(flag_connec,flag_connec));
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu_NotIn_ChiTietDatHang(int flag_connec, int flag_tran, int MaHoaDon, int MaNCC, String MaNH)
        {
            String store = "SelectNguyenLieu_NotIn_ChiTietDatHang";
            if(flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNH", SqlDbType.NChar);

            _provider.Command.Parameters["@MaHoaDon"].Value = MaHoaDon;
            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;
            _provider.Command.Parameters["@MaNH"].Value = MaNH;
            return ConvertToList(_provider.ExecSelectCommand(flag_connec,flag_tran));
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
                catch (Exception){}
                ls.Add(nguyenlieu);
            }
            return ls;
        }
        
    }
}
