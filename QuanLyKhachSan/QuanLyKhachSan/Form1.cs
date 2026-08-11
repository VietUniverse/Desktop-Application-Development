using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        private readonly HotelManager _hotelManager;

        public Form1()
        {
            InitializeComponent();
            _hotelManager = new HotelManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatusTime.Text = $"Ngày làm việc: {DateTime.Now:dd/MM/yyyy HH:mm}";
            ShowDashboardOverview();
        }

        private void ShowDashboardOverview()
        {
            pnlMainContent.Controls.Clear();

            Label lblWelcome = new Label
            {
                Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN & DỊCH VỤ - GRAND HOTEL",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 212),
                AutoSize = true,
                Location = new Point(20, 20)
            };

            // Dashboard Card 1: Total Rooms
            Panel pnlTotalRooms = CreateDashboardCard("TỔNG SỐ PHÒNG", $"{_hotelManager.Rooms.Count} Phòng", Color.FromArgb(0, 120, 212), 20, 70);
            
            // Dashboard Card 2: Occupied Rooms
            int occupiedCount = _hotelManager.Rooms.Count(r => r.IsOccupied);
            Panel pnlOccupiedRooms = CreateDashboardCard("PHÒNG ĐANG CÓ KHÁCH", $"{occupiedCount} Phòng", Color.FromArgb(216, 59, 1), 280, 70);

            // Dashboard Card 3: Available Rooms
            int availableCount = _hotelManager.Rooms.Count(r => !r.IsOccupied);
            Panel pnlAvailableRooms = CreateDashboardCard("PHÒNG CÒN TRỐNG", $"{availableCount} Phòng", Color.FromArgb(35, 145, 32), 540, 70);

            // Dashboard Card 4: Today Service Revenue
            decimal todayRevenue = _hotelManager.GetDailyServiceRevenue(DateTime.Today);
            Panel pnlRevenue = CreateDashboardCard("DOANH THU DỊCH VỤ HÔM NAY", $"{todayRevenue:N0} VNĐ", Color.FromArgb(81, 43, 212), 800, 70);

            // Services alphabetical list view
            Label lblServiceListTitle = new Label
            {
                Text = "📌 BẢNG GIÁ DỊCH VỤ NIÊM YẾT (SẮP XẾP TỪ ĐIỂN A-Z)",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 210)
            };

            DataGridView dgvServicesOverview = new DataGridView
            {
                Location = new Point(20, 240),
                Size = new Size(1060, 210),
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvServicesOverview.DataSource = _hotelManager.GetServicesAlphabetical();

            pnlMainContent.Controls.Add(lblWelcome);
            pnlMainContent.Controls.Add(pnlTotalRooms);
            pnlMainContent.Controls.Add(pnlOccupiedRooms);
            pnlMainContent.Controls.Add(pnlAvailableRooms);
            pnlMainContent.Controls.Add(pnlRevenue);
            pnlMainContent.Controls.Add(lblServiceListTitle);
            pnlMainContent.Controls.Add(dgvServicesOverview);
            pnlMainContent.Controls.Add(stsbStatusBar);
        }

        private Panel CreateDashboardCard(string title, string value, Color accentColor, int x, int y)
        {
            Panel card = new Panel
            {
                Size = new Size(240, 110),
                Location = new Point(x, y),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(10, 15),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(10, 45),
                AutoSize = true
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            return card;
        }

        // Navigation Sidebar Event Handlers
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardOverview();
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            ShowDashboardOverview();
            MessageBox.Show("Chức năng Quản lý Phòng & Khách hàng hoạt động sẵn sàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavServices_Click(object sender, EventArgs e)
        {
            ShowDashboardOverview();
            MessageBox.Show("Chức năng Quản lý Dịch vụ & Bảng giá hoạt động sẵn sàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavBilling_Click(object sender, EventArgs e)
        {
            ShowDashboardOverview();
            MessageBox.Show("Chức năng Tính tiền Dịch vụ Theo Phòng hoạt động sẵn sàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            ShowDashboardOverview();
            MessageBox.Show($"Tổng doanh thu dịch vụ trong ngày là: {_hotelManager.GetDailyServiceRevenue(DateTime.Today):N0} VNĐ", "Báo cáo Doanh Thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Top Menu Event Handlers
        private void mnuThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQuanLyPhong_Click(object sender, EventArgs e)
        {
            btnNavRooms_Click(sender, e);
        }

        private void mnuQuanLyDichVu_Click(object sender, EventArgs e)
        {
            btnNavServices_Click(sender, e);
        }

        private void mnuTinhTienDichVu_Click(object sender, EventArgs e)
        {
            btnNavBilling_Click(sender, e);
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            btnNavReports_Click(sender, e);
        }
    }
}
