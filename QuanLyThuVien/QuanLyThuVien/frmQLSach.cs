using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQLSach : Form
    {
        Sach s = new Sach();
        NhaXuatBancs n = new NhaXuatBancs();
        TheLoai t = new TheLoai();
        TacGia tg = new TacGia();
        public frmQLSach()
        {
            InitializeComponent();
        }


        private void frmQLSach_Load(object sender, EventArgs e)
        {
            this.cbxTinhTrangSach.Items.Add("Tốt");
            this.cbxTinhTrangSach.Items.Add("Xấu");
            this.cbxTinhTrangSach.Items.Add("Bình Thường");
            this.cbxTinhTrangSach.SelectedItem = "Tốt";
            this.cbxKhoSach.SelectedItem = "20X30";
            this.cbxNgonNgu.SelectedItem = "Tiếng việt";
            //lấy tên tác giả
            cbxTenTacGiaSach.DataSource = tg.HienThi();
            cbxTenTacGiaSach.DisplayMember = "TenTacGia";
            cbxTenTacGiaSach.ValueMember = "MaTacGia";
            //Lấy tên thể loại
            cbxTenTheLoaiSach.DataSource = t.HienThiDSTheLoai();
            cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            cbxTenTheLoaiSach.ValueMember = "MaTheLoai";
            //Lấy tên NXB
            cbxTenNXBSach.DataSource = n.HienThiDSNhaXuatBan();
            cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";
            cbxTenNXBSach.ValueMember = "MaNhaXuaBan";
            HienThiNXB();
            HienthiSach();
            HienThiTheLoai();
        }
        #region hiển thị
        void HienthiSach()
        {
            DataTable dt = s.HienThiDSSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSach.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void HienThiTheLoai()
        {
            DataTable dt = t.HienThiDSTheLoai();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvTheLoai.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }

       }
        void HienThiNXB()
        {
            DataTable dt = n.HienThiDSNhaXuatBan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNXB.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        #endregion

        #region sự kiện thể loại
        private void btnThemTL_Click(object sender, EventArgs e)
        {
            t.ThemTheLoai(txtMaTL.Text, txtTenTL.Text);
            lsvTheLoai.Items.Clear();
            HienThiTheLoai();
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            t.SuaTheLoai(txtMaTL.Text, txtTenTL.Text);
            lsvTheLoai.Items.Clear();
            HienThiTheLoai();
        }
        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            t.XoaTheLoai(txtMaTL.Text);
            lsvTheLoai.Items.Clear();
            HienThiTheLoai();
        }
        private void lsvTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTheLoai.SelectedIndices.Count > 0)
            {
                txtMaTL.Text = lsvTheLoai.SelectedItems[0].SubItems[0].Text;
                txtTenTL.Text = lsvTheLoai.SelectedItems[0].SubItems[1].Text;

            }
        }
        #endregion
        #region sự kiện NXB
     
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            n.ThemNhaXuatBan(txtMaNXB.Text,txtTenNXB.Text,txtDiaChiNXB.Text,ngay);
            lsvNXB.Items.Clear();
            HienThiNXB();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            n.SuaNhaXuatBan(txtMaNXB.Text,txtTenNXB.Text, txtDiaChiNXB.Text, ngay);
            lsvNXB.Items.Clear();
            HienThiNXB();
        }
        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            
            n.XoaNhaXuatBan(txtMaNXB.Text);
            lsvNXB.Items.Clear();
            HienThiNXB();
        }
        private void lsvNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNXB.SelectedIndices.Count > 0)
            {
                txtMaNXB.Text = lsvNXB.SelectedItems[0].SubItems[0].Text;
                txtTenNXB.Text = lsvNXB.SelectedItems[0].SubItems[1].Text;
                txtDiaChiNXB.Text = lsvNXB.SelectedItems[0].SubItems[2].Text;
                dateTimePicker1.Value = DateTime.Parse(lsvNXB.SelectedItems[0].SubItems[3].Text);
            }
        }
        #endregion
        #region sự kiện Sach

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);
            s.ThemSach(tbxTen.Text,ngay,int.Parse(tbxTaiBan.Text),int.Parse(tbxSoTrang.Text),int.Parse(tbxGia.Text),int.Parse(tbxSoTap.Text),cbxTinhTrangSach.Text,cbxNgonNgu.Text,cbxTenTacGiaSach.SelectedValue.ToString(),cbxTenTheLoaiSach.SelectedValue.ToString(),cbxTenNXBSach.SelectedValue.ToString(),tbxMa.Text,cbxKhoSach.Text);
            lsvSach.Items.Clear();
            HienthiSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            s.SuaSach(tbxTen.Text, ngay, int.Parse(tbxTaiBan.Text), int.Parse(tbxSoTrang.Text), int.Parse(tbxGia.Text), int.Parse(tbxSoTap.Text), cbxTinhTrangSach.Text, cbxNgonNgu.Text, cbxTenTacGiaSach.SelectedValue.ToString(), cbxTenTheLoaiSach.SelectedValue.ToString(), cbxTenNXBSach.SelectedValue.ToString(), tbxMa.Text, cbxKhoSach.Text);
            lsvSach.Items.Clear();
            HienthiSach();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            s.XoaSach(txtMaNXB.Text);
            lsvSach.Items.Clear();
            HienthiSach();
        }
        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSach.SelectedIndices.Count > 0)
            {
                tbxMa.Text = lsvSach.SelectedItems[0].SubItems[0].Text;
                tbxTen.Text = lsvSach.SelectedItems[0].SubItems[1].Text;
                dateTimePicker2.Value = DateTime.Parse(lsvSach.SelectedItems[0].SubItems[2].Text);
                tbxTaiBan.Text = lsvSach.SelectedItems[0].SubItems[3].Text;
                tbxSoTrang.Text = lsvSach.SelectedItems[0].SubItems[4].Text;
                tbxGia.Text = lsvSach.SelectedItems[0].SubItems[5].Text;
                tbxSoTap.Text = lsvSach.SelectedItems[0].SubItems[6].Text;
            }
        }

        #endregion

        private void frmQLSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tL;
            tL = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tL == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
