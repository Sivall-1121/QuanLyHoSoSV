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
    public partial class inthongtinchinhsach : DevExpress.XtraEditors.XtraForm
    {
        public inthongtinchinhsach()
        {
            InitializeComponent();
        }

        private void inthongtinchinhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.chinhsach' table. You can move, or remove it, as needed.
            this.chinhsachTableAdapter.Fill(this.qlsinhvienDataSet.chinhsach);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
