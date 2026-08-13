using System;
using System.Drawing;
using System.Windows.Forms;

namespace Btap_ThietKeForm
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            // Mảng số mẫu theo đề bài
            int[] danhSachSo = { 6, 3, 7, 9, 12, 37, 21, 5, 9, 18 };

            // Nạp các số vào ListBox bên trái
            lstSo.Items.Clear();
            foreach (int so in danhSachSo)
            {
                lstSo.Items.Add(so);
            }

            // Xóa nhãn kết quả lúc mới mở Form
            lblKetQua.Text = "";
        }

        // Nút "Tìm số"
        private void btnTimSo_Click(object sender, EventArgs e)
        {
            string input = txtSoCanTim.Text.Trim();

            // Kiểm tra xem có phải là số nguyên hợp lệ không
            if (!int.TryParse(input, out int val))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoCanTim.Focus();
                return;
            }

            bool timThay = false;
            lstSo.ClearSelected();

            // Duyệt danh sách các số trong ListBox để tìm kiếm
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int itemSo = Convert.ToInt32(lstSo.Items[i]);

                if (itemSo == val)
                {
                    timThay = true;
                    lstSo.SetSelected(i, true); // Tự động chọn (tô xanh) số tìm thấy trong ListBox
                    break;
                }
            }

            // Hiển thị kết quả bằng chữ ĐỎ in đậm giống hình đề bài
            if (timThay)
            {
                lblKetQua.Text = "Tìm thấy";
                lblKetQua.ForeColor = Color.Red;
            }
            else
            {
                lblKetQua.Text = "Không tìm thấy";
                lblKetQua.ForeColor = Color.Red;
            }
        }
    }
}
