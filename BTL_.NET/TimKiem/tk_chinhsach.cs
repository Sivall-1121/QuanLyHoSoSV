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
    public partial class tk_chinhsach : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public tk_chinhsach()
        {
            InitializeComponent();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dgcs.DataSource = ds.Tables[0];
            dgcs.Columns[0].HeaderText = "Mã Chính Sách";
            dgcs.Columns[1].HeaderText = "Tên Chính Sách";
            dgcs.Columns[2].HeaderText = "Chế Độ";


            dgcs.Columns[0].Width = 200;
            dgcs.Columns[1].Width = 200;
            dgcs.Columns[2].Width = 200;


            dgcs.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgcs.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        private void tk_chinhsach_Load(object sender, EventArgs e)
        {
            cbtim.Focus();
            ketnoi();
            string sql = "select * from chinhsach";
            load_DL(sql);
        }

        private void btnloadlai_Click(object sender, EventArgs e)
        {
            txttukhoa.Text = "";
            cbtim.Text = "";
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
                        sql = "select * from chinhsach where macs like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[1].ToString())
                    {
                        sql = "select * from chinhsach where tencs like '%" + txttukhoa.Text + "%'";
                    }
                    else if (cbtim.Text == cbtim.Items[2].ToString())
                    {
                        sql = "select * from chinhsach where chedo like '%" + txttukhoa.Text + "%'";
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

        private void dgcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
