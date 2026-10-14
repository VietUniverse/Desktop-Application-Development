using System;
using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    // Form hỗ trợ tìm kiếm thông tin giảng viên
    public partial class frmSearchGiangVien : Form
    {
        public string TuKhoa { get; set; } = "";
        public KieuTim KieuTimKiem { get; set; } = KieuTim.TheoMa;

        public frmSearchGiangVien()
        {
            InitializeComponent();
        }

        // TODO: Sự kiện khi nhấn nút Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
