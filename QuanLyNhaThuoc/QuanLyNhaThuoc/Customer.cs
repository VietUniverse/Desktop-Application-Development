using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class Customer
    {
        public string Name {  get; set; }
        public string NumPhone {  get; set; }
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
