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
    public partial class QuanLyTacGia : Form
    {
        public QuanLyTacGia()
        {
            InitializeComponent();
        }

        private void QuanLyTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter1.Fill(this.quanLyThuVienDataSet1.TacGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
          
            string sql = "Select *from TacGia";
            dataGridViewTacGia.DataSource = ac.TaoBang(sql);
            Xoa();

        }
        private void Xoa()
        {

            txtMaTacGia.Clear();
            txtTenTacGia.Clear();
            txtDiaChiTG.Clear();
            txtMaTacGia.Focus();
        }
        AccessData ac = new AccessData();
        private void buttonX4_Click(object sender, EventArgs e)
        {

            string sql = "Insert into TacGia values('" + txtMaTacGia.Text + "',N'" + txtTenTacGia.Text + "',N'" + txtDiaChiTG.Text + "')";
            try
            {
                if (txtMaTacGia.Text.Length == 0 || txtTenTacGia.Text.Length == 0 || txtDiaChiTG.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu mã tác giả !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ac.ExcuteNonQuery(sql);
                    string sql1 = "Select *from TacGia";
                    dataGridViewTacGia.DataSource = ac.TaoBang(sql1);

                    Xoa();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã tồn tại mã tác giả !", "Lỗi ", MessageBoxButtons.OK);
                txtMaTacGia.Clear();
                txtMaTacGia.Focus();
            }
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            string sql1 = "Update TacGia set TenTacGia= N'" + txtTenTacGia.Text + "' where MaTacGia = '" + txtMaTacGia.Text + "'";
            ac.ExcuteNonQuery(sql1);
            string sql2 = "Update TacGia set DiaChi= N'" + txtDiaChiTG.Text + "' where MaTacGia = '" + txtMaTacGia.Text + "'";
            ac.ExcuteNonQuery(sql2);

            string sql = "Select *from TacGia";
            dataGridViewTacGia.DataSource = ac.TaoBang(sql);
            Xoa();

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TacGia where MaTacGia ='" + txtMaTacGia.Text + "'";

            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Tác Giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql);
                string sql2 = "Select *from TacGia";
                dataGridViewTacGia.DataSource = ac.TaoBang(sql2);
                Xoa();
            }
             
       
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {

            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
        int dong;
        private void dataGridViewTacGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaTacGia.Text = dataGridViewTacGia.Rows[dong].Cells[0].Value.ToString();
            txtTenTacGia.Text = dataGridViewTacGia.Rows[dong].Cells[1].Value.ToString();
            txtDiaChiTG.Text = dataGridViewTacGia.Rows[dong].Cells[2].Value.ToString();
        }
    }
}
