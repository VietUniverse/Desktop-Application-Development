using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuanLySinhVienCNTT
{
    public partial class frmSinhVienCNTT : Form
    {
        // Danh sách lưu trữ sinh viên trong bộ nhớ
        private List<SinhVien> dsSV;
        // Biến đánh dấu dữ liệu đã bị thay đổi hay chưa
        private bool isModified = false;

        public frmSinhVienCNTT()
        {
            InitializeComponent();
            dsSV = new List<SinhVien>();
        }

        // TODO: Đọc danh sách sinh viên từ file text (DSNV.txt)
        private void DocTuFile(string filename)
        {

        }

        // TODO: Ghi danh sách sinh viên vào file text (DSNV.txt)
        private void LuuVaoFile(string filename)
        {

        }

        // TODO: Hiển thị danh sách sinh viên từ bộ nhớ lên ListView
        private void LoadListView()
        {

        }

        // TODO: Lấy dữ liệu sinh viên được nhập trên các ô điều khiển của Form
        private SinhVien GetSinhVienFromForm()
        {
            return new SinhVien();
        }

        // TODO: Hiển thị thông tin một sinh viên lên Form
        private void ThietLapThongTinForm(SinhVien sv)
        {

        }

        // TODO: Đặt lại các điều khiển trên Form về rỗng (Mặc định)
        private void ResetControls()
        {

        }

        // TODO: Hàm tìm sinh viên theo MSSV
        private SinhVien? TimSinhVien(string mssv)
        {
            return null;
        }

        // TODO: Hàm xóa sinh viên theo MSSV
        private void XoaSinhVien(string mssv)
        {

        }

        // TODO: Sự kiện khi tải Form
        private void frmSinhVienCNTT_Load(object sender, EventArgs e)
        {

        }

        // TODO: Chọn file hình ảnh
        private void btnChonHinh_Click(object sender, EventArgs e)
        {

        }

        // TODO: Lưu thông tin sinh viên (Thêm mới hoặc Cập nhật)
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Mặc định (Reset form)
        private void btnMacDinh_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hiển thị thông tin sinh viên được chọn trên ListView lên Form
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // TODO: Menu chuột phải - Xóa sinh viên được chọn
        private void cmsiXoa_Click(object sender, EventArgs e)
        {

        }

        // TODO: Menu chuột phải - Tải lại danh sách từ file
        private void cmsiTaiLai_Click(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện khi đóng Form (hỏi người dùng có muốn lưu thay đổi hay không)
        private void frmSinhVienCNTT_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
