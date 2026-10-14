using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    public partial class frmGiangVien : Form
    {
        public QuanLyGiangVien qlgv;

        public frmGiangVien()
        {
            InitializeComponent();
            qlgv = new QuanLyGiangVien();
        }

        // TODO: Lấy dữ liệu giảng viên từ trên Form
        private GiangVien GetGiangVienFromForm()
        {
            var hocPhan = new DanhMucHocPhan(); // Tạo biến học phần
            foreach (var item in lbHocPhanDay.Items) // Chạy vòng lặp để thêm các học phần vào, nếu học phần không phải là chữ thì sẽ thêm dấu ""
                hocPhan.Them(new HocPhan(item.ToString() ?? ""));
            var ngoaiNgu = new List<string>(); // Tạo một danh sách tên là ngoại ngữ để chứa các ngoại ngữ biết 
            foreach (var item in chklbNgoaiNgu.Items)
                ngoaiNgu.Add(item.ToString() ?? "");

            return new GiangVien(
                cboMaSo.Text,
                mtxtSoDT.Text,
                txtMail.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                hocPhan,
                rdNam.Checked ? "Nam" : "Nu",
                ngoaiNgu.ToArray()
            );
        }

        // TODO: Sự kiện khi Form tải lên
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            cboMaSo.SelectedIndex = -1;
        }

        // TODO: Chuyển học phần chọn từ ListBox danh sách sang ListBox môn dạy (Nút >>)
        private void btnChon_Click(object sender, EventArgs e)
        {

        }

        // TODO: Chuyển học phần chọn từ ListBox môn dạy về ListBox danh sách (Nút <<)
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        // TODO: Thêm giảng viên vào danh sách
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        // TODO: Mở Form tìm kiếm giảng viên
        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hiển thị thông báo thông tin giảng viên vừa nhập
        private void btnThongBao_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Hủy (Reset form)
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hàm xóa trắng và khôi phục form về mặc định
        private void ReSet()
        {

        }

        // TODO: Nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nhấp vào liên kết liên hệ
        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
