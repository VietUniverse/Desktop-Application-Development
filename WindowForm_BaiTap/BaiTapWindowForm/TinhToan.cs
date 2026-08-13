using System;

namespace BaiTapWindowForm
{
    public static class TinhToan
    {
        // a) Hàm void CongHaiSo(a, b, s) để cộng hai số a và b. Kết quả được trả về cho tham số s.
        public static void CongHaiSo(int a, int b, out int s)
        {
            s = a + b;
        }

        // a) Hàm int TongDaySo(n) để tính tổng các số nguyên liên tục từ 1 đến n.
        public static int TongDaySo(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
