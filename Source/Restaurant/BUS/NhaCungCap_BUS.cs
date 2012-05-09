using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class NhaCungCap_BUS
    {

        public static List<NhaCungCap_DTO> SelectNhaCungCap()
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.SelectNhaCungCap();
        }
        public static List<NhaCungCap_DTO> SelectNhaCungCap_fromNH(String MaNH)
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.SelectNhaCungCap_fromNH(MaNH);
        }
        public static int InsertNhaCungCap(NhaCungCap_DTO ncc)
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.InsertNhaCungCap(ncc);
        }
        public static int UpdatetNhaCungCap(String TenNCC,NhaCungCap_DTO ncc)
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.UpdateNhaCungCap(TenNCC, ncc);
        }
        public static void DeleteNhaCungCap(int MaNCC)
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            NhaCungCapDAO.DeleteNhaCungCap(MaNCC);
        }
    }
}
