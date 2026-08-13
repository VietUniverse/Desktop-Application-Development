using System;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            frmBai1 form = new frmBai1();
            form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            frmBai2 form = new frmBai2();
            form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            frmBai3 form = new frmBai3();
            form.ShowDialog();
        }
    }
}
