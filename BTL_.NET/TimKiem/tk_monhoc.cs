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
    public partial class tk_monhoc : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public tk_monhoc()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dgmh.DataSource = ds.Tables[0];
            dgmh.Columns[0].HeaderText = "Mã Môn Học";
            dgmh.Columns[1].HeaderText = "Tên Môn Học";
            dgmh.Columns[2].HeaderText = "Số Tiết";
            dgmh.Columns[3].HeaderText = "Mã Giáo Viên";


            dgmh.Columns[0].Width = 200;
            dgmh.Columns[1].Width = 200;
            dgmh.Columns[2].Width = 200;
            dgmh.Columns[3].Width = 200;


            dgmh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgmh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void tk_monhoc_Load(object sender, EventArgs e)
        {
            cbtim.Focus();
            ketnoi();
            string sql = "select * from monhoc";
            load_DL(sql);
        }

        private void btnloadlai_Click(object sender, EventArgs e)
        {
            txttukhoa.Clear();
            cbtim.Text = "";
            tk_monhoc_Load(sender, e);
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
                        sql = "select * from monhoc where mamh like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[1].ToString())
                    {
                        sql = "select * from monhoc where tenmh like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[2].ToString())
                    {
                        sql = "select * from monhoc where sotiet like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[3].ToString())
                    {
                        sql = "select * from monhoc where magv like '%" + txttukhoa.Text + "%'";
                    }
                    load_DL(sql);
                    sqlcon.Close();
                }
                catch
                {
                    MessageBox.Show("Không có dữ liệu cần tìm! Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttukhoa.Clear();
                    cbtim.Text = "";
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbtim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
