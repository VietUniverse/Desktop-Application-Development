using System.Collections.Generic;

namespace HuongDanThucHanh
{
    // Cấu trúc của tập tin students.json: một danh sách nằm trong mục "sinhvien".
    public class StudentFile
    {
        public List<StudentInfo> sinhvien { get; set; } = new List<StudentInfo>();
    }

    public class StudentInfo
    {
        // Các thuộc tính
        public string MSSV { get; set; }
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }

        // Thư viện JSON dùng hàm này khi tạo sinh viên từ tập tin.
        public StudentInfo()
        {
            MSSV = "";
            Hoten = "";
        }

        // Phương thức tạo lập
        public StudentInfo(string mssv, string hoten, int tuoi, double diem, bool tongiao)
        {
            this.MSSV = mssv;
            this.Hoten = hoten;
            this.Tuoi = tuoi;
            this.Diem = diem;
            this.TonGiao = tongiao;
        }
    }
}
