using System;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    // Loại tùy chọn (Sắp xếp hoặc Tìm kiếm)
    public enum LoaiTuyChon
    {
        SapXep,
        TimKiem
    }

    // Tiêu chí áp dụng (Mã SV, Họ tên, Ngày sinh)
    public enum TieuChi
    {
        MaSV,
        HoTen,
        NgaySinh
    }

    // Form tùy chọn Sắp xếp / Tìm kiếm
    public partial class frmTuyChon : Form
    {
        public LoaiTuyChon CheDo { get; set; }
        public TieuChi TieuChiChon { get; set; } = TieuChi.MaSV;
        public string TuKhoa { get; set; } = "";

        public frmTuyChon(LoaiTuyChon cheDo)
        {
            InitializeComponent();
            // TODO: Khởi tạo giao diện theo chế độ (SapXep / TimKiem)
        }

        // TODO: Sự kiện khi nhấn nút Thực hiện (Sắp xếp / Tìm)
        private void btnThucHien_Click(object sender, EventArgs e)
        {

        }
    }
}
