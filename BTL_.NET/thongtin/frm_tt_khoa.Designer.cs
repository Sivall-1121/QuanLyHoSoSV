namespace BTL1.thongtin
{
    partial class frm_tt_khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tt_khoa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btĐóng = new System.Windows.Forms.Button();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvkhoa = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btIn);
            this.groupBox1.Controls.Add(this.btĐóng);
            this.groupBox1.Controls.Add(this.txtTenkhoa);
            this.groupBox1.Controls.Add(this.txtMakhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(582, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 225);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // btIn
            // 
            this.btIn.AutoSize = true;
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Black;
            this.btIn.Image = global::BTL_.NET.Properties.Resources.Print;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(96, 155);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(118, 57);
            this.btIn.TabIndex = 20;
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
            this.btĐóng.Location = new System.Drawing.Point(213, 155);
            this.btĐóng.Name = "btĐóng";
            this.btĐóng.Size = new System.Drawing.Size(180, 57);
            this.btĐóng.TabIndex = 19;
            this.btĐóng.Text = "     Đóng";
            this.btĐóng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btĐóng.UseVisualStyleBackColor = true;
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhoa.Location = new System.Drawing.Point(154, 97);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.ReadOnly = true;
            this.txtTenkhoa.Size = new System.Drawing.Size(244, 30);
            this.txtTenkhoa.TabIndex = 3;
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakhoa.Location = new System.Drawing.Point(154, 52);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.ReadOnly = true;
            this.txtMakhoa.Size = new System.Drawing.Size(244, 30);
            this.txtMakhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khoa:";
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoa.Location = new System.Drawing.Point(28, 98);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.RowHeadersWidth = 51;
            this.dgvkhoa.RowTemplate.Height = 24;
            this.dgvkhoa.Size = new System.Drawing.Size(518, 225);
            this.dgvkhoa.TabIndex = 26;
            this.dgvkhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhoa_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(-10, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1075, 13);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(-6, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 78);
            this.label1.TabIndex = 25;
            this.label1.Text = "KHOA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_tt_khoa
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvkhoa);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frm_tt_khoa.IconOptions.Icon")));
            this.Name = "frm_tt_khoa";
            this.Text = "THÔNG TIN KHOA";
            this.Load += new System.EventHandler(this.frm_tt_khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvkhoa;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btĐóng;
    }
}