namespace BTL_.NET.TimKiem
{
    partial class tk_chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_chinhsach));
            this.dgcs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtim = new System.Windows.Forms.ComboBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnloadlai = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcs
            // 
            this.dgcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcs.Location = new System.Drawing.Point(525, 134);
            this.dgcs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgcs.Name = "dgcs";
            this.dgcs.RowHeadersWidth = 62;
            this.dgcs.Size = new System.Drawing.Size(650, 264);
            this.dgcs.TabIndex = 26;
            this.dgcs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcs_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtim);
            this.groupBox1.Controls.Add(this.btndong);
            this.groupBox1.Controls.Add(this.btnloadlai);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(489, 274);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbtim
            // 
            this.cbtim.FormattingEnabled = true;
            this.cbtim.Items.AddRange(new object[] {
            "Mã Chính Sách",
            "Tên Chính Sách",
            "Chế Độ"});
            this.cbtim.Location = new System.Drawing.Point(185, 59);
            this.cbtim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbtim.Name = "cbtim";
            this.cbtim.Size = new System.Drawing.Size(278, 33);
            this.cbtim.TabIndex = 9;
            // 
            // btndong
            // 
            this.btndong.Image = global::BTL_.NET.Properties.Resources.close;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(357, 181);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(106, 46);
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnloadlai
            // 
            this.btnloadlai.Image = global::BTL_.NET.Properties.Resources.refresh;
            this.btnloadlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloadlai.Location = new System.Drawing.Point(198, 181);
            this.btnloadlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnloadlai.Name = "btnloadlai";
            this.btnloadlai.Size = new System.Drawing.Size(136, 46);
            this.btnloadlai.TabIndex = 7;
            this.btnloadlai.Text = "Load lại";
            this.btnloadlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloadlai.UseVisualStyleBackColor = true;
            this.btnloadlai.Click += new System.EventHandler(this.btnloadlai_Click);
            // 
            // btntim
            // 
            this.btntim.Image = global::BTL_.NET.Properties.Resources.Find;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(33, 181);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(142, 46);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(185, 115);
            this.txttukhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(278, 30);
            this.txttukhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm Theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Khoá";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(-8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 76);
            this.label1.TabIndex = 24;
            this.label1.Text = "CHÍNH SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tk_chinhsach
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 456);
            this.Controls.Add(this.dgcs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("tk_chinhsach.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tk_chinhsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM CHÍNH SÁCH";
            this.Load += new System.EventHandler(this.tk_chinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtim;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnloadlai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}