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
    public partial class frm_tt_diem : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_tt_diem()
        {
            InitializeComponent();
        }

        private void frm_tt_diem_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            sqlcon.Open();
            string sql = "Select * from diem";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvdiem.DataSource = dt;
            dgvdiem.Columns[0].HeaderText = "ID";
            dgvdiem.Columns[1].HeaderText = "Mã Sinh Viên";
            dgvdiem.Columns[2].HeaderText = "Mã Môn Học";
            dgvdiem.Columns[3].HeaderText = "Điểm";
           

            dgvdiem.Columns[0].Width = 200;
            dgvdiem.Columns[1].Width = 200;
            dgvdiem.Columns[2].Width = 200;
            dgvdiem.Columns[3].Width = 200;
            dgvdiem.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvdiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtindiem inthongtindiem = new inthongtindiem();
            inthongtindiem.Show();
        }

        private void dgvdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaId.Text = dgvdiem.CurrentRow.Cells[0].Value.ToString();
            txtMasv.Text = dgvdiem.CurrentRow.Cells[1].Value.ToString();
            txtMamh.Text = dgvdiem.CurrentRow.Cells[2].Value.ToString();
            txtDiem.Text = dgvdiem.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
