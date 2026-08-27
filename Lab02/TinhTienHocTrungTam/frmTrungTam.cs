using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinhTienHocTrungTam
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
            CreateCancelIcon();
        }

        private void CreateCancelIcon()
        {
            try
            {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Brush b = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(b, 1, 1, 18, 18);
                    }
                    using (Pen p = new Pen(Color.White, 2.5f))
                    {
                        g.DrawLine(p, 6, 6, 14, 14);
                        g.DrawLine(p, 14, 6, 6, 14);
                    }
                }
                btnCancel.Image = bmp;
                btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
                btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            catch
            {            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += 300000;
            if (chkTinHocB.Checked)
                s += 500000;
            if (chkTiengAnhA.Checked)
                s += 400000;
            if (chkTiengAnhB.Checked)
                s += 600000;

            this.txtTongTien.Text = s.ToString() + " VNĐ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }

        private void ReSet()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.rdNu.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
