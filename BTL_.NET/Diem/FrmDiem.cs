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

namespace BTL.Diem
{
    public partial class FrmDiem : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public FrmDiem()
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

            dgdiem.DataSource = ds.Tables[0];
          
            dgdiem.Columns[0].HeaderText = "ID";
            dgdiem.Columns[1].HeaderText = "Mã Sinh Viên";
            dgdiem.Columns[2].HeaderText = "Mã Môn Học";
            dgdiem.Columns[3].HeaderText = "Điểm";


            dgdiem.Columns[0].Width = 200;
            dgdiem.Columns[1].Width = 200;
            dgdiem.Columns[2].Width = 200;
            dgdiem.Columns[3].Width = 200;
            dgdiem.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgdiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void FrmDiem_Load(object sender, EventArgs e)
        {
            txtmaid.Select();
            this.ActiveControl = txtmaid;
           
            txtmaid.Focus();
            ketnoi();
            string sql = "select * from diem";
            load_DL(sql);
            string sql1 = "select masv from sinhvien";
            SqlDataAdapter da = new SqlDataAdapter(sql1, sqlcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            cbomsv.DataSource = dt;
            cbomsv.DisplayMember = "tensv";
            cbomsv.ValueMember = "masv";
            ///////////////////////////////////
            string sql2 = "select * from monhoc";
            SqlDataAdapter da1 = new SqlDataAdapter(sql2, sqlcon);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            cbommh.DataSource = dt1;
            cbommh.DisplayMember = "tenmh";
            cbommh.ValueMember = "mamh";
        }
        public void reset()
        {
            txtmaid.Clear();
            cbomsv.Text="";
            cbommh.Text="";
            txtdiem.Clear();
            txtmaid.Focus();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmaid.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaid.Focus();
            }
            else if (cbomsv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomsv.Focus();
            }
            else if (cbommh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbommh.Focus();
            }
            else if (txtdiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiem.Focus();
            }
            else
            {
                try
                {
                    ketnoi();
                    string str = "select count(*) from diem where id='" + txtmaid.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Id đã có! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtmaid.Focus();
                    }
                    else
                    {
                        string sql = "insert into diem values('" + txtmaid.Text + "','" + cbomsv.SelectedValue + "','" +cbommh.SelectedValue + "', '" + txtdiem.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        FrmDiem_Load(sender, e);
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

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ketnoi();
                    string sql = "update diem set masv='" + cbomsv.SelectedValue + "',mamh='" +cbommh.SelectedValue + "', diem='" + txtdiem.Text + "' where id='" + txtmaid.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    FrmDiem_Load(sender, e);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    txtmaid.ReadOnly = false;
                    sqlcon.Close();

                }
                catch
                {
                    MessageBox.Show("Sửa không thành công! Mời thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void dgdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaid.ReadOnly = true;
            txtmaid.Text = dgdiem.Rows[e.RowIndex].Cells[0].Value.ToString();
           cbomsv.Text = dgdiem.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbommh.Text = dgdiem.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiem.Text = dgdiem.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ketnoi();

                    string sql = "delete from diem where id='" + txtmaid.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    FrmDiem_Load(sender, e);
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

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           btnthem.Enabled = false;
            btnsua.Enabled=false;
            btnxoa.Enabled = false;
            btnnhaplai.Enabled = false;
            btndong.Enabled = false;
            txtdiem.Enabled = false;
            txtmaid.Enabled=false;
            cbommh.Enabled = false;
            cbomsv.Enabled = false;
        }
    }
}
