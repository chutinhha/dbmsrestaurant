using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Collections;

namespace DAO
{
    class NguyenLieu_DAO
    {
        public static DataTable SelectNguyenLieu(String maNH)
        {
            Provider provider = new Provider();
            DataTable tbLoaiMonAn = new DataTable();
            string store = "SelectNguyenLieu";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            return provider.ExecSelectCommand(cm);
        }
      //  private
        
    }
}
