using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmBai2 : Form
    {
        // Bảng giá chi tiết theo đề bài yêu cầu:
        // Chuột (100.000), Máy in (2.000.000), Bàn phím (150.000)
        private Dictionary<string, double> bangGia = new Dictionary<string, double>()
        {
            { "Chuột", 100000 },
            { "Máy in", 2000000 },
            { "Bàn phím", 150000 }
        };

        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            // Tự động chọn "Chuột" làm mặc định
            if (cboTenHang.Items.Count > 0)
            {
                cboTenHang.SelectedIndex = 0;
            }
        }

        // Khi chọn tên hàng từ ComboBox thì đơn giá tương ứng hiện trong TextBox bên dưới
        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenHang.SelectedItem != null)
            {
                string tenHang = cboTenHang.SelectedItem.ToString();
                if (bangGia.ContainsKey(tenHang))
                {
                    txtDonGia.Text = bangGia[tenHang].ToString();
                }
            }
        }

        // Nhấn nút [Tính tiền]
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng nhập vào
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính tổng tiền
            double tongTien = donGia * soLuong;

            // Nếu hình thức thanh toán là Chuyển khoản -> Giảm 5%
            if (radChuyenKhoan.Checked)
            {
                tongTien = tongTien * 0.95;
            }

            // Hiển thị số tiền thanh toán ra nhãn
            lblSoTienThanhToan.Text = "Số tiền thanh toán: " + string.Format("{0:N0}", tongTien);
        }
    }
}
