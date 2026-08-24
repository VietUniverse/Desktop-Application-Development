using System;

namespace QuanLyNhaThuoc
{
    public class Medicine
    {
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; } // Giá nguyên hộp
        public int StockQuantity { get; set; } = 100; // Tồn kho tính theo Hộp
        public string Unit { get; set; } = "Hộp";
        public string Manufacturer { get; set; } = "Dược Phẩm Việt Nam";
        
        // Quy đổi đơn vị: 1 Hộp = BlistersPerBox Vỉ = (BlistersPerBox * PillsPerBlister) Viên
        public int BlistersPerBox { get; set; } = 10; // Số vỉ trong 1 hộp
        public int PillsPerBlister { get; set; } = 10; // Số viên trong 1 vỉ

        public float PricePerBox => Price;
        public float PricePerBlister => Price / Math.Max(1, BlistersPerBox);
        public float PricePerPill => Price / Math.Max(1, (BlistersPerBox * PillsPerBlister));

        public Medicine(string name, float price, int stockQuantity = 100, string unit = "Hộp", string manufacturer = "Dược Phẩm Việt Nam", int blistersPerBox = 10, int pillsPerBlister = 10)
        { 
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
            Unit = unit;
            Manufacturer = manufacturer;
            BlistersPerBox = blistersPerBox;
            PillsPerBlister = pillsPerBlister;
        }

        public Medicine() { }

        public float GetPriceByUnit(string selectedUnit)
        {
            if (selectedUnit.Equals("Vỉ", StringComparison.OrdinalIgnoreCase))
                return PricePerBlister;
            if (selectedUnit.Equals("Viên", StringComparison.OrdinalIgnoreCase))
                return PricePerPill;
            return PricePerBox;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0}đ/Hộp ({PricePerBlister:N0}đ/Vỉ, {PricePerPill:N0}đ/Viên)";
        }
    }
}
