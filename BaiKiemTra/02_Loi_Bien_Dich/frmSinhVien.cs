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

        // Cập nhật số lượng sinh viên trên thanh trạng thái (StatusStrip)
        private void CapNhatStatusStrip()
        {
            this.toolStripStatusLabelTongSV.Text = "Tổng số sinh viên: " + this.lvSinhVien.Items.Count;
        }

        // Lấy dữ liệu từ toàn bộ Form để tạo đối tượng SinhVien mới
        private SinhVien GetSinhVienToanForm()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = this.mtxtMaSo.Text.Trim();
            sv.HoTen = this.txtHoTen.Text.Trim();
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text.Trim();
            sv.Lop = this.cboLop.Text.Trim();
            sv.Hinh = this.txtHinh.Text.Trim();
            sv.GioiTinh = this.rdNam.Checked;

            // Lấy danh sách các chuyên ngành được tích chọn
            List<string> cn = new List<string>();
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (this.clbChuyenNganh.GetItemChecked(i))
                {
                    string? itemStr = this.clbChuyenNganh.Items[i].ToString();
                    if (!string.IsNullOrEmpty(itemStr))
                    {
                        cn.Add(itemStr);
                    }
                }
            }
            sv.ChuyenNganh = cn;
            return sv;
        }

        // Lấy thông tin sinh viên từ dòng đang được chọn trong ListView
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = item.SubItems[0].Text;
            sv.HoTen = item.SubItems[1].Text;

            DateTime dt;
            if (DateTime.TryParseExact(item.SubItems[2].Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                sv.NgaySinh = dt;
            }
            else
            {
                sv.NgaySinh = DateTime.Now;
            }

            sv.DiaChi = item.SubItems[3].Text;
            sv.Lop = item.SubItems[4].Text;
            sv.GioiTinh = (item.SubItems[5].Text == "Nam");

            string[] cn = item.SubItems[6].Text.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in cn)
            {
                sv.ChuyenNganh.Add(c.Trim());
            }
            sv.Hinh = item.SubItems[7].Text;

            return sv;
        }

        // Hiển thị thông tin đối tượng SinhVien lên các điều khiển trên Form
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;

            if (File.Exists(sv.Hinh))
            {
                this.pbHinh.ImageLocation = sv.Hinh;
            }
            else
            {
                string relativePath = Path.Combine(Application.StartupPath, sv.Hinh);
                if (File.Exists(relativePath))
                {
                    this.pbHinh.ImageLocation = relativePath;
                }
                else
                {
                    this.pbHinh.Image = null;
                }
            }

            if (sv.GioiTinh)
            {
                this.rdNam.Checked = true;
            }
            else
            {
                this.rdNu.Checked = true;
            }

            // Đặt lại các checkbox chuyên ngành
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }

            // Tích chọn lại các chuyên ngành của sinh viên
            foreach (string cn in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    string? tenChuyenNganh = this.clbChuyenNganh.Items[i].ToString();
                    if (tenChuyenNganh == cn)
                    {
                        this.clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }

        // Thêm một dòng sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            string gioiTinh = "Nữ";
            if (sv.GioiTinh)
            {
                gioiTinh = "Nam";
            }
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(string.Join(", ", sv.ChuyenNganh));
            item.SubItems.Add(sv.Hinh);

            this.lvSinhVien.Items.Add(item);
        }

        // Đổ lại toàn bộ danh sách sinh viên từ bộ nhớ lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            CapNhatStatusStrip();
        }

        // Xóa trắng form nhập liệu
        private void ResetControls()
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = 0;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            if (this.cboLop.Items.Count > 0)
            {
                this.cboLop.SelectedIndex = 0;
            }
            this.txtHinh.Text = "";
            this.pbHinh.Image = null;
            this.rdNam.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }
        }

        // Sự kiện khi tải Form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (this.cboLop.Items.Count > 0)
            {
                this.cboLop.SelectedIndex = 0;
            }

            string filePath = "DanhSachSV.txt";
            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(Application.StartupPath, "DanhSachSV.txt");
            }

            if (File.Exists(filePath))
            {
                qlsv.DocTuFile(filePath);
                LoadListView();
            }
        }

        // Khi chọn một sinh viên trên ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(item);
                ThietLapThongTin(sv);
            }
        }

        // Chọn file ảnh đại diện
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                this.txtHinh.Text = this.openFileDialogHinh.FileName;
                this.pbHinh.ImageLocation = this.openFileDialogHinh.FileName;
            }
        }

        // Nút Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienToanForm();

            if (string.IsNullOrWhiteSpace(sv.MaSo))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã sinh viên
            SinhVien? tim = qlsv.TimTheoMa(sv.MaSo);
            if (tim != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            qlsv.Them(sv);
            LoadListView();
        }

        // Nút Xóa các sinh viên được tích chọn trong danh sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.CheckedItems.Count;
            if (count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn sinh viên cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = count - 1; i >= 0; i--)
            {
                ListViewItem item = this.lvSinhVien.CheckedItems[i];
                string maSo = item.SubItems[0].Text;
                qlsv.XoaTheoMa(maSo);
            }

            LoadListView();
            ResetControls();
        }

        // Nút Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienToanForm();
            bool kq = qlsv.Sua(sv);

            if (kq)
            {
                LoadListView();
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Mặc định (Reset form)
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Đổi font chữ của ListView
        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lvSinhVien.Font = fontDialog1.Font;
            }
        }

        // Đổi màu chữ của ListView
        private void tsmiColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lvSinhVien.ForeColor = colorDialog1.Color;
            }
        }

        // Menu Sắp xếp danh sách
        private void tsmiSort_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(LoaiTuyChon.SapXep))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    qlsv.SapXep();
                    LoadListView();
                }
            }
        }

        // Menu Tìm kiếm sinh viên
        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(LoaiTuyChon.TimKiem))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    List<SinhVien> ketQua = new List<SinhVien>();
                    string kw = frm.TuKhoa.ToLower();

                    foreach (SinhVien sv in qlsv.DanhSach)
                    {
                        if (frm.TieuChiChon == TieuChi.MaSV)
                        {
                            if (sv.MaSo.ToLower().Contains(kw))
                            {
                                ketQua.Add(sv);
                            }
                        }
                        else if (frm.TieuChiChon == TieuChi.HoTen)
                        {
                            if (sv.HoTen.ToLower().Contains(kw))
                            {
                                ketQua.Add(sv);
                            }
                        }
                        else if (frm.TieuChiChon == TieuChi.NgaySinh)
                        {
                            if (sv.NgaySinh.ToString("dd/MM/yyyy").Contains(kw))
                            {
                                ketQua.Add(sv);
                            }
                        }
                    }

                    this.lvSinhVien.Items.Clear();
                    foreach (SinhVien sv in ketQua)
                    {
                        ThemSV(sv);
                    }
                    CapNhatStatusStrip();

                    if (ketQua.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên thỏa điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
