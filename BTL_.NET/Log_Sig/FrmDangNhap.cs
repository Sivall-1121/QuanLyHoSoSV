using BTL.FormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTL_.NET.Log_Sig
{
    public partial class FrmDangNhap : Form
    {
        SqlConnection con;
        int dem;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txttdn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập");
            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");

            }
            else
            {
               
                string sql = "Select count(*) from login where tk=N'" + txttdn.Text + "' and mk=N'" + txtmk.Text + "'";
              
                SqlCommand sqlCommand3 = new SqlCommand(sql, con);
                int i = Convert.ToInt32(sqlCommand3.ExecuteScalar().ToString());
              
                if (i != 0 )
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                   
                    string sql1 = "Select quyen from login where tk=N'" + txttdn.Text + "' and mk=N'" + txtmk.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(sql1, con);
                    string quyen=sqlCommand.ExecuteScalar().ToString();
                    //
                    string sql2 = "Select fullname from login where tk=N'" + txttdn.Text + "' and mk=N'" + txtmk.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(sql2, con);
                    string ten = sqlCommand2.ExecuteScalar().ToString();
                    //
                    string sql3 = "UPDATE login SET state=N'1' where tk=N'" + txttdn.Text + "'";
                    SqlCommand sqlCommand4 = new SqlCommand(sql3, con);
                    sqlCommand4.ExecuteNonQuery();
                    //
                    //string sql4 = "Select tk from login where tk=N'" + txttdn.Text + "' and mk=N'" + txtmk.Text + "'";
                    //SqlCommand sqlCommand5 = new SqlCommand(sql2, con);
                    //string tk = sqlCommand5.ExecuteScalar().ToString();
                   
                   frmformchinh formChinh = new frmformchinh(quyen, ten, txttdn.Text);
                    formChinh.ShowDialog();
                    this.Close();
                    txtmk.Text = "";

                }
                else
                {

                    int solan = 5 - dem;
                    dem++;

                    if (solan != 0)
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại!!!Bạn còn " + solan + " lần đăng nhập");
                        txtmk.Text = "";
                    }
                    if (solan == 0)
                    {
                        MessageBox.Show("Bạn thất bại quá 5 lần!!!Vui lòng thử lại sau ");
                        this.Close();
                    }


                }
            }
        }

        private void cbhamk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhamk.Checked)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            if (cbhamk.Checked == false)
            {
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txttdn.Select();
            this.ActiveControl = txttdn;
            txttdn.Focus();
            MaximizeBox = false;
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            dem = 0;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
