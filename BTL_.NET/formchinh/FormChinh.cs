using BTL.Diem;
using BTL_.NET.HeThong;
using BTL_.NET.Hotro;
using BTL_.NET.Log_Sig;
using BTL_.NET.TimKiem;
using BTL1.quanlytaikhoan;
using BTL1.thongtin;
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
using System.Runtime.InteropServices;

namespace BTL.FormChinh
{
    public partial class frmformchinh : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("Powrprof.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
        SqlConnection con;
        string quyen = "";
        string tentaikhoan = "";
        string name = "";
        public frmformchinh(string q, string tk,string ten)
        {
            InitializeComponent();
            quyen = q;
            tentaikhoan = tk;
            name = ten;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            label3.Text = "" + DateTime.Now.ToString();
            label2.Text = "" + tentaikhoan+"/"+name;
            if (quyen == "truongkhoa")
            {
                đăngNhậpToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnAdminToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
                điểmToolStripMenuItem1.Visible = false;

            }
            if (quyen == "admin")
            {

            }
            if (quyen == "nguoidung")
            {
                đăngNhậpToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnAdminToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
                điểmToolStripMenuItem1.Visible = false;
                quảnLýToolStripMenuItem.Visible = false;

            }
            if (quyen == "giaovien")
            {
                đăngNhậpToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnAdminToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
                quảnLýToolStripMenuItem.Visible=false;

            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void quảnLýTàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_qltk_admin frm_Qltk_Admin = new frm_qltk_admin();
            frm_Qltk_Admin.Show();
        }

        private void quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_qltk_truongkhoa frm_Qltk_Truongkhoa = new frm_qltk_truongkhoa();
            frm_Qltk_Truongkhoa.Show();
        }

        private void quảnLýTàiKhoảnGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_qltk_gv frm_Qltk_Gv = new frm_qltk_gv();
            frm_Qltk_Gv.Show();
        }

        private void quảnLýTàiKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_qltk_user frm_Qltk_User = new frm_qltk_user();
            frm_Qltk_User.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ht_DoiMK ht_DoiMK = new ht_DoiMK(quyen);
            ht_DoiMK.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_khoa khoa = new frm_tt_khoa();
                khoa.Show();
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_khoa khoa = new tk_khoa();
            khoa.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tk_giaovien tk_Giaovien = new tk_giaovien();
            tk_Giaovien.Show();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_lop tk_Lop = new tk_lop();
            tk_Lop.Show();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_sinhvien tk_Sinhvien = new tk_sinhvien();
            tk_Sinhvien.Show();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_monhoc tk_Monhoc = new tk_monhoc();
            tk_Monhoc.Show();
        }

        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_chinhsach tk_Chinhsach = new tk_chinhsach();
            tk_Chinhsach.Show();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDiem frmDiem = new FrmDiem();
            frmDiem.Show();
        }

        private void khoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_khoa frm_Ql_Khoa = new frm_ql_khoa();
            frm_Ql_Khoa.Show();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ql_gv frm_Ql_Gv = new frm_ql_gv();
            frm_Ql_Gv.Show();
        }

        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_lop frm_Ql_Lop = new frm_ql_lop();
            frm_Ql_Lop.Show();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_sinhvien frm_Ql_Sinhvien = new frm_ql_sinhvien();
            frm_Ql_Sinhvien.Show();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_monhoc frm_Ql_Monhoc = new frm_ql_monhoc();
            frm_Ql_Monhoc.Show();
        }

        private void điểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_diem frm_Ql_Diem = new frm_ql_diem();
            frm_Ql_Diem.Show();
        }

        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ql_chinhsach frm_Ql_Chinhsach = new frm_ql_chinhsach();
            frm_Ql_Chinhsach.Show();
        }

        private void trongSuốtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;

        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\DELL\\AppData\\Local\\Microsoft\\WindowsApps\\mspaint.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Windows\\System32\\cmd.exe\"");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\notepad.exe");
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void microsoftWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE\"");
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "System";
            quảnLýTàiKhoảnAdminToolStripMenuItem.Text = "Manage Account Admin";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Manage Account Dean";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Manage Account Teacher";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "Manage Account User";
            khóaToolStripMenuItem.Text = "Lock";
            đổiMậtKhẩuToolStripMenuItem.Text = "Change Password";
            xóaToolStripMenuItem.Text = "Logout";
            thôngTinToolStripMenuItem.Text = "Information";
            khoaToolStripMenuItem.Text = "Department";
            nhânViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem.Text = "Class";
            sinhViênToolStripMenuItem.Text = "Student";
            mônHọcToolStripMenuItem.Text = "Subject";
            chínhSáchToolStripMenuItem.Text = "Policy";
            điểmToolStripMenuItem.Text = "Scores";
            tìmKiếmToolStripMenuItem.Text = "Search";
            khoaToolStripMenuItem1.Text = "Department";
            giáoViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem1.Text = "Class";
            sinhViênToolStripMenuItem1.Text = "Student";
            mônHọcToolStripMenuItem1.Text = "Subject";
            chínhSáchToolStripMenuItem1.Text = "Policy";
            điểmToolStripMenuItem1.Text = "Scores";
            quảnLýToolStripMenuItem.Text = "Manage";
            khoaToolStripMenuItem2.Text = "Department";
            giáoViênToolStripMenuItem1.Text = "Teacher";
            lớpToolStripMenuItem2.Text = "Class";
            sinhViênToolStripMenuItem2.Text = "Student";
            mônHọcToolStripMenuItem2.Text = "Subject";
            điểmToolStripMenuItem2.Text = "Scores";
            chínhSáchToolStripMenuItem2.Text = "Policy";
            hiểnThịToolStripMenuItem.Text = "Display";
            kiểuXemToolStripMenuItem.Text = "View Type";
            trongSuốtToolStripMenuItem.Text = "Transparent";
            maToolStripMenuItem.Text = "Default";
            ngônNgữToolStripMenuItem.Text = "Language";
            tiếngAnhToolStripMenuItem.Text = "English";
            tiếngViệtToolStripMenuItem.Text = "Vietnamese";
            tiệnÍchToolStripMenuItem.Text = "Utilities";
            máyTínhToolStripMenuItem.Text = "Calculator";
            hỗTrợToolStripMenuItem.Text = "Support";
            liênHệToolStripMenuItem.Text = "Contact";
            thôngTinToolStripMenuItem1.Text = "Information";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Update Software";
            thoátToolStripMenuItem.Text = "Exit";
        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            quảnLýTàiKhoảnAdminToolStripMenuItem.Text = "Quản lý tài khoản Admin";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Quản lý tài khoản trưởng khoa";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Quản lý tài khoản giáo viên";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "Quản lý tài khoản người dùng";
            khóaToolStripMenuItem.Text = "Khóa";
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            xóaToolStripMenuItem.Text = "Đăng xuất";
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            khoaToolStripMenuItem.Text = "Khoa";
            nhânViênToolStripMenuItem.Text = "Giáo viên";
            lớpToolStripMenuItem.Text = "Lớp";
            sinhViênToolStripMenuItem.Text = "Sinh viên";
            mônHọcToolStripMenuItem.Text = "Môn học";
            chínhSáchToolStripMenuItem.Text = "Chính sách";
            điểmToolStripMenuItem.Text = "Điểm";
            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            khoaToolStripMenuItem1.Text = "Khoa";
            giáoViênToolStripMenuItem.Text = "Giáo viên";
            lớpToolStripMenuItem1.Text = "Lớp";
            sinhViênToolStripMenuItem1.Text = "Sinh viên";
            mônHọcToolStripMenuItem1.Text = "Môn học";
            chínhSáchToolStripMenuItem1.Text = "Chính sách";
            điểmToolStripMenuItem1.Text = "Điểm";
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            khoaToolStripMenuItem2.Text = "Khoa";
            giáoViênToolStripMenuItem1.Text = "Giáo viên";
            lớpToolStripMenuItem2.Text = "Lớp";
            sinhViênToolStripMenuItem2.Text = "Sinh viên";
            mônHọcToolStripMenuItem2.Text = "Môn học";
            điểmToolStripMenuItem2.Text = "Điểm";
            chínhSáchToolStripMenuItem2.Text = "Chính sách";
            hiểnThịToolStripMenuItem.Text = "Hiển Thị";
            kiểuXemToolStripMenuItem.Text = "Kiểu xem";
            trongSuốtToolStripMenuItem.Text = "Trong suốt";
            maToolStripMenuItem.Text = "Mặc định";
            ngônNgữToolStripMenuItem.Text = "Ngôn ngữ";
            tiếngAnhToolStripMenuItem.Text = "Tiếng Anh";
            tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
            tiệnÍchToolStripMenuItem.Text = "Tiện Ích";
            máyTínhToolStripMenuItem.Text = "Máy tính";
            hỗTrợToolStripMenuItem.Text ="Hỗ Trợ";
            liênHệToolStripMenuItem.Text = "Liên Hệ";
            thôngTinToolStripMenuItem1.Text = "Thông tin";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Cập nhật phần mềm";
            thoátToolStripMenuItem.Text = "Thoát";
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_tt_gv frm_Tt_Gv = new frm_tt_gv();
            frm_Tt_Gv.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lienhe lienhe = new Lienhe();
            lienhe.Show();
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Thongtin  frmThongtin = new Thongtin();
            frmThongtin.Show();
        }

        private void cậpNhậtPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capnhatphanmem capnhatphanmem = new Capnhatphanmem();
            capnhatphanmem.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_lop frm_Tt_Lop = new frm_tt_lop();
            frm_Tt_Lop.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_sinhvien frm_Tt_Sinhvien = new frm_tt_sinhvien();
            frm_Tt_Sinhvien.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_monhoc frm_Tt_Monhoc = new frm_tt_monhoc();
            frm_Tt_Monhoc.Show();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_chinhsach frm_Tt_Chinhsach = new frm_tt_chinhsach();
            frm_Tt_Chinhsach.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tt_diem frm_Tt_Diem = new frm_tt_diem();
            frm_Tt_Diem.Show();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsinhvien.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string sql3 = "UPDATE login SET state=N'0' where tk=N'" + name + "'";
            SqlCommand sqlCommand4 = new SqlCommand(sql3, con);
            sqlCommand4.ExecuteNonQuery();
            this.Close();
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=SONVU\SQLEXPRESS;Initial Catalog=qlsinhvien;Integrated Security=True";
            con.Open();
            string sql3 = "UPDATE login SET state=N'0' where tk=N'" + name + "'";
            SqlCommand sqlCommand4 = new SqlCommand(sql3, con);
            sqlCommand4.ExecuteNonQuery();
            this.Close();
           
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\DELL\\Documents\\HelpNDoc\\Output\\chm\\laptrinhnet.chm");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            hệThốngToolStripMenuItem.Text = "System";
            quảnLýTàiKhoảnAdminToolStripMenuItem.Text = "Manage Account Admin";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Manage Account Dean";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Manage Account Teacher";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "Manage Account User";
            khóaToolStripMenuItem.Text = "Lock";
            đổiMậtKhẩuToolStripMenuItem.Text = "Change Password";
            xóaToolStripMenuItem.Text = "Logout";
            thôngTinToolStripMenuItem.Text = "Information";
            khoaToolStripMenuItem.Text = "Department";
            nhânViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem.Text = "Class";
            sinhViênToolStripMenuItem.Text = "Student";
            mônHọcToolStripMenuItem.Text = "Subject";
            chínhSáchToolStripMenuItem.Text = "Policy";
            điểmToolStripMenuItem.Text = "Scores";
            tìmKiếmToolStripMenuItem.Text = "Search";
            khoaToolStripMenuItem1.Text = "Department";
            giáoViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem1.Text = "Class";
            sinhViênToolStripMenuItem1.Text = "Student";
            mônHọcToolStripMenuItem1.Text = "Subject";
            chínhSáchToolStripMenuItem1.Text = "Policy";
            điểmToolStripMenuItem1.Text = "Scores";
            quảnLýToolStripMenuItem.Text = "Manage";
            khoaToolStripMenuItem2.Text = "Department";
            giáoViênToolStripMenuItem1.Text = "Teacher";
            lớpToolStripMenuItem2.Text = "Class";
            sinhViênToolStripMenuItem2.Text = "Student";
            mônHọcToolStripMenuItem2.Text = "Subject";
            điểmToolStripMenuItem2.Text = "Scores";
            chínhSáchToolStripMenuItem2.Text = "Policy";
            hiểnThịToolStripMenuItem.Text = "Display";
            kiểuXemToolStripMenuItem.Text = "View Type";
            trongSuốtToolStripMenuItem.Text = "Transparent";
            maToolStripMenuItem.Text = "Default";
            ngônNgữToolStripMenuItem.Text = "Language";
            tiếngAnhToolStripMenuItem.Text = "English";
            tiếngViệtToolStripMenuItem.Text = "Vietnamese";
            tiệnÍchToolStripMenuItem.Text = "Utilities";
            máyTínhToolStripMenuItem.Text = "Calculator";
            hỗTrợToolStripMenuItem.Text = "Support";
            liênHệToolStripMenuItem.Text = "Contact";
            thôngTinToolStripMenuItem1.Text = "Information";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Update Software";
            thoátToolStripMenuItem.Text = "Exit";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            quảnLýTàiKhoảnAdminToolStripMenuItem.Text = "Quản lý tài khoản Admin";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Quản lý tài khoản trưởng khoa";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Quản lý tài khoản giáo viên";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "Quản lý tài khoản người dùng";
            khóaToolStripMenuItem.Text = "Khóa";
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            xóaToolStripMenuItem.Text = "Đăng xuất";
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            khoaToolStripMenuItem.Text = "Khoa";
            nhânViênToolStripMenuItem.Text = "Giáo viên";
            lớpToolStripMenuItem.Text = "Lớp";
            sinhViênToolStripMenuItem.Text = "Sinh viên";
            mônHọcToolStripMenuItem.Text = "Môn học";
            chínhSáchToolStripMenuItem.Text = "Chính sách";
            điểmToolStripMenuItem.Text = "Điểm";
            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            khoaToolStripMenuItem1.Text = "Khoa";
            giáoViênToolStripMenuItem.Text = "Giáo viên";
            lớpToolStripMenuItem1.Text = "Lớp";
            sinhViênToolStripMenuItem1.Text = "Sinh viên";
            mônHọcToolStripMenuItem1.Text = "Môn học";
            chínhSáchToolStripMenuItem1.Text = "Chính sách";
            điểmToolStripMenuItem1.Text = "Điểm";
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            khoaToolStripMenuItem2.Text = "Khoa";
            giáoViênToolStripMenuItem1.Text = "Giáo viên";
            lớpToolStripMenuItem2.Text = "Lớp";
            sinhViênToolStripMenuItem2.Text = "Sinh viên";
            mônHọcToolStripMenuItem2.Text = "Môn học";
            điểmToolStripMenuItem2.Text = "Điểm";
            chínhSáchToolStripMenuItem2.Text = "Chính sách";
            hiểnThịToolStripMenuItem.Text = "Hiển Thị";
            kiểuXemToolStripMenuItem.Text = "Kiểu xem";
            trongSuốtToolStripMenuItem.Text = "Trong suốt";
            maToolStripMenuItem.Text = "Mặc định";
            ngônNgữToolStripMenuItem.Text = "Ngôn ngữ";
            tiếngAnhToolStripMenuItem.Text = "Tiếng Anh";
            tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
            tiệnÍchToolStripMenuItem.Text = "Tiện Ích";
            máyTínhToolStripMenuItem.Text = "Máy tính";
            hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            liênHệToolStripMenuItem.Text = "Liên Hệ";
            thôngTinToolStripMenuItem1.Text = "Thông tin";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Cập nhật phần mềm";
            thoátToolStripMenuItem.Text = "Thoát";
        }

        private void khóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true);
        }
    }
}
