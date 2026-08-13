using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btap_ThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rad_Checked(object sender, EventArgs e)
        {
            if (radCyan.Checked)
            {
                picBox.BackColor = Color.Cyan;
            }else if(radRed.Checked)
            {
                picBox.BackColor = Color.Red;
            }else
            {
                picBox.BackColor = Color.White;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblRes.Text = (int.Parse(txtPrice.Text) * int.Parse(txtQty.Text)).ToString() + "$";
        }
    }
}
