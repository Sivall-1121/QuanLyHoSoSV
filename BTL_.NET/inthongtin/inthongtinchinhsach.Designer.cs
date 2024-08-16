namespace BTL_.NET.inthongtin
{
    partial class inthongtinchinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inthongtinchinhsach));
            this.chinhsachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvienDataSet = new BTL_.NET.qlsinhvienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chinhsachTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.chinhsachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chinhsachBindingSource
            // 
            this.chinhsachBindingSource.DataMember = "chinhsach";
            this.chinhsachBindingSource.DataSource = this.qlsinhvienDataSet;
            // 
            // qlsinhvienDataSet
            // 
            this.qlsinhvienDataSet.DataSetName = "qlsinhvienDataSet";
            this.qlsinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_cs";
            reportDataSource1.Value = this.chinhsachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_.NET.incs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 428);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // chinhsachTableAdapter
            // 
            this.chinhsachTableAdapter.ClearBeforeFill = true;
            // 
            // inthongtinchinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.reportViewer1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("inthongtinchinhsach.IconOptions.Icon")));
            this.Name = "inthongtinchinhsach";
            this.Text = "IN THÔNG TIN CHÍNH SÁCH";
            this.Load += new System.EventHandler(this.inthongtinchinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private qlsinhvienDataSet qlsinhvienDataSet;
        private System.Windows.Forms.BindingSource chinhsachBindingSource;
        private qlsinhvienDataSetTableAdapters.chinhsachTableAdapter chinhsachTableAdapter;
    }
}