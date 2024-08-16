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
    public partial class frm_ql_gv : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_gv()
        {
            InitializeComponent();
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

        public void reset()
        {
            txtMagv.ReadOnly = false;
            txtMagv.Clear();
            txtTengv.Clear();
            dtpns.Text=DateTime.Now.ToString();
            txtSdt.Clear();
            txtDc.Clear();
            rdonam.Checked = true;
            txtMagv.Focus();
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
      

       
        private void frm_ql_gv_Load(object sender, EventArgs e)
        {
            txtMagv.Select();
            this.ActiveControl = txtMagv;
            txtMagv.Focus();
            ketnoi();
            string sql = "select * from giaovien";
            load_DL(sql);
        }

        private void dggv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMagv.ReadOnly = true;
            txtMagv.Text = dggv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTengv.Text = dggv.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dggv.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
            {
                rdonam.Checked = true;
            }
            else
            {
                rdonu.Checked = true;
            }
            dtpns.Text = dggv.Rows[e.RowIndex].Cells[3].Value.ToString();
           
            txtSdt.Text = dggv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDc.Text = dggv.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMagv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagv.Focus();
            }
            else if (txtTengv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTengv.Focus();
            }
          
            else if (txtSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
            }
            else if (txtDc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDc.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from giaovien where magv='" + txtMagv.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMagv.Focus();
                    }
                    else
                    {
                        string gt = "";
                        if (rdonam.Checked)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }
                        string sql = "insert into giaovien values('" + txtMagv.Text + "',N'" + txtTengv.Text + "', N'" +gt+ "', '" + dtpns.Value + "', '" + txtSdt.Text + "', N'" + txtDc.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_gv_Load(sender, e);
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
                    string gt = "";
                    if (rdonam.Checked)
                    {
                        gt = "Nam";
                    }
                    else
                    {
                        gt = "Nữ";
                    }
                    string sql = "update giaovien set tengv=N'" + txtTengv.Text + "', gioitinh=N'" + gt + "', ngaysinh='" + dtpns.Value + "', sdt='" + txtSdt.Text + "', diachi=N'" + txtDc.Text + "' where magv='" + txtMagv.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_gv_Load(sender, e);
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

                    string sql = "delete from giaovien where magv='" + txtMagv.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_gv_Load(sender, e);
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
