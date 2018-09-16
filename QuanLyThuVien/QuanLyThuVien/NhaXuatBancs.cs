using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class NhaXuatBancs
    {
        DataBase db = new DataBase();
        public DataTable HienThiDSNhaXuatBan()
        {
            string sql = "Select *from NhaXuatBan";
            DataTable dt = db.TaoBang(sql);

            return dt;
        }
        //thêm
        public void ThemNhaXuatBan(string ma, string ten,string DiaChi, string ngayTL)
        {
            string sql = string.Format("Insert Into NhaXuatBan  Values('{0}',N'{1}',N'{2}','{3}')", ma, ten,DiaChi,ngayTL);
            db.ExcuteNonQuery(sql);
        }
        //xóa
        public void XoaNhaXuatBan(string ma)
        {
            string sql = string.Format("DELETE FROM NhaXuatBan WHERE NhaXuatBan.MaNhaXuaBan='{0}'", ma);
            db.ExcuteNonQuery(sql);
        }
        //sửa
        public void SuaNhaXuatBan(string ma, string ten,string DiaChi,string ngayTL)
        {
            string sql = string.Format(@"UPDATE [dbo].[NhaXuatBan] SET [DiaChi]=N'{2}'
																	  ,TenNhaXuatBan=N'{1}'
																	  ,[NgayThanhLap]='{3}'
																    WHERE NhaXuatBan.MaNhaXuaBan='{0}'", ma, ten,DiaChi,ngayTL);
            db.ExcuteNonQuery(sql);
        }
        public int ThongKe()
        {
            string sql = "Select COUNT(*) from NhaXuatBan";

            int a = Convert.ToInt32(db.executeScalar(sql));
            return a;
        }
    }
}
