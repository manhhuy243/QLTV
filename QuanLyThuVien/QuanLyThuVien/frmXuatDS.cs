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
    public partial class frmXuatDS : Form
    {
        public frmXuatDS()
        {
            InitializeComponent();
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            frmXuatSach f = new frmXuatSach();
            f.ShowDialog();
        }

        private void btDocGia_Click(object sender, EventArgs e)
        {
            frmXuatDG f = new frmXuatDG();
            
            f.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            frmXuatMuon f = new frmXuatMuon();
            f.ShowDialog();
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult tL;
            tL= MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tL == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
    
}
