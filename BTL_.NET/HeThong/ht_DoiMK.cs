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

namespace BTL_.NET.HeThong
{
    public partial class ht_DoiMK : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        string quyen;
        public ht_DoiMK(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private void ht_DoiMK_Load(object sender, EventArgs e)
        {
            txttk.Select();
            this.ActiveControl = txttk;
            txttk.Focus();
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(quyen=="truongkhoa")
            {
                string sql = "Select count(*) from login where tk='" + txttk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if(i>0)
                {
                    if(txtmkmoi.Text==txtmknl.Text)
                    {
                        string sql1 = "UPDATE login SET mk=N'" + txtmkmoi.Text + "' where  tk=N'" + txttk.Text + "'";
                        SqlCommand cmd1;
                        cmd1 = new SqlCommand(sql1, con);

                        try
                        {
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Oh!Có vẻ hệ thống đang lỗi!Thử lại sau","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cmd1.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (quyen == "admin")
            {
                string sql = "Select count(*) from login where tk='" + txttk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (i > 0)
                {
                    if (txtmkmoi.Text == txtmknl.Text)
                    {
                        string sql1 = "UPDATE login SET mk=N'" + txtmkmoi.Text + "' where  tk=N'" + txttk.Text + "'";
                        SqlCommand cmd1;
                        cmd1 = new SqlCommand(sql1, con);

                        try
                        {
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Oh!Có vẻ hệ thống đang lỗi!Thử lại sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cmd1.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (quyen == "giaovien")
            {
                string sql = "Select count(*) from login where tk='" + txttk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (i > 0)
                {
                    if (txtmkmoi.Text == txtmknl.Text)
                    {
                        string sql1 = "UPDATE login SET mk=N'" + txtmkmoi.Text + "' where  tk=N'" + txttk.Text + "'";
                        SqlCommand cmd1;
                        cmd1 = new SqlCommand(sql1, con);

                        try
                        {
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Oh!Có vẻ hệ thống đang lỗi!Thử lại sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cmd1.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (quyen == "nguoidung")
            {
                string sql = "Select count(*) from login where tk='" + txttk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (i > 0)
                {
                    if (txtmkmoi.Text == txtmknl.Text)
                    {
                        string sql1 = "UPDATE login SET mk=N'" + txtmkmoi.Text + "' where  tk=N'" + txttk.Text + "'";
                        SqlCommand cmd1;
                        cmd1 = new SqlCommand(sql1, con);

                        try
                        {
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Oh!Có vẻ hệ thống đang lỗi!Thử lại sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cmd1.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtmk.Clear();
            txtmkmoi.Clear();
            txtmknl.Clear();
            txttk.Clear();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
