using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class VChiTietNCC_BUS
    {
        VChiTietNCC_DAO daoChiTietNCC;
        public VChiTietNCC_BUS()
        {
            daoChiTietNCC = new VChiTietNCC_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoChiTietNCC.Copy(b.Provider);
        }
        public int InsertChiTietNCC(int mode, int MaNL, int MaNCC, double Gia)
        {
            return daoChiTietNCC.InsertChiTietNCC(mode, MaNL, MaNCC, Gia);
        }
        public int UpdateChiTietNCC(int mode, int MaNL, int MaNCC, double Gia)
        {
            return daoChiTietNCC.UpdateChiTietNCC( mode,MaNL, MaNCC, Gia);
        }
        public int DeleteChiTietNCC_fromNCC(int mode, int flag_connec, int flag_tran, int MaNCC)
        {
            return daoChiTietNCC.DeleteChiTietNCC_fromNCC( mode,MaNCC);
        }
        public int DeleteChiTietNCC(int mode, int MaNL, int MaNCC)
        {
            return daoChiTietNCC.DeleteChiTietNCC(mode, MaNL, MaNCC);
        }
    }
}
