using System;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        // Gọi hàm tĩnh CongHaiSo(a, b, out s) từ lớp TinhToan
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a))
            {
                MessageBox.Show("Vui lòng nhập số a nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }

            if (!int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui lòng nhập số b nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }

            // Gọi hàm tĩnh CongHaiSo của lớp TinhToan
            TinhToan.CongHaiSo(a, b, out int s);

            lblKetQuaCong.Text = "Kết quả s = " + s;
        }

        // Gọi hàm tĩnh TongDaySo(n) từ lớp TinhToan
        private void btnTongDaySo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text.Trim(), out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên n > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }

            // Gọi hàm tĩnh TongDaySo của lớp TinhToan
            int tong = TinhToan.TongDaySo(n);

            lblKetQuaTong.Text = "Tổng dãy số (1.." + n + ") = " + tong;
        }
    }
}
