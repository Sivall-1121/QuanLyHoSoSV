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
    public partial class inthongtingiaovien : DevExpress.XtraEditors.XtraForm
    {
        public inthongtingiaovien()
        {
            InitializeComponent();
        }

        private void inthongtingiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.giaovien' table. You can move, or remove it, as needed.
            this.giaovienTableAdapter.Fill(this.qlsinhvienDataSet.giaovien);

            this.reportViewer1.RefreshReport();
        }
    }
}
