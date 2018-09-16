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
    public partial class TheoDoiMuonTra : Form
    {
        public TheoDoiMuonTra()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();
        private void Xoa()
        {
            this.txtSoPhieu.Clear();
        }
        private void HienThi()
        {
            string sql = "Select *from PhieuYeuCau";
            dataGridViewMuon.DataSource = ac.TaoBang(sql);

        }
        public static DataTable LaySoPhieu()
        {
            string sql;
            sql = "Select DISTINCT SoPhieu from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);

            return dt;
        }
        public static DataTable LayMaTheDocGia()
        {
            string sql;
            sql = "Select MaThe from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaTheMuon()
        {
            string sql;
            sql = "Select DISTINCT MaThe from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaDocGia()
        {
            string sql;
            sql = "Select MaDocGia from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaSach()
        {
            string sql;
            sql = "Select MaSach from Sach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
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
        public static DataTable LayNgayHenTra()
        {
            string sql;
            sql = "Select NgayTra from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        
        private void TheoDoiMuonTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.PhieuYeuCau' table. You can move, or remove it, as needed.
            this.phieuYeuCauTableAdapter.Fill(this.quanLyThuVienDataSet1.PhieuYeuCau);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.The' table. You can move, or remove it, as needed.
            this.theTableAdapter.Fill(this.quanLyThuVienDataSet1.The);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.PhieuYeuCau' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.The' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PhieuYeuCau' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.The' table. You can move, or remove it, as needed.     

            //Lấy Mã Thẻ Độc giả đưa vào mượn
            cbxMaTheMuon.DataSource = LayMaTheDocGia();
            cbxMaTheMuon.DisplayMember = "MaThe";
            //Lấy Mã Thẻ đã mượn để theo dõi trả
            cbxMaTheTra.DataSource = LayMaTheMuon();
            cbxMaTheTra.DisplayMember = "MaThe";
           
            //Lấy số phiếu
            cbxSoPhieu.DataSource = LaySoPhieu();
            cbxSoPhieu.DisplayMember = "SoPhieu";

            //Lấy mã sách đưa vào mượn
            cbxMaSachMuon.DataSource = LayMaSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            //Lấy tên Sách đưa vòa mượn
            cbxTenSachMuon.DataSource = LayTenSach();
            cbxTenSachMuon.DisplayMember = "TenSach";
            //Lấy ngày hẹn trả đưa vào trả
            cbxNgayHenTraMuon.DataSource = LayNgayHenTra();
            cbxNgayHenTraMuon.DisplayMember = "NgayHenTra";
            
            cbxTinhTrangTra.SelectedItem = "Tốt";
            HienThi();
            Xoa();
            
        }
        int dong;
        private void dataGridViewMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtSoPhieu.Text = dataGridViewMuon.Rows[dong].Cells[1].Value.ToString();
            cbxMaSachMuon.Text = dataGridViewMuon.Rows[dong].Cells[3].Value.ToString();
            
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            //Lấy mã độc giả
            string docgia = "Select MaDocGia from The where MaThe='" + cbxMaTheMuon.Text.ToString() + "'";
            string MaDG = Convert.ToString(ac.executeScalar(docgia));
            //Lấy tên độc giả từ bảng độc giả
            string docgia1 = "Select TenDocGia from DocGia where MaDocGia='" + MaDG + "'";
            string TenDG = Convert.ToString(ac.executeScalar(docgia1));
            //Lấy mã tác giả
            string tacgia="Select MaTacGia from Sach where MaSach='"+cbxMaSachMuon.Text.ToString()+"'";
            string MaTG = Convert.ToString(ac.executeScalar(tacgia));
            //Lấy mã thể loại
            string theloai = "Select MaTheLoai from Sach where MaSach='" + cbxMaSachMuon.Text.ToString() + "'";
            string MaTL = Convert.ToString(ac.executeScalar(theloai));
            //Lấy mã nhà xuất bản    
            string nxb = "Select MaNhaXuatBan from Sach where MaSach='" + cbxMaSachMuon.Text.ToString() + "'";
            string MaNXB = Convert.ToString(ac.executeScalar(nxb));

            //So sach dc muon
            int SoSach = Convert.ToInt32(this.cbxSoSachDM.Text.ToString());
            string sql0 = "Select COUNT(SoPhieu) from PhieuYeuCau where MaThe='"+cbxMaTheMuon.Text.ToString()+"'";
            int so = Convert.ToInt32(ac.executeScalar(sql0));

            //so sanh ngay cap the và ngay hien tai
            string sql1 = "Select NgayHetHan from The where MaThe='" + cbxMaTheMuon.Text.ToString() + "'";
            string NgayHetHan = Convert.ToString(ac.executeScalar(sql1));

            int ngay = Convert.ToInt32(NgayHetHan.Substring(3, 2));
            int thang = Convert.ToInt32(NgayHetHan.Substring(0, 2));
            int nam = Convert.ToInt32(NgayHetHan.Substring(6, 4));
            DateTime dt1 = new DateTime(nam, thang, ngay);
            DateTime dt2 = new DateTime();
            dt2 = DateTime.Today;

            string sql = "Insert into PhieuYeuCau values(" + txtSoPhieu.Text + ",'" + cbxMaTheMuon.Text.ToString() + "','"
            + MaDG + "','" + cbxMaSachMuon.Text.ToString() + "','" + MaTG + "','"
            + MaTL + "','" + MaNXB + "',N'" + cbxTenSachMuon.Text.ToString() + "','"+dtNgayMuon.Value.ToString()+"','"+dtNgayHenTra.Value.ToString()+"')";

            if (txtSoPhieu.Text.Length != 0)
            {
                if (dt1 > dt2)
                    {
                        if (so<Convert.ToInt32(cbxSoSachDM.Text.ToString()))
                        {
                            try
                            {
                                ac.ExcuteNonQuery(sql);
                                HienThi();
                                Xoa();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Đã mượn sách này !", "Mượn Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtSoPhieu.Clear();

                            } 
                        }
                       else
                            MessageBox.Show("Hết số sách được mượn !", "Mượn Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                else
                    MessageBox.Show("Thẻ đã hết hạn ngày "+cbxHanThe.Text.ToString()+" !", "Mượn Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
            }
            else
                MessageBox.Show("Chưa nhập số phiếu !", "Mượn Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
    }
     
    private void btnXoa_Click(object sender, EventArgs e)
    {

        string sql = "Delete from PhieuYeuCau where SoPhieu = " + txtSoPhieu.Text + "";
        DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Nhà Phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (traloi == DialogResult.Yes)
        {
            ac.ExcuteNonQuery(sql);
            HienThi();
            Xoa();
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

        private void btnTra_Click(object sender, EventArgs e)
        {
            string ngaytra = dateTimePickerNgayTra.Value.ToString();
            string ngayhentra = cbxNgayHenTraMuon.Text.ToString();
            int ngay1 =Convert.ToInt32(ngaytra.Substring(3, 2));
            int thang1 = Convert.ToInt32(ngaytra.Substring(0, 2));
            int nam1 = Convert.ToInt32(ngaytra.Substring(6, 4));
            int ngay2 = Convert.ToInt32(ngayhentra.Substring(3, 2));
            int thang2 = Convert.ToInt32(ngayhentra.Substring(0, 2));
            int nam2 = Convert.ToInt32(ngayhentra.Substring(6, 4));

            DateTime ngaytraCT = new DateTime(nam1, thang1, ngay1);
            DateTime ngayhenTra = new DateTime(nam2, thang2, ngay2);

            string sql = "Delete from PhieuYeuCau where MaThe='" + cbxMaTheTra.Text.ToString() + "'and SoPhieu='" + cbxSoPhieu.Text.ToString()+ "'";
            if (ngaytraCT <= ngayhenTra && cbxTinhTrangTra.Text.ToString()=="Tốt")
            {
                ac.ExcuteNonQuery(sql);
                HienThi();
                textBox1.Text = "Đã trả sách và tình trạng sách " + cbxTinhTrangTra.Text.ToString() + " và số tiền bị phạt là: 0 vnđ";
                
            }
            else
            {
                TimeSpan songay =ngaytraCT-ngayhenTra;
                int ngay = Convert.ToInt32(songay.TotalDays);
                float sotien = (float)(ngay * 0.1);
                ac.ExcuteNonQuery(sql);
                HienThi();
                textBox1.Text = "Đã trả sách và tình trạng sách " + cbxTinhTrangTra.Text.ToString() + " bạn đã trả muộn "+ngay+" ngày và số tiền bị phạt là: "+sotien+" vnđ";


            }
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //Lấy Mã Thẻ Độc giả đưa vào mượn
            cbxMaTheMuon.DataSource = LayMaTheDocGia();
            cbxMaTheMuon.DisplayMember = "MaThe";
            //Lấy Mã sách đưa vào mượn
            cbxMaSachMuon.DataSource = LayMaSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            //Lấy tên sách
            cbxTenSachMuon.DataSource = LayTenSach();
            cbxTenSachMuon.DisplayMember = "TenSach";

            //Lấy Mã Thẻ đã mượn để theo dõi trả
            cbxMaTheTra.DataSource = LayMaTheMuon();
            cbxMaTheTra.DisplayMember = "MaThe";

            //Lấy số phiếu đã mượn
            cbxSoPhieu.DataSource = LaySoPhieu();
            cbxSoPhieu.DisplayMember = "SoPhieu";
            //Lấy ngày hẹn trả
            cbxNgayHenTraMuon.DataSource = LayNgayHenTra();
            cbxNgayHenTraMuon.DisplayMember = "NgayTra";

            txtSoPhieu.Clear();
            
        }

        private void cbxMaTheMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql="Select SoSachDuocMuon from The where MaThe='"+cbxMaTheMuon.Text.ToString()+"'";
            string so = Convert.ToString(ac.executeScalar(sql));
            cbxSoSachDM.Text = so;
            string sql1 = "Select NgayHetHan from The where MaThe='" + cbxMaTheMuon.Text.ToString() + "'";
            string NgayHetHan = Convert.ToString(ac.executeScalar(sql1));
            cbxHanThe.Text = NgayHetHan;

            
        }

        private void cbxMaSachMuon_TextChanged(object sender, EventArgs e)
        {
            //Lấy tên sach
            string sach = "Select TenSach from Sach where MaSach='" + cbxMaSachMuon.Text.ToString() + "'";
            string TenS = Convert.ToString(ac.executeScalar(sach));
            cbxTenSachMuon.Text = TenS;
        }

        private void cbxTenSachMuon_TextChanged(object sender, EventArgs e)
        {

            //Lấy mã sach
            string sach = "Select MaSach from Sach where TenSach=N'" + cbxTenSachMuon.Text.ToString()+ "'";
            string MaS = Convert.ToString(ac.executeScalar(sach));
            cbxMaSachMuon.Text = MaS;          
        }

        private void cbxSoPhieu_TextChanged(object sender, EventArgs e)
        {
            string ngayhentra = "Select NgayTra from PhieuYeuCau where SoPhieu='" + cbxSoPhieu.Text.ToString() + "'";
            string ngay = Convert.ToString(ac.executeScalar(ngayhentra));
            cbxNgayHenTraMuon.Text = ngay;
        }

        private void txtSoPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            

        }

        
    }
}