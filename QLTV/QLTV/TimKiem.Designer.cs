namespace WindowsFormsApplication1
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTenSachTK = new System.Windows.Forms.ComboBox();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1();
            this.nhaXuatBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTenNXBTK = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTenTLTK = new System.Windows.Forms.ComboBox();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTenTacGiaTK = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.sachTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter();
            this.tacGiaTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter();
            this.theLoaiTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheLoaiTableAdapter();
            this.nhaXuatBanTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.NhaXuatBanTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(2, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả Tìm Kiếm";
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(9, 21);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(651, 213);
            this.dataGridViewTimKiem.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTenSachTK);
            this.groupBox1.Controls.Add(this.cbxTenNXBTK);
            this.groupBox1.Controls.Add(this.cbxTenTLTK);
            this.groupBox1.Controls.Add(this.cbxTenTacGiaTK);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Sách";
            // 
            // cbxTenSachTK
            // 
            this.cbxTenSachTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenSachTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenSachTK.DataSource = this.sachBindingSource;
            this.cbxTenSachTK.DisplayMember = "TenSach";
            this.cbxTenSachTK.FormattingEnabled = true;
            this.cbxTenSachTK.Location = new System.Drawing.Point(124, 35);
            this.cbxTenSachTK.Name = "cbxTenSachTK";
            this.cbxTenSachTK.Size = new System.Drawing.Size(478, 24);
            this.cbxTenSachTK.TabIndex = 4;
            this.cbxTenSachTK.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // quanLyThuVienDataSet1
            // 
            this.quanLyThuVienDataSet1.DataSetName = "QuanLyThuVienDataSet1";
            this.quanLyThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaXuatBanBindingSource
            // 
            this.nhaXuatBanBindingSource.DataMember = "NhaXuatBan";
            this.nhaXuatBanBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxTenNXBTK
            // 
            this.cbxTenNXBTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenNXBTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenNXBTK.FormattingEnabled = true;
            this.cbxTenNXBTK.Location = new System.Drawing.Point(239, 158);
            this.cbxTenNXBTK.Name = "cbxTenNXBTK";
            this.cbxTenNXBTK.Size = new System.Drawing.Size(363, 24);
            this.cbxTenNXBTK.TabIndex = 2;
            this.cbxTenNXBTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenNXBTK_SelectedIndexChanged);
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxTenTLTK
            // 
            this.cbxTenTLTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenTLTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenTLTK.FormattingEnabled = true;
            this.cbxTenTLTK.Location = new System.Drawing.Point(239, 115);
            this.cbxTenTLTK.Name = "cbxTenTLTK";
            this.cbxTenTLTK.Size = new System.Drawing.Size(363, 24);
            this.cbxTenTLTK.TabIndex = 2;
            this.cbxTenTLTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenTLTK_SelectedIndexChanged);
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxTenTacGiaTK
            // 
            this.cbxTenTacGiaTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenTacGiaTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenTacGiaTK.FormattingEnabled = true;
            this.cbxTenTacGiaTK.Location = new System.Drawing.Point(239, 74);
            this.cbxTenTacGiaTK.Name = "cbxTenTacGiaTK";
            this.cbxTenTacGiaTK.Size = new System.Drawing.Size(363, 24);
            this.cbxTenTacGiaTK.TabIndex = 2;
            this.cbxTenTacGiaTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenTacGiaTK_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(124, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên Tác Giả";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(121, 158);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(117, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tên Nhà Xuất Bản";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(124, 116);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên Thể Loại";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(70, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Sách";
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // nhaXuatBanTableAdapter
            // 
            this.nhaXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiem";
            this.Text = "Tìm Kiếm Sách";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTenSachTK;
        private System.Windows.Forms.ComboBox cbxTenNXBTK;
        private System.Windows.Forms.ComboBox cbxTenTLTK;
        private System.Windows.Forms.ComboBox cbxTenTacGiaTK;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private QuanLyThuVienDataSet1 quanLyThuVienDataSet1;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private System.Windows.Forms.BindingSource nhaXuatBanBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.NhaXuatBanTableAdapter nhaXuatBanTableAdapter;

    }
}