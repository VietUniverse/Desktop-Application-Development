using System.Drawing;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace QuanLyNhaThuoc
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnConfigRate = new Button();
            lblHeaderTitle = new Label();
            pnlCartBox = new Panel();
            products = new Label();
            proBox = new ComboBox();
            lblUnit = new Label();
            cboUnit = new ComboBox();
            lblQty = new Label();
            nudQuantity = new NumericUpDown();
            addProduct = new Button();
            menuPro = new DataGridView();
            pnlBillingSummary = new Panel();
            label2 = new Label();
            points = new Label();
            label3 = new Label();
            money = new Label();
            calc = new Button();
            pnlCustomerBox = new Panel();
            grpCustInfo = new GroupBox();
            sdt = new Label();
            sdtBox = new TextBox();
            name = new Label();
            nameBox = new TextBox();
            lblEditPoint = new Label();
            txtEditPoint = new TextBox();
            btnUpdate = new Button();
            register = new Button();
            grpCustTabs = new GroupBox();
            tabCustomer = new TabControl();
            tabList = new TabPage();
            customer = new DataGridView();
            tabLeader = new TabPage();
            leaderboard = new DataGridView();
            tabRedeem = new TabPage();
            lblChooseReward = new Label();
            cboRewards = new ComboBox();
            lblRedeemNote = new Label();
            btnRedeemReward = new Button();
            btnManageRewards = new Button();
            tabAnalytics = new TabPage();
            rtbAnalytics = new RichTextBox();
            btnRefreshAnalytics = new Button();
            cboYear = new ComboBox();
            cboMonth = new ComboBox();
            lblMonthFilter = new Label();
            pnlHeader.SuspendLayout();
            pnlCartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuPro).BeginInit();
            pnlBillingSummary.SuspendLayout();
            pnlCustomerBox.SuspendLayout();
            grpCustInfo.SuspendLayout();
            grpCustTabs.SuspendLayout();
            tabCustomer.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customer).BeginInit();
            tabLeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leaderboard).BeginInit();
            tabRedeem.SuspendLayout();
            tabAnalytics.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ControlLight;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(btnConfigRate);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnConfigRate
            // 
            btnConfigRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfigRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfigRate.Location = new Point(1095, 10);
            btnConfigRate.Name = "btnConfigRate";
            btnConfigRate.Size = new Size(170, 30);
            btnConfigRate.TabIndex = 1;
            btnConfigRate.Text = "Đổi Tỷ Lệ Điểm";
            btnConfigRate.UseVisualStyleBackColor = true;
            btnConfigRate.Click += btnConfigRate_Click;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.Black;
            lblHeaderTitle.Location = new Point(20, 11);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(490, 28);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC & BÁN HÀNG POS";
            // 
            // pnlCartBox
            // 
            pnlCartBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCartBox.BackColor = SystemColors.Control;
            pnlCartBox.BorderStyle = BorderStyle.FixedSingle;
            pnlCartBox.Controls.Add(products);
            pnlCartBox.Controls.Add(proBox);
            pnlCartBox.Controls.Add(lblUnit);
            pnlCartBox.Controls.Add(cboUnit);
            pnlCartBox.Controls.Add(lblQty);
            pnlCartBox.Controls.Add(nudQuantity);
            pnlCartBox.Controls.Add(addProduct);
            pnlCartBox.Controls.Add(menuPro);
            pnlCartBox.Controls.Add(pnlBillingSummary);
            pnlCartBox.Location = new Point(20, 60);
            pnlCartBox.Name = "pnlCartBox";
            pnlCartBox.Size = new Size(780, 640);
            pnlCartBox.TabIndex = 1;
            // 
            // products
            // 
            products.AutoSize = true;
            products.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            products.Location = new Point(15, 18);
            products.Name = "products";
            products.Size = new Size(99, 21);
            products.TabIndex = 0;
            products.Text = "Chọn thuốc:";
            // 
            // proBox
            // 
            proBox.Font = new Font("Segoe UI", 9.5F);
            proBox.FormattingEnabled = true;
            proBox.Location = new Point(115, 14);
            proBox.Name = "proBox";
            proBox.Size = new Size(240, 29);
            proBox.TabIndex = 1;
            proBox.TextChanged += proBox_TextChanged;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnit.Location = new Point(365, 18);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(44, 20);
            lblUnit.TabIndex = 2;
            lblUnit.Text = "ĐVT:";
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.Font = new Font("Segoe UI", 9.5F);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Hộp", "Vỉ", "Viên" });
            cboUnit.Location = new Point(410, 14);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(80, 29);
            cboUnit.TabIndex = 3;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQty.Location = new Point(500, 18);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(30, 20);
            lblQty.TabIndex = 4;
            lblQty.Text = "SL:";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 9.5F);
            nudQuantity.Location = new Point(535, 14);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(70, 29);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addProduct
            // 
            addProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProduct.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            addProduct.Location = new Point(620, 12);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(145, 33);
            addProduct.TabIndex = 6;
            addProduct.Text = "Thêm Thuốc";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addPro_Click;
            // 
            // menuPro
            // 
            menuPro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuPro.Location = new Point(15, 55);
            menuPro.Name = "menuPro";
            menuPro.ReadOnly = true;
            menuPro.RowHeadersWidth = 51;
            menuPro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuPro.Size = new Size(750, 460);
            menuPro.TabIndex = 7;
            // 
            // pnlBillingSummary
            // 
            pnlBillingSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBillingSummary.BackColor = SystemColors.Control;
            pnlBillingSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlBillingSummary.Controls.Add(label2);
            pnlBillingSummary.Controls.Add(points);
            pnlBillingSummary.Controls.Add(label3);
            pnlBillingSummary.Controls.Add(money);
            pnlBillingSummary.Controls.Add(calc);
            pnlBillingSummary.Location = new Point(15, 525);
            pnlBillingSummary.Name = "pnlBillingSummary";
            pnlBillingSummary.Size = new Size(750, 100);
            pnlBillingSummary.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 18);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 0;
            label2.Text = "Điểm tích lũy nhận được:";
            // 
            // points
            // 
            points.AutoSize = true;
            points.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            points.ForeColor = Color.Black;
            points.Location = new Point(220, 12);
            points.Name = "points";
            points.Size = new Size(28, 32);
            points.TabIndex = 1;
            points.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(15, 55);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 2;
            label3.Text = "Tổng tiền hóa đơn:";
            // 
            // money
            // 
            money.AutoSize = true;
            money.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            money.ForeColor = Color.Black;
            money.Location = new Point(195, 45);
            money.Name = "money";
            money.Size = new Size(54, 41);
            money.TabIndex = 3;
            money.Text = "0đ";
            // 
            // calc
            // 
            calc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            calc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            calc.Location = new Point(500, 15);
            calc.Name = "calc";
            calc.Size = new Size(235, 70);
            calc.TabIndex = 4;
            calc.Text = "THANH TOÁN";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // pnlCustomerBox
            // 
            pnlCustomerBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlCustomerBox.BackColor = SystemColors.Control;
            pnlCustomerBox.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerBox.Controls.Add(grpCustInfo);
            pnlCustomerBox.Controls.Add(grpCustTabs);
            pnlCustomerBox.Location = new Point(815, 60);
            pnlCustomerBox.Name = "pnlCustomerBox";
            pnlCustomerBox.Size = new Size(445, 640);
            pnlCustomerBox.TabIndex = 2;
            // 
            // grpCustInfo
            // 
            grpCustInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCustInfo.Controls.Add(sdt);
            grpCustInfo.Controls.Add(sdtBox);
            grpCustInfo.Controls.Add(name);
            grpCustInfo.Controls.Add(nameBox);
            grpCustInfo.Controls.Add(lblEditPoint);
            grpCustInfo.Controls.Add(txtEditPoint);
            grpCustInfo.Controls.Add(btnUpdate);
            grpCustInfo.Controls.Add(register);
            grpCustInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpCustInfo.Location = new Point(12, 12);
            grpCustInfo.Name = "grpCustInfo";
            grpCustInfo.Size = new Size(420, 185);
            grpCustInfo.TabIndex = 0;
            grpCustInfo.TabStop = false;
            grpCustInfo.Text = "1. Thông Tin Khách Hàng";
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Font = new Font("Segoe UI", 9F);
            sdt.Location = new Point(15, 30);
            sdt.Name = "sdt";
            sdt.Size = new Size(100, 20);
            sdt.TabIndex = 0;
            sdt.Text = "Số điện thoại:";
            // 
            // sdtBox
            // 
            sdtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sdtBox.Font = new Font("Segoe UI", 9.5F);
            sdtBox.Location = new Point(120, 26);
            sdtBox.Name = "sdtBox";
            sdtBox.Size = new Size(280, 29);
            sdtBox.TabIndex = 1;
            sdtBox.TextChanged += sdtBox_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 9F);
            name.Location = new Point(15, 65);
            name.Name = "name";
            name.Size = new Size(76, 20);
            name.TabIndex = 2;
            name.Text = "Họ và Tên:";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameBox.Font = new Font("Segoe UI", 9.5F);
            nameBox.Location = new Point(120, 61);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(280, 29);
            nameBox.TabIndex = 3;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // lblEditPoint
            // 
            lblEditPoint.AutoSize = true;
            lblEditPoint.Font = new Font("Segoe UI", 9F);
            lblEditPoint.Location = new Point(15, 100);
            lblEditPoint.Name = "lblEditPoint";
            lblEditPoint.Size = new Size(105, 20);
            lblEditPoint.TabIndex = 4;
            lblEditPoint.Text = "Điểm Tích Lũy:";
            // 
            // txtEditPoint
            // 
            txtEditPoint.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtEditPoint.ForeColor = Color.Black;
            txtEditPoint.Location = new Point(120, 96);
            txtEditPoint.Name = "txtEditPoint";
            txtEditPoint.ReadOnly = true;
            txtEditPoint.Size = new Size(130, 29);
            txtEditPoint.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnUpdate.Location = new Point(260, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa Tên/SĐT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // register
            // 
            register.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            register.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            register.Location = new Point(15, 135);
            register.Name = "register";
            register.Size = new Size(385, 35);
            register.TabIndex = 7;
            register.Text = "Đăng Ký Khách Hàng Mới";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // grpCustTabs
            // 
            grpCustTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpCustTabs.Controls.Add(tabCustomer);
            grpCustTabs.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpCustTabs.Location = new Point(12, 205);
            grpCustTabs.Name = "grpCustTabs";
            grpCustTabs.Size = new Size(420, 420);
            grpCustTabs.TabIndex = 1;
            grpCustTabs.TabStop = false;
            grpCustTabs.Text = "2. Quản Lý Khách Hàng & Báo Cáo";
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(tabList);
            tabCustomer.Controls.Add(tabLeader);
            tabCustomer.Controls.Add(tabRedeem);
            tabCustomer.Controls.Add(tabAnalytics);
            tabCustomer.Dock = DockStyle.Fill;
            tabCustomer.Font = new Font("Segoe UI", 9F);
            tabCustomer.Location = new Point(3, 25);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.SelectedIndex = 0;
            tabCustomer.Size = new Size(414, 392);
            tabCustomer.TabIndex = 0;
            // 
            // tabList
            // 
            tabList.Controls.Add(customer);
            tabList.Location = new Point(4, 29);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(406, 359);
            tabList.TabIndex = 0;
            tabList.Text = "Danh Sách Khách";
            tabList.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customer.DefaultCellStyle = dataGridViewCellStyle2;
            customer.Dock = DockStyle.Fill;
            customer.Location = new Point(3, 3);
            customer.Name = "customer";
            customer.ReadOnly = true;
            customer.RowHeadersWidth = 51;
            customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customer.Size = new Size(400, 353);
            customer.TabIndex = 0;
            customer.CellClick += customer_CellClick;
            // 
            // tabLeader
            // 
            tabLeader.Controls.Add(leaderboard);
            tabLeader.Location = new Point(4, 29);
            tabLeader.Name = "tabLeader";
            tabLeader.Padding = new Padding(3);
            tabLeader.Size = new Size(406, 359);
            tabLeader.TabIndex = 1;
            tabLeader.Text = "Top VIP";
            tabLeader.UseVisualStyleBackColor = true;
            // 
            // leaderboard
            // 
            leaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            leaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            leaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            leaderboard.DefaultCellStyle = dataGridViewCellStyle4;
            leaderboard.Dock = DockStyle.Fill;
            leaderboard.Location = new Point(3, 3);
            leaderboard.Name = "leaderboard";
            leaderboard.ReadOnly = true;
            leaderboard.RowHeadersWidth = 51;
            leaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leaderboard.Size = new Size(400, 353);
            leaderboard.TabIndex = 0;
            // 
            // tabRedeem
            // 
            tabRedeem.Controls.Add(lblChooseReward);
            tabRedeem.Controls.Add(cboRewards);
            tabRedeem.Controls.Add(lblRedeemNote);
            tabRedeem.Controls.Add(btnRedeemReward);
            tabRedeem.Controls.Add(btnManageRewards);
            tabRedeem.Location = new Point(4, 29);
            tabRedeem.Name = "tabRedeem";
            tabRedeem.Padding = new Padding(10);
            tabRedeem.Size = new Size(406, 359);
            tabRedeem.TabIndex = 2;
            tabRedeem.Text = "Đổi Quà & Kho Quà";
            tabRedeem.UseVisualStyleBackColor = true;
            // 
            // lblChooseReward
            // 
            lblChooseReward.AutoSize = true;
            lblChooseReward.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChooseReward.Location = new Point(10, 15);
            lblChooseReward.Name = "lblChooseReward";
            lblChooseReward.Size = new Size(171, 20);
            lblChooseReward.TabIndex = 0;
            lblChooseReward.Text = "Chọn phần quà quy đổi:";
            // 
            // cboRewards
            // 
            cboRewards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboRewards.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRewards.Font = new Font("Segoe UI", 9.5F);
            cboRewards.FormattingEnabled = true;
            cboRewards.Location = new Point(10, 38);
            cboRewards.Name = "cboRewards";
            cboRewards.Size = new Size(385, 29);
            cboRewards.TabIndex = 1;
            // 
            // lblRedeemNote
            // 
            lblRedeemNote.AutoSize = true;
            lblRedeemNote.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblRedeemNote.ForeColor = Color.DimGray;
            lblRedeemNote.Location = new Point(10, 75);
            lblRedeemNote.Name = "lblRedeemNote";
            lblRedeemNote.Size = new Size(337, 20);
            lblRedeemNote.TabIndex = 2;
            lblRedeemNote.Text = "* Đổi quà cho khách hàng đang chọn (SĐT/Tên ở trên)";
            // 
            // btnRedeemReward
            // 
            btnRedeemReward.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRedeemReward.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRedeemReward.Location = new Point(10, 105);
            btnRedeemReward.Name = "btnRedeemReward";
            btnRedeemReward.Size = new Size(385, 42);
            btnRedeemReward.TabIndex = 3;
            btnRedeemReward.Text = "ĐỔI QUÀ NGAY";
            btnRedeemReward.UseVisualStyleBackColor = true;
            btnRedeemReward.Click += btnRedeemReward_Click;
            // 
            // btnManageRewards
            // 
            btnManageRewards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnManageRewards.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnManageRewards.Location = new Point(10, 160);
            btnManageRewards.Name = "btnManageRewards";
            btnManageRewards.Size = new Size(385, 42);
            btnManageRewards.TabIndex = 4;
            btnManageRewards.Text = "CẤU HÌNH & NHẬP THÊM TỒN KHO QUÀ";
            btnManageRewards.UseVisualStyleBackColor = true;
            btnManageRewards.Click += btnManageRewards_Click;
            // 
            // tabAnalytics
            // 
            tabAnalytics.Controls.Add(rtbAnalytics);
            tabAnalytics.Controls.Add(btnRefreshAnalytics);
            tabAnalytics.Controls.Add(cboYear);
            tabAnalytics.Controls.Add(cboMonth);
            tabAnalytics.Controls.Add(lblMonthFilter);
            tabAnalytics.Location = new Point(4, 29);
            tabAnalytics.Name = "tabAnalytics";
            tabAnalytics.Padding = new Padding(8);
            tabAnalytics.Size = new Size(406, 359);
            tabAnalytics.TabIndex = 3;
            tabAnalytics.Text = "Báo Cáo Tháng";
            tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // rtbAnalytics
            // 
            rtbAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbAnalytics.BackColor = Color.White;
            rtbAnalytics.Font = new Font("Segoe UI", 9F);
            rtbAnalytics.ForeColor = Color.Black;
            rtbAnalytics.Location = new Point(8, 45);
            rtbAnalytics.Name = "rtbAnalytics";
            rtbAnalytics.ReadOnly = true;
            rtbAnalytics.Size = new Size(388, 305);
            rtbAnalytics.TabIndex = 4;
            rtbAnalytics.Text = "";
            // 
            // btnRefreshAnalytics
            // 
            btnRefreshAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshAnalytics.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRefreshAnalytics.Location = new Point(305, 6);
            btnRefreshAnalytics.Name = "btnRefreshAnalytics";
            btnRefreshAnalytics.Size = new Size(92, 30);
            btnRefreshAnalytics.TabIndex = 3;
            btnRefreshAnalytics.Text = "Xem";
            btnRefreshAnalytics.UseVisualStyleBackColor = true;
            btnRefreshAnalytics.Click += btnRefreshAnalytics_Click;
            // 
            // cboYear
            // 
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.Font = new Font("Segoe UI", 8.5F);
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(205, 8);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(90, 27);
            cboYear.TabIndex = 2;
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            // 
            // cboMonth
            // 
            cboMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonth.Font = new Font("Segoe UI", 8.5F);
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(100, 8);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(95, 27);
            cboMonth.TabIndex = 1;
            cboMonth.SelectedIndexChanged += cboMonth_SelectedIndexChanged;
            // 
            // lblMonthFilter
            // 
            lblMonthFilter.AutoSize = true;
            lblMonthFilter.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMonthFilter.Location = new Point(8, 12);
            lblMonthFilter.Name = "lblMonthFilter";
            lblMonthFilter.Size = new Size(90, 19);
            lblMonthFilter.TabIndex = 0;
            lblMonthFilter.Text = "Tháng/Năm:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlCustomerBox);
            Controls.Add(pnlCartBox);
            Controls.Add(pnlHeader);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PHARMACY POS - HỆ THỐNG BÁN HÀNG & TÍCH ĐIỂM NHÀ THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCartBox.ResumeLayout(false);
            pnlCartBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuPro).EndInit();
            pnlBillingSummary.ResumeLayout(false);
            pnlBillingSummary.PerformLayout();
            pnlCustomerBox.ResumeLayout(false);
            grpCustInfo.ResumeLayout(false);
            grpCustInfo.PerformLayout();
            grpCustTabs.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customer).EndInit();
            tabLeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leaderboard).EndInit();
            tabRedeem.ResumeLayout(false);
            tabRedeem.PerformLayout();
            tabAnalytics.ResumeLayout(false);
            tabAnalytics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Button btnConfigRate;
        private Panel pnlCartBox;
        private Label products;
        private ComboBox proBox;
        private Label lblUnit;
        private ComboBox cboUnit;
        private Label lblQty;
        private NumericUpDown nudQuantity;
        private Button addProduct;
        private DataGridView menuPro;
        private Panel pnlBillingSummary;
        private Label label2;
        private Label points;
        private Label label3;
        private Label money;
        private Button calc;
        private Panel pnlCustomerBox;
        private GroupBox grpCustInfo;
        private Label sdt;
        private TextBox sdtBox;
        private Label name;
        private TextBox nameBox;
        private Label lblEditPoint;
        private TextBox txtEditPoint;
        private Button btnUpdate;
        private Button register;
        private GroupBox grpCustTabs;
        private TabControl tabCustomer;
        private TabPage tabList;
        private DataGridView customer;
        private TabPage tabLeader;
        private DataGridView leaderboard;
        private TabPage tabRedeem;
        private Label lblChooseReward;
        private ComboBox cboRewards;
        private Label lblRedeemNote;
        private Button btnRedeemReward;
        private Button btnManageRewards;
        private TabPage tabAnalytics;
        private Label lblMonthFilter;
        private ComboBox cboMonth;
        private ComboBox cboYear;
        private Button btnRefreshAnalytics;
        private RichTextBox rtbAnalytics;
    }
}
