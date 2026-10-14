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

        // Đọc danh sách sinh viên từ file text (DSNV.txt)
        private void DocTuFile(string filename)
        {
            string filePath = Path.Combine(Application.StartupPath, filename);

            if (!File.Exists(filePath))
            {
                return;
            }

            dsSV.Clear();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] s = line.Split('\t');
                if (s.Length >= 8)
                {
                    SinhVien sv = new SinhVien();
                    sv.MSSV = s[0].Trim();
                    sv.HoTen = s[1].Trim();

                    if (s.Length >= 9)
                    {
                        sv.GioiTinh = (s[2].Trim() == "Nam");

                        DateTime dt;
                        if (DateTime.TryParseExact(s[3].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            sv.NgaySinh = dt;
                        }
                        else if (DateTime.TryParse(s[3].Trim(), out dt))
                        {
                            sv.NgaySinh = dt;
                        }

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
                        {
                            sv.NgaySinh = dt;
                        }
                        else if (DateTime.TryParse(s[2].Trim(), out dt))
                        {
                            sv.NgaySinh = dt;
                        }

                        sv.GioiTinh = (s[3].Trim() == "Nam");
                        sv.SoDT = s[4].Trim();
                        sv.Lop = s[5].Trim();
                        sv.DiaChi = s[6].Trim();
                        sv.Hinh = s[7].Trim();
                    }

                    dsSV.Add(sv);
                }
            }
        }

        // Ghi danh sách sinh viên vào file text (DSNV.txt)
        private void LuuVaoFile(string filename)
        {
            List<string> lines = new List<string>();

            foreach (SinhVien sv in dsSV)
            {
                string gioiTinh = "Nữ";
                if (sv.GioiTinh)
                {
                    gioiTinh = "Nam";
                }

                string line = sv.MSSV + "\t" +
                              sv.HoTen + "\t" +
                              gioiTinh + "\t" +
                              sv.NgaySinh.ToString("dd/MM/yyyy") + "\t" +
                              sv.Lop + "\t" +
                              sv.SoDT + "\t" +
                              sv.Email + "\t" +
                              sv.DiaChi + "\t" +
                              sv.Hinh;
                lines.Add(line);
            }

            string filePath = Path.Combine(Application.StartupPath, filename);
            File.WriteAllLines(filePath, lines);
        }

        // Hiển thị danh sách sinh viên từ bộ nhớ lên ListView
        private void LoadListView()
        {
            lvSinhVien.Items.Clear();

            foreach (SinhVien sv in dsSV)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoTen);
                string gioiTinh = "Nữ";
                if (sv.GioiTinh)
                {
                    gioiTinh = "Nam";
                }
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoDT);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Hinh);

                lvSinhVien.Items.Add(item);
            }
        }

        // Lấy dữ liệu sinh viên được nhập trên các ô điều khiển của Form
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

        // Hiển thị thông tin một sinh viên lên Form
        private void ThietLapThongTinForm(SinhVien sv)
        {
            mtxtMSSV.Text = sv.MSSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }

            mtxtSoDT.Text = sv.SoDT;
            cboLop.Text = sv.Lop;
            txtEmail.Text = sv.Email;
            txtDiaChi.Text = sv.DiaChi;
            txtHinh.Text = sv.Hinh;

            // Load hình ảnh sinh viên
            if (File.Exists(sv.Hinh))
            {
                pbHinh.ImageLocation = sv.Hinh;
            }
            else
            {
                string relativePath = Path.Combine(Application.StartupPath, sv.Hinh);
                if (File.Exists(relativePath))
                {
                    pbHinh.ImageLocation = relativePath;
                }
                else
                {
                    pbHinh.Image = null;
                }
            }
        }

        // Đặt lại các điều khiển trên Form về rỗng (Mặc định)
        private void ResetControls()
        {
            mtxtMSSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            mtxtSoDT.Text = "";

            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }

            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtHinh.Text = "";
            pbHinh.Image = null;
        }

        // Hàm tìm sinh viên theo MSSV bằng vòng lặp đơn giản
        private SinhVien? TimSinhVien(string mssv)
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.MSSV.Equals(mssv.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return sv;
                }
            }
            return null;
        }

        // Hàm xóa sinh viên theo MSSV
        private void XoaSinhVien(string mssv)
        {
            for (int i = dsSV.Count - 1; i >= 0; i--)
            {
                if (dsSV[i].MSSV.Equals(mssv.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    dsSV.RemoveAt(i);
                }
            }
        }

        // Sự kiện khi tải Form
        private void frmSinhVienCNTT_Load(object sender, EventArgs e)
        {
            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }

            DocTuFile("DSNV.txt");
            LoadListView();
            isModified = false;
        }

        // Chọn file hình ảnh
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            if (openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialogHinh.FileName;
                pbHinh.ImageLocation = openFileDialogHinh.FileName;
            }
        }

        // Lưu thông tin sinh viên (Thêm mới hoặc Cập nhật)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien svForm = GetSinhVienFromForm();

            if (string.IsNullOrWhiteSpace(svForm.MSSV) || svForm.MSSV.Length < 7)
            {
                MessageBox.Show("Mã sinh viên phải gồm 7 ký tự số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra sinh viên đã tồn tại chưa
            SinhVien? svExist = TimSinhVien(svForm.MSSV);

            if (svExist != null)
            {
                // Cập nhật thông tin sinh viên cũ
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
                // Thêm sinh viên mới vào danh sách
                dsSV.Add(svForm);
            }

            isModified = true;
            LoadListView();
            MessageBox.Show("Lưu thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Mặc định (Reset form)
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hiển thị thông tin sinh viên được chọn trên ListView lên Form
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                string mssv = item.SubItems[0].Text;
                SinhVien? sv = TimSinhVien(mssv);
                if (sv != null)
                {
                    ThietLapThongTinForm(sv);
                }
            }
        }

        // Menu chuột phải - Xóa sinh viên được chọn
        private void cmsiXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvSinhVien.SelectedItems)
                {
                    string mssv = item.SubItems[0].Text;
                    XoaSinhVien(mssv);
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

        // Menu chuột phải - Tải lại danh sách từ file
        private void cmsiTaiLai_Click(object sender, EventArgs e)
        {
            DocTuFile("DSNV.txt");
            LoadListView();
            isModified = false;
        }

        // Sự kiện khi đóng Form (hỏi người dùng có muốn lưu thay đổi hay không)
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
