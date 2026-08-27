using System;
using System.Collections.Generic;

namespace NhapThongTinGiangVien
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSoDT
    }

    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien { get; set; }

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        public bool Them(GiangVien gv)
        {
            foreach (GiangVien item in dsGiangVien)
            {
                if (string.Equals(item.MaSo?.Trim(), gv.MaSo?.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return false; // Mã trùng
                }
            }
            dsGiangVien.Add(gv);
            return true;
        }

        public GiangVien? TimKiem(string tuKhoa, KieuTim kieu)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                return null;

            tuKhoa = tuKhoa.Trim();

            foreach (GiangVien gv in dsGiangVien)
            {
                switch (kieu)
                {
                    case KieuTim.TheoMa:
                        if (string.Equals(gv.MaSo?.Trim(), tuKhoa, StringComparison.OrdinalIgnoreCase))
                            return gv;
                        break;

                    case KieuTim.TheoHoTen:
                        if (gv.HoTen != null && gv.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                            return gv;
                        break;

                    case KieuTim.TheoSoDT:
                        if (gv.SoDT != null && gv.SoDT.Replace(".", "").Replace("(", "").Replace(")", "").Replace("-", "").Contains(tuKhoa.Replace(".", "").Replace("(", "").Replace(")", "").Replace("-", "")))
                            return gv;
                        break;
                }
            }
            return null;
        }
    }
}
