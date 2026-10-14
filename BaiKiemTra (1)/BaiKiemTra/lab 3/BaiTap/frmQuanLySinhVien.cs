using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmQuanLySinhVien : Form
    {
        QuanLySinhVien qlsv = new QuanLySinhVien();

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        // TODO: Sự kiện nạp Form
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        // TODO: Hiển thị danh sách sinh viên lên ListView
        private void HienThiDanhSach(List<SinhVien> list)
        {

        }

        // TODO: Nút Nhập từ tập tin (JSON, XML, TXT)
        private void btnNhapFile_Click(object sender, EventArgs e)
        {

        }

        // TODO: Kiểm tra thông tin nhập hợp lệ
        private bool KiemTraNhap()
        {
            return true;
        }

        // TODO: Lấy thông tin sinh viên từ các điều khiển trên Form
        private SinhVien LayThongTinForm()
        {
            return new SinhVien();
        }

        // TODO: Điền thông tin sinh viên lên Form
        private void DienThongTinForm(SinhVien s)
        {

        }

        // TODO: Sự kiện chọn dòng sinh viên trong ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // TODO: Nút Thêm mới sinh viên
        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Cập nhật sinh viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        // TODO: Thay đổi lựa chọn lớp
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // TODO: Context menu item - Thêm môn học
        private void tsmiThemMonHoc_Click(object sender, EventArgs e)
        {

        }

        // TODO: Context menu item - Xóa môn học
        private void tsmiXoaMonHoc_Click(object sender, EventArgs e)
        {

        }

        // TODO: Context menu item - Xóa sinh viên
        private void tsmiXoaSinhVien_Click(object sender, EventArgs e)
        {

        }

        // TODO: Context menu item - Tải lại
        private void tsmiTaiLai_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
