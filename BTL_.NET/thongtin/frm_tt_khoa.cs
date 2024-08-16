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
    public partial class frm_tt_khoa : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con;
        public frm_tt_khoa()
        {
            InitializeComponent();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtinkhoa inthongtinkhoa = new inthongtinkhoa();
            inthongtinkhoa.Show();
        }

        private void frm_tt_khoa_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string sql = "Select * from khoa";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvkhoa.DataSource = dt;
            dgvkhoa.Columns[0].HeaderText = "Mã Khoa";
            dgvkhoa.Columns[1].HeaderText = "Tên Khoa";

            dgvkhoa.Columns[0].Width = 200;
            dgvkhoa.Columns[1].Width = 200;

            dgvkhoa.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvkhoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakhoa.Text = dgvkhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenkhoa.Text = dgvkhoa.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
