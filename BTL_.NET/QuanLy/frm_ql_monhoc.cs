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

namespace BTL1.thongtin
{
    public partial class frm_ql_monhoc : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_monhoc()
        {
            InitializeComponent();
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

        public void reset()
        {
            txtMamh.ReadOnly = false;
            txtMamh.Clear();
            txtTenmh.Clear();
            txtSotiet.Clear();
            
            txtMamh.Focus();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        private void frm_ql_monhoc_Load(object sender, EventArgs e)
        {
            txtMamh.Select();
            this.ActiveControl = txtMamh;
            txtMamh.Focus();
            ketnoi();
            string sql = "select * from monhoc";
            load_DL(sql);
            /////
            string sql1 = "select * from giaovien";
            SqlDataAdapter da = new SqlDataAdapter(sql1, sqlcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            cbomgv.DataSource = dt;
            cbomgv.DisplayMember = "tengv";
            cbomgv.ValueMember = "magv";
        }

        private void dgmh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMamh.ReadOnly = true;
            txtMamh.Text = dgmh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenmh.Text = dgmh.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSotiet.Text = dgmh.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbomgv.Text = dgmh.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMamh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMamh.Focus();
            }
            else if (txtTenmh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenmh.Focus();
            }
            else if (txtSotiet.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSotiet.Focus();
            }
           
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from monhoc where mamh='" + txtMamh.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMamh.Focus();
                    }
                    else
                    {
                        string sql = "insert into monhoc values('" + txtMamh.Text + "',N'" + txtTenmh.Text + "','" + txtSotiet.Text + "','" + cbomgv.SelectedValue + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_monhoc_Load(sender, e);
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                        sqlcon.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công! Mời thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ketnoi();
                    string sql = "update monhoc set tenmh=N'" + txtTenmh.Text + "', sotiet='" + txtSotiet.Text + "', magv='" + cbomgv.SelectedValue + "' where mamh='" + txtMamh.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_monhoc_Load(sender, e);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    sqlcon.Close();

                }
                catch
                {
                    MessageBox.Show("Sửa không thành công! Mời thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ketnoi();
                    string sql = "delete from monhoc where mamh='" + txtMamh.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_monhoc_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    sqlcon.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công! Mời thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
