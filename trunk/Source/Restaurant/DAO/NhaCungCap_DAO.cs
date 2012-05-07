using System;
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
        public NhaCungCap_DAO()
        {
            provider = new Provider();
        }
        public List<NhaCungCap_DTO> SelectNhaCungCap()
        {
            String store = "SelectNhaCungCap";
            SqlCommand cm = provider.CreateCommandStoreName(store);

            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public int InsertNhaCungCap(NhaCungCap_DTO ncc)
        {
            String store = "InsertNhaCungCap";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@TenNCC", SqlDbType.NVarChar);
            cm.Parameters.Add("@sdt", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiemUuTien", SqlDbType.Int);

            cm.Parameters["@TenNCC"].Value = ncc.TenNCC;
            cm.Parameters["@sdt"].Value = ncc.sdt;
            cm.Parameters["@DiaChi"].Value = ncc.DiaChi;
            cm.Parameters["@DiemUuTien"].Value = ncc.DiemUuTien;

            provider.ExecuteInsertUpdateDelete(cm);
            int a = (int)cm.Parameters["@MaNCC"].Value;
            return (int)cm.Parameters["@MaNCC"].Value;
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
