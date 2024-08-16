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
    public partial class frm_ql_khoa : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_khoa()
        {
            InitializeComponent();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
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

        public void reset()
        {
            txtMakhoa.ReadOnly = false;
            txtMakhoa.Clear();
            txtTenkhoa.Clear();
            txtMakhoa.Focus();
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        private void frm_ql_khoa_Load(object sender, EventArgs e)
        {
            txtMakhoa.Select();
            this.ActiveControl = txtMakhoa;
            txtMakhoa.Focus();
            ketnoi();
            string sql = "select * from khoa";
            load_DL(sql);
        }

        private void dgkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakhoa.ReadOnly = true;
            txtMakhoa.Text = dgkhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenkhoa.Text = dgkhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhoa.Focus();
            }
            else if (txtTenkhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhoa.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from khoa where makhoa='" + txtMakhoa.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMakhoa.Focus();
                    }
                    else
                    {
                        string sql = "insert into khoa values('" + txtMakhoa.Text + "',N'" + txtTenkhoa.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_khoa_Load(sender, e);
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
                    string sql = "update khoa set tenkhoa=N'" + txtTenkhoa.Text + "' where makhoa='" + txtMakhoa.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_khoa_Load(sender, e);
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

                    string sql = "delete from khoa where makhoa='" + txtMakhoa.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_khoa_Load(sender, e);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
