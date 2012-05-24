using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class MonAn_BUS
    {
        public static DataTable DocMonAn(int mode,string maNH)
        {
            return MonAn_DAO.DocMonAn(mode,maNH);
        }

        //public static DataTable DocMonAn_Commit()
        //{
        //    return MonAn_DAO.DocMonAn_Commit();
        //}

        public static int ThemMonAn(int mode,MonAn_DTO monAn, string maNH)
        {
            return MonAn_DAO.ThemMonAn(mode,monAn, maNH);
        }

        public static DataTable LayLoaiMon()
        {
            return MonAn_DAO.LayLoaiMon();
        }

        public static DataTable LayNhaHang()
        {
            return MonAn_DAO.LayNhaHang();
        }

        public static int CapNhatMonAn(int mode,MonAn_DTO MonAn, int maMonAn, string maNH)
        {
            return MonAn_DAO.CapNhatMonAn(mode,MonAn, maMonAn);
        }
        /////////////--------------------------------------------------
        //public static int CapNhatMonAn_Commmit(MonAn_DTO MonAn, int maMonAn)
        //{
        //    return MonAn_DAO.CapNhatMonAn_Commit(MonAn, maMonAn);
        //}
        //-----------------------------------------------------------------
        public static int XoaMonAn(int mode,int maMonAn)
        {
            return MonAn_DAO.XoaMonAn(mode,maMonAn);
        }

        public static DataTable SelectMonAnTheoLoai(String maloai, String manh)
        {
            MonAn_DAO dao = new MonAn_DAO();
            return dao.SelectMonAnTheoLoai(maloai, manh);
        }

        public static DataTable TimTheoLoai(int mode,string maLoai, string MaNH, ref int sl)
        {
            return MonAn_DAO.TimTheoLoai(mode,maLoai, MaNH, ref sl);
        }
    }
}
