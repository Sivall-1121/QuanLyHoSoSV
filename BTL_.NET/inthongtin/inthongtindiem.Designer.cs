namespace BTL_.NET.inthongtin
{
    partial class inthongtindiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inthongtindiem));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlsinhvienDataSet = new BTL_.NET.qlsinhvienDataSet();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.diemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_diem";
            reportDataSource1.Value = this.diemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_.NET.indiem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlsinhvienDataSet
            // 
            this.qlsinhvienDataSet.DataSetName = "qlsinhvienDataSet";
            this.qlsinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "diem";
            this.diemBindingSource.DataSource = this.qlsinhvienDataSet;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // inthongtindiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.reportViewer1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("inthongtindiem.IconOptions.Icon")));
            this.Name = "inthongtindiem";
            this.Text = "IN THÔNG TIN ĐIỂM";
            this.Load += new System.EventHandler(this.inthongtindiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private qlsinhvienDataSet qlsinhvienDataSet;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private qlsinhvienDataSetTableAdapters.diemTableAdapter diemTableAdapter;
    }
}