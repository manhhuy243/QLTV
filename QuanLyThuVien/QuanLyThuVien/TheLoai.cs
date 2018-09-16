using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyThuVien
{
    class TheLoai
    {
        DataBase db = new DataBase();
        public DataTable HienThiDSTheLoai()
        {
            string sql = "Select *from TheLoai";
            DataTable dt = db.TaoBang(sql);

            return dt;
        }
        //thêm
        public void ThemTheLoai(string ma,string ten)
        {
            string sql = string.Format("Insert Into TheLoai  Values('{0}',N'{1}')",ma,ten);
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void XoaTheLoai(string ma)
        {
            string sql = string.Format("DELETE FROM TheLoai WHERE TheLoai.MaTheLoai='{0}'", ma);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void SuaTheLoai(string ma, string ten)
        {
            string sql = string.Format(@"UPDATE [dbo].[TheLoai]
                                       SET 
                                          [TenTheLoai]=N'{1}'
                                     WHERE DocGia.MaTheLoai='{0}'", ma,ten);
        }
        public int ThongKe()
        {
            string sql = "Select COUNT(*) from TheLoai";

            int a = Convert.ToInt32(db.executeScalar(sql));
            return a;
        }
    }
}
