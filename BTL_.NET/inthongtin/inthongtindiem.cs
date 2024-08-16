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
    public partial class inthongtindiem : DevExpress.XtraEditors.XtraForm
    {
        public inthongtindiem()
        {
            InitializeComponent();
        }

        private void inthongtindiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.qlsinhvienDataSet.diem);

            this.reportViewer1.RefreshReport();
        }
    }
}
