using System;

namespace NhapThongTinGiangVien
{
    // Lớp đại diện cho một Giảng viên
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string Mail { get; set; }
        public string[] NgoaiNgu { get; set; }
        public DanhMucHocPhan dsHocPhan { get; set; }

        // Khởi tạo không tham số (Mặc định)
        public GiangVien()
        {
            MaSo = "";
            HoTen = "";
            NgaySinh = DateTime.Now;
            GioiTinh = "Nam";
            SoDT = "";
            Mail = "";
            NgoaiNgu = new string[0];
            dsHocPhan = new DanhMucHocPhan();
        }

        // Khởi tạo có đầy đủ tham số
        public GiangVien(string maso, string sdt, string mail, string hoten, DateTime ngaysinh, DanhMucHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.SoDT = sdt;
            this.Mail = mail;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
        }

        // Xuất thông tin giảng viên dạng chuỗi
        public override string ToString()
        {
            string thongTin = "Mã số: " + MaSo + "\n"
                            + "Họ tên: " + HoTen + "\n"
                            + "Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy") + "\n"
                            + "Giới tính: " + GioiTinh + "\n"
                            + "Số ĐT: " + SoDT + "\n"
                            + "Mail: " + Mail + "\n";

            // Ghép danh sách ngoại ngữ
            string ngoaiNguStr = "Ngoại ngữ: ";
            if (NgoaiNgu != null)
            {
                foreach (string nn in NgoaiNgu)
                {
                    if (!string.IsNullOrEmpty(nn))
                    {
                        ngoaiNguStr += nn + "; ";
                    }
                }
            }

            // Ghép danh sách học phần giảng dạy
            string monDayStr = "Danh sách môn dạy: ";
            if (dsHocPhan != null && dsHocPhan.ds != null)
            {
                foreach (HocPhan hp in dsHocPhan.ds)
                {
                    monDayStr += hp.TenHP + "; ";
                }
            }

            return thongTin + ngoaiNguStr + "\n" + monDayStr;
        }
    }
}
