namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnQuanSach = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnQuanLyDoGia = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.phóngToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuNhỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(601, 77);
            this.button1.TabIndex = 13;
            this.button1.Text = "Quản Lý Thư Viện";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(402, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 128);
            this.button2.TabIndex = 9;
            this.button2.Text = "Liên Hệ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(202, 337);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 128);
            this.button9.TabIndex = 12;
            this.button9.Text = "Trợ Giúp";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(1, 337);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 128);
            this.button8.TabIndex = 11;
            this.button8.Text = "Quản Lý Thẻ ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(1, 208);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 128);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm Sách";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(402, 208);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 128);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(202, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 128);
            this.button6.TabIndex = 4;
            this.button6.Text = "Theo Dõi Mượn Trả";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnQuanSach
            // 
            this.btnQuanSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanSach.ForeColor = System.Drawing.Color.Black;
            this.btnQuanSach.Location = new System.Drawing.Point(202, 79);
            this.btnQuanSach.Name = "btnQuanSach";
            this.btnQuanSach.Size = new System.Drawing.Size(200, 128);
            this.btnQuanSach.TabIndex = 7;
            this.btnQuanSach.Text = "Quản Lý Sách";
            this.btnQuanSach.UseVisualStyleBackColor = false;
            this.btnQuanSach.Click += new System.EventHandler(this.btnQuanSach_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.ForeColor = System.Drawing.Color.Black;
            this.btnTacGia.Location = new System.Drawing.Point(402, 79);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(200, 128);
            this.btnTacGia.TabIndex = 6;
            this.btnTacGia.Text = "Quản Lý Tác Giả";
            this.btnTacGia.UseVisualStyleBackColor = false;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnQuanLyDoGia
            // 
            this.btnQuanLyDoGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyDoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDoGia.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyDoGia.Location = new System.Drawing.Point(1, 79);
            this.btnQuanLyDoGia.Name = "btnQuanLyDoGia";
            this.btnQuanLyDoGia.Size = new System.Drawing.Size(200, 128);
            this.btnQuanLyDoGia.TabIndex = 8;
            this.btnQuanLyDoGia.Text = "Quản Lý Độc Giả";
            this.btnQuanLyDoGia.UseVisualStyleBackColor = false;
            this.btnQuanLyDoGia.Click += new System.EventHandler(this.btnQuanLyDoGia_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phóngToToolStripMenuItem,
            this.thuNhỏToolStripMenuItem,
            this.tắtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 70);
            // 
            // phóngToToolStripMenuItem
            // 
            this.phóngToToolStripMenuItem.Name = "phóngToToolStripMenuItem";
            this.phóngToToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.phóngToToolStripMenuItem.Text = "Phóng to";
            this.phóngToToolStripMenuItem.Click += new System.EventHandler(this.phóngToToolStripMenuItem_Click);
            // 
            // thuNhỏToolStripMenuItem
            // 
            this.thuNhỏToolStripMenuItem.Name = "thuNhỏToolStripMenuItem";
            this.thuNhỏToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.thuNhỏToolStripMenuItem.Text = "Thu nhỏ";
            this.thuNhỏToolStripMenuItem.Click += new System.EventHandler(this.thuNhỏToolStripMenuItem_Click);
            // 
            // tắtToolStripMenuItem
            // 
            this.tắtToolStripMenuItem.Name = "tắtToolStripMenuItem";
            this.tắtToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tắtToolStripMenuItem.Text = "Tắt";
            this.tắtToolStripMenuItem.Click += new System.EventHandler(this.tắtToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnQuanSach);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.btnQuanLyDoGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnQuanSach;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnQuanLyDoGia;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phóngToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuNhỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtToolStripMenuItem;
    }
}