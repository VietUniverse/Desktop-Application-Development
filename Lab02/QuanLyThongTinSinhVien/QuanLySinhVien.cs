using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLyThongTinSinhVien
{
    public delegate int SoSanh(object a, object b);

    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach { get; set; }

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }

        public SinhVien? Tim(object obj, SoSanh ss)
        {
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj, sv) == 0)
                    return sv;
            }
            return null;
        }

        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int count = this.DanhSach.Count;
            for (int i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    return true;
                }
            }
            return false;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = this.DanhSach.Count - 1; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this.DanhSach.RemoveAt(i);
                }
            }
        }

        public void DocTuFile(string filename)
        {
            if (!File.Exists(filename))
                return;

            string[] lines = File.ReadAllLines(filename);
            this.DanhSach.Clear();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
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
                    sv.GioiTinh = s[6].Trim() == "1" || s[6].Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase);

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
