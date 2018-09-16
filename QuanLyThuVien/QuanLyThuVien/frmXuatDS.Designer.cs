namespace QuanLyThuVien
{
    partial class frmXuatDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSach = new System.Windows.Forms.Button();
            this.btDocGia = new System.Windows.Forms.Button();
            this.btMuon = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSach
            // 
            this.btSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSach.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btSach.Location = new System.Drawing.Point(12, 12);
            this.btSach.Name = "btSach";
            this.btSach.Size = new System.Drawing.Size(124, 90);
            this.btSach.TabIndex = 0;
            this.btSach.Text = "Xuất Danh Sách Sách";
            this.btSach.UseVisualStyleBackColor = true;
            this.btSach.Click += new System.EventHandler(this.btSach_Click);
            // 
            // btDocGia
            // 
            this.btDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocGia.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btDocGia.Location = new System.Drawing.Point(142, 12);
            this.btDocGia.Name = "btDocGia";
            this.btDocGia.Size = new System.Drawing.Size(124, 90);
            this.btDocGia.TabIndex = 1;
            this.btDocGia.Text = "Xuất Danh Đọc Giả";
            this.btDocGia.UseVisualStyleBackColor = true;
            this.btDocGia.Click += new System.EventHandler(this.btDocGia_Click);
            // 
            // btMuon
            // 
            this.btMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btMuon.Location = new System.Drawing.Point(12, 108);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(124, 90);
            this.btMuon.TabIndex = 2;
            this.btMuon.Text = "Xuất Danh Mượn";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btThoat.Location = new System.Drawing.Point(142, 108);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(124, 90);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmXuatDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 222);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btMuon);
            this.Controls.Add(this.btDocGia);
            this.Controls.Add(this.btSach);
            this.Name = "frmXuatDS";
            this.Text = "frmXuatDS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSach;
        private System.Windows.Forms.Button btDocGia;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.Button btThoat;
    }
}