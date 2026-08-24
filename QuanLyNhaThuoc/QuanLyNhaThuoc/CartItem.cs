using System;
using System.ComponentModel;

namespace QuanLyNhaThuoc
{
    public class CartItem
    {
        [DisplayName("Tên Thuốc")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Đơn Giá (VNĐ)")]
        public float Price { get; set; }

        [DisplayName("Số Lượng")]
        public int Quantity { get; set; } = 1;

        [DisplayName("Đơn Vị Tính")]
        public string SelectedUnit { get; set; } = "Hộp";

        [DisplayName("Thành Tiền (VNĐ)")]
        public float TotalPrice => Price * Quantity;

        public CartItem(string name, float price, int quantity = 1, string selectedUnit = "Hộp")
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            SelectedUnit = selectedUnit;
        }

        public CartItem() { }

        public override string ToString()
        {
            return $"{Name} (x{Quantity} {SelectedUnit}) - {TotalPrice:N0}đ";
        }
    }

    public class RewardItem
    {
        [DisplayName("Tên Quà Tặng")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Số Điểm Cần Đổi")]
        public int PointsRequired { get; set; }

        [DisplayName("Tồn Kho Quà")]
        public int StockQuantity { get; set; } = 20;

        public RewardItem(string name, int pointsRequired, int stockQuantity = 20)
        {
            Name = name;
            PointsRequired = pointsRequired;
            StockQuantity = stockQuantity;
        }

        public RewardItem() { }

        public override string ToString()
        {
            return $"{Name} - {PointsRequired} điểm (Tồn: {StockQuantity} cái)";
        }
    }
}
