namespace WindowsFormsApplication1
{
    partial class QuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySach));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.sachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoatSach = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaSach = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaSach = new DevComponents.DotNetBar.ButtonX();
            this.btnThemSach = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTenNXBSach = new System.Windows.Forms.ComboBox();
            this.nhaXuatBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTenTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTenTacGiaSach = new System.Windows.Forms.ComboBox();
            this.cbxNgonNgu = new System.Windows.Forms.ComboBox();
            this.cbxKhoSach = new System.Windows.Forms.ComboBox();
            this.cbxTinhTrangSach = new System.Windows.Forms.ComboBox();
            this.cbxNamXuatBan = new System.Windows.Forms.ComboBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaSach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoTap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaSach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoTrangSach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenSach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoBanSach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNXB = new System.Windows.Forms.DataGridView();
            this.maNhaXuaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSuaNXB = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNXB = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaNXB = new DevComponents.DotNetBar.ButtonX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiNXB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.txtTenNXB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNXB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.maTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTheLoai = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenTheLoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaTheLoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.tacGiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiTableAdapter1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheLoaiTableAdapter();
            this.nhaXuatBanTableAdapter1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.NhaXuatBanTableAdapter();
            this.tacGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter();
            this.sachTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBanSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTrangSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngonNguDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoaiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 747);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSach);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AutoGenerateColumns = false;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.namXuatBanDataGridViewTextBoxColumn,
            this.SoBanSach,
            this.soTrangSachDataGridViewTextBoxColumn,
            this.giaSachDataGridViewTextBoxColumn,
            this.soTapDataGridViewTextBoxColumn,
            this.khoSachDataGridViewTextBoxColumn,
            this.tinhTrangSachDataGridViewTextBoxColumn,
            this.ngonNguDataGridViewTextBoxColumn,
            this.maTacGiaDataGridViewTextBoxColumn,
            this.maTheLoaiDataGridViewTextBoxColumn1,
            this.maNhaXuatBanDataGridViewTextBoxColumn});
            this.dataGridViewSach.DataSource = this.sachBindingSource1;
            this.dataGridViewSach.Location = new System.Drawing.Point(5, 340);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.Size = new System.Drawing.Size(742, 266);
            this.dataGridViewSach.TabIndex = 4;
            this.dataGridViewSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_RowEnter);
            // 
            // sachBindingSource1
            // 
            this.sachBindingSource1.DataMember = "Sach";
            this.sachBindingSource1.DataSource = this.quanLyThuVienDataSet1;
            // 
            // quanLyThuVienDataSet1
            // 
            this.quanLyThuVienDataSet1.DataSetName = "QuanLyThuVienDataSet1";
            this.quanLyThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoatSach);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnSuaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Location = new System.Drawing.Point(5, 617);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực Hiện";
            // 
            // btnThoatSach
            // 
            this.btnThoatSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatSach.ForeColor = System.Drawing.Color.Blue;
            this.btnThoatSach.Location = new System.Drawing.Point(533, 23);
            this.btnThoatSach.Name = "btnThoatSach";
            this.btnThoatSach.Size = new System.Drawing.Size(94, 23);
            this.btnThoatSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatSach.TabIndex = 0;
            this.btnThoatSach.Text = "Thoát";
            this.btnThoatSach.Click += new System.EventHandler(this.btnThoatSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.ForeColor = System.Drawing.Color.Blue;
            this.btnXoaSach.Location = new System.Drawing.Point(386, 23);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(94, 23);
            this.btnXoaSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaSach.TabIndex = 0;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSach.ForeColor = System.Drawing.Color.Blue;
            this.btnSuaSach.Location = new System.Drawing.Point(247, 23);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(94, 23);
            this.btnSuaSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaSach.TabIndex = 0;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click_1);
            // 
            // btnThemSach
            // 
            this.btnThemSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.Color.Blue;
            this.btnThemSach.Location = new System.Drawing.Point(97, 23);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(94, 23);
            this.btnThemSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cbxTenNXBSach);
            this.groupBox1.Controls.Add(this.cbxTenTheLoaiSach);
            this.groupBox1.Controls.Add(this.cbxTenTacGiaSach);
            this.groupBox1.Controls.Add(this.cbxNgonNgu);
            this.groupBox1.Controls.Add(this.cbxKhoSach);
            this.groupBox1.Controls.Add(this.cbxTinhTrangSach);
            this.groupBox1.Controls.Add(this.cbxNamXuatBan);
            this.groupBox1.Controls.Add(this.labelX12);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX13);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtSoTap);
            this.groupBox1.Controls.Add(this.txtGiaSach);
            this.groupBox1.Controls.Add(this.txtSoTrangSach);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtSoBanSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Sách Mới";
            // 
            // cbxTenNXBSach
            // 
            this.cbxTenNXBSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenNXBSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenNXBSach.DataSource = this.nhaXuatBanBindingSource1;
            this.cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";
            this.cbxTenNXBSach.FormattingEnabled = true;
            this.cbxTenNXBSach.Location = new System.Drawing.Point(172, 283);
            this.cbxTenNXBSach.Name = "cbxTenNXBSach";
            this.cbxTenNXBSach.Size = new System.Drawing.Size(185, 24);
            this.cbxTenNXBSach.TabIndex = 4;
            // 
            // nhaXuatBanBindingSource1
            // 
            this.nhaXuatBanBindingSource1.DataMember = "NhaXuatBan";
            this.nhaXuatBanBindingSource1.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxTenTheLoaiSach
            // 
            this.cbxTenTheLoaiSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenTheLoaiSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenTheLoaiSach.DataSource = this.theLoaiBindingSource1;
            this.cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            this.cbxTenTheLoaiSach.FormattingEnabled = true;
            this.cbxTenTheLoaiSach.Location = new System.Drawing.Point(171, 245);
            this.cbxTenTheLoaiSach.Name = "cbxTenTheLoaiSach";
            this.cbxTenTheLoaiSach.Size = new System.Drawing.Size(185, 24);
            this.cbxTenTheLoaiSach.TabIndex = 4;
            // 
            // theLoaiBindingSource1
            // 
            this.theLoaiBindingSource1.DataMember = "TheLoai";
            this.theLoaiBindingSource1.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxTenTacGiaSach
            // 
            this.cbxTenTacGiaSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenTacGiaSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenTacGiaSach.FormattingEnabled = true;
            this.cbxTenTacGiaSach.Location = new System.Drawing.Point(171, 207);
            this.cbxTenTacGiaSach.Name = "cbxTenTacGiaSach";
            this.cbxTenTacGiaSach.Size = new System.Drawing.Size(185, 24);
            this.cbxTenTacGiaSach.TabIndex = 4;
            // 
            // cbxNgonNgu
            // 
            this.cbxNgonNgu.FormattingEnabled = true;
            this.cbxNgonNgu.Items.AddRange(new object[] {
            "Tiếng việt",
            "Tiếng anh"});
            this.cbxNgonNgu.Location = new System.Drawing.Point(505, 171);
            this.cbxNgonNgu.Name = "cbxNgonNgu";
            this.cbxNgonNgu.Size = new System.Drawing.Size(185, 24);
            this.cbxNgonNgu.TabIndex = 3;
            // 
            // cbxKhoSach
            // 
            this.cbxKhoSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxKhoSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxKhoSach.FormattingEnabled = true;
            this.cbxKhoSach.Items.AddRange(new object[] {
            "20X30",
            "25X35"});
            this.cbxKhoSach.Location = new System.Drawing.Point(505, 92);
            this.cbxKhoSach.Name = "cbxKhoSach";
            this.cbxKhoSach.Size = new System.Drawing.Size(185, 24);
            this.cbxKhoSach.TabIndex = 2;
            // 
            // cbxTinhTrangSach
            // 
            this.cbxTinhTrangSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTinhTrangSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTinhTrangSach.FormattingEnabled = true;
            this.cbxTinhTrangSach.Location = new System.Drawing.Point(505, 133);
            this.cbxTinhTrangSach.Name = "cbxTinhTrangSach";
            this.cbxTinhTrangSach.Size = new System.Drawing.Size(185, 24);
            this.cbxTinhTrangSach.TabIndex = 2;
            // 
            // cbxNamXuatBan
            // 
            this.cbxNamXuatBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNamXuatBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNamXuatBan.DisplayMember = "TenTacGia";
            this.cbxNamXuatBan.FormattingEnabled = true;
            this.cbxNamXuatBan.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
            this.cbxNamXuatBan.Location = new System.Drawing.Point(171, 92);
            this.cbxNamXuatBan.Name = "cbxNamXuatBan";
            this.cbxNamXuatBan.Size = new System.Drawing.Size(185, 24);
            this.cbxNamXuatBan.TabIndex = 2;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.ForeColor = System.Drawing.Color.Blue;
            this.labelX12.Location = new System.Drawing.Point(419, 133);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(86, 23);
            this.labelX12.TabIndex = 1;
            this.labelX12.Text = "Tình Trạng";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Blue;
            this.labelX10.Location = new System.Drawing.Point(419, 168);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(81, 23);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Ngôn Ngữ";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.ForeColor = System.Drawing.Color.Blue;
            this.labelX13.Location = new System.Drawing.Point(52, 284);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(118, 23);
            this.labelX13.TabIndex = 1;
            this.labelX13.Text = "Tên Nhà Xuất Bản";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Blue;
            this.labelX11.Location = new System.Drawing.Point(51, 244);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(86, 23);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "Tên Thể Loại";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Blue;
            this.labelX9.Location = new System.Drawing.Point(52, 205);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(91, 23);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "Tên Tác Giả";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Blue;
            this.labelX8.Location = new System.Drawing.Point(419, 92);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(81, 23);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Khổ Sách";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Blue;
            this.labelX7.Location = new System.Drawing.Point(419, 56);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(81, 23);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Số Tập";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Blue;
            this.labelX6.Location = new System.Drawing.Point(419, 19);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(81, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Giá Sách";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Blue;
            this.labelX5.Location = new System.Drawing.Point(52, 166);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(91, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Số Trang Sách";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Blue;
            this.labelX4.Location = new System.Drawing.Point(52, 126);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(86, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Số Bản Sách";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Blue;
            this.labelX3.Location = new System.Drawing.Point(52, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Năm Xuất Bản";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(51, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(86, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên Sách";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(51, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Cấp Mã Sách";
            // 
            // txtMaSach
            // 
            // 
            // 
            // 
            this.txtMaSach.Border.Class = "TextBoxBorder";
            this.txtMaSach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaSach.Location = new System.Drawing.Point(171, 56);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(185, 22);
            this.txtMaSach.TabIndex = 0;
            // 
            // txtSoTap
            // 
            // 
            // 
            // 
            this.txtSoTap.Border.Class = "TextBoxBorder";
            this.txtSoTap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTap.Location = new System.Drawing.Point(505, 58);
            this.txtSoTap.Name = "txtSoTap";
            this.txtSoTap.Size = new System.Drawing.Size(185, 22);
            this.txtSoTap.TabIndex = 0;
            this.txtSoTap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTap_KeyPress);
            this.txtSoTap.TextChanged += new System.EventHandler(this.txtSoTap_TextChanged);
            // 
            // txtGiaSach
            // 
            // 
            // 
            // 
            this.txtGiaSach.Border.Class = "TextBoxBorder";
            this.txtGiaSach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaSach.Location = new System.Drawing.Point(505, 19);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(185, 22);
            this.txtGiaSach.TabIndex = 0;
            this.txtGiaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSach_KeyPress);
            // 
            // txtSoTrangSach
            // 
            // 
            // 
            // 
            this.txtSoTrangSach.Border.Class = "TextBoxBorder";
            this.txtSoTrangSach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTrangSach.Location = new System.Drawing.Point(172, 168);
            this.txtSoTrangSach.Name = "txtSoTrangSach";
            this.txtSoTrangSach.Size = new System.Drawing.Size(185, 22);
            this.txtSoTrangSach.TabIndex = 0;
            this.txtSoTrangSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTrangSach_KeyPress);
            // 
            // txtTenSach
            // 
            // 
            // 
            // 
            this.txtTenSach.Border.Class = "TextBoxBorder";
            this.txtTenSach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenSach.Location = new System.Drawing.Point(171, 21);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(185, 22);
            this.txtTenSach.TabIndex = 0;
            // 
            // txtSoBanSach
            // 
            // 
            // 
            // 
            this.txtSoBanSach.Border.Class = "TextBoxBorder";
            this.txtSoBanSach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoBanSach.Location = new System.Drawing.Point(172, 130);
            this.txtSoBanSach.Name = "txtSoBanSach";
            this.txtSoBanSach.Size = new System.Drawing.Size(185, 22);
            this.txtSoBanSach.TabIndex = 0;
            this.txtSoBanSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBanSach_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.btnThoat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thể Loại - Nhà Xuất Bản";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridViewNXB);
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox8.Location = new System.Drawing.Point(389, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(347, 620);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            // 
            // dataGridViewNXB
            // 
            this.dataGridViewNXB.AutoGenerateColumns = false;
            this.dataGridViewNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaXuaBanDataGridViewTextBoxColumn,
            this.tenNhaXuatBanDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngayThanhLapDataGridViewTextBoxColumn});
            this.dataGridViewNXB.DataSource = this.nhaXuatBanBindingSource1;
            this.dataGridViewNXB.Location = new System.Drawing.Point(12, 206);
            this.dataGridViewNXB.Name = "dataGridViewNXB";
            this.dataGridViewNXB.Size = new System.Drawing.Size(327, 316);
            this.dataGridViewNXB.TabIndex = 5;
            this.dataGridViewNXB.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNXB_RowEnter);
            // 
            // maNhaXuaBanDataGridViewTextBoxColumn
            // 
            this.maNhaXuaBanDataGridViewTextBoxColumn.DataPropertyName = "MaNhaXuaBan";
            this.maNhaXuaBanDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.maNhaXuaBanDataGridViewTextBoxColumn.Name = "maNhaXuaBanDataGridViewTextBoxColumn";
            this.maNhaXuaBanDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenNhaXuatBanDataGridViewTextBoxColumn
            // 
            this.tenNhaXuatBanDataGridViewTextBoxColumn.DataPropertyName = "TenNhaXuatBan";
            this.tenNhaXuatBanDataGridViewTextBoxColumn.HeaderText = "Tên NXB";
            this.tenNhaXuatBanDataGridViewTextBoxColumn.Name = "tenNhaXuatBanDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // ngayThanhLapDataGridViewTextBoxColumn
            // 
            this.ngayThanhLapDataGridViewTextBoxColumn.DataPropertyName = "NgayThanhLap";
            this.ngayThanhLapDataGridViewTextBoxColumn.HeaderText = "Ngày Thành Lập";
            this.ngayThanhLapDataGridViewTextBoxColumn.Name = "ngayThanhLapDataGridViewTextBoxColumn";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSuaNXB);
            this.groupBox6.Controls.Add(this.btnThemNXB);
            this.groupBox6.Controls.Add(this.btnXoaNXB);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(8, 549);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 59);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhà Xuất Bản";
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNXB.Location = new System.Drawing.Point(132, 23);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(65, 23);
            this.btnSuaNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaNXB.TabIndex = 3;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNXB.Location = new System.Drawing.Point(21, 24);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(65, 23);
            this.btnThemNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemNXB.TabIndex = 2;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaNXB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNXB.Location = new System.Drawing.Point(238, 24);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(65, 23);
            this.btnXoaNXB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaNXB.TabIndex = 2;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.txtDiaChiNXB);
            this.groupBox4.Controls.Add(this.labelX20);
            this.groupBox4.Controls.Add(this.txtTenNXB);
            this.groupBox4.Controls.Add(this.labelX19);
            this.groupBox4.Controls.Add(this.txtMaNXB);
            this.groupBox4.Controls.Add(this.labelX17);
            this.groupBox4.Controls.Add(this.labelX18);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 182);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhà Xuất Bản";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtDiaChiNXB
            // 
            // 
            // 
            // 
            this.txtDiaChiNXB.Border.Class = "TextBoxBorder";
            this.txtDiaChiNXB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChiNXB.Location = new System.Drawing.Point(145, 101);
            this.txtDiaChiNXB.Name = "txtDiaChiNXB";
            this.txtDiaChiNXB.Size = new System.Drawing.Size(162, 22);
            this.txtDiaChiNXB.TabIndex = 1;
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.Location = new System.Drawing.Point(21, 136);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(98, 23);
            this.labelX20.TabIndex = 0;
            this.labelX20.Text = "Ngày Thành Lập";
            // 
            // txtTenNXB
            // 
            // 
            // 
            // 
            this.txtTenNXB.Border.Class = "TextBoxBorder";
            this.txtTenNXB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNXB.Location = new System.Drawing.Point(145, 65);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(162, 22);
            this.txtTenNXB.TabIndex = 1;
            // 
            // labelX19
            // 
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX19.Location = new System.Drawing.Point(21, 98);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(75, 23);
            this.labelX19.TabIndex = 0;
            this.labelX19.Text = "Địa Chỉ";
            // 
            // txtMaNXB
            // 
            // 
            // 
            // 
            this.txtMaNXB.Border.Class = "TextBoxBorder";
            this.txtMaNXB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNXB.Location = new System.Drawing.Point(145, 29);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(162, 22);
            this.txtMaNXB.TabIndex = 1;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(21, 29);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(106, 23);
            this.labelX17.TabIndex = 0;
            this.labelX17.Text = "Mã Nhà Xuất Bản";
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.Location = new System.Drawing.Point(21, 62);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(118, 23);
            this.labelX18.TabIndex = 0;
            this.labelX18.Text = "Tên Nhà Xuất Bản";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridViewTheLoai);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Location = new System.Drawing.Point(14, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(341, 620);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.AutoGenerateColumns = false;
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTheLoaiDataGridViewTextBoxColumn,
            this.tenTheLoaiDataGridViewTextBoxColumn});
            this.dataGridViewTheLoai.DataSource = this.theLoaiBindingSource1;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(10, 206);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(324, 316);
            this.dataGridViewTheLoai.TabIndex = 4;
            this.dataGridViewTheLoai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheLoai_RowEnter);
            // 
            // maTheLoaiDataGridViewTextBoxColumn
            // 
            this.maTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Thể Loại";
            this.maTheLoaiDataGridViewTextBoxColumn.Name = "maTheLoaiDataGridViewTextBoxColumn";
            // 
            // tenTheLoaiDataGridViewTextBoxColumn
            // 
            this.tenTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenTheLoai";
            this.tenTheLoaiDataGridViewTextBoxColumn.HeaderText = "Tên Thể Loại";
            this.tenTheLoaiDataGridViewTextBoxColumn.Name = "tenTheLoaiDataGridViewTextBoxColumn";
            this.tenTheLoaiDataGridViewTextBoxColumn.Width = 180;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoaTheLoai);
            this.groupBox5.Controls.Add(this.btnThemTheLoai);
            this.groupBox5.Controls.Add(this.btnSuaTheLoai);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 549);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 59);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thể Loại";
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTheLoai.Location = new System.Drawing.Point(236, 24);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTheLoai.TabIndex = 3;
            this.btnXoaTheLoai.Text = "Xóa";
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheLoai.Location = new System.Drawing.Point(24, 24);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnThemTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTheLoai.TabIndex = 2;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // btnSuaTheLoai
            // 
            this.btnSuaTheLoai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTheLoai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTheLoai.Location = new System.Drawing.Point(130, 24);
            this.btnSuaTheLoai.Name = "btnSuaTheLoai";
            this.btnSuaTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTheLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTheLoai.TabIndex = 2;
            this.btnSuaTheLoai.Text = "Sửa";
            this.btnSuaTheLoai.Click += new System.EventHandler(this.btnSuaTheLoai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenTheLoai);
            this.groupBox3.Controls.Add(this.txtMaTheLoai);
            this.groupBox3.Controls.Add(this.labelX15);
            this.groupBox3.Controls.Add(this.labelX14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 182);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thể Loại";
            // 
            // txtTenTheLoai
            // 
            // 
            // 
            // 
            this.txtTenTheLoai.Border.Class = "TextBoxBorder";
            this.txtTenTheLoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTheLoai.Location = new System.Drawing.Point(120, 76);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(162, 22);
            this.txtTenTheLoai.TabIndex = 1;
            // 
            // txtMaTheLoai
            // 
            // 
            // 
            // 
            this.txtMaTheLoai.Border.Class = "TextBoxBorder";
            this.txtMaTheLoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaTheLoai.Location = new System.Drawing.Point(120, 40);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(162, 22);
            this.txtMaTheLoai.TabIndex = 1;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(24, 75);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(85, 23);
            this.labelX15.TabIndex = 0;
            this.labelX15.Text = "Tên Thể Loại";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(24, 39);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 23);
            this.labelX14.TabIndex = 0;
            this.labelX14.Text = "Mã Thể Loại";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(336, 639);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tacGiaBindingSource2
            // 
            this.tacGiaBindingSource2.DataMember = "TacGia";
            this.tacGiaBindingSource2.DataSource = this.quanLyThuVienDataSet1;
            // 
            // theLoaiTableAdapter1
            // 
            this.theLoaiTableAdapter1.ClearBeforeFill = true;
            // 
            // nhaXuatBanTableAdapter1
            // 
            this.nhaXuatBanTableAdapter1.ClearBeforeFill = true;
            // 
            // tacGiaBindingSource1
            // 
            this.tacGiaBindingSource1.DataMember = "TacGia";
            this.tacGiaBindingSource1.DataSource = this.quanLyThuVienDataSet1;
            // 
            // tacGiaTableAdapter1
            // 
            this.tacGiaTableAdapter1.ClearBeforeFill = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên Sách";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            // 
            // namXuatBanDataGridViewTextBoxColumn
            // 
            this.namXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NamXuatBan";
            this.namXuatBanDataGridViewTextBoxColumn.HeaderText = "Năm XB";
            this.namXuatBanDataGridViewTextBoxColumn.Name = "namXuatBanDataGridViewTextBoxColumn";
            // 
            // SoBanSach
            // 
            this.SoBanSach.DataPropertyName = "SoBanSach";
            this.SoBanSach.HeaderText = "Số Bản Sách";
            this.SoBanSach.Name = "SoBanSach";
            // 
            // soTrangSachDataGridViewTextBoxColumn
            // 
            this.soTrangSachDataGridViewTextBoxColumn.DataPropertyName = "SoTrangSach";
            this.soTrangSachDataGridViewTextBoxColumn.HeaderText = "Số Trang";
            this.soTrangSachDataGridViewTextBoxColumn.Name = "soTrangSachDataGridViewTextBoxColumn";
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "Giá Sách";
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            // 
            // soTapDataGridViewTextBoxColumn
            // 
            this.soTapDataGridViewTextBoxColumn.DataPropertyName = "SoTap";
            this.soTapDataGridViewTextBoxColumn.HeaderText = "Số Tập";
            this.soTapDataGridViewTextBoxColumn.Name = "soTapDataGridViewTextBoxColumn";
            // 
            // khoSachDataGridViewTextBoxColumn
            // 
            this.khoSachDataGridViewTextBoxColumn.DataPropertyName = "KhoSach";
            this.khoSachDataGridViewTextBoxColumn.HeaderText = "Khổ Sách";
            this.khoSachDataGridViewTextBoxColumn.Name = "khoSachDataGridViewTextBoxColumn";
            // 
            // tinhTrangSachDataGridViewTextBoxColumn
            // 
            this.tinhTrangSachDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangSach";
            this.tinhTrangSachDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangSachDataGridViewTextBoxColumn.Name = "tinhTrangSachDataGridViewTextBoxColumn";
            // 
            // ngonNguDataGridViewTextBoxColumn
            // 
            this.ngonNguDataGridViewTextBoxColumn.DataPropertyName = "NgonNgu";
            this.ngonNguDataGridViewTextBoxColumn.HeaderText = "Ngôn Ngữ";
            this.ngonNguDataGridViewTextBoxColumn.Name = "ngonNguDataGridViewTextBoxColumn";
            // 
            // maTacGiaDataGridViewTextBoxColumn
            // 
            this.maTacGiaDataGridViewTextBoxColumn.DataPropertyName = "MaTacGia";
            this.maTacGiaDataGridViewTextBoxColumn.HeaderText = "Mã Tác Giả";
            this.maTacGiaDataGridViewTextBoxColumn.Name = "maTacGiaDataGridViewTextBoxColumn";
            // 
            // maTheLoaiDataGridViewTextBoxColumn1
            // 
            this.maTheLoaiDataGridViewTextBoxColumn1.DataPropertyName = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn1.HeaderText = "Mã Thể Loại";
            this.maTheLoaiDataGridViewTextBoxColumn1.Name = "maTheLoaiDataGridViewTextBoxColumn1";
            // 
            // maNhaXuatBanDataGridViewTextBoxColumn
            // 
            this.maNhaXuatBanDataGridViewTextBoxColumn.DataPropertyName = "MaNhaXuatBan";
            this.maNhaXuatBanDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.maNhaXuatBanDataGridViewTextBoxColumn.Name = "maNhaXuatBanDataGridViewTextBoxColumn";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 706);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "QuanLySach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnThoatSach;
        private DevComponents.DotNetBar.ButtonX btnXoaSach;
        private DevComponents.DotNetBar.ButtonX btnSuaSach;
        private DevComponents.DotNetBar.ButtonX btnThemSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNgonNgu;
        private System.Windows.Forms.ComboBox cbxKhoSach;
        private System.Windows.Forms.ComboBox cbxTinhTrangSach;
        private System.Windows.Forms.ComboBox cbxNamXuatBan;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSach;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaSach;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTrangSach;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenSach;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoBanSach;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridViewNXB;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.DotNetBar.ButtonX btnSuaNXB;
        private DevComponents.DotNetBar.ButtonX btnThemNXB;
        private DevComponents.DotNetBar.ButtonX btnXoaNXB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiNXB;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNXB;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNXB;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX18;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.ButtonX btnXoaTheLoai;
        private DevComponents.DotNetBar.ButtonX btnThemTheLoai;
        private DevComponents.DotNetBar.ButtonX btnSuaTheLoai;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTheLoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaTheLoai;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaXuaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxTenNXBSach;
        private System.Windows.Forms.ComboBox cbxTenTheLoaiSach;
        private System.Windows.Forms.ComboBox cbxTenTacGiaSach;
        private QuanLyThuVienDataSet1 quanLyThuVienDataSet1;
        private System.Windows.Forms.BindingSource theLoaiBindingSource1;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheLoaiTableAdapter theLoaiTableAdapter1;
        private System.Windows.Forms.BindingSource nhaXuatBanBindingSource1;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.NhaXuatBanTableAdapter nhaXuatBanTableAdapter1;
        private System.Windows.Forms.BindingSource tacGiaBindingSource1;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter tacGiaTableAdapter1;
        private System.Windows.Forms.BindingSource tacGiaBindingSource2;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBanSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTrangSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngonNguDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaXuatBanDataGridViewTextBoxColumn;
    }
}