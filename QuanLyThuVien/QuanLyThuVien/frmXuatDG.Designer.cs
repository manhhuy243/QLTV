namespace QuanLyThuVien
{
    partial class frmXuatDG
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyThuVien.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SachTableAdapter = new QuanLyThuVien.DataSet1TableAdapters.SachTableAdapter();
            this.DocGiaTableAdapter = new QuanLyThuVien.DataSet1TableAdapters.DocGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocGiaBindingSource
            // 
            this.DocGiaBindingSource.DataMember = "DocGia";
            this.DocGiaBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DocGiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.ReportDG.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // SachBindingSource
            // 
            this.SachBindingSource.DataMember = "Sach";
            this.SachBindingSource.DataSource = this.DataSet1;
            // 
            // SachTableAdapter
            // 
            this.SachTableAdapter.ClearBeforeFill = true;
            // 
            // DocGiaTableAdapter
            // 
            this.DocGiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmXuatDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 322);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmXuatDG";
            this.Text = "frmXuatDG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXuatDG_FormClosing);
            this.Load += new System.EventHandler(this.frmXuatDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SachBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SachTableAdapter SachTableAdapter;
        private System.Windows.Forms.BindingSource DocGiaBindingSource;
        private DataSet1TableAdapters.DocGiaTableAdapter DocGiaTableAdapter;
    }
}