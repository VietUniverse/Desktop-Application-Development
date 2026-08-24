using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class FormEditCartItem : Form
    {
        private CartItem _cartItem;
        private Medicine? _medicine;

        public FormEditCartItem(CartItem cartItem, Medicine? medicine)
        {
            _cartItem = cartItem;
            _medicine = medicine;
            InitializeComponent();
        }

        private void FormEditCartItem_Load(object sender, EventArgs e)
        {
            lblMedName.Text = $"Tên thuốc: {_cartItem.Name}";

            string hangSX = _medicine != null ? _medicine.Manufacturer : "Dược Phẩm Việt Nam";
            lblManufacturer.Text = $"Nhà sản xuất: {hangSX}";

            float giaHop = _medicine != null ? _medicine.PricePerBox : _cartItem.Price;
            float giaVi = _medicine != null ? _medicine.PricePerBlister : (_cartItem.Price / 10);
            float giaVien = _medicine != null ? _medicine.PricePerPill : (_cartItem.Price / 100);

            lblPriceInfo.Text = $"Bảng giá: 1 Hộp ({giaHop:N0}đ) | 1 Vỉ ({giaVi:N0}đ) | 1 Viên ({giaVien:N0}đ)";

            int tonKho = _medicine != null ? _medicine.StockQuantity : 0;
            lblStockInfo.Text = $"Tồn kho nhà thuốc hiện tại: {tonKho} Hộp";

            if (cboUnit.Items.Contains(_cartItem.SelectedUnit))
            {
                cboUnit.SelectedItem = _cartItem.SelectedUnit;
            }
            else
            {
                cboUnit.SelectedIndex = 0;
            }

            nudQuantity.Value = Math.Max(1, _cartItem.Quantity);
            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            string selUnit = cboUnit.SelectedItem?.ToString() ?? "Hộp";
            float unitPrice = _medicine != null ? _medicine.GetPriceByUnit(selUnit) : _cartItem.Price;
            int qty = (int)nudQuantity.Value;
            float total = unitPrice * qty;

            lblTotalPrice.Text = $"{total:N0}đ";
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selUnit = cboUnit.SelectedItem?.ToString() ?? "Hộp";
            float unitPrice = _medicine != null ? _medicine.GetPriceByUnit(selUnit) : _cartItem.Price;

            _cartItem.SelectedUnit = selUnit;
            _cartItem.Quantity = (int)nudQuantity.Value;
            _cartItem.Price = unitPrice;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{_cartItem.Name}' khỏi đơn hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
