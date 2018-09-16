namespace WindowsFormsApplication1
{
    partial class TheoDoiMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoDoiMuonTra));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnMuon = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewMuon = new System.Windows.Forms.DataGridView();
            this.maTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuYeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet1 = new WindowsFormsApplication1.QuanLyThuVienDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbxHanThe = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbxTenSachMuon = new System.Windows.Forms.ComboBox();
            this.cbxSoSachDM = new System.Windows.Forms.ComboBox();
            this.cbxMaSachMuon = new System.Windows.Forms.ComboBox();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMaTheMuon = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTra = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.cbxNgayHenTraMuon = new System.Windows.Forms.ComboBox();
            this.cbxSoPhieu = new System.Windows.Forms.ComboBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cbxTinhTrangTra = new System.Windows.Forms.ComboBox();
            this.cbxMaTheTra = new System.Windows.Forms.ComboBox();
            this.theBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheTableAdapter();
            this.phieuYeuCauTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.PhieuYeuCauTableAdapter();
            this.sachTableAdapter = new WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuYeuCauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 563);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridViewMuon);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mượn Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnMuon);
            this.groupBox2.Location = new System.Drawing.Point(82, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực hiện";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(390, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(233, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMuon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMuon.Location = new System.Drawing.Point(75, 18);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(75, 23);
            this.btnMuon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMuon.TabIndex = 0;
            this.btnMuon.Text = "Cho Mượn";
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // dataGridViewMuon
            // 
            this.dataGridViewMuon.AutoGenerateColumns = false;
            this.dataGridViewMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTheDataGridViewTextBoxColumn,
            this.soPhieuDataGridViewTextBoxColumn,
            this.maDocGiaDataGridViewTextBoxColumn,
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.maTacGiaDataGridViewTextBoxColumn,
            this.maTheLoaiDataGridViewTextBoxColumn,
            this.maNhaXuatBanDataGridViewTextBoxColumn});
            this.dataGridViewMuon.DataSource = this.phieuYeuCauBindingSource;
            this.dataGridViewMuon.Location = new System.Drawing.Point(1, 206);
            this.dataGridViewMuon.Name = "dataGridViewMuon";
            this.dataGridViewMuon.Size = new System.Drawing.Size(720, 266);
            this.dataGridViewMuon.TabIndex = 1;
            this.dataGridViewMuon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMuon_RowEnter);
            // 
            // maTheDataGridViewTextBoxColumn
            // 
            this.maTheDataGridViewTextBoxColumn.DataPropertyName = "MaThe";
            this.maTheDataGridViewTextBoxColumn.HeaderText = "Mã Thẻ";
            this.maTheDataGridViewTextBoxColumn.Name = "maTheDataGridViewTextBoxColumn";
            // 
            // soPhieuDataGridViewTextBoxColumn
            // 
            this.soPhieuDataGridViewTextBoxColumn.DataPropertyName = "SoPhieu";
            this.soPhieuDataGridViewTextBoxColumn.HeaderText = "Phiếu Số";
            this.soPhieuDataGridViewTextBoxColumn.Name = "soPhieuDataGridViewTextBoxColumn";
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã ĐG";
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
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
            // maTacGiaDataGridViewTextBoxColumn
            // 
            this.maTacGiaDataGridViewTextBoxColumn.DataPropertyName = "MaTacGia";
            this.maTacGiaDataGridViewTextBoxColumn.HeaderText = "Mã TG";
            this.maTacGiaDataGridViewTextBoxColumn.Name = "maTacGiaDataGridViewTextBoxColumn";
            // 
            // maTheLoaiDataGridViewTextBoxColumn
            // 
            this.maTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.HeaderText = "Mã TL";
            this.maTheLoaiDataGridViewTextBoxColumn.Name = "maTheLoaiDataGridViewTextBoxColumn";
            // 
            // maNhaXuatBanDataGridViewTextBoxColumn
            // 
            this.maNhaXuatBanDataGridViewTextBoxColumn.DataPropertyName = "MaNhaXuatBan";
            this.maNhaXuatBanDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.maNhaXuatBanDataGridViewTextBoxColumn.Name = "maNhaXuatBanDataGridViewTextBoxColumn";
            // 
            // phieuYeuCauBindingSource
            // 
            this.phieuYeuCauBindingSource.DataMember = "PhieuYeuCau";
            this.phieuYeuCauBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // quanLyThuVienDataSet1
            // 
            this.quanLyThuVienDataSet1.DataSetName = "QuanLyThuVienDataSet1";
            this.quanLyThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayHenTra);
            this.groupBox1.Controls.Add(this.dtNgayMuon);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.cbxHanThe);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cbxTenSachMuon);
            this.groupBox1.Controls.Add(this.cbxSoSachDM);
            this.groupBox1.Controls.Add(this.cbxMaSachMuon);
            this.groupBox1.Controls.Add(this.cbxMaTheMuon);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cho Mượn";
            // 
            // dtNgayHenTra
            // 
            this.dtNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHenTra.Location = new System.Drawing.Point(499, 96);
            this.dtNgayHenTra.Name = "dtNgayHenTra";
            this.dtNgayHenTra.Size = new System.Drawing.Size(139, 22);
            this.dtNgayHenTra.TabIndex = 3;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(499, 57);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(139, 22);
            this.dtNgayMuon.TabIndex = 3;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(153, 57);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(141, 22);
            this.txtSoPhieu.TabIndex = 2;
            this.txtSoPhieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoPhieu_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(391, 56);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Ngày Mượn";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(391, 94);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(92, 23);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Ngày Hẹn Trả";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(391, 134);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Hạn Thẻ";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(391, 17);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "Số Sách ĐM";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(47, 134);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Tên Sách";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(47, 94);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Mã Sách";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(47, 56);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(100, 23);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Nhập Số Phiếu";
            // 
            // cbxHanThe
            // 
            this.cbxHanThe.Enabled = false;
            this.cbxHanThe.FormattingEnabled = true;
            this.cbxHanThe.Location = new System.Drawing.Point(497, 136);
            this.cbxHanThe.Name = "cbxHanThe";
            this.cbxHanThe.Size = new System.Drawing.Size(141, 24);
            this.cbxHanThe.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(47, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(84, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Chọn Mã Thẻ";
            // 
            // cbxTenSachMuon
            // 
            this.cbxTenSachMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenSachMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenSachMuon.DisplayMember = "MaSach";
            this.cbxTenSachMuon.FormattingEnabled = true;
            this.cbxTenSachMuon.Location = new System.Drawing.Point(153, 133);
            this.cbxTenSachMuon.Name = "cbxTenSachMuon";
            this.cbxTenSachMuon.Size = new System.Drawing.Size(141, 24);
            this.cbxTenSachMuon.TabIndex = 0;
            this.cbxTenSachMuon.TextChanged += new System.EventHandler(this.cbxTenSachMuon_TextChanged);
            // 
            // cbxSoSachDM
            // 
            this.cbxSoSachDM.Enabled = false;
            this.cbxSoSachDM.FormattingEnabled = true;
            this.cbxSoSachDM.Location = new System.Drawing.Point(497, 19);
            this.cbxSoSachDM.Name = "cbxSoSachDM";
            this.cbxSoSachDM.Size = new System.Drawing.Size(141, 24);
            this.cbxSoSachDM.TabIndex = 0;
            // 
            // cbxMaSachMuon
            // 
            this.cbxMaSachMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaSachMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaSachMuon.DataSource = this.sachBindingSource;
            this.cbxMaSachMuon.DisplayMember = "MaSach";
            this.cbxMaSachMuon.FormattingEnabled = true;
            this.cbxMaSachMuon.Location = new System.Drawing.Point(153, 93);
            this.cbxMaSachMuon.Name = "cbxMaSachMuon";
            this.cbxMaSachMuon.Size = new System.Drawing.Size(141, 24);
            this.cbxMaSachMuon.TabIndex = 0;
            this.cbxMaSachMuon.TextChanged += new System.EventHandler(this.cbxMaSachMuon_TextChanged);
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // cbxMaTheMuon
            // 
            this.cbxMaTheMuon.FormattingEnabled = true;
            this.cbxMaTheMuon.Location = new System.Drawing.Point(153, 20);
            this.cbxMaTheMuon.Name = "cbxMaTheMuon";
            this.cbxMaTheMuon.Size = new System.Drawing.Size(141, 24);
            this.cbxMaTheMuon.TabIndex = 0;
            this.cbxMaTheMuon.SelectedIndexChanged += new System.EventHandler(this.cbxMaTheMuon_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trả Sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTra);
            this.groupBox4.Controls.Add(this.buttonX2);
            this.groupBox4.Location = new System.Drawing.Point(6, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(711, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thực Hiện";
            // 
            // btnTra
            // 
            this.btnTra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTra.Location = new System.Drawing.Point(141, 21);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(75, 23);
            this.btnTra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTra.TabIndex = 2;
            this.btnTra.Text = "Trả";
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(456, 20);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "Thoát";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(6, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(711, 205);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox3.Controls.Add(this.labelX15);
            this.groupBox3.Controls.Add(this.labelX16);
            this.groupBox3.Controls.Add(this.labelX8);
            this.groupBox3.Controls.Add(this.labelX14);
            this.groupBox3.Controls.Add(this.cbxNgayHenTraMuon);
            this.groupBox3.Controls.Add(this.cbxSoPhieu);
            this.groupBox3.Controls.Add(this.labelX11);
            this.groupBox3.Controls.Add(this.cbxTinhTrangTra);
            this.groupBox3.Controls.Add(this.cbxMaTheTra);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trả Sách";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(522, 72);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerNgayTra.TabIndex = 2;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(30, 72);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(95, 23);
            this.labelX15.TabIndex = 1;
            this.labelX15.Text = "Chọn Số Phiếu";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(411, 72);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(95, 23);
            this.labelX16.TabIndex = 1;
            this.labelX16.Text = "Ngày Trả Sách";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(411, 31);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(105, 23);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Ngày Hẹn Trả";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(30, 112);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(105, 23);
            this.labelX14.TabIndex = 1;
            this.labelX14.Text = "Tình Trạng Sách";
            // 
            // cbxNgayHenTraMuon
            // 
            this.cbxNgayHenTraMuon.Enabled = false;
            this.cbxNgayHenTraMuon.FormattingEnabled = true;
            this.cbxNgayHenTraMuon.Items.AddRange(new object[] {
            "Tốt",
            "Bình thường",
            "Xấu"});
            this.cbxNgayHenTraMuon.Location = new System.Drawing.Point(522, 30);
            this.cbxNgayHenTraMuon.Name = "cbxNgayHenTraMuon";
            this.cbxNgayHenTraMuon.Size = new System.Drawing.Size(141, 24);
            this.cbxNgayHenTraMuon.TabIndex = 0;
            // 
            // cbxSoPhieu
            // 
            this.cbxSoPhieu.FormattingEnabled = true;
            this.cbxSoPhieu.Location = new System.Drawing.Point(141, 71);
            this.cbxSoPhieu.Name = "cbxSoPhieu";
            this.cbxSoPhieu.Size = new System.Drawing.Size(155, 24);
            this.cbxSoPhieu.TabIndex = 0;
            this.cbxSoPhieu.TextChanged += new System.EventHandler(this.cbxSoPhieu_TextChanged);
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(30, 31);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(95, 23);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "Chọn Mã Thẻ";
            // 
            // cbxTinhTrangTra
            // 
            this.cbxTinhTrangTra.FormattingEnabled = true;
            this.cbxTinhTrangTra.Items.AddRange(new object[] {
            "Tốt",
            "Bình thường",
            "Xấu"});
            this.cbxTinhTrangTra.Location = new System.Drawing.Point(141, 111);
            this.cbxTinhTrangTra.Name = "cbxTinhTrangTra";
            this.cbxTinhTrangTra.Size = new System.Drawing.Size(155, 24);
            this.cbxTinhTrangTra.TabIndex = 0;
            // 
            // cbxMaTheTra
            // 
            this.cbxMaTheTra.DataSource = this.theBindingSource;
            this.cbxMaTheTra.DisplayMember = "MaThe";
            this.cbxMaTheTra.FormattingEnabled = true;
            this.cbxMaTheTra.Location = new System.Drawing.Point(141, 31);
            this.cbxMaTheTra.Name = "cbxMaTheTra";
            this.cbxMaTheTra.Size = new System.Drawing.Size(155, 24);
            this.cbxMaTheTra.TabIndex = 0;
            // 
            // theBindingSource
            // 
            this.theBindingSource.DataMember = "The";
            this.theBindingSource.DataSource = this.quanLyThuVienDataSet1;
            // 
            // theTableAdapter
            // 
            this.theTableAdapter.ClearBeforeFill = true;
            // 
            // phieuYeuCauTableAdapter
            // 
            this.phieuYeuCauTableAdapter.ClearBeforeFill = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // TheoDoiMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 564);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheoDoiMuonTra";
            this.Text = "Theo Dõi Mượn Trả";
            this.Load += new System.EventHandler(this.TheoDoiMuonTra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuYeuCauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnMuon;
        private System.Windows.Forms.DataGridView dataGridViewMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cbxSoSachDM;
        private System.Windows.Forms.ComboBox cbxMaTheMuon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btnTra;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX11;
        private System.Windows.Forms.ComboBox cbxTinhTrangTra;
        private System.Windows.Forms.ComboBox cbxMaTheTra;
        private System.Windows.Forms.TextBox textBox1;
        private QuanLyThuVienDataSet1 quanLyThuVienDataSet1;
        private System.Windows.Forms.BindingSource theBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.TheTableAdapter theTableAdapter;
        private System.Windows.Forms.BindingSource phieuYeuCauBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.PhieuYeuCauTableAdapter phieuYeuCauTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private WindowsFormsApplication1.QuanLyThuVienDataSet1TableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxSoPhieu;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayHenTra;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cbxHanThe;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cbxTenSachMuon;
        private System.Windows.Forms.ComboBox cbxMaSachMuon;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.ComboBox cbxNgayHenTraMuon;
    }
}