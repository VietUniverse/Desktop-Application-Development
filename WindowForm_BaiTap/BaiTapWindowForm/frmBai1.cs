using System;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Khai báo và khởi tạo đối tượng HangHoa (sử dụng hàm khởi tạo không tham số)
            HangHoa hh = new HangHoa();

            // Gán các thuộc tính từ các ô nhập trên Form
            hh.MaHang = txtMaHang.Text.Trim();
            hh.TenHang = txtTenHang.Text.Trim();
            hh.DVT = txtDVT.Text.Trim();
            hh.SoLuong = (int)numSoLuong.Value;

            if (double.TryParse(txtDonGia.Text.Trim(), out double donGia))
            {
                hh.DonGia = donGia;
            }

            // Gọi phương thức HienThi() của đối tượng HangHoa
            hh.HienThi();
        }
    }
}
