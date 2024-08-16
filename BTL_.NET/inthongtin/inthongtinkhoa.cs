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
    public partial class inthongtinkhoa : DevExpress.XtraEditors.XtraForm
    {
        public inthongtinkhoa()
        {
            InitializeComponent();
        }

        private void thontin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienDataSet.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qlsinhvienDataSet.khoa);
            //this.khoaTableAdapter1.Fill(this.qlsinhvienDataSet1.khoa);
            this.khoaTableAdapter1.Fill(this.khoaDataSet1.khoa);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
