using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class LoaiMonAn_DAO
    {
        Provider provider = new Provider();

        public DataTable DocLoaiMonAn()
        {
            DataTable tbLoaiMonAn = new DataTable();
            string sql = "select MaLoai,TenLoai from LoaiMonAn";
            provider.cm = provider.CreateCommand(sql);
            tbLoaiMonAn.Load(provider.cm.ExecuteReader());
            provider.cnn.Close();
            return tbLoaiMonAn;
        }
    }
}
