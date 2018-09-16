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
    public partial class Main : Form
    {
        public Main()
        {   
          
            
            InitializeComponent();
        }

        AccessData ac = new AccessData();
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void phóngToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void thuNhỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                e.Cancel=false;
            }
            if (traloi==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnQuanLyDoGia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia fm = new QuanLyDocGia();
            fm.ShowDialog();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            QuanLyTacGia fm = new QuanLyTacGia();
            fm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem fm = new TimKiem();
            fm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QuanLyThe fm = new QuanLyThe();
            fm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TheoDoiMuonTra fm = new TheoDoiMuonTra();
            fm.ShowDialog();
        }

        private void btnQuanSach_Click(object sender, EventArgs e)
        {
            QuanLySach fm = new QuanLySach();
            fm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe fm = new ThongKe();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About fm = new About();
            fm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(1300, 850);
        }

     
    }
}
