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
    public partial class frm_ql_chinhsach : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_chinhsach()
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
        public void reset()
        {
            txtMacs.ReadOnly = false;
            txtMacs.Clear();
            txtTencs.Clear();
            txtCd.Clear();
            txtMacs.Focus();
        }
        private void frm_ql_chinhsach_Load(object sender, EventArgs e)
        {
            txtMacs.Select();
            this.ActiveControl = txtMacs;
            txtMacs.Focus();
            ketnoi();
            string sql = "select * from chinhsach";
            load_DL(sql);
        }

        private void dgcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMacs.ReadOnly = true;
            txtMacs.Text = dgcs.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTencs.Text = dgcs.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCd.Text = dgcs.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMacs.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacs.Focus();
            }
            else if (txtTencs.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTencs.Focus();
            }
            else if (txtCd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCd.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from chinhsach where macs='" + txtMacs.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMacs.Focus();
                    }
                    else
                    {
                        string sql = "insert into chinhsach values(N'" + txtMacs.Text + "',N'" + txtTencs.Text + "','" + txtCd.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_chinhsach_Load(sender, e);
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
                    string sql = "update chinhsach set tencs=N'" + txtTencs.Text + "', chedo=N'" + txtCd.Text + "' where macs='" + txtMacs.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_chinhsach_Load(sender, e);
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

                    string sql = "delete from chinhsach where macs='" + txtMacs.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_chinhsach_Load(sender, e);
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
