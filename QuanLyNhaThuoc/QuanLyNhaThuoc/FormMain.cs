using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class FormMain : Form
    {
        private List<Medicine> medicines = new List<Medicine>();
        private List<Customer> customers = new List<Customer>();
        private List<CartItem> buyings = new List<CartItem>();
        private List<RewardItem> rewards = new List<RewardItem>();
        private List<Invoice> invoices = new List<Invoice>();
        private int pointRate = 1000; // Mặc định 1.000 VNĐ = 1 điểm tích lũy

        public FormMain()
        {
            InitializeComponent();

            register.Enabled = false;
            addProduct.Enabled = false;
            calc.Enabled = false;

            invoices = DataManager.LoadInvoices();
            customers = DataManager.LoadCustomers();
            medicines = DataManager.LoadMedicines();
            rewards = DataManager.LoadRewards();

            if (customers.Count < 20 || medicines.Count < 15 || invoices.Count < 20)
            {
                DataManager.GenerateRichSampleDataIfEmpty();
                invoices = DataManager.LoadInvoices();
                customers = DataManager.LoadCustomers();
                medicines = DataManager.LoadMedicines();
                rewards = DataManager.LoadRewards();
            }

            if (cboUnit.Items.Count > 0 && cboUnit.SelectedIndex < 0) cboUnit.SelectedIndex = 0;
            ShowAllCustomers();
            LoadLeaderboard();
            CapNhatComboboxThuoc();
            CapNhatComboboxQua();

            menuPro.DataSource = buyings;
            FormatCartGridHeaders();

            proBox.DropDownStyle = ComboBoxStyle.DropDown;
            proBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            proBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            proBox.KeyDown += proBox_KeyDown;
            nudQuantity.KeyDown += nudQuantity_KeyDown;

            SetupContextMenu();
            KhoiTaoComboboxBaoCao();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormatCartGridHeaders();
            FormatCustomerGridHeaders();
            FormatLeaderboardHeaders();
            CapNhatBaoCaoThang();
        }

        private void FormatCustomerGridHeaders()
        {
            if (customer.Columns["Name"] != null) customer.Columns["Name"].HeaderText = "Họ Và Tên Khách Hàng";
            if (customer.Columns["NumPhone"] != null) customer.Columns["NumPhone"].HeaderText = "Số Điện Thoại";
            if (customer.Columns["Point"] != null) customer.Columns["Point"].HeaderText = "Điểm Tích Lũy";
        }

        private void FormatLeaderboardHeaders()
        {
            if (leaderboard.Columns["Name"] != null) leaderboard.Columns["Name"].HeaderText = "Họ Và Tên Khách VIP";
            if (leaderboard.Columns["NumPhone"] != null) leaderboard.Columns["NumPhone"].HeaderText = "Số Điện Thoại";
            if (leaderboard.Columns["Point"] != null) leaderboard.Columns["Point"].HeaderText = "Điểm Tích Lũy";
        }

        private void FormatCartGridHeaders()
        {
            if (menuPro.Columns["Name"] != null) menuPro.Columns["Name"].HeaderText = "Tên Thuốc";
            if (menuPro.Columns["Price"] != null) menuPro.Columns["Price"].HeaderText = "Đơn Giá (VNĐ)";
            if (menuPro.Columns["SelectedUnit"] != null) menuPro.Columns["SelectedUnit"].HeaderText = "Đơn Vị Tính";
            if (menuPro.Columns["Quantity"] != null) menuPro.Columns["Quantity"].HeaderText = "Số Lượng";
            if (menuPro.Columns["TotalPrice"] != null) menuPro.Columns["TotalPrice"].HeaderText = "Thành Tiền (VNĐ)";
        }

        private void ShowAllCustomers()
        {
            customer.DataSource = null;
            customer.DataSource = customers;
            FormatCustomerGridHeaders();
        }

        // --- TRA CỨU TỰ ĐỘNG REAL-TIME KHI GÕ (BỎ NÚT TRA CỨU) ---
        private void sdtBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput_Register();
            CheckInput_Calc();
            ThucHienTimKiemRealtime();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput_Register();
            CheckInput_Calc();
            ThucHienTimKiemRealtime();
        }

        private void ThucHienTimKiemRealtime()
        {
            string sdtStr = sdtBox.Text.Trim();
            string nameStr = nameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdtStr) && string.IsNullOrWhiteSpace(nameStr))
            {
                ShowAllCustomers();
                txtEditPoint.Text = "0";
                return;
            }

            var dsMatch = customers.Where(x =>
                (string.IsNullOrWhiteSpace(sdtStr) || x.NumPhone.Contains(sdtStr, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(nameStr) || x.Name.Contains(nameStr, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            customer.DataSource = null;
            customer.DataSource = dsMatch;
            FormatCustomerGridHeaders();

            if (dsMatch.Count == 1)
            {
                txtEditPoint.Text = dsMatch[0].Point.ToString();
            }
            else
            {
                Customer? exact = dsMatch.FirstOrDefault(x => x.NumPhone.Equals(sdtStr, StringComparison.OrdinalIgnoreCase));
                if (exact != null)
                {
                    txtEditPoint.Text = exact.Point.ToString();
                }
            }
        }

        private void CheckInput_Register()
        {
            register.Enabled = !string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(sdtBox.Text);
        }

        private void CheckInput_Product()
        {
            try
            {
                string text = (proBox.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    addProduct.Enabled = false;
                    return;
                }

                addProduct.Enabled = medicines.Any(x => x.Name.Equals(text, StringComparison.OrdinalIgnoreCase) || x.ToString().Equals(text, StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                addProduct.Enabled = false;
            }
        }

        private void CheckInput_Calc()
        {
            calc.Enabled = buyings.Count > 0;
        }

        private void proBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput_Product();
        }

        private void proBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (addProduct.Enabled) addPro_Click(sender, e);
                else nudQuantity.Focus();
            }
        }

        private void nudQuantity_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (addProduct.Enabled) addPro_Click(sender, e);
            }
        }

        private void UpdateTotal()
        {
            float totalMoney = buyings.Sum(x => x.TotalPrice);
            money.Text = $"{totalMoney:N0}đ";

            int totalPoint = (int)(totalMoney / pointRate);
            points.Text = totalPoint.ToString();
        }

        private void addPro_Click(object? sender, EventArgs e)
        {
            string name = proBox.Text.Trim();
            int qty = (int)nudQuantity.Value;
            string selectedUnit = cboUnit.SelectedItem?.ToString() ?? "Hộp";

            Medicine? medicine = medicines.FirstOrDefault(x =>
                x.Name.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                x.ToString().Equals(name, StringComparison.OrdinalIgnoreCase)
            );

            if (medicine == null)
            {
                MessageBox.Show("Vui lòng chọn một thuốc hợp lệ từ danh sách kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float unitPrice = medicine.GetPriceByUnit(selectedUnit);

            // Trừ số lượng tồn kho thuốc (1 Hộp)
            medicine.StockQuantity -= 1;

            CartItem? existingItem = buyings.FirstOrDefault(x => x.Name.Equals(medicine.Name, StringComparison.OrdinalIgnoreCase) && x.SelectedUnit.Equals(selectedUnit, StringComparison.OrdinalIgnoreCase));
            if (existingItem != null)
            {
                existingItem.Quantity += qty;
            }
            else
            {
                buyings.Add(new CartItem(medicine.Name, unitPrice, qty, selectedUnit));
            }

            menuPro.DataSource = null;
            menuPro.DataSource = buyings;
            FormatCartGridHeaders();

            DataManager.SaveMedicines(medicines);
            CapNhatComboboxThuoc();

            UpdateTotal();
            CheckInput_Calc();

            proBox.Text = "";
            nudQuantity.Value = 1;
            proBox.Focus();
        }

        private void LoadLeaderboard()
        {
            var ranking = customers.OrderByDescending(x => x.Point).ToList();
            leaderboard.DataSource = null;
            leaderboard.DataSource = ranking;
            FormatLeaderboardHeaders();
        }

        private int GetCurrentPoint()
        {
            float totalMoney = buyings.Sum(x => x.TotalPrice);
            return (int)(totalMoney / pointRate);
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (buyings.Count == 0)
            {
                MessageBox.Show("Chưa có thuốc nào trong đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdtStr = sdtBox.Text.Trim();
            string nameStr = nameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdtStr) || string.IsNullOrWhiteSpace(nameStr))
            {
                FormCustomerChoice choiceForm = new FormCustomerChoice();
                choiceForm.ShowDialog();

                if (choiceForm.SelectedMode == CustomerChoiceMode.NewCustomer)
                {
                    string newSdt = Microsoft.VisualBasic.Interaction.InputBox("Nhập SỐ ĐIỆN THOẠI khách hàng mới:", "Đăng Ký Khách Mới", sdtStr);
                    if (string.IsNullOrWhiteSpace(newSdt)) return;

                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Nhập HỌ VÀ TÊN khách hàng mới:", "Đăng Ký Khách Mới", nameStr);
                    if (string.IsNullOrWhiteSpace(newName)) return;

                    sdtBox.Text = newSdt;
                    nameBox.Text = newName;
                    sdtStr = newSdt.Trim();
                    nameStr = newName.Trim();
                }
                else if (choiceForm.SelectedMode == CustomerChoiceMode.ExistingCustomer)
                {
                    tabCustomer.SelectedTab = tabList;
                    MessageBox.Show("Vui lòng chọn khách hàng trong danh sách ở khung bên phải hoặc nhập SĐT!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sdtBox.Focus();
                    return;
                }
                else if (choiceForm.SelectedMode == CustomerChoiceMode.GuestCheckout)
                {
                    sdtBox.Text = "0000000000";
                    nameBox.Text = "Khách Vãng Lai";
                    sdtStr = "0000000000";
                    nameStr = "Khách Vãng Lai";
                }
                else
                {
                    return; // Cancel
                }
            }

            int newPoint = GetCurrentPoint();
            if (sdtStr == "0000000000") newPoint = 0; // Khách vãng lai không tích điểm

            Customer? customerFound = customers.FirstOrDefault(x => x.NumPhone == sdtStr);

            if (customerFound != null)
            {
                if (customerFound.NumPhone != "0000000000")
                {
                    customerFound.Point += newPoint;
                }

                float totalMoney = buyings.Sum(x => x.TotalPrice);
                string invId = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                Invoice inv = new Invoice(invId, customerFound.NumPhone, customerFound.Name, DateTime.Now, new List<CartItem>(buyings), totalMoney, newPoint);
                invoices.Add(inv);

                DataManager.SaveInvoices(invoices);
                DataManager.SaveCustomers(customers);

                string thongBao = customerFound.NumPhone == "0000000000"
                    ? $"THANH TOÁN THÀNH CÔNG (KHÁCH VÃNG LAI)!\n\n" +
                      $"• Tổng tiền: {totalMoney:N0}đ\n" +
                      $"• Đã lưu hóa đơn {invId}!"
                    : $"THANH TOÁN THÀNH CÔNG!\n\n" +
                      $"• Khách hàng: {customerFound.Name}\n" +
                      $"• SĐT: {customerFound.NumPhone}\n" +
                      $"• Tổng tiền: {totalMoney:N0}đ\n" +
                      $"• Điểm tích lũy nhận được: +{newPoint} điểm\n" +
                      $"• Tổng điểm hiện tại: {customerFound.Point} điểm\n\n" +
                      $"• Đã lưu hóa đơn {invId}!";

                MessageBox.Show(thongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowAllCustomers();
                LoadLeaderboard();
                CapNhatBaoCaoThang();
                ClearBill();
                return;
            }

            // Đăng ký khách hàng mới hoàn toàn
            Customer newCustomer = new Customer(nameStr, sdtStr, newPoint);
            customers.Add(newCustomer);

            float moneyTotal = buyings.Sum(x => x.TotalPrice);
            string idInv = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Invoice invoiceNew = new Invoice(idInv, newCustomer.NumPhone, newCustomer.Name, DateTime.Now, new List<CartItem>(buyings), moneyTotal, newPoint);
            invoices.Add(invoiceNew);

            DataManager.SaveInvoices(invoices);
            DataManager.SaveCustomers(customers);

            ShowAllCustomers();
            LoadLeaderboard();
            CapNhatBaoCaoThang();

            MessageBox.Show(
                $"ĐÃ ĐĂNG KÝ KHÁCH MỚI VÀ TÍCH ĐIỂM THÀNH CÔNG!\n\n" +
                $"• Họ tên: {nameStr}\n" +
                $"• SĐT: {sdtStr}\n" +
                $"• Điểm tích lũy: {newPoint} điểm\n\n" +
                $"• Đã lưu hóa đơn {idInv}!",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            ClearBill();
        }

        private void ClearBill()
        {
            buyings.Clear();
            menuPro.DataSource = null;
            menuPro.DataSource = buyings;
            FormatCartGridHeaders();

            money.Text = "0đ";
            points.Text = "0";
            proBox.Text = "";
            sdtBox.Clear();
            nameBox.Clear();
            txtEditPoint.Clear();
            CheckInput_Calc();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string sdtStr = sdtBox.Text.Trim();
            string hoTen = nameBox.Text.Trim();

            if (!Regex.IsMatch(sdtStr, @"^0\d{8,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdtBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameBox.Focus();
                return;
            }

            if (customers.Any(x => x.NumPhone == sdtStr))
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdtBox.Focus();
                return;
            }

            Customer customerNew = new Customer(hoTen, sdtStr, 0);
            customers.Add(customerNew);
            DataManager.SaveCustomers(customers);

            ShowAllCustomers();
            LoadLeaderboard();
            CapNhatBaoCaoThang();

            MessageBox.Show("Đăng ký khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sdtBox.Clear();
            nameBox.Clear();
        }

        private void customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= customer.Rows.Count) return;

            DataGridViewRow row = customer.Rows[e.RowIndex];
            if (row.DataBoundItem is Customer cust)
            {
                nameBox.Text = cust.Name;
                sdtBox.Text = cust.NumPhone;
                txtEditPoint.Text = cust.Point.ToString();
            }
        }

        private void OpenEditCustomerDialog()
        {
            string sdtStr = sdtBox.Text.Trim();
            Customer? targetCust = customers.FirstOrDefault(x => x.NumPhone == sdtStr);

            if (targetCust == null && customer.SelectedRows.Count > 0)
                targetCust = customer.SelectedRows[0].DataBoundItem as Customer;

            if (targetCust == null && leaderboard.SelectedRows.Count > 0)
                targetCust = leaderboard.SelectedRows[0].DataBoundItem as Customer;

            if (targetCust == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập SĐT khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormEditCustomer editForm = new FormEditCustomer(targetCust, customers);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                sdtBox.Text = targetCust.NumPhone;
                nameBox.Text = targetCust.Name;
                txtEditPoint.Text = targetCust.Point.ToString();

                DataManager.SaveCustomers(customers);
                ShowAllCustomers();
                LoadLeaderboard();

                MessageBox.Show($"Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenCustomerHistory()
        {
            string sdtStr = sdtBox.Text.Trim();
            Customer? targetCust = customers.FirstOrDefault(x => x.NumPhone == sdtStr);

            if (targetCust == null && customer.SelectedRows.Count > 0)
                targetCust = customer.SelectedRows[0].DataBoundItem as Customer;

            if (targetCust == null && leaderboard.SelectedRows.Count > 0)
                targetCust = leaderboard.SelectedRows[0].DataBoundItem as Customer;

            if (targetCust == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xem lịch sử mua hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormHistory historyForm = new FormHistory(targetCust, invoices);
            historyForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenEditCustomerDialog();
        }

        private void SetupContextMenu()
        {
            ContextMenuStrip cmsCust = new ContextMenuStrip();
            ToolStripMenuItem tsmiHistory = new ToolStripMenuItem("Xem lịch sử mua hàng của khách hàng này");
            ToolStripMenuItem tsmiEdit = new ToolStripMenuItem("Chỉnh sửa tên / SĐT khách hàng");
            ToolStripMenuItem tsmiDelete = new ToolStripMenuItem("Xóa khách hàng này");

            tsmiHistory.Click += (s, e) => OpenCustomerHistory();
            tsmiEdit.Click += (s, e) => OpenEditCustomerDialog();
            tsmiDelete.Click += TsmiDelete_Click;

            cmsCust.Items.Add(tsmiHistory);
            cmsCust.Items.Add(tsmiEdit);
            cmsCust.Items.Add(new ToolStripSeparator());
            cmsCust.Items.Add(tsmiDelete);

            customer.ContextMenuStrip = cmsCust;
            leaderboard.ContextMenuStrip = cmsCust;

            // Context menu cho giỏ hàng (menuPro)
            ContextMenuStrip cmsCart = new ContextMenuStrip();
            ToolStripMenuItem tsmiDetail = new ToolStripMenuItem("Xem thông tin & Chỉnh sửa thuốc");
            ToolStripMenuItem tsmiRemoveCart = new ToolStripMenuItem("Xóa thuốc khỏi đơn hàng");

            tsmiDetail.Click += (s, e) => OpenEditCartItemDialog();
            tsmiRemoveCart.Click += (s, e) => XoaThuocKhoiGioHang();

            cmsCart.Items.Add(tsmiDetail);
            cmsCart.Items.Add(new ToolStripSeparator());
            cmsCart.Items.Add(tsmiRemoveCart);

            menuPro.ContextMenuStrip = cmsCart;
            menuPro.CellMouseDoubleClick += MenuPro_CellMouseDoubleClick;
        }

        private void MenuPro_CellMouseDoubleClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < buyings.Count)
            {
                OpenEditCartItemDialog(e.RowIndex);
            }
        }

        private CartItem? GetSelectedCartItem(int rowIndex = -1)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < buyings.Count)
                {
                    return buyings[rowIndex];
                }
                if (menuPro.SelectedRows.Count > 0 && menuPro.SelectedRows[0].Index >= 0 && menuPro.SelectedRows[0].Index < buyings.Count)
                {
                    return buyings[menuPro.SelectedRows[0].Index];
                }
                if (menuPro.CurrentRow != null && menuPro.CurrentRow.Index >= 0 && menuPro.CurrentRow.Index < buyings.Count)
                {
                    return buyings[menuPro.CurrentRow.Index];
                }
            }
            catch { }
            return null;
        }

        private void OpenEditCartItemDialog(int rowIndex = -1)
        {
            CartItem? item = GetSelectedCartItem(rowIndex);
            if (item == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc trong giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medicine? med = medicines.FirstOrDefault(x => x.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));

            FormEditCartItem editForm = new FormEditCartItem(item, med);
            DialogResult res = editForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                menuPro.DataSource = null;
                menuPro.DataSource = buyings;
                FormatCartGridHeaders();
                UpdateTotal();
            }
            else if (res == DialogResult.Yes)
            {
                if (med != null)
                {
                    med.StockQuantity += 1;
                }

                buyings.Remove(item);
                menuPro.DataSource = null;
                menuPro.DataSource = buyings;
                FormatCartGridHeaders();

                UpdateTotal();
                CheckInput_Calc();
            }
        }

        private void XoaThuocKhoiGioHang()
        {
            CartItem? item = GetSelectedCartItem();
            if (item == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{item.Name}' khỏi đơn hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Medicine? med = medicines.FirstOrDefault(x => x.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
                if (med != null)
                {
                    med.StockQuantity += 1;
                }

                buyings.Remove(item);
                menuPro.DataSource = null;
                menuPro.DataSource = buyings;

                UpdateTotal();
                CheckInput_Calc();
                MessageBox.Show($"Đã xóa '{item.Name}' khỏi đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TsmiDelete_Click(object? sender, EventArgs e)
        {
            string sdtStr = sdtBox.Text.Trim();
            string nameStr = nameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdtStr))
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng {nameStr} (SĐT: {sdtStr})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                customers.RemoveAll(x => x.NumPhone == sdtStr);
                DataManager.SaveCustomers(customers);

                ShowAllCustomers();
                LoadLeaderboard();
                CapNhatBaoCaoThang();

                sdtBox.Clear();
                nameBox.Clear();
                txtEditPoint.Clear();

                MessageBox.Show($"Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CapNhatComboboxThuoc()
        {
            proBox.Items.Clear();
            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            foreach (var m in medicines)
            {
                proBox.Items.Add(m.ToString());
                autoSource.Add(m.Name);
                autoSource.Add(m.ToString());
            }
            proBox.AutoCompleteCustomSource = autoSource;
        }

        private void CapNhatComboboxQua()
        {
            cboRewards.DataSource = null;
            cboRewards.DataSource = rewards;
            cboRewards.DisplayMember = "ToString";
            if (cboRewards.Items.Count > 0) cboRewards.SelectedIndex = 0;
        }

        private void btnConfigRate_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập số tiền VNĐ cần có để đổi được 1 điểm tích lũy:\n(Ví dụ: 1000 = 1.000 VNĐ được 1 điểm)",
                "Cấu hình tỷ lệ tích điểm",
                pointRate.ToString()
            );

            if (int.TryParse(input, out int rateMoi) && rateMoi > 0)
            {
                pointRate = rateMoi;
                MessageBox.Show($"Đã cập nhật quy tắc tích điểm mới:\n• {pointRate:N0} VNĐ tiền thuốc = 1 Điểm tích lũy", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTotal();
            }
        }

        private void btnRedeemReward_Click(object sender, EventArgs e)
        {
            string sdtStr = sdtBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdtStr))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập SĐT khách hàng đổi quà!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sdtBox.Focus();
                return;
            }

            Customer? cust = customers.FirstOrDefault(x => x.NumPhone == sdtStr);
            if (cust == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RewardItem? reward = cboRewards.SelectedItem as RewardItem;
            if (reward == null)
            {
                MessageBox.Show("Vui lòng chọn quà cần đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (reward.StockQuantity <= 0)
            {
                MessageBox.Show(
                    $"QUÀ ĐÃ HẾT TỒN KHO!\n\n" +
                    $"Phần quà '{reward.Name}' đã hết trong kho quà (Tồn: 0 phần).\n" +
                    $"Vui lòng nhập thêm tồn kho quà!",
                    "Cảnh báo tồn kho",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (cust.Point < reward.PointsRequired)
            {
                MessageBox.Show(
                    $"Không đủ điểm đổi quà!\n\n" +
                    $"Khách hàng {cust.Name} có: {cust.Point} điểm.\n" +
                    $"Cần: {reward.PointsRequired} điểm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            cust.Point -= reward.PointsRequired;
            reward.StockQuantity -= 1;

            txtEditPoint.Text = cust.Point.ToString();

            DataManager.SaveCustomers(customers);
            DataManager.SaveRewards(rewards);

            ShowAllCustomers();
            LoadLeaderboard();
            CapNhatComboboxQua();
            CapNhatBaoCaoThang();

            MessageBox.Show(
                $"ĐỔI QUÀ THÀNH CÔNG!\n\n" +
                $"• Khách hàng: {cust.Name}\n" +
                $"• Phần quà: {reward.Name}\n" +
                $"• Đã trừ: -{reward.PointsRequired} điểm\n" +
                $"• Số quà còn lại trong kho: {reward.StockQuantity} phần\n" +
                $"• Điểm dư còn lại: {cust.Point} điểm",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnManageRewards_Click(object sender, EventArgs e)
        {
            FormRewardManager rewardForm = new FormRewardManager(rewards, () =>
            {
                DataManager.SaveRewards(rewards);
                CapNhatComboboxQua();
                CapNhatBaoCaoThang();
            });
            rewardForm.ShowDialog();
        }

        // --- BÁO CÁO THỐNG KÊ THEO THÁNG & NĂM HIỆN TẠI ---
        private void KhoiTaoComboboxBaoCao()
        {
            cboMonth.Items.Clear();
            for (int m = 1; m <= 12; m++) cboMonth.Items.Add($"Tháng {m}");
            cboMonth.SelectedIndex = DateTime.Now.Month - 1;

            cboYear.Items.Clear();
            int curYear = DateTime.Now.Year;
            for (int y = curYear - 2; y <= curYear + 2; y++) cboYear.Items.Add(y.ToString());
            cboYear.SelectedItem = curYear.ToString();
        }

        private void CapNhatBaoCaoThang()
        {
            if (cboMonth.SelectedIndex < 0 || cboYear.SelectedItem == null) return;

            int selMonth = cboMonth.SelectedIndex + 1;
            if (!int.TryParse(cboYear.SelectedItem.ToString(), out int selYear)) selYear = DateTime.Now.Year;

            var dsHDLoc = invoices.Where(x => x.PurchaseDate.Month == selMonth && x.PurchaseDate.Year == selYear).ToList();

            float tongDoanhThu = dsHDLoc.Sum(x => x.TotalAmount);
            int tongSoLuongThuocBan = dsHDLoc.Sum(x => x.Items != null ? x.Items.Sum(i => i.Quantity) : 0);

            // Top thuốc bán chạy
            Dictionary<string, int> dictThuoc = new Dictionary<string, int>();
            foreach (var inv in dsHDLoc)
            {
                if (inv.Items == null) continue;
                foreach (var item in inv.Items)
                {
                    if (!dictThuoc.ContainsKey(item.Name)) dictThuoc[item.Name] = 0;
                    dictThuoc[item.Name] += item.Quantity;
                }
            }
            var topThuoc = dictThuoc.OrderByDescending(x => x.Value).Take(5).ToList();

            // Điểm tích lũy KH
            int tongDiemKH = customers.Sum(x => x.Point);
            int t1 = customers.Count(x => x.Point < 50);
            int t2 = customers.Count(x => x.Point >= 50 && x.Point < 150);
            int t3 = customers.Count(x => x.Point >= 150 && x.Point < 300);
            int t4 = customers.Count(x => x.Point >= 300);

            int tongTonQua = rewards.Sum(x => x.StockQuantity);

            rtbAnalytics.Clear();
            rtbAnalytics.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            rtbAnalytics.AppendText($"BÁO CÁO NHÀ THUỐC THÁNG {selMonth}/{selYear}\n");
            rtbAnalytics.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Regular);
            rtbAnalytics.AppendText($"• Tổng doanh thu: {tongDoanhThu:N0}đ ({dsHDLoc.Count} đơn)\n");
            rtbAnalytics.AppendText($"• Tổng số lượng thuốc đã bán: {tongSoLuongThuocBan} sản phẩm\n\n");

            rtbAnalytics.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            rtbAnalytics.AppendText("TOP THUỐC BÁN CHẠY NHẤT:\n");
            rtbAnalytics.SelectionFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            if (topThuoc.Count == 0)
            {
                rtbAnalytics.AppendText("   (Chưa có dữ liệu bán thuốc tháng này)\n");
            }
            else
            {
                for (int i = 0; i < topThuoc.Count; i++)
                {
                    rtbAnalytics.AppendText($" #{i + 1} {topThuoc[i].Key}: {topThuoc[i].Value} sản phẩm\n");
                }
            }

            rtbAnalytics.AppendText("\n");
            rtbAnalytics.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            rtbAnalytics.AppendText("PHÂN LỚP ĐIỂM KHÁCH HÀNG & QUÀ TẶNG:\n");
            rtbAnalytics.SelectionFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            rtbAnalytics.AppendText($"• Tổng điểm tích lũy hiện có: {tongDiemKH} điểm ({customers.Count} KH)\n");
            rtbAnalytics.AppendText($"• Mức <50đ: {t1} KH | 50-150đ: {t2} KH\n");
            rtbAnalytics.AppendText($"• Mức 150-300đ: {t3} KH | >300đ: {t4} KH\n");
            rtbAnalytics.AppendText($"• Tồn kho quà hiện tại: {tongTonQua} phần quà\n");

            if (tongTonQua < (t2 + t3 + t4))
            {
                rtbAnalytics.SelectionFont = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                rtbAnalytics.AppendText($"• CẢNH BÁO: Ước tính cần nhập thêm {(t2 + t3 + t4) - tongTonQua} quà để đáp ứng nhu cầu đổi điểm!");
            }
            else
            {
                rtbAnalytics.SelectionFont = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                rtbAnalytics.AppendText("• Tồn kho quà đủ phục vụ khách đổi điểm!");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e) => CapNhatBaoCaoThang();
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e) => CapNhatBaoCaoThang();
        private void btnRefreshAnalytics_Click(object sender, EventArgs e) => CapNhatBaoCaoThang();
    }
}
