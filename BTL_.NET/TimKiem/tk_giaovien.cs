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
    public partial class tk_giaovien : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public tk_giaovien()
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
            dggv.DataSource = ds.Tables[0];
            dggv.Columns[0].HeaderText = "Mã Giáo Viên";
            dggv.Columns[1].HeaderText = "Tên Giáo Viên";
            dggv.Columns[2].HeaderText = "Giới Tính";
            dggv.Columns[3].HeaderText = "Ngày Sinh";
            dggv.Columns[4].HeaderText = "Số Điện Thoại";
            dggv.Columns[5].HeaderText = "Địa Chỉ";

            dggv.Columns[0].Width = 200;
            dggv.Columns[1].Width = 200;
            dggv.Columns[2].Width = 200;
            dggv.Columns[3].Width = 200;
            dggv.Columns[4].Width = 200;
            dggv.Columns[5].Width = 200;

            dggv.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dggv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tk_giaovien_Load(object sender, EventArgs e)
        {
            cbtim.Focus();
            ketnoi();
            string sql = "select * from giaovien";
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
                        sql = "select * from giaovien where magv like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[1].ToString())
                    {
                        sql = "select * from giaovien where tengv like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[2].ToString())
                    {
                        sql = "select * from giaovien where sdt like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[3].ToString())
                    {
                        sql = "select * from giaovien where diachi like '%" + txttukhoa.Text + "%'";
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

        private void btnloadlai_Click(object sender, EventArgs e)
        {
            txttukhoa.Text = "";
            cbtim.Text = "";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dggv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
