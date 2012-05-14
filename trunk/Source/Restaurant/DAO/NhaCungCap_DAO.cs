﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhaCungCap_DAO
    {
        Provider provider ;
        Provider_Vu _provider;
        public Provider_Vu Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public NhaCungCap_DAO()
        {
            provider = new Provider();
            _provider = new Provider_Vu();
        }
        public List<NhaCungCap_DTO> SelectNhaCungCap()
        {
            String store = "SelectNhaCungCap";
            SqlCommand cm = provider.CreateCommandStoreName(store);

            return ConvertToList(provider.ExecSelectCommand(cm));
        }

        public List<NhaCungCap_DTO> SelectNhaCungCap_fromNH(int flag_connec,int flag_tran,String MaNH)
        {
            String store = "SelectNhaCungCap_fromNH";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNH", SqlDbType.NChar);

            _provider.Command.Parameters["@MaNH"].Value = MaNH;

            return ConvertToList(_provider.ExecSelectCommand(flag_connec,flag_tran));
        }

        public int InsertNhaCungCap(int flag_connec, int flag_tran, NhaCungCap_DTO ncc)
        {
            String store = "InsertNhaCungCap";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int).Direction = ParameterDirection.Output;
            _provider.Command.Parameters.Add("@TenNCC", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@sdt", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@DiemUuTien", SqlDbType.Int);

            _provider.Command.Parameters["@TenNCC"].Value = ncc.TenNCC;
            _provider.Command.Parameters["@sdt"].Value = ncc.sdt;
            _provider.Command.Parameters["@DiaChi"].Value = ncc.DiaChi;
            _provider.Command.Parameters["@DiemUuTien"].Value = ncc.DiemUuTien;

            _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
            return (int)_provider.Command.Parameters["@MaNCC"].Value;
        }
        public int UpdateNhaCungCap(int flag_connec, int flag_tran, String TenNCC, NhaCungCap_DTO ncc)
        {
            String store = "UpdateNhaCungCap";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            _provider.Command.Parameters.Add("@TenNCC_old", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@TenNCC", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@sdt", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            _provider.Command.Parameters.Add("@DiemUuTien", SqlDbType.Int);

            _provider.Command.Parameters["@TenNCC_old"].Value = TenNCC;
            _provider.Command.Parameters["@MaNCC"].Value = ncc.MaNCC;
            _provider.Command.Parameters["@TenNCC"].Value = ncc.TenNCC;
            _provider.Command.Parameters["@sdt"].Value = ncc.sdt;
            _provider.Command.Parameters["@DiaChi"].Value = ncc.DiaChi;
            _provider.Command.Parameters["@DiemUuTien"].Value = ncc.DiemUuTien;

            _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
            return (int)_provider.Command.Parameters["@Flag"].Value;
        }
        public void DeleteNhaCungCap(int MaNCC)
        {
            String store = "DeleteNhaCungCap";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters["@MaNCC"].Value = MaNCC;
            ConvertToList(provider.ExecSelectCommand(cm));
        }
        private List<NhaCungCap_DTO> ConvertToList(DataTable dt)
        {
            List<NhaCungCap_DTO> ls = new List<NhaCungCap_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.MaNCC = (int)row.ItemArray[0];
                ncc.TenNCC = row.ItemArray[1].ToString();
                ncc.sdt = row.ItemArray[2].ToString();
                ncc.DiaChi = row.ItemArray[3].ToString();
                ncc.DiemUuTien = (int)row.ItemArray[4];
                ls.Add(ncc);
            }
            return ls;
        }
    }
}