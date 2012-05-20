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

        public List<VNhaCungCap_DTO> SelectNhaCungCap(int mode)
        {
            return daoNhaCungCap.SelectNhaCungCap(mode);
        }
        public List<VNhaCungCap_DTO> SelectNhaCungCap_fromNH(int mode, String MaNH)
        {
            return  daoNhaCungCap.SelectNhaCungCap_fromNH( mode, MaNH);
        }
        public int InsertNhaCungCap(int mode, VNhaCungCap_DTO ncc, DataTable ChiTiet)
        {
            return daoNhaCungCap.InsertNhaCungCap( mode,ncc,ChiTiet);
        }
        public int UpdatetNhaCungCap(int mode, VNhaCungCap_DTO ncc, DataTable ChiTiet)
        {
            return daoNhaCungCap.UpdateNhaCungCap( mode,ncc,ChiTiet);
        }
        public int DeleteNhaCungCap(int mode, int MaNCC)
        {
            return daoNhaCungCap.DeleteNhaCungCap(mode,MaNCC);
        }
    }
}
