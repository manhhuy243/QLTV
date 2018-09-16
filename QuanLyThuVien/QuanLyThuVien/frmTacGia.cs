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
    public partial class frmTacGia : Form
    {
        TacGia tg = new TacGia();
        public frmTacGia()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            listView1.Items.Clear();
            DataTable dt = tg.HienThi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }

        }
        private void btThem_Click(object sender, EventArgs e)
        {
            tg.Them(txtMa.Text, txtTacGia.Text, txtDiaChi.Text);
            SetNull();
            HienThi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tg.Xoa(txtMa.Text);
            SetNull();
            HienThi();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            tg.Sua(txtMa.Text, txtTacGia.Text, txtDiaChi.Text);
            SetNull();
            HienThi();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                txtMa.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTacGia.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }
        void SetNull()
        {
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtTacGia.Text = "";
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void frmTacGia_FormClosing(object sender, FormClosingEventArgs e)
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
