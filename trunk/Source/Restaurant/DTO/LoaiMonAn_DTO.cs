using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DTO
{
   public class LoaiMonAn_DTO
    {
        //private DataTable tbLoaiMonAn;

        //public DataTable TbLoaiMonAn
        //{
        //    get { return tbLoaiMonAn; }
        //    set { tbLoaiMonAn = value; }
        //}
        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string tenloai;

        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
    }
}
