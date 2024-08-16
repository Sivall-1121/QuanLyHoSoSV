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
    public partial class frm_qltk_truongkhoa : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        public frm_qltk_truongkhoa()
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
                    MessageBox.Show("Tài khoản đã được đăng ký!!!Vui lòng chọn tên tài khoản khác","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttdn.Text = "";
                    txtmk.Text = "";
                    txthoten.Focus();
                }
                else
                {
                    string sql2 = "Insert into login values('" + txttdn.Text + "', '" + txtmk.Text + "',N'"+txthoten.Text+"','truongkhoa','0')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đăng ký thành công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txthoten.Text = "";
                    txttdn.Text = "";
                    txtmk.Text = "";
                    txthoten.Focus();
                    frm_qltk_truongkhoa_Load(sender, e);
                }
            }
        }

        private void frm_qltk_truongkhoa_Load(object sender, EventArgs e)
        {
            txthoten.Select();
            this.ActiveControl = txthoten;
            txthoten.Focus();
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string sql = "Select * from login where quyen='truongkhoa'";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvtruongkhoa.CellFormatting += dgvtruongkhoa_CellFormatting;
            dgvtruongkhoa.DataSource = dt;
            dgvtruongkhoa.Columns[0].HeaderText = "Tài Khoản";
            dgvtruongkhoa.Columns[1].HeaderText = "Mật Khẩu";
            dgvtruongkhoa.Columns[2].HeaderText = "Họ Tên";
            dgvtruongkhoa.Columns[3].HeaderText = "Quyền";
            dgvtruongkhoa.Columns[4].HeaderText = "Trạng Thái";
            dgvtruongkhoa.Columns[0].Width = 200;
            dgvtruongkhoa.Columns[1].Width = 200;
            dgvtruongkhoa.Columns[2].Width = 200;
            dgvtruongkhoa.Columns[3].Width = 200;
            dgvtruongkhoa.Columns[4].Width = 200;

            dgvtruongkhoa.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvtruongkhoa.EditMode = DataGridViewEditMode.EditProgrammatically;
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
                    MessageBox.Show("Oh!Có vẻ hệ thống lỗi!Thử lại sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txthoten.Text = "";
                txttdn.Text = "";
                txtmk.Text = "";
                txthoten.Focus();
                cmd.Dispose();
                cmd = null;
                frm_qltk_truongkhoa_Load(sender, e);
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
                    MessageBox.Show("Mã không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txthoten.Text = "";
                txttdn.Text = "";
                txtmk.Text = "";
                txthoten.Focus();
                cmd.Dispose();
                cmd = null;
                frm_qltk_truongkhoa_Load(sender, e);
            }
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

        private void dgvtruongkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txttdn.Text = dgvtruongkhoa.CurrentRow.Cells[0].Value.ToString();
            txtmk.Text = dgvtruongkhoa.CurrentRow.Cells[1].FormattedValue.ToString();
            txthoten.Text= dgvtruongkhoa.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvtruongkhoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvtruongkhoa.Columns[e.ColumnIndex].HeaderText == "Mật Khẩu" && e.RowIndex >= 0)
            {
                string pass = dgvtruongkhoa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
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
