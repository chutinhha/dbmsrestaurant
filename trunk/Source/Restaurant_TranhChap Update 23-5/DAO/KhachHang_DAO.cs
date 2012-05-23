using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KhachHang_DAO
    {
        public static DataTable DocKhachHang()
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select cmnd,TenKhachHang from KhachHang";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
    }
}
