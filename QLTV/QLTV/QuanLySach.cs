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
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DocGia' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter1.Fill(this.quanLyThuVienDataSet1.TacGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter1.Fill(this.quanLyThuVienDataSet1.NhaXuatBan);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter1.Fill(this.quanLyThuVienDataSet1.TheLoai);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TheLoai' table. You can move, or remove it, as needed.
            

            //Thêm dữ liệu vào cboTinhTrangSach
            this.cbxTinhTrangSach.Items.Add("Tốt");
            this.cbxTinhTrangSach.Items.Add("Xấu");
            this.cbxTinhTrangSach.Items.Add("Bình Thường");
            this.cbxTinhTrangSach.SelectedItem = "Tốt";
            this.cbxNamXuatBan.SelectedItem = "2010";
            this.cbxKhoSach.SelectedItem = "20X30";
            this.cbxNgonNgu.SelectedItem = "Tiếng việt";

            string sql1 = "Select *from Sach";
            dataGridViewSach.DataSource = ac.TaoBang(sql1);
            XoaSach();

            string sql2 = "Select *from TheLoai";
            dataGridViewTheLoai.DataSource = ac.TaoBang(sql2);
            XoaTheLoai();

            string sql3 = "Select *from NhaXuatBan";
            dataGridViewNXB.DataSource = ac.TaoBang(sql3);
            XoaNXB();

            //lấy tên tác giả
            cbxTenTacGiaSach.DataSource = LayTenTacGia();
            cbxTenTacGiaSach.DisplayMember = "TenTacGia";
            //Lấy tên thể loại
            cbxTenTheLoaiSach.DataSource = LayTenTheLoai();
            cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            //Lấy tên NXB
            cbxTenNXBSach.DataSource = LayTenNXB();
            cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";

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

        private void XoaTheLoai()
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
        }
        private void XoaNXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChiNXB.Clear();
        }
        private void XoaSach()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoBanSach.Clear();
            txtSoTrangSach.Clear();
            txtGiaSach.Clear();
            txtSoTap.Clear();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TheLoai values('" + txtMaTheLoai.Text + "',N'" + txtTenTheLoai.Text + "')";
            try
            {
                ac.ExcuteNonQuery(sql);
                string sql1 = "Select *from TheLoai";
                dataGridViewTheLoai.DataSource = ac.TaoBang(sql1);
                XoaTheLoai();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã tồn tại thể loại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTheLoai.Clear();
                txtMaTheLoai.Focus();

            }
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            string sql = "Update TheLoai set TenTheLoai = N'" + txtTenTheLoai.Text + "' where MaTheLoai='" + txtMaTheLoai.Text + "'";
            ac.ExcuteNonQuery(sql);
            string sql1 = "Select *from TheLoai";
            dataGridViewTheLoai.DataSource = ac.TaoBang(sql1);
            XoaTheLoai();
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {

            string sql = "Delete from TheLoai where MaTheLoai='" + txtMaTheLoai.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Thể Loại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql);
                string sql1 = "Select *from TheLoai";
                dataGridViewTheLoai.DataSource = ac.TaoBang(sql1);
                XoaTheLoai();

            }
        }
        int dongTL;
        private void dataGridViewTheLoai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            dongTL = e.RowIndex;
            txtMaTheLoai.Text = dataGridViewTheLoai.Rows[dongTL].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dataGridViewTheLoai.Rows[dongTL].Cells[1].Value.ToString();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhaXuatBan values('" + txtMaNXB.Text + "',N'" + txtTenNXB.Text + "',N'" + txtDiaChiNXB.Text + "','" + dateTimePicker1.Value.ToString() + "')";
            try
            {
                ac.ExcuteNonQuery(sql);
                string sql1 = "Select *from NhaXuatBan";
                dataGridViewNXB.DataSource = ac.TaoBang(sql1);
                XoaNXB();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã tồn tại thể loại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNXB.Clear();
                txtMaNXB.Focus();

            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            
            string sql = "Update NhaXuatBan set TenNhaXuatBan =N'" + txtTenNXB.Text + "',DiaChi =N'" + txtDiaChiNXB.Text + "',NgayThanhLap='" + dateTimePicker1.Value.ToString() + "' where MaNhaXuaBan='" + txtMaNXB.Text + "'";
            ac.ExcuteNonQuery(sql);
            string sql1 = "Select *from NhaXuatBan";
            dataGridViewNXB.DataSource = ac.TaoBang(sql1);
            XoaNXB();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string sql1 = "Delete from NhaXuatBan where MaNhaXuaBan ='" + txtMaNXB.Text + "'";
            string sql2 = "Delete from Sach where MaNhaXuatBan='" + txtMaNXB.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Nhà Xuất Bản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql1);
                ac.ExcuteNonQuery(sql2);
                string sql3 = "Select *from NhaXuatBan";
                dataGridViewNXB.DataSource = ac.TaoBang(sql3);
                XoaNXB();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
        int dongNXB;
        private void dataGridViewNXB_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dongNXB = e.RowIndex;
            txtMaNXB.Text = dataGridViewNXB.Rows[dongNXB].Cells[0].Value.ToString();
            txtTenNXB.Text = dataGridViewNXB.Rows[dongNXB].Cells[1].Value.ToString();
            txtDiaChiNXB.Text = dataGridViewNXB.Rows[dongNXB].Cells[2].Value.ToString();
        }
        int dongsach;
        private void dataGridViewSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dongsach = e.RowIndex;
            txtMaSach.Text = dataGridViewSach.Rows[dongsach].Cells[0].Value.ToString();
            txtTenSach.Text = dataGridViewSach.Rows[dongsach].Cells[1].Value.ToString();
            cbxNamXuatBan.Text = dataGridViewSach.Rows[dongsach].Cells[2].Value.ToString();
            txtSoBanSach.Text = dataGridViewSach.Rows[dongsach].Cells[3].Value.ToString();
            txtSoTrangSach.Text = dataGridViewSach.Rows[dongsach].Cells[4].Value.ToString();
            txtGiaSach.Text = dataGridViewSach.Rows[dongsach].Cells[5].Value.ToString();
            txtSoTap.Text = dataGridViewSach.Rows[dongsach].Cells[6].Value.ToString();
            cbxKhoSach.Text = dataGridViewSach.Rows[dongsach].Cells[7].Value.ToString();
            cbxTinhTrangSach.Text = dataGridViewSach.Rows[dongsach].Cells[8].Value.ToString();
            cbxNgonNgu.Text = dataGridViewSach.Rows[dongsach].Cells[9].Value.ToString();
            
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            //Lấy mã tác giả
            string tacgia = "Select MaTacGia from TacGia where TenTacGia=N'" + cbxTenTacGiaSach.Text.ToString() + "'";
            string MaTG = Convert.ToString(ac.executeScalar(tacgia));
            //Lấy mã thể loại
            string theloai = "Select MaTheLoai from TheLoai where TenTheLoai=N'" + cbxTenTheLoaiSach.Text.ToString()+ "'";
            string MaTL = Convert.ToString(ac.executeScalar(theloai));
            //Lấy mã NXB
            string nxb = "Select MaNhaXuaBan from NhaXuatBan where TenNhaXuatBan=N'" + cbxTenNXBSach.Text.ToString() + "'";
            string MaNXB = Convert.ToString(ac.executeScalar(nxb));
            
           
            string sql = "Insert into Sach values('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',"
            + cbxNamXuatBan.Text.ToString() + "," + txtSoBanSach.Text + "," + txtSoTrangSach.Text + ","
            + txtGiaSach.Text + "," + txtSoTap.Text + ",'" + cbxKhoSach.Text.ToString() + "',N'" + cbxTinhTrangSach.Text.ToString() + "',N'"
            + cbxNgonNgu.Text.ToString() + "','" +MaTG+ "','"
            + MaTL+ "','" + MaNXB + "')";

            if (txtMaSach.Text.Length != 0 && txtTenSach.Text.Length != 0)
            {
                try
                {
                    ac.ExcuteNonQuery(sql);
                    string sql1 = "Select *from Sach";
                    dataGridViewSach.DataSource = ac.TaoBang(sql1);
                    XoaSach();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã sách đã tồn !", "Thêm Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSach.Clear();
                }
            }
            else
                MessageBox.Show("Mã sách và tên sách không được để trống !", "Thêm Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Sach where MaSach = '" + txtMaSach.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql);
                string sql1 = "Select *from Sach";
                dataGridViewSach.DataSource = ac.TaoBang(sql1);
            }
            XoaSach();
        }

        private void btnThoatSach_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSuaSach_Click_1(object sender, EventArgs e)
        {
            //Lấy mã tác giả
            string tacgia = "Select MaTacGia from TacGia where TenTacGia=N'" + cbxTenTacGiaSach.Text.ToString() + "'";
            string MaTacGia = Convert.ToString(ac.executeScalar(tacgia));
            //Lấy mã thể loại
            string theloai = "Select MaTheLoai from TheLoai where TenTheLoai=N'" + cbxTenTheLoaiSach.Text.ToString() + "'";
            string MaTheLoai = Convert.ToString(ac.executeScalar(theloai));
            //Lấy mã NXB
            string NXB = "Select MaNhaXuaBan from NhaXuatBan where TenNhaXuatBan=N'" + cbxTenNXBSach.Text.ToString() + "'";
            string MaNXB = Convert.ToString(ac.executeScalar(NXB));
            
            string sql = "Update Sach set TenSach=N'" + txtTenSach.Text + "',NamXuatBan =" + cbxNamXuatBan.Text.ToString() + ",SoBanSach="
            + txtSoBanSach.Text + ",SoTrangSach=" + txtSoTrangSach.Text + ",GiaSach = " + txtGiaSach.Text + ",SoTap="
            + txtSoTap.Text + ",KhoSach ='" + cbxKhoSach.Text.ToString() + "',TinhTrangSach=N'" + cbxTinhTrangSach.Text.ToString() + "',NgonNgu=N'"
            + cbxNgonNgu.Text.ToString() + "',MaTacGia='" +MaTacGia+ "',MaTheLoai='" + MaTheLoai + "',MaNhaXuatBan='"
            + MaNXB + "' where MaSach ='" + txtMaSach.Text + "'";

            ac.ExcuteNonQuery(sql);
            string sql1 = "Select *from Sach";
            dataGridViewSach.DataSource = ac.TaoBang(sql1);
            XoaSach();
       
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //lấy tên tác giả
            cbxTenTacGiaSach.DataSource = LayTenTacGia();
            cbxTenTacGiaSach.DisplayMember = "TenTacGia";
            //Lấy tên thể loại
            cbxTenTheLoaiSach.DataSource = LayTenTheLoai();
            cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            //Lấy tên NXB
            cbxTenNXBSach.DataSource = LayTenNXB();
            cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";
        }

        private void txtSoTap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoBanSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTrangSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
