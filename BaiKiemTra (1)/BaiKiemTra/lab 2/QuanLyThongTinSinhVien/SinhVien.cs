using System;
using System.Collections.Generic;

namespace QuanLyThongTinSinhVien
{
    // Lớp đại diện cho Sinh viên trong QuanLyThongTinSinhVien
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public List<string> ChuyenNganh { get; set; }

        // Khởi tạo mặc định
        public SinhVien()
        {
            MaSo = "";
            HoTen = "";
            NgaySinh = DateTime.Now;
            DiaChi = "";
            Lop = "";
            Hinh = "";
            GioiTinh = true;
            ChuyenNganh = new List<string>();
        }

        // Khởi tạo có đầy đủ tham số
        public SinhVien(string ms, string ht, DateTime ns, string dc, string lop, string hinh, bool gt, List<string> cn)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.NgaySinh = ns;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.GioiTinh = gt;
            this.ChuyenNganh = cn;
        }
    }
}

