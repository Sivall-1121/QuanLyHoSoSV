namespace BTL_.NET.inthongtin
{
    partial class inthongtinkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inthongtinkhoa));
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaDataSet1 = new BTL_.NET.khoaDataSet();
            this.khoaTableAdapter1 = new BTL_.NET.khoaDataSetTableAdapters.khoaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlsinhvienDataSet = new BTL_.NET.qlsinhvienDataSet();
            this.khoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new BTL_.NET.qlsinhvienDataSetTableAdapters.khoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            // 
            // khoaDataSet1
            // 
            this.khoaDataSet1.DataSetName = "khoaDataSet";
            this.khoaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaTableAdapter1
            // 
            this.khoaTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_khoa";
            reportDataSource1.Value = this.khoaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_.NET.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1110, 580);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlsinhvienDataSet
            // 
            this.qlsinhvienDataSet.DataSetName = "qlsinhvienDataSet";
            this.qlsinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource1
            // 
            this.khoaBindingSource1.DataMember = "khoa";
            this.khoaBindingSource1.DataSource = this.qlsinhvienDataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // inthongtinkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 580);
            this.Controls.Add(this.reportViewer1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("inthongtinkhoa.IconOptions.Icon")));
            this.Name = "inthongtinkhoa";
            this.Text = "IN THÔNG TIN KHOA";
            this.Load += new System.EventHandler(this.thontin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      //  private qlsinhvienDataSet qlsinhvienDataSet1;
       // private qlsinhvienDataSetTableAdapters.khoaTableAdapter khoaTableAdapter1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private khoaDataSet khoaDataSet1;
        private khoaDataSetTableAdapters.khoaTableAdapter khoaTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private qlsinhvienDataSet qlsinhvienDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource1;
        private qlsinhvienDataSetTableAdapters.khoaTableAdapter khoaTableAdapter;
        //private khoaDataSet2 khoaDataSet21;
        // private khoaDataSet2TableAdapters.khoaTableAdapter khoaTableAdapter1;
    }
}