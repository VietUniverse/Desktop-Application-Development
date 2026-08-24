using System;
using System.ComponentModel;

namespace QuanLyNhaThuoc
{
    public class Customer
    {
        [DisplayName("Họ Và Tên Khách Hàng")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Số Điện Thoại")]
        public string NumPhone { get; set; } = string.Empty;

        [DisplayName("Điểm Tích Lũy")]
        public int Point { get; set; }

        public Customer(string name, string nphone, int point)
        {
            Name = name;
            NumPhone = nphone;
            Point = point;
        }

        public Customer() { }
    }
}
