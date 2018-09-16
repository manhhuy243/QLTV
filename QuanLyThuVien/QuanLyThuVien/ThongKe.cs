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
    public partial class frmThongKe : Form
    {
        Sach s = new Sach();
        TacGia tg = new TacGia();
        DocGia d = new DocGia();
        NhaXuatBancs nxb = new NhaXuatBancs();
        TheLoai t = new TheLoai();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            lbSach.Text += s.ThongKe();
            lbTacGia.Text += tg.ThongKe();
            lbDocGia.Text += d.ThongKe();
            lbNSB.Text += nxb.ThongKe();
            lbTL.Text += t.ThongKe();

            
        }

        private void frmThongKe_FormClosing(object sender, FormClosingEventArgs e)
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
