using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class Medicine
    {
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        
        public Medicine(string name, float price)
        { 
            Name = name;
            Price = price;
        }

        public Medicine() { }
    }

}
