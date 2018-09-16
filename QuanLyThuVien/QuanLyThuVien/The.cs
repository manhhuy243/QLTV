using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class The
    {
        DataBase db = new DataBase();
        public DataTable HienThi()
        {
            string sql = "Select *from The";
            DataTable dt = db.TaoBang(sql);

            return dt;
        }
        //thêm
        public void Them(string ma, string maDG,string ngayCap,string ngayHetHan,int gioiHan)
        {
            string sql = string.Format("Insert Into The  Values('{0}','{1}','{2}','{3}',{4})", ma, maDG,ngayCap,ngayHetHan,gioiHan);
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void Xoa(string ma)
        {
            string sql = string.Format("DELETE FROM The WHERE The.MaThe='{0}'", ma);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void Sua(string ma, string maDG, string ngayCap, string ngayHetHan, int gioiHan)
        {
            string sql = string.Format(@"UPDATE The SET MaDocGia='{1}'
														  ,NgayCapThe='{2}'
														  ,NgayHetHan='{3}'
														  ,SoSachDuocMuon={4}
												       WHERE The.MaThe='{0}'", ma,maDG, ngayCap,ngayHetHan,gioiHan);
            db.ExcuteNonQuery(sql);
        }
    }
}
