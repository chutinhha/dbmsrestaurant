using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class MonAn_DAO
    {
        Provider provider;
        public  DataTable DocMonAn()
        {
            string str_sql = "select TenMon,TenLoai,Gia,DonViTinh,TenNH";
            str_sql+= " from MonAn m,LoaiMonAn lm,NhaHang nh";
            str_sql+= " where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH";

            provider = new Provider();
            provider.cm = provider.CreateCommand(str_sql);
            DataTable tb = new DataTable();
            tb.Load(provider.cm.ExecuteReader());
            provider.cnn.Close();
            return tb;
        }
    }
}
