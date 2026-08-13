using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Btap_ThietKeForm
{
    public partial class frmBai2 : Form
    {
        // Bảng giá chi tiết của từng mặt hàng
        private Dictionary<string, int> bangGia = new Dictionary<string, int>()
        {
            { "Chuột", 100000 },
            { "Bàn phím", 150000 },
            { "Máy in", 2000000 },
            { "USB Kingmax", 200000 }
        };

        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            // Nạp danh sách hàng hóa vào ListBox bên trái khi Form vừa mở
            listBuying.Items.Clear();
            foreach (var hangHoa in bangGia.Keys)
            {
                listBuying.Items.Add(hangHoa);
            }
        }

        // 1. Nút "Chọn hàng >": Thêm mặt hàng được chọn từ danh sách bên trái sang bên phải
        private void btnChonHang_Click(object sender, EventArgs e)
        {
            if (listBuying.SelectedItem != null)
            {
                listUnBuying.Items.Add(listBuying.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 mặt hàng từ danh sách bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 2. Nút "< Bỏ hàng": Xóa mặt hàng đang chọn ở danh sách bên phải
        private void btnBoHang_Click(object sender, EventArgs e)
        {
            if (listUnBuying.SelectedIndex >= 0)
            {
                listUnBuying.Items.RemoveAt(listUnBuying.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng muốn bỏ từ danh sách bên phải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Nút "Tính tiền": Cộng tổng tiền các hàng trong danh sách mua (bên phải)
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            foreach (var item in listUnBuying.Items)
            {
                string tenHang = item.ToString();
                if (bangGia.ContainsKey(tenHang))
                {
                    tongTien += bangGia[tenHang];
                }
            }

            // Hiển thị tổng tiền dạng chuẩn: 500.000 đồng
            lblTongTien.Text = string.Format("{0:N0} đồng", tongTien);
        }
    }
}
