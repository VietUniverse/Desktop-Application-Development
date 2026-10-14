using System;
using System.Collections.Generic;
using System.IO;
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
                List<SinhVien>? list = JsonConvert.DeserializeObject<List<SinhVien>>(json);
                if (list != null)
                {
                    DanhSach = list;
                }
                else
                {
                    DanhSach = new List<SinhVien>();
                }
            }
            else if (type == "XML")
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                    using (StreamReader reader = new StreamReader(path))
                    {
                        List<SinhVien>? list = serializer.Deserialize(reader) as List<SinhVien>;
                        if (list != null)
                        {
                            DanhSach = list;
                        }
                        else
                        {
                            DanhSach = new List<SinhVien>();
                        }
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
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split('*');
                    if (parts.Length < 9)
                    {
                        continue;
                    }

                    SinhVien s = new SinhVien();
                    s.MSSV = parts[0];
                    s.HoTenLot = parts[1];
                    s.Ten = parts[2];
                    s.GioiTinh = parts[3] == "Nam";
                    DateTime dt;
                    DateTime.TryParse(parts[4], out dt);
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
                    string gt = "Nữ";
                    if (s.GioiTinh)
                    {
                        gt = "Nam";
                    }
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
                if (st.Ten == s.Ten)
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
                if (DanhSach[i].Lop == s.Lop)
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
            for (int i = DanhSach.Count - 1; i >= 0; i--)
            {
                if (listMSSV.Contains(DanhSach[i].MSSV))
                {
                    DanhSach.RemoveAt(i);
                }
            }
            GhiVaoFile();
        }

        // Kiểm tra từng sinh viên với các điều kiện tìm kiếm.
        public List<SinhVien> TimKiem(string mssv, string ten, string lop)
        {
            List<SinhVien> ketQua = new List<SinhVien>();
            foreach (SinhVien s in DanhSach)
            {
                if (!string.IsNullOrEmpty(mssv) && !s.MSSV.Contains(mssv))
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(ten))
                {
                    string tenCanTim = ten.ToLower();
                    bool timThayTrongTen = s.Ten.ToLower().Contains(tenCanTim);
                    bool timThayTrongHo = s.HoTenLot.ToLower().Contains(tenCanTim);
                    if (!timThayTrongTen && !timThayTrongHo)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(lop) && s.Lop == lop)
                {
                    continue;
                }

                ketQua.Add(s);
            }

            return ketQua;
        }

        // Sinh MSSV gợi ý (AABBCCC)
        public string TaoMSSV(string tenLop)
        {
            string aa = "20";
            if (tenLop.Contains("42"))
            {
                aa = "18";
            }
            else if (tenLop.Contains("43"))
            {
                aa = "19";
            }
            else if (tenLop.Contains("44"))
            {
                aa = "20";
            }
            else if (tenLop.Contains("45"))
            {
                aa = "21";
            }
            else if (tenLop.Contains("46"))
            {
                aa = "22";
            }

            string prefix = aa + "10";
            int max = 0;
            foreach (SinhVien s in DanhSach)
            {
                if (s.MSSV.StartsWith(prefix) && s.MSSV.Length == 7)
                {
                    int num;
                    int.TryParse(s.MSSV.Substring(4), out num);
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }

            int next = max;
            return prefix + next.ToString("000");
        }
    }
}
