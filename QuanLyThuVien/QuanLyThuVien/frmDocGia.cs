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
    public partial class frmDocGia : Form
    {
        DocGia d = new DocGia();
        public frmDocGia()
        {
            InitializeComponent();
        }
        void HienThiDS()
        {
            listView1.Items.Clear();
            DataTable dt = d.HienThiDSDocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }


        private void btThem_Click(object sender, EventArgs e)
        {

            string i;
            if (rdbNam.Checked == true)
            {
                i = "Nam";

            }
            else
            {
                i = "Nữ";
            }
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            float tien = float.Parse(txtTienGui.Text);
            d.ThemDocGia(txtMaDocGia.Text, txtTenDocGia.Text, i, ngay, txtDiaChi.Text, txtChuDanh.Text, txtSoCMT.Text, tien);
            HienThiDS();
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            string i;
            if (rdbNam.Checked == true)
            {
                i = "Nam";

            }
            else
            {
                i = "Nữ";
            }
            string ngay = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            d.SuaDocGia(txtMaDocGia.Text, txtTenDocGia.Text, i, ngay, txtDiaChi.Text, txtChuDanh.Text, txtSoCMT.Text, int.Parse(txtTienGui.Text));
            HienThiDS();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            d.XoaDocGia(txtMaDocGia.Text);
            HienThiDS();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                txtMaDocGia.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTenDocGia.Text = listView1.SelectedItems[0].SubItems[1].Text;
                string i = listView1.SelectedItems[0].SubItems[2].Text;
                if (i=="Nam")
                {
                    rdbNam.Checked = true;

                }
                else
                {
                    rdbNu.Checked = true;
                }
                dateTimePicker1.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                txtDiaChi.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtChuDanh.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtSoCMT.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txtTienGui.Text = listView1.SelectedItems[0].SubItems[7].Text;

            }
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            HienThiDS();
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
