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
    public partial class frmHeThongcs : Form
    {
        public frmHeThongcs()
        {
            InitializeComponent();
        }

        private void btnQuanLyDoGia_Click(object sender, EventArgs e)
        {
            frmDocGia f = new frmDocGia();
            f.ShowDialog();
        }

        private void btnQuanSach_Click(object sender, EventArgs e)
        {
            frmQLSach f = new frmQLSach();
            f.ShowDialog();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia f = new frmTacGia();
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmQLThe f = new frmQLThe();
            f.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmThecs f = new frmThecs();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmXuatDS f = new frmXuatDS();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLienHe f = new frmLienHe();
            f.ShowDialog();
        }
        private void frm_FormClosing(object sender, FormClosingEventArgs e)
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
