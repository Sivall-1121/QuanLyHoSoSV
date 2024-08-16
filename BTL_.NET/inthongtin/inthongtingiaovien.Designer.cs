namespace BTL_.NET.inthongtin
{
    partial class inthongtingiaovien
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlsinhvienDataSet = new BTL_.NET.qlsinhvienDataSet();
            this.qlsinhvienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaovienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaovienTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.giaovienTableAdapter();
            this.giaovienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_gv";
            reportDataSource1.Value = this.giaovienBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_.NET.ingv.rdlc";
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
            // qlsinhvienDataSetBindingSource
            // 
            this.qlsinhvienDataSetBindingSource.DataSource = this.qlsinhvienDataSet;
            this.qlsinhvienDataSetBindingSource.Position = 0;
            // 
            // giaovienBindingSource
            // 
            this.giaovienBindingSource.DataMember = "giaovien";
            this.giaovienBindingSource.DataSource = this.qlsinhvienDataSetBindingSource;
            // 
            // giaovienTableAdapter
            // 
            this.giaovienTableAdapter.ClearBeforeFill = true;
            // 
            // giaovienBindingSource1
            // 
            this.giaovienBindingSource1.DataMember = "giaovien";
            this.giaovienBindingSource1.DataSource = this.qlsinhvienDataSet;
            // 
            // inthongtingiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.reportViewer1);
            this.Name = "inthongtingiaovien";
            this.Text = "inthongtingiaovien";
            this.Load += new System.EventHandler(this.inthongtingiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private qlsinhvienDataSet qlsinhvienDataSet;
        private System.Windows.Forms.BindingSource qlsinhvienDataSetBindingSource;
        private System.Windows.Forms.BindingSource giaovienBindingSource;
        private qlsinhvienDataSetTableAdapters.giaovienTableAdapter giaovienTableAdapter;
        private System.Windows.Forms.BindingSource giaovienBindingSource1;
    }
}