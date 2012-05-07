using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietNCC_DAO
    {
        Provider provider ;
        public ChiTietNCC_DAO()
        {
            provider = new Provider();
        }
        //public List<ChiTietNCC_DTO> SelectNhaCungCap(int MaNCC,String MaNH)
        //{
        //    String store = "SelectChiTietNCC_MaNCC";
        //    SqlCommand cm = provider.CreateCommandStoreName(store);
        //    cm.Parameters.Add("@MaNCC", SqlDbType.Int);
        //    cm.Parameters.Add("@MaNH", SqlDbType.NChar);

        //    cm.Parameters["@MaNCC"].Value = MaNCC;
        //    cm.Parameters["@MaNH"].Value = MaNH;
        //    return ConvertToList(provider.ExecSelectCommand(cm));
        //}

        public int InsertChiTietNCC(int MaNL,int MaNCC)
        {
            String store = "InsertChiTietNCC";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);

            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNCC"].Value = MaNCC;

            return  provider.ExecuteInsertUpdateDelete(cm);
        }
        private List<ChiTietNCC_DTO> ConvertToList(DataTable dt)
        {
            List<ChiTietNCC_DTO> ls = new List<ChiTietNCC_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietNCC_DTO ct = new ChiTietNCC_DTO();
                ct.MaNL= (int)row.ItemArray[0];
                ct.MaNCC = (int)row.ItemArray[1];
                ct.TenNL = row.ItemArray[2].ToString();
                ls.Add(ct);
            }
            return ls;
        }
    }
}
