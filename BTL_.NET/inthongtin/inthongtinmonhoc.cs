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
    public partial class inthongtinmonhoc : DevExpress.XtraEditors.XtraForm
    {
        public inthongtinmonhoc()
        {
            InitializeComponent();
        }

        private void inthongtinmonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.qlsinhvienDataSet.monhoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
