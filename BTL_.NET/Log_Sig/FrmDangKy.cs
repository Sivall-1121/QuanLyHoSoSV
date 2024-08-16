﻿using DevExpress.Office.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTL.Log_Sig
{
    public partial class FrmDangKy : Form
    {
        SqlConnection con;
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void txttendn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            try
            {

                if (txttdndk.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!!");
                }
                else
                if (txtfullname.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập họ và tên!!!!");
                }
                else
                if (txtmkdk.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else if (txtmknl.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu nhập lại!!!");
                }
                else if (txtmkdk.Text != txtmknl.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp!!!");
                }
                else
                {
                    
                    string sql = "Select count(*) from login where tk='" + txttdndk.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (i != 0)
                    {
                        MessageBox.Show("Tài khoản đã được đăng ký!!!Vui lòng chọn tên tài khoản khác");
                        txttdndk.Text = "";
                        txtmkdk.Text = "";
                        txtmknl.Text = "";
                        txttdndk.Focus();
                    }
                    else
                    {
                        string sql2 = "Insert into login values('" + txttdndk.Text + "', '" + txtmkdk.Text + "',N'"+txtfullname.Text+"','nguoidung','0')";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đăng ký thành công");
                        txtmkdk.Text = "";
                        txtmknl.Text = "";
                        txttdndk.Text = "";
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ohhh!!Có vẻ lỗi hệ thống");
            }





         }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            txttdndk.Select();
            this.ActiveControl = txttdndk;
            txttdndk.Focus();
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
        }

        private void cbhamk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhamk.Checked)
            {
                txtmkdk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmkdk.UseSystemPasswordChar = true;
            }
        }

        private void cbhanlmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhanlmk.Checked)
            {
                txtmknl.UseSystemPasswordChar = false;
            }
            else
            {
                txtmknl.UseSystemPasswordChar = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmkdk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

