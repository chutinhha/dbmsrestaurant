using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiMonAn_BUS
    {
        public DataTable DocLoaiMonAn()
        {
            LoaiMonAn_DAO loaimonan = new LoaiMonAn_DAO();
            return loaimonan.DocLoaiMonAn();
        }
    }
}
