using System;
using System.Windows.Forms;

namespace TinhTienHocTrungTam
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            // Kiểm tra từng khóa học được tích chọn và cộng tiền tương ứng
            if (chkTinHocA.Checked)
            {
                tongTien += 300000;
            }

            if (chkTinHocB.Checked)
            {
                tongTien += 500000;
            }

            if (chkTiengAnhA.Checked)
            {
                tongTien += 400000;
            }

            if (chkTiengAnhB.Checked)
            {
                tongTien += 600000;
            }

            // Hiển thị tổng tiền ra ô txtTongTien
            this.txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // Sự kiện khi nhấn nút Cancel (Hủy / Xóa thông tin đã nhập)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }

        // Hàm đặt lại tất cả các ô nhập liệu về trạng thái ban đầu
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

        // Sự kiện khi nhấn nút Exit (Thoát ứng dụng)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
