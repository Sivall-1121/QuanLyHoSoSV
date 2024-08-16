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

namespace BTL1.quanlytaikhoan
{
    public partial class frm_qltk_user : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        public frm_qltk_user()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttdn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "Select count(*) from login where tk='" + txttdn.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (i != 0)
                {
                    MessageBox.Show("Tài khoản đã được đăng ký!!!Vui lòng chọn tên tài khoản khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txthoten.Text = "";
                    txttdn.Text = "";
                    txtmk.Text = "";
                    txthoten.Focus();
                }
                else
                {
                    string sql2 = "Insert into login values('" + txttdn.Text + "', '" + txtmk.Text + "',N'"+txthoten.Text+"','nguoidung','0')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txthoten.Text = "";
                    txttdn.Text = "";
                    txtmk.Text = "";
                    txthoten.Focus();
                    frm_qltk_user_Load(sender, e);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttdn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql;
                sql = "UPDATE login SET mk=N'" + txtmk.Text + "',fullname=N'"+txthoten.Text+"' where  tk=N'" + txttdn.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(sql, con);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ohh!Có vẻ hệ thống lỗi!Thử lại sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txthoten.Text = "";
                txttdn.Text = "";
                txtmk.Text = "";
                txthoten.Focus();
                cmd.Dispose();
                cmd = null;
                frm_qltk_user_Load(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txttdn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql;
                sql = "DELETE login WHERE tk=N'" + txttdn.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(sql, con);

                try
                {
                    DialogResult dg = MessageBox.Show("Bạn xóa không?", "Thông báo",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txthoten.Text = "";
                txttdn.Text = "";
                txtmk.Text = "";
                txthoten.Focus();
                cmd.Dispose();
                cmd = null;
                frm_qltk_user_Load(sender, e);
            }
        }

        private void frm_qltk_user_Load(object sender, EventArgs e)
        {
            txthoten.Select();
            this.ActiveControl = txthoten;
            txthoten.Focus();
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string sql = "Select * from login where quyen='nguoidung'";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvnd.CellFormatting += dgvnd_CellFormatting;
            dgvnd.DataSource = dt;
            dgvnd.Columns[0].HeaderText = "Tài Khoản";
            dgvnd.Columns[1].HeaderText = "Mật Khẩu";
            dgvnd.Columns[2].HeaderText = "Họ Tên";
            dgvnd.Columns[3].HeaderText = "Quyền";
            dgvnd.Columns[4].HeaderText = "Trạng Thái";
            dgvnd.Columns[0].Width = 200;
            dgvnd.Columns[1].Width = 200;
            dgvnd.Columns[2].Width = 200;
            dgvnd.Columns[3].Width = 200;
            dgvnd.Columns[4].Width = 200;

            dgvnd.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvnd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
            txttdn.Text = "";
            txtmk.Text = "";
            txthoten.Focus();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttdn.Text = dgvnd.CurrentRow.Cells[0].Value.ToString();
            txtmk.Text = dgvnd.CurrentRow.Cells[1].FormattedValue.ToString();
            txthoten.Text = dgvnd.CurrentRow.Cells[2].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvnd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvnd.Columns[e.ColumnIndex].HeaderText == "Mật Khẩu" && e.RowIndex >= 0)
            {
                string pass = dgvnd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string encryptpass = EncryptPass(pass);
                e.Value = encryptpass;
            }
        }
        private string EncryptPass(string p)
        {
            string epass = "";
            foreach (char c in p)
            {
                epass += "*";
            }
            return epass;
        }
    }
}
