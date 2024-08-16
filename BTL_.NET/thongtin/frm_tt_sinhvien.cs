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
    public partial class frm_tt_sinhvien : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_tt_sinhvien()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtMasv.Text = dgvsv.CurrentRow.Cells[0].Value.ToString();
           txtTensv.Text = dgvsv.CurrentRow.Cells[1].Value.ToString();
            cbGt.Text = dgvsv.CurrentRow.Cells[2].Value.ToString();
            textNs.Text = dgvsv.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvsv.CurrentRow.Cells[4].Value.ToString();
            txtDc.Text = dgvsv.CurrentRow.Cells[5].Value.ToString();
            txtMacs.Text = dgvsv.CurrentRow.Cells[6].Value.ToString();
            txtMalop.Text = dgvsv.CurrentRow.Cells[7].Value.ToString();
        }

        private void frm_tt_sinhvien_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            sqlcon.Open();
            string sql = "Select * from sinhvien";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvsv.DataSource = dt;
            dgvsv.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvsv.Columns[1].HeaderText = "Tên Sinh Viên";
            dgvsv.Columns[2].HeaderText = "Giới Tính";
            dgvsv.Columns[3].HeaderText = "Ngày Sinh";
            dgvsv.Columns[4].HeaderText = "Số Điện Thoại";
            dgvsv.Columns[5].HeaderText = "Địa Chỉ";
            dgvsv.Columns[6].HeaderText = "Mã Chính Sách";
            dgvsv.Columns[7].HeaderText = "Mã Lớp";
            dgvsv.Columns[0].Width = 200;
            dgvsv.Columns[1].Width = 200;
            dgvsv.Columns[2].Width = 200;
            dgvsv.Columns[3].Width = 200;
            dgvsv.Columns[4].Width = 200;
            dgvsv.Columns[5].Width = 200;
            dgvsv.Columns[6].Width = 200;
            dgvsv.Columns[7].Width = 200;
            dgvsv.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvsv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtinsinhvien inthongtinsinhvien = new inthongtinsinhvien();
            inthongtinsinhvien.Show();
        }
    }
}
