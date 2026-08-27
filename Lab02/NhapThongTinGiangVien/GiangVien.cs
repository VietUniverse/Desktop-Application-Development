using System;

namespace NhapThongTinGiangVien
{
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhMucHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;

        public GiangVien()
        {
            MaSo = "";
            HoTen = "";
            GioiTinh = "Nam";
            SoDT = "";
            Mail = "";
            dsHocPhan = new DanhMucHocPhan();
            NgoaiNgu = new string[20];
        }

        public GiangVien(string maso, string sdt, string mail, string hoten, DateTime ngaysinh, DanhMucHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
            this.GioiTinh = gt;
        }

        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                     + "Họ tên: " + HoTen + "\n"
                     + "Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy") + "\n"
                     + "Giới tính: " + GioiTinh + "\n"
                     + "Số ĐT: " + SoDT + "\n"
                     + "Mail: " + Mail + "\n";

            string sngoaingu = "Ngoại ngữ: ";
            if (NgoaiNgu != null)
            {
                foreach (string t in NgoaiNgu)
                {
                    if (!string.IsNullOrEmpty(t))
                        sngoaingu += t + "; ";
                }
            }

            string monDay = "Danh sách môn dạy: ";
            if (dsHocPhan != null && dsHocPhan.ds != null)
            {
                foreach (HocPhan hp in dsHocPhan.ds)
                {
                    monDay += hp.TenHP + "; ";
                }
            }

            s += sngoaingu + "\n" + monDay;
            return s;
        }
    }
}
