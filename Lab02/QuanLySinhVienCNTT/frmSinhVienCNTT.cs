using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLySinhVienCNTT
{
    public partial class frmSinhVienCNTT : Form
    {
        private List<SinhVien> dsSV;
        private bool isModified = false;

        public frmSinhVienCNTT()
        {
            InitializeComponent();
            dsSV = new List<SinhVien>();
        }

        private void DocTuFile(string filename)
        {
            string filePath = filename;
            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(Application.StartupPath, filename);
            }

            if (!File.Exists(filePath)) return;

            dsSV.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] s = line.Split('\t');
                if (s.Length >= 8)
                {
                    SinhVien sv = new SinhVien();
                    sv.MSSV = s[0].Trim();
                    sv.HoTen = s[1].Trim();

                    if (s.Length >= 9)
                    {
                        sv.GioiTinh = s[2].Trim() == "Nam";

                        DateTime dt;
                        if (DateTime.TryParseExact(s[3].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                            sv.NgaySinh = dt;
                        else if (DateTime.TryParse(s[3].Trim(), out dt))
                            sv.NgaySinh = dt;

                        sv.Lop = s[4].Trim();
                        sv.SoDT = s[5].Trim();
                        sv.Email = s[6].Trim();
                        sv.DiaChi = s[7].Trim();
                        sv.Hinh = s[8].Trim();
                    }
                    else
                    {
                        DateTime dt;
                        if (DateTime.TryParseExact(s[2].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                            sv.NgaySinh = dt;
                        else if (DateTime.TryParse(s[2].Trim(), out dt))
                            sv.NgaySinh = dt;

                        sv.GioiTinh = s[3].Trim() == "Nam";
                        sv.SoDT = s[4].Trim();
                        sv.Lop = s[5].Trim();
                        sv.DiaChi = s[6].Trim();
                        sv.Hinh = s[7].Trim();
                    }

                    dsSV.Add(sv);
                }
            }
        }

        private void LuuVaoFile(string filename)
        {
            string filePath = filename;
            List<string> lines = new List<string>();
            foreach (SinhVien sv in dsSV)
            {
                string line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                    sv.MSSV,
                    sv.HoTen,
                    sv.GioiTinh ? "Nam" : "Nữ",
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.Lop,
                    sv.SoDT,
                    sv.Email,
                    sv.DiaChi,
                    sv.Hinh
                );
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
            if (File.Exists(Path.Combine(Application.StartupPath, filename)))
            {
                try
                {
                    File.WriteAllLines(Path.Combine(Application.StartupPath, filename), lines);
                }
                catch { }
            }
        }

        private void LoadListView()
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien sv in dsSV)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoDT);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Hinh);

                lvSinhVien.Items.Add(item);
            }
        }

        private SinhVien GetSinhVienFromForm()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = mtxtMSSV.Text.Trim();
            sv.HoTen = txtHoTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = rdNam.Checked;
            sv.SoDT = mtxtSoDT.Text.Trim();
            sv.Lop = cboLop.Text.Trim();
            sv.Email = txtEmail.Text.Trim();
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.Hinh = txtHinh.Text.Trim();
            return sv;
        }

        private void ThietLapThongTinForm(SinhVien sv)
        {
            mtxtMSSV.Text = sv.MSSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh) rdNam.Checked = true;
            else rdNu.Checked = true;

            mtxtSoDT.Text = sv.SoDT;
            cboLop.Text = sv.Lop;
            txtEmail.Text = sv.Email;
            txtDiaChi.Text = sv.DiaChi;
            txtHinh.Text = sv.Hinh;

            if (File.Exists(sv.Hinh))
            {
                pbHinh.ImageLocation = sv.Hinh;
            }
            else
            {
                string rel = Path.Combine(Application.StartupPath, sv.Hinh);
                if (File.Exists(rel))
                    pbHinh.ImageLocation = rel;
                else
                    pbHinh.Image = null;
            }
        }

        private void ResetControls()
        {
            mtxtMSSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            mtxtSoDT.Text = "";
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtHinh.Text = "";
            pbHinh.Image = null;
        }


        private void frmSinhVienCNTT_Load(object sender, EventArgs e)
        {
            if (cboLop.Items.Count > 0)
                cboLop.SelectedIndex = 0;

            DocTuFile("DSNV.txt");
            LoadListView();
            isModified = false;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialogHinh.FileName;
                pbHinh.ImageLocation = openFileDialogHinh.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien svForm = GetSinhVienFromForm();
            if (string.IsNullOrWhiteSpace(svForm.MSSV) || svForm.MSSV.Length < 7)
            {
                MessageBox.Show("Mã sinh viên phải gồm 7 ký tự số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien? svExist = dsSV.Find(s => s.MSSV.Equals(svForm.MSSV, StringComparison.OrdinalIgnoreCase));
            if (svExist != null)
            {
                // Cập nhật sinh viên đã có
                svExist.HoTen = svForm.HoTen;
                svExist.NgaySinh = svForm.NgaySinh;
                svExist.GioiTinh = svForm.GioiTinh;
                svExist.SoDT = svForm.SoDT;
                svExist.Lop = svForm.Lop;
                svExist.Email = svForm.Email;
                svExist.DiaChi = svForm.DiaChi;
                svExist.Hinh = svForm.Hinh;
            }
            else
            {
                // Thêm sinh viên mới
                dsSV.Add(svForm);
            }

            isModified = true;
            LoadListView();
            MessageBox.Show("Lưu thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                string mssv = item.SubItems[0].Text;
                SinhVien? sv = dsSV.Find(s => s.MSSV == mssv);
                if (sv != null)
                {
                    ThietLapThongTinForm(sv);
                }
            }
        }

        private void cmsiXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvSinhVien.SelectedItems)
                {
                    string mssv = item.SubItems[0].Text;
                    dsSV.RemoveAll(s => s.MSSV == mssv);
                }
                isModified = true;
                LoadListView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmsiTaiLai_Click(object sender, EventArgs e)
        {
            DocTuFile("DSNV.txt");
            LoadListView();
            isModified = false;
        }

        private void frmSinhVienCNTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult dlg = MessageBox.Show(
                    "Danh sách sinh viên đã bị thay đổi. Bạn có muốn lưu lại vào tập tin DSNV.txt không?",
                    "Xác nhận lưu thay đổi",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (dlg == DialogResult.Yes)
                {
                    LuuVaoFile("DSNV.txt");
                }
                else if (dlg == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
