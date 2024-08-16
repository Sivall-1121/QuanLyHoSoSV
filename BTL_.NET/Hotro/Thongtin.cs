using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_.NET.Hotro
{
    public partial class Thongtin : DevExpress.XtraEditors.XtraForm
    {
        public Thongtin()
        {
            InitializeComponent();
        }

        private void Thongtin_Load(object sender, EventArgs e)
        {
            String tt;
            tt = "Phần mềm quản lí sinh viên\n";
            tt += "\n";
            tt += "Version: 1.1 \n";
            tt += "\n";
            tt += "Học phần thực tập: \n \n";
            tt += "Lập trình hướng cơ sở dữ liệu.\n";
            tt += "\n\n";
            tt += "Copy right @ năm 2023 \n";
            tt += "Designer by: Nhóm 3-DHTI14A1CL \n";

            label1.Text = tt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
