using System;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public class HangHoa
    {
        // Các thuộc tính: MaHang, TenHang, DVT, SoLuong, DonGia
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        // Hàm khởi tạo không có tham số
        public HangHoa()
        {
            MaHang = "";
            TenHang = "";
            DVT = "";
            SoLuong = 0;
            DonGia = 0;
        }

        // Hàm khởi tạo có tham số
        public HangHoa(string maHang, string tenHang, string dvt, int soLuong, double donGia)
        {
            MaHang = maHang;
            TenHang = tenHang;
            DVT = dvt;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        // Phương thức HienThi (hiển thị tất cả thông tin của hàng hóa)
        public void HienThi()
        {
            string thongTin = $"Mã hàng: {MaHang}\n" +
                              $"Tên hàng: {TenHang}\n" +
                              $"Đơn vị tính: {DVT}\n" +
                              $"Số lượng: {SoLuong}\n" +
                              $"Đơn giá: {DonGia:N0} VNĐ";

            MessageBox.Show(thongTin, "Thông tin Hàng Hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
