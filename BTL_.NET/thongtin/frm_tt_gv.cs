using BTL_.NET.inthongtin;
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
    public partial class frm_tt_gv : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_tt_gv()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_tt_gv_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            sqlcon.Open();
            string sql = "Select * from giaovien";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvgv.DataSource = dt;
            dgvgv.Columns[0].HeaderText = "Mã Giáo Viên";
            dgvgv.Columns[1].HeaderText = "Tên Giáo Viên";
            dgvgv.Columns[2].HeaderText = "Giới Tính";
            dgvgv.Columns[3].HeaderText = "Ngày Sinh";
            dgvgv.Columns[4].HeaderText = "Số Điện Thoại"; 
            dgvgv.Columns[5].HeaderText = "Địa Chỉ";

            dgvgv.Columns[0].Width = 200;
            dgvgv.Columns[1].Width = 200;
            dgvgv.Columns[2].Width = 200;
            dgvgv.Columns[3].Width = 200;
            dgvgv.Columns[4].Width = 200;
            dgvgv.Columns[5].Width = 200;

            dgvgv.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtingiaovien inthongtingiaovien = new inthongtingiaovien();
            inthongtingiaovien.Show();
        }

        private void dgvgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMagv.Text = dgvgv.CurrentRow.Cells[0].Value.ToString();
            txtTengv.Text = dgvgv.CurrentRow.Cells[1].Value.ToString();
            cbGt.Text = dgvgv.CurrentRow.Cells[2].Value.ToString();
            txtns.Text = dgvgv.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvgv.CurrentRow.Cells[4].Value.ToString();
           txtDc.Text = dgvgv.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
