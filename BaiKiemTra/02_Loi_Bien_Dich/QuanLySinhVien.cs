using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLyThongTinSinhVien
{
    // Lớp quản lý danh sách sinh viên
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach { get; set; }

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        // Thêm sinh viên vào danh sách
        public void Them(SinhVien sv)
        {
            this.DanhSach.Them(sv);
        }

        // Tìm sinh viên theo mã số bằng vòng lặp đơn giản
        public SinhVien? TimTheoMa(string maSo)
        {
            foreach (SinhVien sv in DanhSach)
            {
                if (sv.MaSo.Trim().Equals(maSo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return sv;
                }
            }
            return null;
        }

        // Sửa thông tin sinh viên theo Mã Số
        public bool Sua(SinhVien svSua)
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i].MaSo.Trim().Equals(svSua.MaSo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    DanhSach[i] = svSua;
                    return true;
                }
            }
            return false;
        }

        // Xóa sinh viên theo mã số
        public void XoaTheoMa(string maSo)
        {
            for (int i = DanhSach.Count - 1; i >= 0; i--)
            {
                if (DanhSach[i].MaSo.Trim().Equals(maSo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    DanhSach.RemoveAt(i);
                }
            }
        }

        // So sánh hai sinh viên theo tiêu chí đã chọn, rồi đổi chỗ nếu cần.
        public void SapXep(TieuChi tieuChi)
        {
            for (int i = 0; i < DanhSach.Count - 1; i++)
            {
                for (int j = i + 1; j < DanhSach.Count; j++)
                {
                    int ketQuaSoSanh = 0;

                    if (tieuChi == TieuChi.MaSV)
                    {
                        ketQuaSoSanh = string.Compare(DanhSach[i].MaSo, DanhSach[j].MaSo);
                    }
                    else if (tieuChi == TieuChi.HoTen)
                    {
                        ketQuaSoSanh = string.Compare(DanhSach[i].HoTen, DanhSach[j].HoTen);
                    }
                    else if (tieuChi == TieuChi.NgaySinh)
                    {
                        ketQuaSoSanh = DateTime.Compare(DanhSach[i].NgaySinh, DanhSach[j].NgaySinh);
                    }

                    if (ketQuaSoSanh > 0)
                    {
                        SinhVien tam = DanhSach[i];
                        DanhSach[i] = DanhSach[j];
                        DanhSach[j] = tam;
                    }
                }
            }
        }

        // Đọc danh sách sinh viên từ tập tin text
        public void DocTuFile(string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            this.DanhSach.Clear();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] s = line.Split('\t');
                if (s.Length >= 8)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSo = s[0].Trim();
                    sv.HoTen = s[1].Trim();

                    DateTime dt;
                    if (DateTime.TryParseExact(s[2].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                    {
                        sv.NgaySinh = dt;
                    }
                    else if (DateTime.TryParse(s[2].Trim(), out dt))
                    {
                        sv.NgaySinh = dt;
                    }

                    sv.DiaChi = s[3].Trim();
                    sv.Lop = s[4].Trim();
                    sv.Hinh = s[5].Trim();
                    sv.GioiTinh = (s[6].Trim() == "1" || s[6].Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase));

                    string[] cn = s[7].Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string c in cn)
                    {
                        sv.ChuyenNganh.Add(c.Trim());
                    }

                    this.Them(sv);
                }
            }
        }
    }
}
