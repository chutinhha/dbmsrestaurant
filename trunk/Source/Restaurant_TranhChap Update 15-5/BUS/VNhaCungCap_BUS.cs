using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class VNhaCungCap_BUS
    {
        VNhaCungCap_DAO daoNhaCungCap;
        public VNhaCungCap_BUS()
        {
            daoNhaCungCap = new VNhaCungCap_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoNhaCungCap.Copy(b.Provider);
        }

        public List<VNhaCungCap_DTO> SelectNhaCungCap()
        {
            return daoNhaCungCap.SelectNhaCungCap();
        }
        public List<VNhaCungCap_DTO> SelectNhaCungCap_fromNH(String MaNH)
        {
            return  daoNhaCungCap.SelectNhaCungCap_fromNH( MaNH);
        }
        public int InsertNhaCungCap( VNhaCungCap_DTO ncc,DataTable ChiTiet)
        {
            return daoNhaCungCap.InsertNhaCungCap(ncc,ChiTiet);
        }
        public int UpdatetNhaCungCap(VNhaCungCap_DTO ncc, DataTable ChiTiet)
        {
            return daoNhaCungCap.UpdateNhaCungCap( ncc,ChiTiet);
        }
        public int DeleteNhaCungCap(int MaNCC)
        {
            return daoNhaCungCap.DeleteNhaCungCap(MaNCC);
        }
    }
}
