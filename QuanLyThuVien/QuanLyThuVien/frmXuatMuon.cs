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
    public partial class frmXuatMuon : Form
    {
        public frmXuatMuon()
        {
            InitializeComponent();
        }

        private void frmXuatMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.PhieuYeuCau' table. You can move, or remove it, as needed.
            this.PhieuYeuCauTableAdapter.Fill(this.DataSet1.PhieuYeuCau);

            this.reportViewer1.RefreshReport();
        }

        private void frmXuatMuon_FormClosing(object sender, FormClosingEventArgs e)
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
