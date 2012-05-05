using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu_DTO> SelectNguyenLieu(String maNH)
        {
            NguyenLieu_DAO nguyenlieuDAO = new NguyenLieu_DAO();
            return nguyenlieuDAO.SelectNguyenLieu(maNH);
        }
    }
}
