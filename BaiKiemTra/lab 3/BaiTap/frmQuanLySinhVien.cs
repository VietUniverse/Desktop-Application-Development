using System;
using System.Collections.Generic;
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

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cboLop.Items.Add("CTK42");
            cboLop.Items.Add("CTK43");
            cboLop.Items.Add("CTK44");
            cboLop.Items.Add("CTK45");
            cboLop.Items.Add("CTK46");
            cboLop.SelectedIndex = 2; // CTK44

            // Mặc định nạp dữ liệu từ students.json
            qlsv.DocTuFile("students.json", "JSON");
            HienThiDanhSach(qlsv.DanhSach);
        }

        private void HienThiDanhSach(List<SinhVien> list)
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien s in list)
            {
                ListViewItem item = new ListViewItem(s.MSSV);
                item.SubItems.Add(s.HoTenLot);
                item.SubItems.Add(s.Ten);
                item.SubItems.Add(s.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(s.Lop);
                item.SubItems.Add(s.SoCMND);
                item.SubItems.Add(s.SoDT);
                item.SubItems.Add(s.DiaChi);
                item.Tag = s;

                lvSinhVien.Items.Add(item);
            }

            if (string.IsNullOrEmpty(mtxtMSSV.Text.Replace(" ", "")))
            {
                mtxtMSSV.Text = qlsv.TaoMSSV(cboLop.Text);
            }
        }

        private void btnNhapFile_Click(object sender, EventArgs e)
        {
            frmNhapFile formImport = new frmNhapFile();
            if (formImport.ShowDialog() == DialogResult.OK)
            {
                qlsv.DocTuFile(formImport.DuongDanFile, formImport.LoaiFile);
                HienThiDanhSach(qlsv.DanhSach);
                MessageBox.Show("Nhập dữ liệu từ file thành công!");
            }
        }

        private bool KiemTraNhap()
        {
            if (mtxtMSSV.Text.Trim().Length != 7)
            {
                MessageBox.Show("MSSV phải gồm 7 chữ số!");
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTenLot.Text))
            {
                MessageBox.Show("Chưa nhập Họ và tên lót!");
                return false;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Chưa nhập Tên!");
                return false;
            }

            if (mtxtCMND.Text.Trim().Length != 9)
            {
                MessageBox.Show("Số CMND phải gồm 9 chữ số!");
                return false;
            }

            if (mtxtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số!");
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập Địa chỉ!");
                return false;
            }

            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn môn học đăng ký!");
                return false;
            }

            return true;
        }

        private SinhVien LayThongTinForm()
        {
            SinhVien s = new SinhVien();
            s.MSSV = mtxtMSSV.Text.Trim();
            s.HoTenLot = txtHoTenLot.Text.Trim();
            s.Ten = txtTen.Text.Trim();
            s.GioiTinh = rdoNam.Checked;
            s.NgaySinh = dtpNgaySinh.Value;
            s.Lop = cboLop.Text.Trim();
            s.SoCMND = mtxtCMND.Text.Trim();
            s.SoDT = mtxtSDT.Text.Trim();
            s.DiaChi = txtDiaChi.Text.Trim();

            s.MonHocDangKy = new List<string>();
            foreach (object item in clbMonHoc.CheckedItems)
            {
                string? tenMon = item.ToString();
                if (tenMon != null)
                {
                    s.MonHocDangKy.Add(tenMon);
                }
            }

            return s;
        }

        private void DienThongTinForm(SinhVien s)
        {
            mtxtMSSV.Text = s.MSSV;
            txtHoTenLot.Text = s.HoTenLot;
            txtTen.Text = s.Ten;
            if (s.GioiTinh)
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            dtpNgaySinh.Value = s.NgaySinh;
            cboLop.Text = s.Lop;
            mtxtCMND.Text = s.SoCMND;
            mtxtSDT.Text = s.SoDT;
            txtDiaChi.Text = s.DiaChi;

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                string? mon = clbMonHoc.Items[i].ToString();
                if (mon != null)
                {
                    bool daDangKy = s.MonHocDangKy.Contains(mon);
                    clbMonHoc.SetItemChecked(i, daDangKy);
                }
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                SinhVien? s = lvSinhVien.SelectedItems[0].Tag as SinhVien;
                if (s != null)
                {
                    DienThongTinForm(s);
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                return;
            }

            SinhVien s = LayThongTinForm();
            if (qlsv.Them(s))
            {
                MessageBox.Show("Thêm sinh viên thành công!");
                HienThiDanhSach(qlsv.DanhSach);
            }
            else
            {
                MessageBox.Show("Trùng mã sinh viên!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                return;
            }

            SinhVien s = LayThongTinForm();
            if (qlsv.CapNhat(s))
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiDanhSach(qlsv.DanhSach);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<string> dsLop = new List<string>();
            foreach (object item in cboLop.Items)
            {
                string? lop = item.ToString();
                if (lop != null)
                {
                    dsLop.Add(lop);
                }
            }

            frmTimKiem formTim = new frmTimKiem(dsLop);
            if (formTim.ShowDialog() == DialogResult.OK)
            {
                List<SinhVien> ketQua = qlsv.TimKiem(formTim.MSSVTim, formTim.TenTim, formTim.LopTim);
                HienThiDanhSach(ketQua);
                MessageBox.Show($"Tìm thấy {ketQua.Count} sinh viên!");
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtMSSV.Text = qlsv.TaoMSSV(cboLop.Text);
        }

        private void tsmiThemMonHoc_Click(object sender, EventArgs e)
        {
            string monMoi = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên môn học mới:", "Thêm môn học", "");
            if (!string.IsNullOrWhiteSpace(monMoi))
            {
                if (!clbMonHoc.Items.Contains(monMoi.Trim()))
                {
                    clbMonHoc.Items.Add(monMoi.Trim(), true);
                }
            }
        }

        private void tsmiXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.SelectedIndex >= 0)
            {
                clbMonHoc.Items.RemoveAt(clbMonHoc.SelectedIndex);
            }
        }

        private void tsmiXoaSinhVien_Click(object sender, EventArgs e)
        {
            List<string> dsXoa = new List<string>();
            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                dsXoa.Add(item.Text);
            }

            if (dsXoa.Count == 0 && lvSinhVien.SelectedItems.Count > 0)
            {
                dsXoa.Add(lvSinhVien.SelectedItems[0].Text);
            }

            if (dsXoa.Count == 0)
            {
                MessageBox.Show("Chưa chọn sinh viên để xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có muốn xóa {dsXoa.Count} sinh viên?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                qlsv.Xoa(dsXoa);
                HienThiDanhSach(qlsv.DanhSach);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void tsmiTaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(qlsv.DanhSach);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
