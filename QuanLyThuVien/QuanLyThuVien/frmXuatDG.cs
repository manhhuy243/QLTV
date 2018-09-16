﻿using System;
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
    public partial class frmXuatDG : Form
    {
        public frmXuatDG()
        {
            InitializeComponent();
        }

        private void frmXuatDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DocGia' table. You can move, or remove it, as needed.
            this.DocGiaTableAdapter.Fill(this.DataSet1.DocGia);
            // TODO: This line of code loads data into the 'DataSet1.Sach' table. You can move, or remove it, as needed.
            this.SachTableAdapter.Fill(this.DataSet1.Sach);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void frmXuatDG_FormClosing(object sender, FormClosingEventArgs e)
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