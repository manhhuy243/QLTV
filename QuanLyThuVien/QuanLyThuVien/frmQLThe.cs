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
    public partial class frmQLThe : Form
    {
        Sach s = new Sach();
        The t = new The();

        public frmQLThe()
        {
            InitializeComponent();
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQLThe_Load(object sender, EventArgs e)
        {
            cbxMaTheMuon.DataSource = s.HienThiDSSach();
            cbxMaTheMuon.DisplayMember = "MaThe";
            cbxMaSachMuon.DataSource = s.HienThiDSSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            cbxTenSachMuon.DataSource = s.HienThiDSSach();
            cbxMaSachMuon.DisplayMember = "TenSach";

        }

        private void frmQLThe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tL;
            tL = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tL == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
