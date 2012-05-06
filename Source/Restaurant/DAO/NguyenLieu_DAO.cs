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
        DataTable tbLoaiMonAn ;
        public NguyenLieu_DAO()
        {
            provider = new Provider();
            tbLoaiMonAn = new DataTable();
        }
        public List<NguyenLieu_DTO> SelectNguyenLieu(String maNH)
        {
            string store = "SelectNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = maNH;
            return ConvertToList(provider.ExecSelectCommand(cm));
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
                nguyenlieu.Gia = (double)row.ItemArray[3];
                nguyenlieu.DonVi = row.ItemArray[4].ToString();
                nguyenlieu.SoLuongTon = (int)row.ItemArray[5];
                ls.Add(nguyenlieu);
            }
            return ls;
        }
        
    }
}
