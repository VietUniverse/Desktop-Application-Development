using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Btap_ThietKeForm
{
    public partial class frmBai3 : Form
    {
        // Từ điển lưu trữ danh sách từ mới (Từ tiếng Anh -> Nghĩa tiếng Việt)
        private Dictionary<string, string> tuDien = new Dictionary<string, string>();

        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {
            // Nạp các từ mặc định theo đề bài
            tuDien.Add("Go", "Đi, di chuyển");
            tuDien.Add("House", "Ngôi nhà");
            tuDien.Add("School", "Trường học");
            tuDien.Add("Teacher", "Giáo viên, thầy cô");
            tuDien.Add("Student", "Học sinh, sinh viên");

            // Đổ danh sách từ lên ListBox (lstTuMoi)
            NapDanhSachTu();

            // Chọn mặc định từ "Student" giống trong hình đề bài
            if (lstTuMoi.Items.Count > 0)
            {
                lstTuMoi.SelectedIndex = lstTuMoi.Items.Count - 1;
            }
        }

        private void NapDanhSachTu()
        {
            lstTuMoi.Items.Clear();
            foreach (var tu in tuDien.Keys)
            {
                lstTuMoi.Items.Add(tu);
            }
        }

        // Khi bấm vào 1 từ trong ListBox bên trái
        private void lstTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuMoi.SelectedItem != null)
            {
                string tuChon = lstTuMoi.SelectedItem.ToString();
                if (tuDien.ContainsKey(tuChon))
                {
                    txtNghiaHienThi.Text = tuDien[tuChon];
                }
            }
        }

        // Nút "Thêm từ mới"
        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            string tuMoi = txtTuMoi.Text.Trim();
            string nghia = txtNghia.Text.Trim();

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrEmpty(tuMoi) || string.IsNullOrEmpty(nghia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Từ mới và Nghĩa của từ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu từ đã tồn tại thì cập nhật nghĩa mới, nếu chưa thì thêm mới
            if (tuDien.ContainsKey(tuMoi))
            {
                tuDien[tuMoi] = nghia;
            }
            else
            {
                tuDien.Add(tuMoi, nghia);
                lstTuMoi.Items.Add(tuMoi);
            }

            // Tự động chọn từ vừa thêm và hiển thị nghĩa ở khung xám bên phải
            lstTuMoi.SelectedItem = tuMoi;

            // Xóa dữ liệu cũ trong 2 ô nhập
            txtTuMoi.Clear();
            txtNghia.Clear();
            txtTuMoi.Focus();
        }
    }
}
