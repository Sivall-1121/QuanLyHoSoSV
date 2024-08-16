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
    public partial class frm_ql_lop : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_lop()
        {
            InitializeComponent();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dglop.DataSource = ds.Tables[0];
            dglop.Columns[0].HeaderText = "Mã Lớp";
            dglop.Columns[1].HeaderText = "Tên Lớp";
            dglop.Columns[2].HeaderText = "Mã Khoa";


            dglop.Columns[0].Width = 200;
            dglop.Columns[1].Width = 200;
            dglop.Columns[2].Width = 200;


            dglop.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dglop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void reset()
        {
            txtMalop.ReadOnly = false;
            txtMalop.Clear();
            txtTenlop.Clear();
            cbomk.Text="";
            txtMalop.Focus();
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        private void frm_ql_lop_Load(object sender, EventArgs e)
        {
            txtMalop.Select();
            this.ActiveControl = txtMalop;
            txtMalop.Focus();
            ketnoi();
            string sql = "select * from lop";
            load_DL(sql);
            //////////////
            string sql2 = "select * from khoa";
            SqlDataAdapter da1 = new SqlDataAdapter(sql2, sqlcon);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            cbomk.DataSource = dt1;
            cbomk.DisplayMember = "tenkhoa";
            cbomk.ValueMember = "makhoa";
        }

        private void dglop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMalop.Text = dglop.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenlop.Text = dglop.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbomk.Text = dglop.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMalop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMalop.Focus();
            }
            else if (txtTenlop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenlop.Focus();
            }
            else if (cbomk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomk.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from lop where malop='" + txtMalop.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMalop.Focus();
                    }
                    else
                    {
                        string sql = "insert into lop values('" + txtMalop.Text + "',N'" + txtTenlop.Text + "', '" +cbomk.SelectedValue + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_lop_Load(sender, e);
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
                    string sql = "update lop set tenlop=N'" + txtTenlop.Text + "', makhoa='" + cbomk.SelectedValue + "' where malop='" + txtMalop.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_lop_Load(sender, e);
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

                    string sql = "delete from lop where malop='" + txtMalop.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_lop_Load(sender, e);
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
