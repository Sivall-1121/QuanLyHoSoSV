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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL1.quanlytaikhoan
{
    public partial class frm_qltk_gv : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        public frm_qltk_gv()
        {
            InitializeComponent();
        }

        private void frm_qltk_gv_Load(object sender, EventArgs e)
        {
            txttk.Select();
            this.ActiveControl = txttk;
            txttk.Focus();
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            /////////
            string sql1 = "select * from giaovien";
            SqlDataAdapter da = new SqlDataAdapter(sql1, con);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            cboht.DataSource = dt1;
            cboht.DisplayMember = "magv";
            cboht.ValueMember = "tengv";
            ////////
            string sql = "Select * from login where quyen='giaovien'";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvgv.CellFormatting += dgvgv_CellFormatting;
            dgvgv.DataSource = dt;
            dgvgv.Columns[0].HeaderText = "Tài Khoản";
            dgvgv.Columns[1].HeaderText = "Mật Khẩu";
            dgvgv.Columns[2].HeaderText = "Họ Tên";
            dgvgv.Columns[3].HeaderText = "Quyền";
            dgvgv.Columns[4].HeaderText = "Trạng Thái";
            dgvgv.Columns[0].Width = 200;
            dgvgv.Columns[1].Width = 200;
            dgvgv.Columns[2].Width = 200;
            dgvgv.Columns[3].Width = 200;
            dgvgv.Columns[4].Width = 200;

            dgvgv.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
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
                string sql = "Select count(*) from login where tk='" + txttk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (i != 0)
                {
                    MessageBox.Show("Tài khoản đã được đăng ký!!!Vui lòng chọn tên tài khoản khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttk.Text = "";
                    txtmk.Text = "";
                    txttk.Focus();
                }
                else
                {
                    string sql2 = "Insert into login values('" + txttk.Text + "', '" + txtmk.Text + "',N'"+cboht.SelectedValue+"','giaovien','0')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txttk.Text = "";
                    txtmk.Text = "";
                    txttk.Focus();
                    frm_qltk_gv_Load(sender, e);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
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
                sql = "UPDATE login SET mk=N'" + txtmk.Text + "',fullname=N'"+cboht.SelectedValue+"' where  tk=N'" + txttk.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(sql, con);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ohhh!Có vẻ lỗi hệ thống","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmd.Dispose();
                cmd = null;
                txttk.Text = "";
                txtmk.Text = "";
                txttk.Focus();
                frm_qltk_gv_Load(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else
            //   if (txtmk.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập mật khẩu");
            //}
            else
            {
                string sql;
                sql = "DELETE login WHERE tk=N'" + txttk.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(sql, con);

                try
                {
                    DialogResult dg = MessageBox.Show("Bạn xóa không?", "Thông báo",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmd.Dispose();
                cmd = null;
                txttk.Text = "";
                txtmk.Text = "";
                txttk.Focus();
                frm_qltk_gv_Load(sender, e);
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
            txttk.Focus();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttk.Text = dgvgv.CurrentRow.Cells[0].Value.ToString();
            txtmk.Text = dgvgv.CurrentRow.Cells[1].FormattedValue.ToString();
            cboht.SelectedValue=dgvgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvgv.Columns[e.ColumnIndex].HeaderText == "Mật Khẩu" && e.RowIndex >= 0)
            {
                string pass = dgvgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
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
