﻿namespace BTL1.quanlytaikhoan
{
    partial class frm_qltk_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_qltk_user));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgvnd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(-6, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1099, 13);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // dgvnd
            // 
            this.dgvnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnd.Location = new System.Drawing.Point(530, 126);
            this.dgvnd.Name = "dgvnd";
            this.dgvnd.RowHeadersWidth = 51;
            this.dgvnd.RowTemplate.Height = 24;
            this.dgvnd.Size = new System.Drawing.Size(518, 282);
            this.dgvnd.TabIndex = 10;
            this.dgvnd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnd_CellContentClick);
            this.dgvnd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvnd_CellFormatting);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 78);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btndong);
            this.groupBox1.Controls.Add(this.btnnhaplai);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttdn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 296);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(207, 47);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(262, 30);
            this.txthoten.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ và tên:";
            // 
            // btndong
            // 
            this.btndong.ForeColor = System.Drawing.Color.Black;
            this.btndong.Image = global::BTL_.NET.Properties.Resources.close;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(262, 235);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(112, 46);
            this.btndong.TabIndex = 13;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.ForeColor = System.Drawing.Color.Black;
            this.btnnhaplai.Image = global::BTL_.NET.Properties.Resources.refresh;
            this.btnnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaplai.Location = new System.Drawing.Point(106, 235);
            this.btnnhaplai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(147, 46);
            this.btnnhaplai.TabIndex = 12;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::BTL_.NET.Properties.Resources.del;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(310, 181);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 46);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::BTL_.NET.Properties.Resources.tool;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(207, 181);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 46);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Image = global::BTL_.NET.Properties.Resources.add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(86, 181);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 46);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(207, 138);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(262, 30);
            this.txtmk.TabIndex = 3;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttdn
            // 
            this.txttdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttdn.Location = new System.Drawing.Point(207, 93);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(262, 30);
            this.txttdn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // frm_qltk_user
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvnd);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frm_qltk_user.IconOptions.Icon")));
            this.Name = "frm_qltk_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TÀI KHOẢN USER";
            this.Load += new System.EventHandler(this.frm_qltk_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dgvnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
    }
}