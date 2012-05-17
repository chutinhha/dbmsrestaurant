using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DatBan_DAO
    {
        Provider provider;
        public DatBan_DAO(SqlCommand cm)
        {
           // IsolationLevel.Chaos
            provider = new Provider(cm);
        }
        public DatBan_DAO()
        {
           provider = new Provider();
        }
     //   SqlCommand cm;
        //đọc danh sách bàn Ăn
        public DataTable DocBanTrong(int maNH)
        {        
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH="+maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocBanAn(int maNH,string khuvuc,string succhua)
        {
            //Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH=" + maNH + khuvuc + succhua;
            sql+="  and b.maban not in(select MaBan from DatBan where MaNH=1 and ThoiGianDen=CONVERT(nvarchar,GETDATE(),101) and TrangThai=0)";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocBanAn_CommitTran(int maNH, string khuvuc, string succhua)
        {
            //Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH=" + maNH + khuvuc + succhua;
           // sql += " and b.maban not in(select MaBan from DatBan where MaNH="+ maNH+" and ThoiGianDen=CONVERT(nvarchar,GETDATE(),101) and TrangThai=0)";
            sql+=" commit tran";
            provider.cm = provider.CreateCommandStringSql (sql);
            return provider.ExecSelectCommand_CloseConnection(provider.cm);
        }
        public DataTable DocBanAn_CommitTran2(int maNH, string khuvuc, string succhua)
        {
            //Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "waitfor delay '0:0:10' select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH=" + maNH + khuvuc + succhua;
            sql += " and b.maban not in(select MaBan from DatBan where MaNH=" + maNH + " and ThoiGianDen=CONVERT(nvarchar,GETDATE(),101) and TrangThai=0)";
            sql += " commit tran";
            provider.cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand_CloseConnection(provider.cm);
        }
        public DataTable DocBanAn_BeginTran(int maNH, string khuvuc, string succhua)
        {
            //Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL repeatable read begin tran select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH=" + maNH + khuvuc + succhua;
            provider.cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand_OpenConnection(provider.cm);
        }
        public DataTable DSBanDatTrongNgay(int maNH, DateTime timeNow)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select MaBan from DatBan where MaNH=" + maNH + " and ThoiGianDen='" + timeNow.ToString("MM/dd/yyyy") + "' and TrangThai=0";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DSBanDatTrongNgay_BeginTran(int maNH, DateTime timeNow)
        {
            // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED begin tran select MaBan from DatBan where MaNH=" + maNH + " and ThoiGianDen='" + timeNow.ToString("MM/dd/yyyy") + "' and TrangThai=0";
            provider.cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand_OpenConnection(provider.cm);
        }
        public DataTable DocSucChua(int maNH)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select MaLoai,SucChua from LoaiBan";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocKhuVuc(int maNH)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select MaKhuVuc,TenKhuVuc from KhuVuc where MaNH=" + maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocLoaiBan()
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select MaLoai,SucChua from LoaiBan ";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocDanhSachBanDat(int maNH, string maBan, string khuVuc, string sucChua, string trangThai)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select b.MaBan,TenKhachHang,TenKhuVuc,ViTri,SucChua,ThoiGianDat,ThoiGianDen,d.MaKhachHang, ";
            sql += " case(d.TrangThai) when 0 then N'Chưa đến ăn' else N'Đã đến ăn' end as TrangThai";
            sql += " from banan b,khuvuc k,loaiban l,datban d, khachhang kh ";
            sql += " where b.maban=d.maban and b.makhuvuc=k.makhuvuc and b.loaiban=l.maloai and d.maKhachHang=kh.cmnd and d.manh=" + maNH + maBan + khuVuc + sucChua + trangThai;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public DataTable DocDanhSachBanDat_BeginTran(int maNH, string maBan, string khuVuc, string sucChua, string trangThai,ref SqlCommand cm)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED begin tran select b.MaBan,TenKhachHang,TenKhuVuc,ViTri,SucChua,ThoiGianDat,ThoiGianDen,d.MaKhachHang, ";
            sql += " case(d.TrangThai) when 0 then N'Chưa đến ăn' else N'Đã đến ăn' end as TrangThai";
            sql += " from banan b,khuvuc k,loaiban l,datban d, khachhang kh ";
            sql += " where b.maban=d.maban and b.makhuvuc=k.makhuvuc and b.loaiban=l.maloai and d.maKhachHang=kh.cmnd and d.manh=" + maNH + maBan + khuVuc + sucChua + trangThai;
            provider.cm = provider.CreateCommandStringSql(sql);
            tb= provider.ExecSelectCommand_OpenConnection(provider.cm);
            cm = provider.cm;
            return tb;
        }
        public int ThemDatBan(DatBan_DTO bandat)
        {
           // Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            string thoigianden = t.ToString("MM/dd/yyyy");
            if (bandat.Sdt == "")
                bandat.Sdt = "0";
            string sql = string.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED begin tran insert into DatBan values({0},{1},{2},'{3}',{4},'{5}',{6})", bandat.MaNH, bandat.MaBan, bandat.MaKhachHang, DateTime.Now.ToString("MM/dd/yyyy"), 0, thoigianden, bandat.Sdt);//0 ban dat
            sql += " waitfor delay '0:0:5'";
            sql += "declare @sdt int ";
            sql+="select @sdt=sdt from DatBan where maban="+bandat.MaBan;
            sql+=" if @sdt=0";
            sql+="	rollback tran"; 
            sql+=" else commit tran";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        //cập nhật lại tình trang bên bảng Bàn Ăn khi có 1 bàn được đặt
        public int UpdateTrangThaiBanAn(int MaBan,int trangthai)
        {
           // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "update BanAn set TrangThai=" + trangthai +" where MaBan=" + MaBan;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public int UpdateTrangThaiBanAn_CommitTran(int MaBan, int trangthai)
        {
            // Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = " waitfor delay '0:0:10' update BanAn set TrangThai=" + trangthai + " where MaBan=" + MaBan+" commit tran";
            provider.cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete_CloseConnection(provider.cm);
        }
        public int UpdateTrangThaiDatBan(int maNH,int MaBan, int trangthai,DateTime thoigianden)
        {
          //  Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "update DatBan set TrangThai=" + trangthai + " where MaBan=" + MaBan+" and maNH="+maNH+" and ThoiGianDen='"+thoigianden.ToString("MM/dd/yyyy")+"'";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        //cập nhật lại thông tin đặt bàn.Nếu có Trạng thái là Đã đến ăn thì cập nhật Tình Trạng bên bảng Bàn Ăn luôn.
        public int UpdateDatBan(DatBan_DTO bandat,string maban,string maNH,string thoiGianden)
        {
           // Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            string timeDen = t.ToString("MM/dd/yyyy");
            //t = DateTime.Parse(bandat.ThoiGianDat);
            //string timenDat = t.ToString("MM/dd/yyyy");

            //t = DateTime.Parse(luuBanDat.ThoiGianDen);
            //luuBanDat.ThoiGianDen = t.ToString("MM/dd/yyyy");
            int trangthai=0;
            if (bandat.TrangThai == "Chưa đến ăn")
                trangthai = 0;
            else
                trangthai = 1;
            string sql = string.Format("waitfor delay '0:0:5' update DatBan set MaBan={0},MaKhachHang={1},ThoiGianDen='{2}',TrangThai={3} where MaNH={4} and MaBan={5} and ThoiGianDen='{6}' commit tran ", bandat.MaBan, bandat.MaKhachHang, timeDen, trangthai, maNH, maban, thoiGianden);//0 ban dat
            provider.cm = provider.CreateCommand_CommitTran(sql);

            int flag = provider.ExecuteInsertUpdateDelete_CloseConnection(provider.cm);

            if (trangthai == 1)//khi da den an
            {
                string sqlBanAn = "update BanAn set TrangThai=1 where MaBan=" + bandat.MaBan;
                SqlCommand cmBanAn = provider.CreateCommandStringSql(sqlBanAn);
                provider.ExecuteInsertUpdateDelete(cmBanAn);
               
            }
            return flag;
        }
        public int XoaDatBan(DatBan_DTO bandat)
        {
           // Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            string thoigianden = t.ToString("MM/dd/yyyy");
            string sql = string.Format("delete from DatBan where MaNH={0} and MaBan={1} and ThoiGianDen='{2}' ",bandat.MaNH,bandat.MaBan,thoigianden);//0 ban dat
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
