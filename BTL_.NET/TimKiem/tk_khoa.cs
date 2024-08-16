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

namespace BTL_.NET.TimKiem
{
    public partial class tk_khoa : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        public tk_khoa()
        {
            InitializeComponent();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dgkhoa.DataSource = ds.Tables[0];
            dgkhoa.Columns[0].HeaderText = "Mã Khoa";
            dgkhoa.Columns[1].HeaderText = "Tên Khoa";

            dgkhoa.Columns[0].Width = 200;
            dgkhoa.Columns[1].Width = 200;

            dgkhoa.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgkhoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void ketnoi()
        {
            con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void tk_khoa_Load(object sender, EventArgs e)
        {
            cbtim.Focus();
            ketnoi();
            string sql = "select * from khoa";
            load_DL(sql);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (cbtim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu tìm kiếm! Hãy chọn dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtim.Focus();
            }
            else if (txttukhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu tìm kiếm! Hãy nhập dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttukhoa.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string sql = "";
                    if (cbtim.Text == cbtim.Items[0].ToString())
                    {
                        sql = "select * from khoa where makhoa like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[1].ToString())
                    {
                        sql = "select * from khoa where tenkhoa like '%" + txttukhoa.Text + "%'";
                    }
                    load_DL(sql);
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Không có dữ liệu cần tìm! Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttukhoa.Clear();
                    cbtim.Text = "";
                }
            }
        }

        private void btnloadlai_Click(object sender, EventArgs e)
        {
            txttukhoa.Text = "";
            cbtim.Text = "";
            tk_khoa_Load(sender, e);
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
