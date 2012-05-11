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
       
        NhaCungCap_DAO _NhaCungCapDAO;
        public NhaCungCap_DAO NhaCungCapDAO
        {
            get { return _NhaCungCapDAO; }
            set { _NhaCungCapDAO = value; }
        }
        public NhaCungCap_BUS()
        {
            _NhaCungCapDAO = new NhaCungCap_DAO();
        }
        public static List<NhaCungCap_DTO> SelectNhaCungCap()
        {
            NhaCungCap_DAO NhaCungCapDAO = new NhaCungCap_DAO();
            return NhaCungCapDAO.SelectNhaCungCap();
        }
        public List<NhaCungCap_DTO> SelectNhaCungCap_fromNH(int flag_connec,int flag_tran,String MaNH)
        {
            return _NhaCungCapDAO.SelectNhaCungCap_fromNH(flag_connec,flag_tran, MaNH);
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
