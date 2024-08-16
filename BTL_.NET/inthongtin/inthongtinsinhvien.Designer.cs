namespace BTL_.NET.inthongtin
{
    partial class inthongtinsinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inthongtinsinhvien));
            this.qlsinhvienDataSet = new BTL_.NET.qlsinhvienDataSet();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.monhocTableAdapter();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.sinhvienTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sinhvienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // qlsinhvienDataSet
            // 
            this.qlsinhvienDataSet.DataSetName = "qlsinhvienDataSet";
            this.qlsinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "monhoc";
            this.monhocBindingSource.DataSource = this.qlsinhvienDataSet;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.qlsinhvienDataSet;
            // 
            // sinhvienBindingSource1
            // 
            this.sinhvienBindingSource1.DataMember = "sinhvien";
            this.sinhvienBindingSource1.DataSource = this.qlsinhvienDataSet;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_sv";
            reportDataSource1.Value = this.sinhvienBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_.NET.insv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // sinhvienBindingSource2
            // 
            this.sinhvienBindingSource2.DataMember = "sinhvien";
            this.sinhvienBindingSource2.DataSource = this.qlsinhvienDataSet;
            // 
            // inthongtinsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.reportViewer1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("inthongtinsinhvien.IconOptions.Icon")));
            this.Name = "inthongtinsinhvien";
            this.Text = "IN THÔNG TIN SINH VIÊN";
            this.Load += new System.EventHandler(this.inthongtinsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private qlsinhvienDataSet qlsinhvienDataSet;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private qlsinhvienDataSetTableAdapters.monhocTableAdapter monhocTableAdapter;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private System.Windows.Forms.BindingSource sinhvienBindingSource1;
        private qlsinhvienDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource2;
    }
}