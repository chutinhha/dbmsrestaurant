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
        //đọc danh sách bàn Ăn
        public static DataTable DocBanTrong(int maNH)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua,b.TrangThai,nh.TenNH";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb,NhaHang nh";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and nh.MaNH=n.MaNH and n.MaNH="+maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static DataTable DSBanDatTrongNgay(int maNH, DateTime timeNow)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select MaBan from DatBan where MaNH="+maNH+" and ThoiGianDen='"+timeNow.ToString("MM/dd/yyyy")+"' and TrangThai=0";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }

        public static DataTable DocKhuVuc(int maNH)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select MaKhuVuc,TenKhuVuc from KhuVuc where MaNH="+maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static DataTable DocLoaiBan()
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select MaLoai,SucChua from LoaiBan ";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static DataTable DocDanhSachBanDat(int maNH, string maBan, string khuVuc, string sucChua, string trangThai)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select b.MaBan,TenKhachHang,TenKhuVuc,ViTri,SucChua,ThoiGianDat,ThoiGianDen,d.MaKhachHang, ";
            sql += " case(d.TrangThai) when 0 then N'Chưa đến ăn' else N'Đã đến ăn' end as TrangThai";
            sql += " from banan b,khuvuc k,loaiban l,datban d, khachhang kh ";
            sql += " where b.maban=d.maban and b.makhuvuc=k.makhuvuc and b.loaiban=l.maloai and d.maKhachHang=kh.cmnd and d.manh=" + maNH + maBan + khuVuc + sucChua + trangThai;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static int ThemDatBan(DatBan_DTO bandat)
        {
            Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            string thoigianden = t.ToString("MM/dd/yyyy");
            string sql = string.Format("insert into DatBan values({0},{1},{2},'{3}',{4},'{5}',{6})",bandat.MaNH,bandat.MaBan,bandat.MaKhachHang,DateTime.Now.ToString("MM/dd/yyyy"),0,thoigianden,bandat.Sdt);//0 ban dat
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        //cập nhật lại tình trang bên bảng Bàn Ăn khi có 1 bàn được đặt
        public static int UpdateTrangThaiBanAn(int MaBan,int trangthai)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "update BanAn set TrangThai=" + trangthai +" where MaBan=" + MaBan;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public static int UpdateTrangThaiDatBan(int maNH,int MaBan, int trangthai,DateTime thoigianden)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "update DatBan set TrangThai=" + trangthai + " where MaBan=" + MaBan+" and maNH="+maNH+" and ThoiGianDen='"+thoigianden.ToString("MM/dd/yyyy")+"'";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        //cập nhật lại thông tin đặt bàn.Nếu có Trạng thái là Đã đến ăn thì cập nhật Tình Trạng bên bảng Bàn Ăn luôn.
        public static int UpdateDatBan(DatBan_DTO bandat,string maban,string maNH,string thoiGianden)
        {
            Provider provider = new Provider();
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
            string sql = string.Format("update DatBan set MaBan={0},MaKhachHang={1},ThoiGianDen='{2}',TrangThai={3} where MaNH={4} and MaBan={5} and ThoiGianDen='{6}'",bandat.MaBan,bandat.MaKhachHang,timeDen,trangthai,maNH,maban,thoiGianden);//0 ban dat
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            if (trangthai == 1)//khi da den an
            {
                string sqlBanAn = "update BanAn set TrangThai=2 where MaBan="+bandat.MaBan;
                SqlCommand cmBanAn = provider.CreateCommandStringSql(sqlBanAn);
                provider.ExecuteInsertUpdateDelete(cmBanAn);
            }
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public static int XoaDatBan(DatBan_DTO bandat)
        {
            Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            string thoigianden = t.ToString("MM/dd/yyyy");
            string sql = string.Format("delete from DatBan where MaNH={0} and MaBan={1} and ThoiGianDen='{2}' ",bandat.MaNH,bandat.MaBan,thoigianden);//0 ban dat
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
