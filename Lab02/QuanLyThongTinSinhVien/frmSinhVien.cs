using System;
using System.Collections.Generic;
using System.Drawing;
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

        #region Phương thức bổ trợ

        private void CapNhatStatusStrip()
        {
            this.toolStripStatusLabelTongSV.Text = "Tổng số sinh viên: " + this.lvSinhVien.Items.Count;
        }

        private SinhVien GetSinhVienToanForm()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            sv.GioiTinh = this.rdNam.Checked;

            List<string> cn = new List<string>();
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (this.clbChuyenNganh.GetItemChecked(i))
                {
                    string? itemStr = this.clbChuyenNganh.Items[i]?.ToString();
                    if (!string.IsNullOrEmpty(itemStr))
                        cn.Add(itemStr);
                }
            }
            sv.ChuyenNganh = cn;
            return sv;
        }

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
            sv.GioiTinh = item.SubItems[5].Text == "Nam";

            string[] cn = item.SubItems[6].Text.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in cn)
            {
                sv.ChuyenNganh.Add(c.Trim());
            }
            sv.Hinh = item.SubItems[7].Text;

            return sv;
        }

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
                    this.pbHinh.ImageLocation = relativePath;
                else
                    this.pbHinh.Image = null;
            }

            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }

            foreach (string cn in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (this.clbChuyenNganh.Items[i]?.ToString() == cn)
                    {
                        this.clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            item.SubItems.Add(string.Join(", ", sv.ChuyenNganh));
            item.SubItems.Add(sv.Hinh);

            this.lvSinhVien.Items.Add(item);
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            CapNhatStatusStrip();
        }

        private void ResetControls()
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
            this.txtHinh.Text = "";
            this.pbHinh.Image = null;
            this.rdNam.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }
        }

        private int SoSanhTheoMa(object a, object b)
        {
            SinhVien? sv = b as SinhVien;
            string? ma = a as string;
            if (sv != null && ma != null)
            {
                return string.Compare(ma.Trim(), sv.MaSo.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            return -1;
        }

        #endregion

        #region Event Handlers

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;

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

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(item);
                ThietLapThongTin(sv);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                this.txtHinh.Text = this.openFileDialogHinh.FileName;
                this.pbHinh.ImageLocation = this.openFileDialogHinh.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienToanForm();
            SinhVien? tim = qlsv.Tim(sv.MaSo, SoSanhTheoMa);
            if (tim != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            qlsv.Them(sv);
            LoadListView();
        }

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
                qlsv.Xoa(maSo, SoSanhTheoMa);
            }

            LoadListView();
            ResetControls();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienToanForm();
            bool kq = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
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

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lvSinhVien.Font = fontDialog1.Font;
            }
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lvSinhVien.ForeColor = colorDialog1.Color;
            }
        }

        private void tsmiSort_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(LoaiTuyChon.SapXep))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    switch (frm.TieuChiChon)
                    {
                        case TieuChi.MaSV:
                            qlsv.DanhSach.Sort((a, b) => string.Compare(a.MaSo, b.MaSo));
                            break;
                        case TieuChi.HoTen:
                            qlsv.DanhSach.Sort((a, b) => string.Compare(a.HoTen, b.HoTen));
                            break;
                        case TieuChi.NgaySinh:
                            qlsv.DanhSach.Sort((a, b) => DateTime.Compare(a.NgaySinh, b.NgaySinh));
                            break;
                    }
                    LoadListView();
                }
            }
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            using (frmTuyChon frm = new frmTuyChon(LoaiTuyChon.TimKiem))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    List<SinhVien> ketQua = new List<SinhVien>();
                    string kw = frm.TuKhoa;

                    foreach (SinhVien sv in qlsv.DanhSach)
                    {
                        switch (frm.TieuChiChon)
                        {
                            case TieuChi.MaSV:
                                if (sv.MaSo != null && sv.MaSo.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                                    ketQua.Add(sv);
                                break;
                            case TieuChi.HoTen:
                                if (sv.HoTen != null && sv.HoTen.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                                    ketQua.Add(sv);
                                break;
                            case TieuChi.NgaySinh:
                                if (sv.NgaySinh.ToString("dd/MM/yyyy").Contains(kw))
                                    ketQua.Add(sv);
                                break;
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

        #endregion
    }
}
