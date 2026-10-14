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

        private GiangVien GetGiangVienFromForm()
        {
            string gioiTinh = "Nữ";
            if (rdNam.Checked)
            {
                gioiTinh = "Nam";
            }

            List<string> listNgoaiNgu = new List<string>();
            foreach (object item in chklbNgoaiNgu.CheckedItems)
            {
                if (item != null)
                {
                    string? tenNgoaiNgu = item.ToString();
                    if (tenNgoaiNgu != null)
                    {
                        listNgoaiNgu.Add(tenNgoaiNgu);
                    }
                }
            }

            DanhMucHocPhan dsHocPhan = new DanhMucHocPhan();
            foreach (object item in lbHocPhanDay.Items)
            {
                if (item != null)
                {
                    string? tenHocPhan = item.ToString();
                    if (tenHocPhan != null)
                    {
                        dsHocPhan.Them(new HocPhan(tenHocPhan));
                    }
                }
            }

            string[] ngoaiNgu = new string[listNgoaiNgu.Count];
            for (int i = 0; i < listNgoaiNgu.Count; i++)
            {
                ngoaiNgu[i] = listNgoaiNgu[i];
            }

            return new GiangVien(
                cboMaSo.Text,
                mtxtSoDT.Text,
                txtMail.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                dsHocPhan,
                gioiTinh,
                ngoaiNgu
            );
        }

        // Sự kiện khi Form tải lên
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);

            if (this.cboMaSo.Items.Count > 0)
            {
                this.cboMaSo.SelectedIndex = 0;
            }
        }

        // Chuyển học phần chọn từ ListBox danh sách sang ListBox môn dạy (Nút >>)
        private void btnChon_Click(object sender, EventArgs e)
        {
            for (int i = lbDanhSachHP.SelectedItems.Count - 1; i >= 0; i--)
            {
                object? item = lbDanhSachHP.SelectedItems[i];
                if (item != null)
                {
                    lbHocPhanDay.Items.Add(item);
                    lbDanhSachHP.Items.Remove(item);
                }
            }
        }

        // Chuyển học phần chọn từ ListBox môn dạy về ListBox danh sách (Nút <<)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = lbHocPhanDay.SelectedItems.Count - 1; i >= 0; i--)
            {
                object? item = lbHocPhanDay.SelectedItems[i];
                if (item != null)
                {
                    lbDanhSachHP.Items.Add(item);
                    lbHocPhanDay.Items.Remove(item);
                }
            }
        }

        // Thêm giảng viên vào danh sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGiangVienFromForm();
            bool ketQua = qlgv.Them(gv);

            if (!ketQua)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Mở Form tìm kiếm giảng viên
        private void btnTim_Click(object sender, EventArgs e)
        {
            using (frmSearchGiangVien frmSearch = new frmSearchGiangVien())
            {
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    GiangVien? gvFound = qlgv.TimKiem(frmSearch.TuKhoa, frmSearch.KieuTimKiem);
                    if (gvFound != null)
                    {
                        frmTBGiangVien frmTB = new frmTBGiangVien();
                        frmTB.SetText(gvFound.ToString());
                        frmTB.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giảng viên thỏa điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Hiển thị thông báo thông tin giảng viên vừa nhập
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGiangVienFromForm();
            frmTBGiangVien frmTB = new frmTBGiangVien();
            frmTB.SetText(gv.ToString());
            frmTB.ShowDialog();
        }

        // Nút Hủy (Reset form)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }

        // Hàm xóa trắng và khôi phục form về mặc định
        private void ReSet()
        {
            if (cboMaSo.Items.Count > 0)
            {
                cboMaSo.SelectedIndex = 0;
            }

            txtHoTen.Text = "";
            mtxtSoDT.Text = "";
            txtMail.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            rdNu.Checked = false;

            // Bỏ chọn tất cả ngoại ngữ
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }

            // Trả lại các môn dạy về danh sách ban đầu
            foreach (object item in lbHocPhanDay.Items)
            {
                lbDanhSachHP.Items.Add(item);
            }
            lbHocPhanDay.Items.Clear();
        }

        // Nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Nhấp vào liên kết liên hệ
        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo thongTin = new System.Diagnostics.ProcessStartInfo();
                thongTin.FileName = "https://cntt.dlu.edu.vn/";
                thongTin.UseShellExecute = true;
                System.Diagnostics.Process.Start(thongTin);
            }
            catch
            {
                // Bỏ qua nếu không mở được trình duyệt
            }
        }
    }
}
