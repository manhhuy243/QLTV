using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class Sach
    {
        DataBase db = new DataBase();
        public DataTable HienThiDSSach()
        {
            string sql = string.Format(@"SELECT MaSach,TenSach,NamXuatBan,SoBanSach,SoTrangSach,GiaSach,SoTap FROM Sach");
            DataTable dt = db.TaoBang(sql);
            return dt;
        }
        //thêm 
        public void ThemSach(string ten, string namXB, int soBanSach, int soTrang, int Gia, int tap, string tinhTrang, string ngonNgu, string maTG, string maTL, string maNXB, string MaSach,string khoSach)
        {
            string sql = string.Format(@"INSERT INTO sach values ('{0}',N'{1}',{2},{3},{4},{5},'{6}',N'{7}',N'{8}','{9}','{10}','{11}','{12}')", MaSach,ten,soBanSach,soTrang,Gia,tap,khoSach,tinhTrang,ngonNgu,maTG,maTL,maNXB,namXB);
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void XoaSach(string maSach)
        {
            string sql = string.Format(@"DELETE FROM [dbo].[Sach] WHERE Sach.MaSach = '{0}'", maSach);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void SuaSach(string ten, string namXB, int soBanSach, int soTrang, int Gia, int tap, string tinhTrang, string ngonNgu, string maTG, string maTL, string maNXB, string MaSach, string khoSach)
        {
            string sql = string.Format(@"UPDATE Sach SET TenSach = N'{1}', SoBanSach=2,SoTrangSach=3,GiaSach=4,SoTap=5,KhoSach='{6}',TinhTrangSach=N'{7}',NgonNgu=N'{8}',MaTacGia='T001',MaTheLoai='TL02',MaNhaXuatBan='XB01',NamXuatBan='5/5/1997' WHERE sach.MaSach='{0}'", MaSach, ten, soBanSach, soTrang, Gia, tap, khoSach, tinhTrang, ngonNgu, maTG, maTL, maNXB, namXB); 
            db.ExcuteNonQuery(sql);
        }
        //tìm
        public DataTable TimSach(string Sach)
        {
            string sql = string.Format(@"SELECT MaSach,TenSach,NamXuatBan,SoBanSach,SoTrangSach,GiaSach,SoTap FROM Sach WHERE TenSach like '%{0}%'", Sach);
            DataTable dt = db.TaoBang(sql);
            return dt;
        }
        public int ThongKe()
        {
            string sql = "Select COUNT(*) from Sach";
            
            int a = Convert.ToInt32(db.executeScalar(sql));
            return a;
        }
    }
}
