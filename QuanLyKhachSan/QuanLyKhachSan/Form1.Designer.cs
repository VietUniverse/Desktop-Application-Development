namespace QuanLyKhachSan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mstMainMenu = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuThoatToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLyPhong = new ToolStripMenuItem();
            mnuQuanLyDichVu = new ToolStripMenuItem();
            mnuTinhTienDichVu = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            pnlSidebar = new Panel();
            btnNavReports = new Button();
            btnNavBilling = new Button();
            btnNavServices = new Button();
            btnNavRooms = new Button();
            btnNavDashboard = new Button();
            pnlMainContent = new Panel();
            stsbStatusBar = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            
            mstMainMenu.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMainContent.SuspendLayout();
            stsbStatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // mstMainMenu
            // 
            mstMainMenu.ImageScalingSize = new Size(20, 20);
            mstMainMenu.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, báoCáoToolStripMenuItem, trợGiúpToolStripMenuItem });
            mstMainMenu.Location = new Point(0, 0);
            mstMainMenu.Name = "mstMainMenu";
            mstMainMenu.Size = new Size(1456, 28);
            mstMainMenu.TabIndex = 0;
            mstMainMenu.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThoatToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuThoatToolStripMenuItem
            // 
            mnuThoatToolStripMenuItem.Name = "mnuThoatToolStripMenuItem";
            mnuThoatToolStripMenuItem.Size = new Size(201, 26);
            mnuThoatToolStripMenuItem.Text = "Thoát Ứng Dụng";
            mnuThoatToolStripMenuItem.Click += mnuThoatToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyPhong, mnuQuanLyDichVu, mnuTinhTienDichVu });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuQuanLyPhong
            // 
            mnuQuanLyPhong.Name = "mnuQuanLyPhong";
            mnuQuanLyPhong.Size = new Size(295, 26);
            mnuQuanLyPhong.Text = "Quản Lý Phòng & Khách Hàng";
            mnuQuanLyPhong.Click += mnuQuanLyPhong_Click;
            // 
            // mnuQuanLyDichVu
            // 
            mnuQuanLyDichVu.Name = "mnuQuanLyDichVu";
            mnuQuanLyDichVu.Size = new Size(295, 26);
            mnuQuanLyDichVu.Text = "Quản Lý Dịch Vụ & Bảng Giá";
            mnuQuanLyDichVu.Click += mnuQuanLyDichVu_Click;
            // 
            // mnuTinhTienDichVu
            // 
            mnuTinhTienDichVu.Name = "mnuTinhTienDichVu";
            mnuTinhTienDichVu.Size = new Size(295, 26);
            mnuTinhTienDichVu.Text = "Tính Tiền Dịch Vụ Theo Phòng";
            mnuTinhTienDichVu.Click += mnuTinhTienDichVu_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKe });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuThongKe
            // 
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(260, 26);
            mnuThongKe.Text = "Thống Kê Thu Nhập Ngày";
            mnuThongKe.Click += mnuThongKe_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(240, 244, 248);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavBilling);
            pnlSidebar.Controls.Add(btnNavServices);
            pnlSidebar.Controls.Add(btnNavRooms);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 28);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(180, 500);
            pnlSidebar.TabIndex = 1;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(5, 10);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(170, 45);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Text = "Trang Chủ / Tổng Quan";
            btnNavDashboard.UseVisualStyleBackColor = true;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // btnNavRooms
            // 
            btnNavRooms.Location = new Point(5, 65);
            btnNavRooms.Name = "btnNavRooms";
            btnNavRooms.Size = new Size(170, 45);
            btnNavRooms.TabIndex = 1;
            btnNavRooms.Text = "Quản Lý Phòng & Khách";
            btnNavRooms.UseVisualStyleBackColor = true;
            btnNavRooms.Click += btnNavRooms_Click;
            // 
            // btnNavServices
            // 
            btnNavServices.Location = new Point(5, 120);
            btnNavServices.Name = "btnNavServices";
            btnNavServices.Size = new Size(170, 45);
            btnNavServices.TabIndex = 2;
            btnNavServices.Text = "Dịch Vụ & Bảng Giá";
            btnNavServices.UseVisualStyleBackColor = true;
            btnNavServices.Click += btnNavServices_Click;
            // 
            // btnNavBilling
            // 
            btnNavBilling.Location = new Point(5, 175);
            btnNavBilling.Name = "btnNavBilling";
            btnNavBilling.Size = new Size(170, 45);
            btnNavBilling.TabIndex = 3;
            btnNavBilling.Text = "Tính Tiền Dịch Vụ";
            btnNavBilling.UseVisualStyleBackColor = true;
            btnNavBilling.Click += btnNavBilling_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.Location = new Point(5, 230);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(170, 45);
            btnNavReports.TabIndex = 4;
            btnNavReports.Text = "Thống Kê Doanh Thu";
            btnNavReports.UseVisualStyleBackColor = true;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(180, 28);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1276, 474);
            pnlMainContent.TabIndex = 2;
            // 
            // stsbStatusBar
            // 
            stsbStatusBar.ImageScalingSize = new Size(20, 20);
            stsbStatusBar.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusTime });
            stsbStatusBar.Location = new Point(0, 502);
            stsbStatusBar.Name = "stsbStatusBar";
            stsbStatusBar.Size = new Size(1456, 26);
            stsbStatusBar.TabIndex = 0;
            stsbStatusBar.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(160, 20);
            lblStatusUser.Text = "Thu ngân: Lễ tân Admin";
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(140, 20);
            lblStatusTime.Text = "Hệ thống sẵn sàng";
            // 
            // Form1
            // 
            ClientSize = new Size(1456, 528);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Controls.Add(stsbStatusBar);
            Controls.Add(mstMainMenu);
            MainMenuStrip = mstMainMenu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grand Hotel Suite - Hệ Thống Quản Lý Khách Sạn & Dịch Vụ";
            Load += Form1_Load;
            
            mstMainMenu.ResumeLayout(false);
            mstMainMenu.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            stsbStatusBar.ResumeLayout(false);
            stsbStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mstMainMenu;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuThoatToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuQuanLyPhong;
        private ToolStripMenuItem mnuQuanLyDichVu;
        private ToolStripMenuItem mnuTinhTienDichVu;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Panel pnlSidebar;
        private Button btnNavDashboard;
        private Button btnNavRooms;
        private Button btnNavServices;
        private Button btnNavBilling;
        private Button btnNavReports;
        private Panel pnlMainContent;
        private StatusStrip stsbStatusBar;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusTime;
    }
}
