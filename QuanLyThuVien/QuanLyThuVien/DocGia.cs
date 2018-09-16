using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class DocGia
    {
        DataBase db = new DataBase();
        public DataTable HienThiDSDocGia()
        {
            string sql = "Select *from DocGia";
            DataTable dt = db.TaoBang(sql);

            return dt;
        }
        //thêm
        public void ThemDocGia(string MaDocGia,string TenDocGia,string GioiTinh,string NgaySinh,string DiaChi,string chucVu,string soCMT,float TienKiGui)
        {
            string sql = string.Format("Insert Into DocGia  Values('{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}','{6}',{7})",MaDocGia,TenDocGia,GioiTinh,NgaySinh,DiaChi,chucVu,soCMT,TienKiGui );
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void XoaDocGia(string MaDocGia)
        {
            string sql = string.Format("DELETE FROM DocGia WHERE DocGia.MaDocGia='{0}'", MaDocGia);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void SuaDocGia(string MaDocGia, string TenDocGia, string GioiTinh, string NgaySinh, string DiaChi, string chucVu, string soCMT, float TienKiGui)
        {
            string sql = string.Format(@"UPDATE [dbo].[DocGia]
                                       SET [TenDocGia] = N'{1}'
                                          ,[GioiTinh] = N'{2}'
                                          ,[NgaySinh] = '{3}'
                                          ,[DiaChi] = N'{4}'
                                          ,[ChucDanh] = N'{5}'
                                          ,[SoCMT] = '{6}'
                                          ,[TienKiGui] = {7}
                                     WHERE DocGia.MaDocGia={0}", MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, chucVu, soCMT, TienKiGui);
        }
        //tìm kiếm
        public DataTable TimDocGia(string ten)
        {
            string sql = string.Format(@"SELECT * FROM [dbo].[DocGia] WHERE DocGia.TenDocGia='{0}'", ten);
            DataTable dt = db.TaoBang(sql);
            return dt;
        }
        public int ThongKe()
        {
            string sql = "Select COUNT(*) from DocGia";

            int a = Convert.ToInt32(db.executeScalar(sql));
            return a;
        }

    }
}
