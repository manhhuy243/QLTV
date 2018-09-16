namespace WindowsFormsApplication1
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labChoMuon = new DevComponents.DotNetBar.LabelX();
            this.labSoNXB = new DevComponents.DotNetBar.LabelX();
            this.labSoDocGia = new DevComponents.DotNetBar.LabelX();
            this.labSoTL = new DevComponents.DotNetBar.LabelX();
            this.labSoTacGia = new DevComponents.DotNetBar.LabelX();
            this.labSoSach = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.quanLyThuVienDataSet = new WindowsFormsApplication1.QuanLyThuVienDataSet();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng Số Sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labChoMuon);
            this.groupBox1.Controls.Add(this.labSoNXB);
            this.groupBox1.Controls.Add(this.labSoDocGia);
            this.groupBox1.Controls.Add(this.labSoTL);
            this.groupBox1.Controls.Add(this.labSoTacGia);
            this.groupBox1.Controls.Add(this.labSoSach);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // labChoMuon
            // 
            // 
            // 
            // 
            this.labChoMuon.BackgroundStyle.Class = "";
            this.labChoMuon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labChoMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChoMuon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labChoMuon.Location = new System.Drawing.Point(483, 102);
            this.labChoMuon.Name = "labChoMuon";
            this.labChoMuon.Size = new System.Drawing.Size(75, 23);
            this.labChoMuon.TabIndex = 1;
            // 
            // labSoNXB
            // 
            // 
            // 
            // 
            this.labSoNXB.BackgroundStyle.Class = "";
            this.labSoNXB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labSoNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoNXB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSoNXB.Location = new System.Drawing.Point(483, 64);
            this.labSoNXB.Name = "labSoNXB";
            this.labSoNXB.Size = new System.Drawing.Size(75, 23);
            this.labSoNXB.TabIndex = 1;
            // 
            // labSoDocGia
            // 
            // 
            // 
            // 
            this.labSoDocGia.BackgroundStyle.Class = "";
            this.labSoDocGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labSoDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoDocGia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSoDocGia.Location = new System.Drawing.Point(157, 63);
            this.labSoDocGia.Name = "labSoDocGia";
            this.labSoDocGia.Size = new System.Drawing.Size(75, 23);
            this.labSoDocGia.TabIndex = 1;
            // 
            // labSoTL
            // 
            // 
            // 
            // 
            this.labSoTL.BackgroundStyle.Class = "";
            this.labSoTL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labSoTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoTL.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSoTL.Location = new System.Drawing.Point(483, 24);
            this.labSoTL.Name = "labSoTL";
            this.labSoTL.Size = new System.Drawing.Size(75, 23);
            this.labSoTL.TabIndex = 1;
            // 
            // labSoTacGia
            // 
            // 
            // 
            // 
            this.labSoTacGia.BackgroundStyle.Class = "";
            this.labSoTacGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labSoTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoTacGia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSoTacGia.Location = new System.Drawing.Point(157, 102);
            this.labSoTacGia.Name = "labSoTacGia";
            this.labSoTacGia.Size = new System.Drawing.Size(75, 23);
            this.labSoTacGia.TabIndex = 1;
            // 
            // labSoSach
            // 
            // 
            // 
            // 
            this.labSoSach.BackgroundStyle.Class = "";
            this.labSoSach.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labSoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoSach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSoSach.Location = new System.Drawing.Point(157, 24);
            this.labSoSach.Name = "labSoSach";
            this.labSoSach.Size = new System.Drawing.Size(75, 23);
            this.labSoSach.TabIndex = 1;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(358, 102);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(107, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Sách Đang Mượn";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(358, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(97, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Tổng Số NXB:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(358, 24);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(119, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tổng Số Thể Loại:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(23, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(115, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tổng Số Độc Giả:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 102);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(115, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tổng Số Tác Giả:";
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 174);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labSoNXB;
        private DevComponents.DotNetBar.LabelX labSoDocGia;
        private DevComponents.DotNetBar.LabelX labSoTL;
        private DevComponents.DotNetBar.LabelX labSoTacGia;
        private DevComponents.DotNetBar.LabelX labSoSach;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labChoMuon;
        private DevComponents.DotNetBar.LabelX labelX6;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
    }
}