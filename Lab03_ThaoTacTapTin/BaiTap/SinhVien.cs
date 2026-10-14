using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class SinhVien
    {
        public string MSSV { get; set; } = "";
        public string HoTenLot { get; set; } = "";
        public string Ten { get; set; } = "";
        public bool GioiTinh { get; set; } = true; // true = Nam, false = Nữ
        public DateTime NgaySinh { get; set; } = DateTime.Now;
        public string Lop { get; set; } = "";
        public string SoCMND { get; set; } = "";
        public string SoDT { get; set; } = "";
        public string DiaChi { get; set; } = "";
        public List<string> MonHocDangKy { get; set; } = new List<string>();

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string hoTenLot, string ten, bool gioiTinh, DateTime ngaySinh, string lop, string soCMND, string soDT, string diaChi, List<string> monHoc)
        {
            MSSV = mssv;
            HoTenLot = hoTenLot;
            Ten = ten;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Lop = lop;
            SoCMND = soCMND;
            SoDT = soDT;
            DiaChi = diaChi;
            MonHocDangKy = monHoc;
        }

        public string HoVaTen
        {
            get
            {
                return (HoTenLot + " " + Ten).Trim();
            }
        }
    }
}
