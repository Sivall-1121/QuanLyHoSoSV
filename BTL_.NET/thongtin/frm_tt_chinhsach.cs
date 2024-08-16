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
    public partial class frm_tt_chinhsach : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_tt_chinhsach()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_tt_chinhsach_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            sqlcon.Open();
            string sql = "Select * from chinhsach";
            SqlDataAdapter sqldt = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sqldt.Fill(dt);
            sqldt.Fill(ds);
            dgvcs.DataSource = dt;
            dgvcs.Columns[0].HeaderText = "Mã Chính Sách";
            dgvcs.Columns[1].HeaderText = "Tên Chính Sách";
            dgvcs.Columns[2].HeaderText = "Chế Độ";
           

            dgvcs.Columns[0].Width = 200;
            dgvcs.Columns[1].Width = 200;
            dgvcs.Columns[2].Width = 200;
           

            dgvcs.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvcs.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            inthongtinchinhsach inthongtinchinhsach = new inthongtinchinhsach();
            inthongtinchinhsach.Show();
        }

        private void dgvcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMacs.Text = dgvcs.CurrentRow.Cells[0].Value.ToString();
            txtTencs.Text = dgvcs.CurrentRow.Cells[1].Value.ToString();
            txtcd.Text = dgvcs.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
