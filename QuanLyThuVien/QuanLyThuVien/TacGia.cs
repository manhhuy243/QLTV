using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class TacGia
    {
        DataBase db = new DataBase();
        public DataTable HienThi()
        {
            string sql = "Select *from TacGia";
            DataTable dt = db.TaoBang(sql);

            return dt;
        }
        //thêm
        public void Them(string ma, string ten, string DiaChi)
        {
            string sql = string.Format("Insert Into TacGia  Values('{0}',N'{1}',N'{2}')", ma, ten, DiaChi);
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void Xoa(string ma)
        {
            string sql = string.Format("DELETE FROM TacGia WHERE TacGia.MaTacGia='{0}'", ma);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void Sua(string ma, string ten, string DiaChi)
        {
            string sql = string.Format(@"UPDATE TacGia SET [DiaChi]=N'{2}'
														  ,TenTacGia=N'{1}'
												       WHERE TacGia.MaTacGia='{0}'", ma, ten, DiaChi);
            db.ExcuteNonQuery(sql);
        }
        public int ThongKe()
        {
            string sql = "Select COUNT(*) from TacGia";

            int a = Convert.ToInt32(db.executeScalar(sql));
            return a;
        }
    }
}
