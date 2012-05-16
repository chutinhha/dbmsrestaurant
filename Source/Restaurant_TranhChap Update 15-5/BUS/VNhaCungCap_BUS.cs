using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class VNhaCungCap_BUS:VBus
    {
        VNhaCungCap_DAO daoNhaCungCap;
        public VNhaCungCap_BUS()
        {
            daoNhaCungCap = new VNhaCungCap_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoNhaCungCap.Provider = b.Provider;
        }

        public List<VNhaCungCap_DTO> SelectNhaCungCap()
        {
            return daoNhaCungCap.SelectNhaCungCap();
        }
        public List<VNhaCungCap_DTO> SelectNhaCungCap_fromNH(String MaNH)
        {
            return  daoNhaCungCap.SelectNhaCungCap_fromNH( MaNH);
        }
        public int InsertNhaCungCap(int flag_connec, int flag_tran, VNhaCungCap_DTO ncc)
        {
            return daoNhaCungCap.InsertNhaCungCap(ncc);
        }
        public int UpdatetNhaCungCap( String TenNCC, VNhaCungCap_DTO ncc)
        {
            return daoNhaCungCap.UpdateNhaCungCap( TenNCC, ncc);
        }
        public void DeleteNhaCungCap(int MaNCC)
        {
            daoNhaCungCap.DeleteNhaCungCap(MaNCC);
        }
    }
}
