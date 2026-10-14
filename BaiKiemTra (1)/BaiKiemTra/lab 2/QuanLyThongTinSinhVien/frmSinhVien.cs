using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    public partial class frmSinhVien : Form
    {
        private QuanLySinhVien qlsv;

        public frmSinhVien()
        {
            InitializeComponent();
            qlsv = new QuanLySinhVien();
        }

        // TODO: Cập nhật số lượng sinh viên trên thanh trạng thái (StatusStrip)
        private void CapNhatStatusStrip()
        {

        }

        // TODO: Lấy dữ liệu từ toàn bộ Form để tạo đối tượng SinhVien mới
        private SinhVien GetSinhVienToanForm()
        {
            return new SinhVien();
        }

        // TODO: Lấy thông tin sinh viên từ dòng đang được chọn trong ListView
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            return new SinhVien();
        }

        // TODO: Hiển thị thông tin đối tượng SinhVien lên các điều khiển trên Form
        private void ThietLapThongTin(SinhVien sv)
        {

        }

        // TODO: Thêm một dòng sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {

        }

        // TODO: Đổ lại toàn bộ danh sách sinh viên từ bộ nhớ lên ListView
        private void LoadListView()
        {

        }

        // TODO: Xóa trắng form nhập liệu
        private void ResetControls()
        {

        }

        // TODO: Sự kiện khi tải Form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {

        }

        // TODO: Khi chọn một sinh viên trên ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // TODO: Chọn file ảnh đại diện
        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Xóa các sinh viên được tích chọn trong danh sách
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
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

        // TODO: Đổi font chữ của ListView
        private void tsmiFont_Click(object sender, EventArgs e)
        {

        }

        // TODO: Đổi màu chữ của ListView
        private void tsmiColor_Click(object sender, EventArgs e)
        {

        }

        // TODO: Menu Sắp xếp danh sách
        private void tsmiSort_Click(object sender, EventArgs e)
        {

        }

        // TODO: Menu Tìm kiếm sinh viên
        private void tsmiSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
