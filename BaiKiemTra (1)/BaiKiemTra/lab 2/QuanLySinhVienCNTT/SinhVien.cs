using System;

namespace QuanLySinhVienCNTT
{
    // Lớp đại diện cho một Sinh viên ngành CNTT
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public string SoDT { get; set; }
        public string Lop { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }

        // Khởi tạo mặc định
        public SinhVien()
        {
            MSSV = "";
            HoTen = "";
            NgaySinh = DateTime.Now;
            GioiTinh = true;
            SoDT = "";
            Lop = "CTK43";
            Email = "";
            DiaChi = "";
            Hinh = "";
        }

        // Khởi tạo có đầy đủ tham số
        public SinhVien(string mssv, string ht, DateTime ns, bool gt, string sdt, string lop, string email, string dc, string hinh)
        {
            MSSV = mssv;
            HoTen = ht;
            NgaySinh = ns;
            GioiTinh = gt;
            SoDT = sdt;
            Lop = lop;
            Email = email;
            DiaChi = dc;
            Hinh = hinh;
        }
    }
}

