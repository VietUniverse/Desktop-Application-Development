using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDanCoBan_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMale_CheckedChange(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính nam", "Thông báo");
            }
        }
        private void radFemale_CheckedChange(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính nữ", "Thông báo");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.BackColor = radCyan.Checked ? Color.Cyan : Color.OrangeRed;
        }

    }
}
