using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace QuanLyNhaThuoc
{
    public static class DataManager
    {
        private static readonly string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static readonly string CustomersFile = Path.Combine(DataFolder, "customers.json");
        private static readonly string MedicinesFile = Path.Combine(DataFolder, "medicines.json");
        private static readonly string RewardsFile = Path.Combine(DataFolder, "rewards.json");
        private static readonly string InvoicesFile = Path.Combine(DataFolder, "invoices.json");

        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        static DataManager()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
        }

        public static void GenerateRichSampleDataIfEmpty()
        {
            // Tự động nạp dữ liệu mẫu phong phú nếu chưa có tệp dữ liệu hoặc tệp bị rỗng
            var customers = GetRichSampleCustomers();
            var medicines = GetRichSampleMedicines();
            var rewards = GetRichSampleRewards();
            var invoices = GetRichSampleInvoices();

            SaveCustomers(customers);
            SaveMedicines(medicines);
            SaveRewards(rewards);
            SaveInvoices(invoices);
        }

        // ===================== KHÁCH HÀNG (30 Khách Hàng) =====================
        public static List<Customer> LoadCustomers()
        {
            try
            {
                if (File.Exists(CustomersFile))
                {
                    string json = File.ReadAllText(CustomersFile);
                    var list = JsonSerializer.Deserialize<List<Customer>>(json, Options);
                    if (list != null && list.Count >= 5) return list;
                }
            }
            catch { }

            var defaultCustomers = GetRichSampleCustomers();
            SaveCustomers(defaultCustomers);
            return defaultCustomers;
        }

        private static List<Customer> GetRichSampleCustomers()
        {
            return new List<Customer>
            {
                new Customer("Nguyễn Văn An", "0901234567", 350),
                new Customer("Trần Thị Bình", "0912345678", 87),
                new Customer("Lê Văn Cường", "0923456789", 520),
                new Customer("Phạm Thị Dung", "0934567890", 25),
                new Customer("Hoàng Văn Đức", "0945678901", 178),
                new Customer("Vũ Thị Hoa", "0956789012", 320),
                new Customer("Đặng Văn Hùng", "0967890123", 42),
                new Customer("Bùi Thị Lan", "0978901234", 156),
                new Customer("Ngô Văn Minh", "0989012345", 93),
                new Customer("Đỗ Thị Ngọc", "0990123456", 267),
                new Customer("Trịnh Thanh Hà", "0911223344", 410),
                new Customer("Nguyễn Hoàng Nam", "0922334455", 65),
                new Customer("Phan Thị Mai", "0933445566", 195),
                new Customer("Võ Văn Kiệt", "0944556677", 340),
                new Customer("Nông Văn Hùng", "0955667788", 15),
                new Customer("Lương Thị Ngọc", "0966778899", 280),
                new Customer("Dương Minh Châu", "0977889900", 510),
                new Customer("Ngô Tấn Tài", "0988990011", 75),
                new Customer("Lý Thanh Thảo", "0999001122", 160),
                new Customer("Đào Văn Phú", "0909090909", 230),
                new Customer("Hồ Thị Linh", "0918181818", 120),
                new Customer("Trần Văn Bảo", "0927272727", 310),
                new Customer("Nguyễn Đức Thịnh", "0936363636", 45),
                new Customer("Vũ Kim Anh", "0945454545", 185),
                new Customer("Phạm Hoàng Yến", "0954545454", 295),
                new Customer("Hoàng Gia Huy", "0963636363", 420),
                new Customer("Đỗ Minh Tuấn", "0972727272", 88),
                new Customer("Trịnh Thu Trang", "0981818181", 145),
                new Customer("Bùi Đức Mạnh", "0990909090", 260),
                new Customer("Lê Hải Yến", "0908080808", 380)
            };
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            try
            {
                string json = JsonSerializer.Serialize(customers, Options);
                File.WriteAllText(CustomersFile, json);
            }
            catch { }
        }

        // ===================== THUỐC (20 Sản Phẩm Thuốc) =====================
        public static List<Medicine> LoadMedicines()
        {
            try
            {
                if (File.Exists(MedicinesFile))
                {
                    string json = File.ReadAllText(MedicinesFile);
                    var list = JsonSerializer.Deserialize<List<Medicine>>(json, Options);
                    if (list != null && list.Count >= 5) return list;
                }
            }
            catch { }

            var defaultMedicines = GetRichSampleMedicines();
            SaveMedicines(defaultMedicines);
            return defaultMedicines;
        }

        private static List<Medicine> GetRichSampleMedicines()
        {
            return new List<Medicine>
            {
                new Medicine("Panadol Extra 500mg", 40000, 150, "Hộp", "GSK (Anh)"),
                new Medicine("Augmentin 1g Kháng Sinh", 240000, 60, "Hộp", "GSK (Anh)"),
                new Medicine("Efferalgan Codeine 500mg", 85000, 80, "Hộp", "UPSA (Pháp)"),
                new Medicine("Decolgen Forte Cảm Cúm", 35000, 120, "Hộp", "United Pharma"),
                new Medicine("Tiffy Dey Trị Cảm Cúm", 30000, 140, "Hộp", "Thai Nakorn Patana"),
                new Medicine("Berocca Performance C Bổ", 80000, 90, "Tuýp", "Bayer (Đức)"),
                new Medicine("Smecta 3g Trị Tiêu Chảy", 120000, 70, "Hộp", "Ipsen (Pháp)"),
                new Medicine("Siro Eugica Trị Ho Thảo Dược", 45000, 110, "Chai", "Mega We Care"),
                new Medicine("Siro Ho Prospan 100ml", 95000, 35, "Chai", "Engelhard (Đức)"),
                new Medicine("Dung Dịch Oresol 27.9g", 25000, 300, "Hộp", "DHG Pharma"),
                new Medicine("Men Vi Sinh Bio-Acimin Gold", 165000, 50, "Hộp", "Việt Đức"),
                new Medicine("Nước Muối Sinh Lý 0.9% 500ml", 10000, 250, "Chai", "Pharmadic"),
                new Medicine("Khẩu Trang N95 3M Kháng Khuẩn", 150000, 200, "Hộp", "3M (Mỹ)"),
                new Medicine("Cồn Y Tế 70 Độ 500ml", 22000, 150, "Chai", "Vĩnh Phúc"),
                new Medicine("Dầu Gió Xanh Con Ó 24ml", 135000, 45, "Chai", "Borden (Singapore)"),
                new Medicine("Amoxicillin 500mg Dược Hậu Giang", 45000, 100, "Hộp", "DHG Pharma"),
                new Medicine("Cephalexin 500mg Kháng Sinh", 55000, 85, "Hộp", "Mekophar"),
                new Medicine("Cetirizine 10mg Chống Dị Ứng", 25000, 160, "Hộp", "Stada"),
                new Medicine("Loratadine 10mg Trị Sổ Mũi", 30000, 130, "Hộp", "Dược Hà Tây"),
                new Medicine("Aspirin 81mg Giảm Đau", 20000, 180, "Hộp", "Pymepharco")
            };
        }

        public static void SaveMedicines(List<Medicine> medicines)
        {
            try
            {
                string json = JsonSerializer.Serialize(medicines, Options);
                File.WriteAllText(MedicinesFile, json);
            }
            catch { }
        }

        // ===================== QUÀ TẶNG / VOUCHER (8 Quà Tặng) =====================
        public static List<RewardItem> LoadRewards()
        {
            try
            {
                if (File.Exists(RewardsFile))
                {
                    string json = File.ReadAllText(RewardsFile);
                    var list = JsonSerializer.Deserialize<List<RewardItem>>(json, Options);
                    if (list != null && list.Count >= 3) return list;
                }
            }
            catch { }

            var defaultRewards = GetRichSampleRewards();
            SaveRewards(defaultRewards);
            return defaultRewards;
        }

        private static List<RewardItem> GetRichSampleRewards()
        {
            return new List<RewardItem>
            {
                new RewardItem("Khẩu trang y tế 4 lớp (50 cái)", 15, 50),
                new RewardItem("Chai Xịt khuẩn Hand Sanitizer 100ml", 30, 40),
                new RewardItem("Áo mưa cao cấp Pharmacy", 50, 25),
                new RewardItem("Voucher Giảm 50.000đ Tiền Thuốc", 50, 30),
                new RewardItem("Bình nước giữ nhiệt 500ml", 80, 15),
                new RewardItem("Voucher Giảm 100.000đ Tiền Thuốc", 100, 20),
                new RewardItem("Nồi chiên không dầu Lock&Lock", 250, 5),
                new RewardItem("Máy Đo Huyết Áp Điện Tử Omron", 300, 5)
            };
        }

        public static void SaveRewards(List<RewardItem> rewards)
        {
            try
            {
                string json = JsonSerializer.Serialize(rewards, Options);
                File.WriteAllText(RewardsFile, json);
            }
            catch { }
        }

        // ===================== HÓA ĐƠN / LỊCH SỬ MUA HÀNG (40 Hóa Đơn Mẫu) =====================
        public static List<Invoice> LoadInvoices()
        {
            try
            {
                if (File.Exists(InvoicesFile))
                {
                    string json = File.ReadAllText(InvoicesFile);
                    var list = JsonSerializer.Deserialize<List<Invoice>>(json, Options);
                    if (list != null && list.Count >= 5) return list;
                }
            }
            catch { }

            var defaultInvoices = GetRichSampleInvoices();
            SaveInvoices(defaultInvoices);
            return defaultInvoices;
        }

        private static List<Invoice> GetRichSampleInvoices()
        {
            List<Invoice> list = new List<Invoice>();
            DateTime now = DateTime.Now;
            var custs = GetRichSampleCustomers();
            var meds = GetRichSampleMedicines();

            for (int i = 1; i <= 40; i++)
            {
                var cust = custs[(i - 1) % custs.Count];
                var m1 = meds[(i * 3) % meds.Count];
                var m2 = meds[(i * 7) % meds.Count];

                int qty1 = (i % 3) + 1;
                int qty2 = (i % 2) + 1;

                float total = (m1.Price * qty1) + (m2.Price * qty2);
                int points = (int)(total / 1000);

                DateTime date = now.AddDays(-((i - 1) % 60)).AddHours(-((i * 4) % 12));
                string invId = "HD" + date.ToString("yyyyMMdd") + i.ToString("D3");

                CartItem item1 = new CartItem(m1.Name, m1.Price, qty1);
                CartItem item2 = new CartItem(m2.Name, m2.Price, qty2);

                list.Add(new Invoice(invId, cust.NumPhone, cust.Name, date, new List<CartItem> { item1, item2 }, total, points));
            }

            return list;
        }

        public static void SaveInvoices(List<Invoice> invoices)
        {
            try
            {
                string json = JsonSerializer.Serialize(invoices, Options);
                File.WriteAllText(InvoicesFile, json);
            }
            catch { }
        }
    }
}
