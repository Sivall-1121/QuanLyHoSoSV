using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_.NET.inthongtin
{
    public partial class inthongtinsinhvien : DevExpress.XtraEditors.XtraForm
    {
        public inthongtinsinhvien()
        {
            InitializeComponent();
        }

        private void inthongtinsinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.qlsinhvienDataSet.sinhvien);
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.qlsinhvienDataSet.monhoc);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
