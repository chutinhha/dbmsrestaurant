using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class DatHang_BUS
    {
        public void SelectDatHang(String MaNH)
        {
            DatHang_DAO dh = new DatHang_DAO();
            dh.SelectDatHang(MaNH);
        }
    }
}
