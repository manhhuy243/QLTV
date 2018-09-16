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
    public partial class frmThecs : Form
    {
        DataBase db = new DataBase();
        The t = new The();
        DocGia dg = new DocGia();

        public frmThecs()
        {
            InitializeComponent();
        }
        void HienThiDS()
        {
            listView1.Items.Clear();
            DataTable dt = t.HienThi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

               
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string ngayCap = String.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            string ngayHetHan = String.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);

            t.Them(txtMaThe.Text,cbxMa.Text ,ngayCap, ngayHetHan, int.Parse(txtGioiHan.Text));
            HienThiDS();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string ngayCap = String.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            string ngayHetHan = String.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);

            t.Sua(txtMaThe.Text, cbxMa.Text, ngayCap, ngayHetHan, int.Parse(txtGioiHan.Text));
            HienThiDS();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            t.Xoa(txtMaThe.Text);
            HienThiDS();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        int i;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedIndices.Count > 0)
            {
                txtMaThe.Text = listView1.SelectedItems[0].SubItems[0].Text;
                cbxMa.Text= listView1.SelectedItems[0].SubItems[1].Text;
                 
                dateTimePicker1.Value=DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                dateTimePicker2.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                txtGioiHan.Text=listView1.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void frmThecs_Load(object sender, EventArgs e)
        {
            HienThiDS();
            DataTable dt = t.HienThi();
            cbxMa.DataSource = dt;
            cbxMa.DisplayMember = "MaDocGia";
        }

        private void frmThecs_FormClosing(object sender, FormClosingEventArgs e)
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
