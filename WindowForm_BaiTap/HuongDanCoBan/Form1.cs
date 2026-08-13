using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDanCoBan
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        private void btnExe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào bạn " + txtName.Text + ", rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btnCopy_Click (object sender, EventArgs e)
        {
            txtCopy.Text = txtName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtCopy.Text = txtName.Text;
        }
    }
}
