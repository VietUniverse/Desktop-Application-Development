using System;
using System.Collections.Generic;

namespace NhapThongTinGiangVien
{
    // Kiểu tìm kiếm (Theo Mã, Theo Họ Tên, Theo Số ĐT)
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSoDT
    }

    // Lớp quản lý danh sách giảng viên
    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien { get; set; }

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        // Thêm một giảng viên mới vào danh sách (trả về false nếu mã đã tồn tại)
        public bool Them(GiangVien gv)
        {
            foreach (GiangVien item in dsGiangVien)
            {
                // So sánh mã số (không phân biệt hoa/thường)
                if (item.MaSo.Trim().Equals(gv.MaSo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return false; // Trùng mã giảng viên
                }
            }

            dsGiangVien.Add(gv);
            return true;
        }

        // Tìm kiếm giảng viên theo từ khóa và kiểu tìm
        public GiangVien? TimKiem(string tuKhoa, KieuTim kieu)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return null;
            }

            tuKhoa = tuKhoa.Trim();

            foreach (GiangVien gv in dsGiangVien)
            {
                if (kieu == KieuTim.TheoMa)
                {
                    if (gv.MaSo.Trim().Equals(tuKhoa, StringComparison.OrdinalIgnoreCase))
                    {
                        return gv;
                    }
                }
                else if (kieu == KieuTim.TheoHoTen)
                {
                    if (gv.HoTen.ToLower().Contains(tuKhoa.ToLower()))
                    {
                        return gv;
                    }
                }
                else if (kieu == KieuTim.TheoSoDT)
                {
                    if (gv.SoDT.Contains(tuKhoa))
                    {
                        return gv;
                    }
                }
            }

            return null; // Không tìm thấy
        }
    }
}
