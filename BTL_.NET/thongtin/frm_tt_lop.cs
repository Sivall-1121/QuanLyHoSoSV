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
    public partial class frm_tt_lop : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_tt_lop()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_tt_lop_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            sqlcon.Open();
            string sql = "Select * from lop";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvlop.DataSource = dt;
            dgvlop.Columns[0].HeaderText = "Mã Lớp";
            dgvlop.Columns[1].HeaderText = "Tên Lớp";
            dgvlop.Columns[2].HeaderText = "Mã Khoa";
            

            dgvlop.Columns[0].Width = 200;
            dgvlop.Columns[1].Width = 200;
            dgvlop.Columns[2].Width = 200;
           

            dgvlop.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvlop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtinlop inthongtinlop = new inthongtinlop();
            inthongtinlop.Show();
        }

        private void dgvlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMalop.Text = dgvlop.CurrentRow.Cells[0].Value.ToString();
            txtTenlop.Text = dgvlop.CurrentRow.Cells[1].Value.ToString();
            txtMakhoa.Text = dgvlop.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
