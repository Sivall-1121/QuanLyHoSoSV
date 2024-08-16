using DevExpress.XtraPrinting.BarCode;
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
using ZXing;
using ZXing.Common;
using ZXing.Presentation;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using BarcodeWriter = ZXing.BarcodeWriter;
using ErrorCorrectionLevel = ZXing.QrCode.Internal.ErrorCorrectionLevel;

namespace BTL1.thongtin
{
    public partial class frm_ql_sinhvien : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlcon;
        public frm_ql_sinhvien()
        {
            InitializeComponent();
        }
        public void load_DL(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dgsv.DataSource = ds.Tables[0];
            dgsv.Columns[0].HeaderText = "Mã Sinh Viên";
            dgsv.Columns[1].HeaderText = "Tên Sinh Viên";
            dgsv.Columns[2].HeaderText = "Giới Tính";
            dgsv.Columns[3].HeaderText = "Ngày Sinh";
            dgsv.Columns[4].HeaderText = "Số Điện Thoại";
            dgsv.Columns[5].HeaderText = "Địa Chỉ";
            dgsv.Columns[6].HeaderText = "Mã Chính Sách";
            dgsv.Columns[7].HeaderText = "Mã Lớp";
            dgsv.Columns[0].Width = 200;
            dgsv.Columns[1].Width = 200;
            dgsv.Columns[2].Width = 200;
            dgsv.Columns[3].Width = 200;
            dgsv.Columns[4].Width = 200;
            dgsv.Columns[5].Width = 200;
            dgsv.Columns[6].Width = 200;
            dgsv.Columns[7].Width = 200;
            dgsv.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgsv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void reset()
        {
            txtMasv.ReadOnly = false;
            txtMasv.Clear();
            txtTensv.Clear();
            rdonam.Checked = true;
            ns.Text = DateTime.Now.ToString();
            txtSdt.Clear();
            txtDc.Clear();
            
            txtMasv.Focus();
        }
        public void ketnoi()
        {
            sqlcon = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        private void frm_ql_sinhvien_Load(object sender, EventArgs e)
        {
            txtMasv.Select();
            this.ActiveControl = txtMasv;
            txtMasv.Focus();
            ketnoi();
            string sql = "select * from sinhvien";
            load_DL(sql);
            ///////
            string sql1 = "select macs from chinhsach";
            SqlDataAdapter da = new SqlDataAdapter(sql1, sqlcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            cbomcs.DataSource = dt;
            cbomcs.DisplayMember = "tencs";
            cbomcs.ValueMember = "macs";
            ///////////////////////////////////
            string sql2 = "select malop from lop";
            SqlDataAdapter da1 = new SqlDataAdapter(sql2, sqlcon);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            cboml.DataSource = dt1;
            cboml.DisplayMember = "tenlop";
            cboml.ValueMember = "malop";
        }

        private void dgsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasv.ReadOnly = true;
            txtMasv.Text = dgsv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTensv.Text = dgsv.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(dgsv.Rows[e.RowIndex].Cells[2].Value.ToString()=="Nam")
            {
                rdonam.Checked = true;
            }
            else
            {
                rdonu.Checked = true;
            }
            ns.Text = dgsv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSdt.Text = dgsv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDc.Text = dgsv.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbomcs.Text = dgsv.Rows[e.RowIndex].Cells[6].Value.ToString();
            cboml.Text = dgsv.Rows[e.RowIndex].Cells[7].Value.ToString();
            //////////////////////////////////////
            var qrcode_text = $"{txtMasv.Text.Trim()}|{txtTensv.Text.Trim()}|{txtSdt.Text.Trim()}|";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions=new EncodingOptions() { Width=100, Height = 100, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            
         //  encodingOptions.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            barcodeWriter.Renderer=new BitmapRenderer();
            barcodeWriter.Options= encodingOptions;
            barcodeWriter.Options.Hints.Add(EncodeHintType.DISABLE_ECI, true);
            barcodeWriter.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            pictureBox1.Image=bitmap;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasv.Focus();
            }
            else if (txtTensv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu! Hãy nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensv.Focus();
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
                    string str = "select count(*) from sinhvien where masv='" + txtMasv.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(str, sqlcon);
                    int i = (int)sqlcom.ExecuteScalar();
                    sqlcom.Dispose();
                    if (i != 0)
                    {
                        MessageBox.Show("Trùng mã! Mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMasv.Focus();
                    }
                    else
                    {
                        string gt = "";
                        if(rdonam.Checked)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }   
                        string sql = "insert into sinhvien values('" + txtMasv.Text + "',N'" + txtTensv.Text + "',N'" + gt + "','" + ns.Value + "','" + txtSdt.Text + "',N'" + txtDc.Text + "','" +cbomcs.SelectedValue + "','" + cboml.SelectedValue + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.ExecuteNonQuery();
                        frm_ql_sinhvien_Load(sender, e);
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
                    string sql = "update sinhvien set tensv=N'" + txtTensv.Text + "',gioitinh=N'" + gt + "',ngaysinh='" + ns.Value + "',sdt='" + txtSdt.Text + "',diachi=N'" + txtDc.Text + "',macs='" + cbomcs.SelectedValue + "',malop='" + cboml.SelectedValue + "'  where masv='" + txtMasv.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_sinhvien_Load(sender, e);
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

                    string sql = "delete from sinhvien where masv='" + txtMasv.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    frm_ql_sinhvien_Load(sender, e);
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
            pictureBox1.Image = default;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
