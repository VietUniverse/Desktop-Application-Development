using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BaiTap
{
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach { get; set; } = new List<SinhVien>();
        public string DuongDanFile { get; set; } = "students.json";
        public string LoaiFile { get; set; } = "JSON"; // "JSON", "XML", "TXT"

        // Đọc dữ liệu từ file
        public void DocTuFile(string path, string type)
        {
            DuongDanFile = path;
            LoaiFile = type;

            if (!File.Exists(path))
            {
                DanhSach = new List<SinhVien>();
                return;
            }

            if (type == "JSON")
            {
                string json = File.ReadAllText(path);
                var list = JsonConvert.DeserializeObject<List<SinhVien>>(json);
                DanhSach = list ?? new List<SinhVien>();
            }
            else if (type == "XML")
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                    using (StreamReader reader = new StreamReader(path))
                    {
                        var list = (List<SinhVien>?)serializer.Deserialize(reader);
                        DanhSach = list ?? new List<SinhVien>();
                    }
                }
                catch
                {
                    DanhSach = new List<SinhVien>();
                }
            }
            else if (type == "TXT")
            {
                DanhSach = new List<SinhVien>();
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split('*');
                    if (parts.Length < 9) continue;

                    SinhVien s = new SinhVien();
                    s.MSSV = parts[0];
                    s.HoTenLot = parts[1];
                    s.Ten = parts[2];
                    s.GioiTinh = parts[3] == "Nam";
                    DateTime.TryParse(parts[4], out DateTime dt);
                    s.NgaySinh = dt;
                    s.Lop = parts[5];
                    s.SoCMND = parts[6];
                    s.SoDT = parts[7];
                    s.DiaChi = parts[8];

                    if (parts.Length >= 10 && !string.IsNullOrWhiteSpace(parts[9]))
                    {
                        string[] mons = parts[9].Split(',');
                        foreach (string m in mons)
                        {
                            s.MonHocDangKy.Add(m.Trim());
                        }
                    }
                    DanhSach.Add(s);
                }
            }
        }

        // Ghi dữ liệu ra file
        public void GhiVaoFile()
        {
            if (LoaiFile == "JSON")
            {
                string json = JsonConvert.SerializeObject(DanhSach, Formatting.Indented);
                File.WriteAllText(DuongDanFile, json);
            }
            else if (LoaiFile == "XML")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                using (StreamWriter writer = new StreamWriter(DuongDanFile))
                {
                    serializer.Serialize(writer, DanhSach);
                }
            }
            else if (LoaiFile == "TXT")
            {
                List<string> lines = new List<string>();
                foreach (SinhVien s in DanhSach)
                {
                    string gt = s.GioiTinh ? "Nam" : "Nữ";
                    string ns = s.NgaySinh.ToString("dd/MM/yyyy");
                    string mons = string.Join(",", s.MonHocDangKy);
                    string line = $"{s.MSSV}*{s.HoTenLot}*{s.Ten}*{gt}*{ns}*{s.Lop}*{s.SoCMND}*{s.SoDT}*{s.DiaChi}*{mons}";
                    lines.Add(line);
                }
                File.WriteAllLines(DuongDanFile, lines);
            }
        }

        // Thêm sinh viên
        public bool Them(SinhVien s)
        {
            foreach (SinhVien st in DanhSach)
            {
                if (st.MSSV == s.MSSV)
                {
                    return false; // Trùng mã
                }
            }
            DanhSach.Add(s);
            GhiVaoFile();
            return true;
        }

        // Cập nhật sinh viên
        public bool CapNhat(SinhVien s)
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i].MSSV == s.MSSV)
                {
                    DanhSach[i] = s;
                    GhiVaoFile();
                    return true;
                }
            }
            return false;
        }

        // Xóa sinh viên
        public void Xoa(List<string> listMSSV)
        {
            DanhSach.RemoveAll(s => listMSSV.Contains(s.MSSV));
            GhiVaoFile();
        }

        // Tìm kiếm (dùng LINQ đơn giản)
        public List<SinhVien> TimKiem(string mssv, string ten, string lop)
        {
            var result = DanhSach.AsEnumerable();

            if (!string.IsNullOrEmpty(mssv))
            {
                result = result.Where(s => s.MSSV.Contains(mssv));
            }

            if (!string.IsNullOrEmpty(ten))
            {
                result = result.Where(s => s.Ten.ToLower().Contains(ten.ToLower()) || s.HoTenLot.ToLower().Contains(ten.ToLower()));
            }

            if (!string.IsNullOrEmpty(lop))
            {
                result = result.Where(s => s.Lop == lop);
            }

            return result.ToList();
        }

        // Sinh MSSV gợi ý (AABBCCC)
        public string TaoMSSV(string tenLop)
        {
            string aa = "20";
            if (tenLop.Contains("42")) aa = "18";
            else if (tenLop.Contains("43")) aa = "19";
            else if (tenLop.Contains("44")) aa = "20";
            else if (tenLop.Contains("45")) aa = "21";
            else if (tenLop.Contains("46")) aa = "22";

            string prefix = aa + "10";
            int max = 0;
            foreach (SinhVien s in DanhSach)
            {
                if (s.MSSV.StartsWith(prefix) && s.MSSV.Length == 7)
                {
                    int.TryParse(s.MSSV.Substring(4), out int num);
                    if (num > max) max = num;
                }
            }

            int next = max + 1;
            return prefix + next.ToString("000");
        }
    }
}
