using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        AccessData ac = new AccessData();
        private void TimKiem_Load(object sender, EventArgs e)
        {
           
            this.nhaXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet1.NhaXuatBan);
        
            this.theLoaiTableAdapter.Fill(this.quanLyThuVienDataSet1.TheLoai);
        
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet1.TacGia);
            
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
           
            
       
            
            cbxTenSachTK.DisplayMember = "";
            //hiển thị tên sách
            cbxTenSachTK.DataSource = LayTenSach();
            cbxTenSachTK.DisplayMember = "TenSach";
            //Hiển thị tên tác giả
            cbxTenTacGiaTK.DataSource = LayTenTacGia();
            cbxTenTacGiaTK.DisplayMember = "TenTacGia";
            //Hiển thị tên Thể Loại
            cbxTenTLTK.DataSource = LayTenTheLoai();
            cbxTenTLTK.DisplayMember = "TenTheLoai";
            //Hiển thị tên nhà xuất bản
            cbxTenNXBTK.DataSource = LayTenNXB();
            cbxTenNXBTK.DisplayMember = "TenNhaXuatBan";



        }

        public static DataTable LayTenSach()
        {
            string sql;
            sql = "Select TenSach from Sach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenTacGia()
        {
            string sql;
            sql = "Select TenTacGia from TacGia ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenTheLoai()
        {
            string sql;
            sql = "Select TenTheLoai from TheLoai ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenNXB()
        {
            string sql;
            sql = "Select TenNhaXuatBan from NhaXuatBan ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        } 
        private void cbxTenTacGiaTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tacgia="Select MaTacGia from TacGia where TenTacGia =N'"+cbxTenTacGiaTK.Text.ToString()+"'";
            string MaTG = Convert.ToString(ac.executeScalar(tacgia));
            string sql2 = "Select *from Sach where MaTacGia ='" + MaTG + "'";
            dataGridViewTimKiem.DataSource = ac.TaoBang(sql2);
        }

        private void cbxTenTLTK_SelectedIndexChanged(object sender, EventArgs e)
        { //Lấy mã thể loại
            string theloai = "Select MaTheLoai from TheLoai where TenTheLoai=N'" +cbxTenTLTK.Text.ToString()+ "'";
            string MaTL = Convert.ToString(ac.executeScalar(theloai));
            
            string sql3 = "Select *from Sach where MaTheLoai ='" + MaTL+ "'";
            dataGridViewTimKiem.DataSource = ac.TaoBang(sql3);
        }

        private void cbxTenNXBTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy mã NXB
            string nxb = "Select MaNhaXuaBan from NhaXuatBan where TenNhaXuatBan=N'" + cbxTenNXBTK.Text.ToString() + "'";
            string MaNXB = Convert.ToString(ac.executeScalar(nxb));
            
            string sql4 = "Select *from Sach where MaNhaXuatBan ='" +MaNXB+ "'";
            dataGridViewTimKiem.DataSource = ac.TaoBang(sql4);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from Sach where TenSach like N'%" + cbxTenSachTK.Text.ToString() + "%'";
            dataGridViewTimKiem.DataSource = ac.TaoBang(sql1);
        }
    }
}
