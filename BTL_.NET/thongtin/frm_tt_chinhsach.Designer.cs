namespace BTL1.thongtin
{
    partial class frm_tt_chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tt_chinhsach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.btĐóng = new System.Windows.Forms.Button();
            this.txtTencs = new System.Windows.Forms.TextBox();
            this.txtMacs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgvcs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btIn);
            this.groupBox1.Controls.Add(this.btĐóng);
            this.groupBox1.Controls.Add(this.txtTencs);
            this.groupBox1.Controls.Add(this.txtMacs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 250);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chính sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcd
            // 
            this.txtcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcd.Location = new System.Drawing.Point(196, 138);
            this.txtcd.Name = "txtcd";
            this.txtcd.ReadOnly = true;
            this.txtcd.Size = new System.Drawing.Size(244, 30);
            this.txtcd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chế độ:";
            // 
            // btIn
            // 
            this.btIn.AutoSize = true;
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Black;
            this.btIn.Image = global::BTL_.NET.Properties.Resources.Print;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(112, 176);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(118, 57);
            this.btIn.TabIndex = 6;
            this.btIn.Text = "     In";
            this.btIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btĐóng
            // 
            this.btĐóng.AutoSize = true;
            this.btĐóng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btĐóng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btĐóng.ForeColor = System.Drawing.Color.Black;
            this.btĐóng.Image = global::BTL_.NET.Properties.Resources.close;
            this.btĐóng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btĐóng.Location = new System.Drawing.Point(230, 176);
            this.btĐóng.Name = "btĐóng";
            this.btĐóng.Size = new System.Drawing.Size(180, 57);
            this.btĐóng.TabIndex = 5;
            this.btĐóng.Text = "     Đóng";
            this.btĐóng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btĐóng.UseVisualStyleBackColor = true;
            // 
            // txtTencs
            // 
            this.txtTencs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencs.Location = new System.Drawing.Point(196, 97);
            this.txtTencs.Name = "txtTencs";
            this.txtTencs.ReadOnly = true;
            this.txtTencs.Size = new System.Drawing.Size(244, 30);
            this.txtTencs.TabIndex = 3;
            // 
            // txtMacs
            // 
            this.txtMacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacs.Location = new System.Drawing.Point(196, 52);
            this.txtMacs.Name = "txtMacs";
            this.txtMacs.ReadOnly = true;
            this.txtMacs.Size = new System.Drawing.Size(244, 30);
            this.txtMacs.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên chính sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chính sách:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(-15, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1075, 13);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // dgvcs
            // 
            this.dgvcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcs.Location = new System.Drawing.Point(27, 100);
            this.dgvcs.Name = "dgvcs";
            this.dgvcs.RowHeadersWidth = 51;
            this.dgvcs.RowTemplate.Height = 24;
            this.dgvcs.Size = new System.Drawing.Size(518, 250);
            this.dgvcs.TabIndex = 22;
            this.dgvcs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcs_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(-10, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 78);
            this.label1.TabIndex = 21;
            this.label1.Text = "CHÍNH SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_tt_chinhsach
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvcs);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frm_tt_chinhsach.IconOptions.Icon")));
            this.Name = "frm_tt_chinhsach";
            this.Text = "THÔNG TIN CHÍNH SÁCH";
            this.Load += new System.EventHandler(this.frm_tt_chinhsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btĐóng;
        private System.Windows.Forms.TextBox txtTencs;
        private System.Windows.Forms.TextBox txtMacs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dgvcs;
        private System.Windows.Forms.Label label1;
    }
}