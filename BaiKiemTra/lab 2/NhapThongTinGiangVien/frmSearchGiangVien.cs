using System;
using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    // Form hỗ trợ tìm kiếm thông tin giảng viên
    public partial class frmSearchGiangVien : Form
    {
        public string TuKhoa { get; private set; } = "";
        public KieuTim KieuTimKiem { get; private set; } = KieuTim.TheoMa;

        public frmSearchGiangVien()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu từ khóa nhập vào
            this.TuKhoa = txtTuKhoa.Text.Trim();

            // Xác định tiêu chí tìm kiếm được chọn
            if (rdTheoMa.Checked)
            {
                this.KieuTimKiem = KieuTim.TheoMa;
            }
            else if (rdTheoHoTen.Checked)
            {
                this.KieuTimKiem = KieuTim.TheoHoTen;
            }
            else if (rdTheoSoDT.Checked)
            {
                this.KieuTimKiem = KieuTim.TheoSoDT;
            }

            // Đóng Form và trả về kết quả OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
