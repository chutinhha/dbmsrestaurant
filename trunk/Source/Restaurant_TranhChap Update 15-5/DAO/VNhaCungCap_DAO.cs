using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class VNhaCungCap_DAO:VProvider
    {

        public List<VNhaCungCap_DTO> SelectNhaCungCap()
        {
            String store = "SelectNhaCungCap";
            CreateCommand_StoreName(store);

            return ConvertToList(ExecSelectCommand());
        }

        public List<VNhaCungCap_DTO> SelectNhaCungCap_fromNH(String MaNH)
        {
            String store = "SelectNhaCungCap_fromNH";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);

            cm.Parameters["@MaNH"].Value = MaNH;

            return ConvertToList(ExecSelectCommand());
        }

        public int InsertNhaCungCap(VNhaCungCap_DTO ncc,DataTable ChiTiet)
        {
            String store = "InsertNhaCungCap";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@TenNCC", SqlDbType.NVarChar);
            cm.Parameters.Add("@sdt", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiemUuTien", SqlDbType.Int);
            cm.Parameters.Add("@ChiTiet", SqlDbType.Structured);

            cm.Parameters["@TenNCC"].Value = ncc.TenNCC;
            cm.Parameters["@sdt"].Value = ncc.sdt;
            cm.Parameters["@DiaChi"].Value = ncc.DiaChi;
            cm.Parameters["@DiemUuTien"].Value = ncc.DiemUuTien;
            cm.Parameters["@ChiTiet"].Value = ChiTiet;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@MaNCC"].Value;
        }
        public int UpdateNhaCungCap(VNhaCungCap_DTO ncc,DataTable ChiTiet)
        {
            String store = "UpdateNhaCungCap";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@TenNCC", SqlDbType.NVarChar);
            cm.Parameters.Add("@sdt", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiemUuTien", SqlDbType.Int);
            cm.Parameters.Add("@ChiTiet", SqlDbType.Structured);

            cm.Parameters["@MaNCC"].Value = ncc.MaNCC;
            cm.Parameters["@TenNCC"].Value = ncc.TenNCC;
            cm.Parameters["@sdt"].Value = ncc.sdt;
            cm.Parameters["@DiaChi"].Value = ncc.DiaChi;
            cm.Parameters["@DiemUuTien"].Value = ncc.DiemUuTien;
            cm.Parameters["@ChiTiet"].Value = ChiTiet;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        public int DeleteNhaCungCap(int MaNCC)
        {
            String store = "DeleteNhaCungCap";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters["@MaNCC"].Value = MaNCC;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        private List<VNhaCungCap_DTO> ConvertToList(DataTable dt)
        {
            List<VNhaCungCap_DTO> ls = new List<VNhaCungCap_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                VNhaCungCap_DTO ncc = new VNhaCungCap_DTO();
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
