using System;

namespace QuanLyNhaThuoc
{
    internal class CartItem
    {
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public int Quantity { get; set; } = 1;
        public float TotalPrice => Price * Quantity;

        public CartItem(string name, float price, int quantity = 1)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public CartItem() { }
    }
}
