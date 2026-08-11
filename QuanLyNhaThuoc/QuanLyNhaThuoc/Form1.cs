using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
namespace QuanLyNhaThuoc
{
    public partial class Form1 : Form
    {

        List<Medicine> medicines = new List<Medicine>();
        List<Customer> customers = new List<Customer>();
        List<Medicine> buyings = new List<Medicine>();


        public Form1()
        {
            InitializeComponent();

            find.Enabled = false;
            register.Enabled = false;
            addProduct.Enabled = false;
            calc.Enabled = false;

            LoadCustomers();
            LoadLeaderboard();
            LoadMedicines();

            menuPro.DataSource = buyings;
            customer.DataSource = customers;

            proBox.DropDownStyle = ComboBoxStyle.DropDown;
            proBox.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void ShowAllCustomers()
        {
            customer.DataSource = null;
            customer.DataSource = customers;
        }

        private void sdtBox_TextChanged(object sender, EventArgs e)
        {
            find.Enabled = !string.IsNullOrWhiteSpace(sdtBox.Text);
            CheckInput_Register();
            CheckInput_Calc();

            if (string.IsNullOrWhiteSpace(sdtBox.Text))
            {
                ShowAllCustomers();
            }

        }
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput_Register();
            find.Enabled = !string.IsNullOrWhiteSpace(nameBox.Text);
            CheckInput_Calc();
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                ShowAllCustomers();
            }

        }
        private void CheckInput_Register()
        {
            register.Enabled =
                !string.IsNullOrWhiteSpace(nameBox.Text) &&
                !string.IsNullOrWhiteSpace(sdtBox.Text);
        }

        private void CheckInput_Product()
        {
            addProduct.Enabled =
                !string.IsNullOrWhiteSpace(proBox.Text) &&
                medicines.Any(x =>
                    x.Name.Equals(
                        proBox.Text.Trim(),
                        StringComparison.OrdinalIgnoreCase));
        }
        private void CheckInput_Calc()
        {
            calc.Enabled =
                !string.IsNullOrWhiteSpace(sdtBox.Text) &&
                !string.IsNullOrWhiteSpace(nameBox.Text) &&
                buyings.Count > 0;
        }
        private void proBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput_Product();
            
        }
        private void proBox_TextUpdate(object sender, EventArgs e)
        {
            string text = proBox.Text;

            var result = medicines
                .Where(x => x.Name.Contains(
                    text,
                    StringComparison.OrdinalIgnoreCase))
                .Take(10)
                .ToList();

            proBox.Items.Clear();

            foreach (Medicine medicine in result)
            {
                proBox.Items.Add(medicine.Name);
            }

            proBox.Text = text;
            proBox.SelectionStart = text.Length;

            if (result.Count > 0 && !string.IsNullOrWhiteSpace(text))
            {
                proBox.DroppedDown = true;
            }

            CheckInput_Product();
        }
        private void proBox_DropDown(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(proBox.Text))
            {
                proBox.Items.Clear();

                foreach (Medicine medicine in medicines.Take(10))
                {
                    proBox.Items.Add(medicine.Name);
                }
            }
        }
        private void UpdateTotal()
        {
            float totalMoney = buyings.Sum(x => x.Price);

            money.Text = $"{totalMoney:N0}đ";

            int totalPoint = (int)(totalMoney / 1000);

            points.Text = totalPoint.ToString();
        }

        private void addPro_Click(object sender, EventArgs e)
        {
            string name = proBox.Text.Trim();

            Medicine? medicine = medicines.FirstOrDefault(
                x => x.Name.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase)
            );

            if (medicine == null)
            {
                MessageBox.Show("Vui lòng chọn một thuốc hợp lệ!");
                return;
            }

            buyings.Add(medicine);

            menuPro.DataSource = null;
            menuPro.DataSource = buyings;

            UpdateTotal();
            CheckInput_Calc();

            proBox.Text = "";
        }
        private void find_Click(object sender, EventArgs e)
        {
            string sdt = sdtBox.Text.Trim();
            string name = nameBox.Text.Trim();

            var result = customers.Where(x =>
                (string.IsNullOrWhiteSpace(sdt) ||
                 x.NumPhone.Contains(sdt)) &&

                (string.IsNullOrWhiteSpace(name) ||
                 x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            customer.DataSource = null;
            customer.DataSource = result;
        }

        private void LoadLeaderboard()
        {
            var ranking = customers.OrderByDescending(x => x.Point).ToList();
            leaderboard.DataSource = null;
            leaderboard.DataSource = ranking;
        }

        private int GetCurrentPoint()
        {
            float totalMoney = buyings.Sum(x => x.Price);

            return (int)(totalMoney / 1000);
        }


        private void calc_Click(object sender, EventArgs e)
        {
            string sdt = sdtBox.Text.Trim();
            string name = nameBox.Text.Trim();

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ SĐT và Họ tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Kiểm tra có thuốc đang mua hay chưa
            if (buyings.Count == 0)
            {
                MessageBox.Show(
                    "Chưa có thuốc nào trong danh sách mua!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Tính điểm của hóa đơn hiện tại
            int newPoint = GetCurrentPoint();

            // Tìm khách hàng theo SĐT
            Customer? customerFound = customers.FirstOrDefault(
                x => x.NumPhone == sdt
            );

            // =========================
            // TRƯỜNG HỢP KHÁCH ĐÃ CÓ
            // =========================
            if (customerFound != null)
            {
                customerFound.Point += newPoint;

                MessageBox.Show(
                    $"Khách hàng: {customerFound.Name}\n" +
                    $"SĐT: {customerFound.NumPhone}\n\n" +
                    $"Điểm tích lũy thêm: {newPoint}\n" +
                    $"Tổng điểm hiện tại: {customerFound.Point}",
                    "Thanh toán thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Cập nhật bảng khách hàng
                customer.DataSource = null;
                customer.DataSource = customers;

                // Cập nhật bảng xếp hạng
                LoadLeaderboard();

                return;
            }

            // =========================
            // KHÁCH CHƯA CÓ
            // =========================

            DialogResult result = MessageBox.Show(
                $"Không tìm thấy khách hàng trong hệ thống.\n\n" +
                $"SĐT: {sdt}\n" +
                $"Họ tên: {name}\n\n" +
                $"Bạn có muốn đăng ký khách hàng mới không?",
                "Khách hàng mới",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Tạo khách hàng mới
                Customer newCustomer = new Customer(
                    name,
                    sdt,
                    newPoint
                );

                // Thêm vào danh sách
                customers.Add(newCustomer);

                // Cập nhật bảng khách hàng
                customer.DataSource = null;
                customer.DataSource = customers;

                // Cập nhật bảng xếp hạng
                LoadLeaderboard();

                MessageBox.Show(
                    $"Đã đăng ký khách hàng mới!\n\n" +
                    $"Họ tên: {name}\n" +
                    $"SĐT: {sdt}\n" +
                    $"Điểm tích lũy: {newPoint}",
                    "Đăng ký thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            ClearBill();
        }

        private void ClearBill()
        {
            buyings.Clear();

            menuPro.DataSource = null;
            menuPro.DataSource = buyings;

            money.Text = "0đ";
            points.Text = "0";

            proBox.Text = "";
        }

        private void register_Click(object sender, EventArgs e)
        {
            string sdt = sdtBox.Text.Trim();
            string hoTen = nameBox.Text.Trim();

            // Kiểm tra số điện thoại
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show(
                    "Số điện thoại phải có đúng 10 chữ số và đúng cú pháp!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                sdtBox.Focus();
                return;
            }

            // Kiểm tra họ tên
            if (!Regex.IsMatch(hoTen, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show(
                    "Họ và tên chỉ được chứa chữ cái và khoảng trắng!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nameBox.Focus();
                return;
            }

            // Kiểm tra số điện thoại đã tồn tại
            if (customers.Any(x => x.NumPhone == sdt))
            {
                MessageBox.Show(
                    "Số điện thoại này đã được đăng ký!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                sdtBox.Focus();
                return;
            }

            // Tạo khách hàng mới
            Customer customerNew = new Customer
            {
                Name = hoTen,
                NumPhone = sdt,
                Point = 0
            };

            customers.Add(customerNew);

            // Cập nhật DataGridView khách hàng
            customer.DataSource = null;
            customer.DataSource = customers;

            // Cập nhật bảng xếp hạng
            LoadLeaderboard();

            MessageBox.Show(
                "Đăng ký khách hàng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Xóa dữ liệu sau khi đăng ký
            sdtBox.Clear();
            nameBox.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }




        private void LoadMedicines()
        {
            string data = @"
            Paracetamol|2000
            Aspirin|1500
            Ibuprofen|3000
            Amoxicillin|5000
            Azithromycin|8000
            Cephalexin|6000
            Cefuroxime|10000
            Cefixime|12000
            Metformin|2500
            Glimepiride|4000
            Amlodipine|3000
            Losartan|3500
            Enalapril|2500
            Omeprazole|4000
            Esomeprazole|6000
            Lansoprazole|5000
            Pantoprazole|5500
            Domperidone|3000
            Smecta|5000
            Berocca|7000
            Vitamin C|2000
            Vitamin B1|1500
            Vitamin B6|1500
            Vitamin B12|2000
            Calcium|3000
            Magnesium|2500
            Kẽm|2000
            Sắt|3000
            Dầu cá Omega 3|5000
            Cetirizine|2500
            Loratadine|3000
            Fexofenadine|4000
            Chlorpheniramine|1500
            Salbutamol|2500
            Dextromethorphan|3000
            Guaifenesin|2500
            Acetylcysteine|4000
            Bromhexine|2500
            Ambroxol|3000
            Povidone Iodine|5000
            Oresol|3000
            Berberin|2000
            Than hoạt tính|2500
            Men tiêu hóa|3000
            Loperamide|2500
            Bisacodyl|2000
            Magnesi hydroxide|3000
            Diclofenac|3500
            Naproxen|4000
            Ketoprofen|4500
            ";

            string[] lines = data.Trim().Split('\n');

            foreach (string line in lines)
            {
                string[] parts = line.Trim().Split('|');

                if (parts.Length == 2 &&
                    float.TryParse(parts[1], out float price))
                {
                    medicines.Add(new Medicine(parts[0], price));
                }
            }
        }
        private void LoadCustomers()
        {
            customers.Add(new Customer("Nguyễn Văn An", "0901234567", 125));
            customers.Add(new Customer("Trần Thị Bình", "0912345678", 87));
            customers.Add(new Customer("Lê Văn Cường", "0923456789", 215));
            customers.Add(new Customer("Phạm Thị Dung", "0934567890", 56));
            customers.Add(new Customer("Hoàng Văn Đức", "0945678901", 178));
            customers.Add(new Customer("Vũ Thị Hoa", "0956789012", 320));
            customers.Add(new Customer("Đặng Văn Hùng", "0967890123", 42));
            customers.Add(new Customer("Bùi Thị Lan", "0978901234", 156));
            customers.Add(new Customer("Ngô Văn Minh", "0989012345", 93));
            customers.Add(new Customer("Đỗ Thị Ngọc", "0990123456", 267));
        }
    }
}
