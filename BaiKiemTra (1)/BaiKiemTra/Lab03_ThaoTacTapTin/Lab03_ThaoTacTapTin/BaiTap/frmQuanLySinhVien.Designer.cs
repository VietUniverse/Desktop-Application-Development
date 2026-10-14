namespace BaiTap
{
    partial class frmQuanLySinhVien
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMSSV = new Label();
            mtxtMSSV = new MaskedTextBox();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblHoTenLot = new Label();
            txtHoTenLot = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblLop = new Label();
            cboLop = new ComboBox();
            lblCMND = new Label();
            mtxtCMND = new MaskedTextBox();
            lblSDT = new Label();
            mtxtSDT = new MaskedTextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblMonHoc = new Label();
            clbMonHoc = new CheckedListBox();
            cmsMonHoc = new ContextMenuStrip(components);
            tsmiThemMonHoc = new ToolStripMenuItem();
            tsmiXoaMonHoc = new ToolStripMenuItem();
            btnNhapFile = new Button();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            btnCapNhat = new Button();
            btnThoat = new Button();
            gbxDanhSach = new GroupBox();
            lvSinhVien = new ListView();
            columnHeaderMSSV = new ColumnHeader();
            columnHeaderHoTenLot = new ColumnHeader();
            columnHeaderTen = new ColumnHeader();
            columnHeaderNgaySinh = new ColumnHeader();
            columnHeaderLop = new ColumnHeader();
            columnHeaderCMND = new ColumnHeader();
            columnHeaderSDT = new ColumnHeader();
            columnHeaderDiaChi = new ColumnHeader();
            cmsSinhVien = new ContextMenuStrip(components);
            tsmiXoaSinhVien = new ToolStripMenuItem();
            tsmiTaiLai = new ToolStripMenuItem();
            cmsMonHoc.SuspendLayout();
            gbxDanhSach.SuspendLayout();
            cmsSinhVien.SuspendLayout();
            SuspendLayout();
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Location = new Point(38, 25);
            lblMSSV.Margin = new Padding(4, 0, 4, 0);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(68, 25);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "MSSV :";
            // 
            // mtxtMSSV
            // 
            mtxtMSSV.Location = new Point(175, 21);
            mtxtMSSV.Margin = new Padding(4, 4, 4, 4);
            mtxtMSSV.Mask = "0000000";
            mtxtMSSV.Name = "mtxtMSSV";
            mtxtMSSV.Size = new Size(299, 31);
            mtxtMSSV.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(519, 25);
            lblGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(87, 25);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính :";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(638, 22);
            rdoNam.Margin = new Padding(4, 4, 4, 4);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 3;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(738, 22);
            rdoNu.Margin = new Padding(4, 4, 4, 4);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 4;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // lblHoTenLot
            // 
            lblHoTenLot.AutoSize = true;
            lblHoTenLot.Location = new Point(38, 71);
            lblHoTenLot.Margin = new Padding(4, 0, 4, 0);
            lblHoTenLot.Name = "lblHoTenLot";
            lblHoTenLot.Size = new Size(124, 25);
            lblHoTenLot.TabIndex = 5;
            lblHoTenLot.Text = "Họ và tên lót :";
            // 
            // txtHoTenLot
            // 
            txtHoTenLot.Location = new Point(175, 68);
            txtHoTenLot.Margin = new Padding(4, 4, 4, 4);
            txtHoTenLot.Name = "txtHoTenLot";
            txtHoTenLot.Size = new Size(299, 31);
            txtHoTenLot.TabIndex = 6;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(519, 71);
            lblTen.Margin = new Padding(4, 0, 4, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(47, 25);
            lblTen.TabIndex = 7;
            lblTen.Text = "Tên :";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(638, 68);
            txtTen.Margin = new Padding(4, 4, 4, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(312, 31);
            txtTen.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(38, 118);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 25);
            lblNgaySinh.TabIndex = 9;
            lblNgaySinh.Text = "Ngày sinh :";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(175, 114);
            dtpNgaySinh.Margin = new Padding(4, 4, 4, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(299, 31);
            dtpNgaySinh.TabIndex = 10;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(519, 118);
            lblLop.Margin = new Padding(4, 0, 4, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(51, 25);
            lblLop.TabIndex = 11;
            lblLop.Text = "Lớp :";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(638, 114);
            cboLop.Margin = new Padding(4, 4, 4, 4);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(312, 33);
            cboLop.TabIndex = 12;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(38, 164);
            lblCMND.Margin = new Padding(4, 0, 4, 0);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(100, 25);
            lblCMND.TabIndex = 13;
            lblCMND.Text = "Số CMND :";
            // 
            // mtxtCMND
            // 
            mtxtCMND.Location = new Point(175, 160);
            mtxtCMND.Margin = new Padding(4, 4, 4, 4);
            mtxtCMND.Mask = "000000000";
            mtxtCMND.Name = "mtxtCMND";
            mtxtCMND.Size = new Size(299, 31);
            mtxtCMND.TabIndex = 14;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(519, 164);
            lblSDT.Margin = new Padding(4, 0, 4, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(69, 25);
            lblSDT.TabIndex = 15;
            lblSDT.Text = "Số ĐT :";
            // 
            // mtxtSDT
            // 
            mtxtSDT.Location = new Point(638, 160);
            mtxtSDT.Margin = new Padding(4, 4, 4, 4);
            mtxtSDT.Mask = "0000000000";
            mtxtSDT.Name = "mtxtSDT";
            mtxtSDT.Size = new Size(312, 31);
            mtxtSDT.TabIndex = 16;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(38, 210);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(132, 25);
            lblDiaChi.TabIndex = 17;
            lblDiaChi.Text = "Địa chỉ liên lạc :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(175, 206);
            txtDiaChi.Margin = new Padding(4, 4, 4, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(774, 31);
            txtDiaChi.TabIndex = 18;
            // 
            // lblMonHoc
            // 
            lblMonHoc.AutoSize = true;
            lblMonHoc.Location = new Point(38, 256);
            lblMonHoc.Margin = new Padding(4, 0, 4, 0);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(161, 25);
            lblMonHoc.TabIndex = 19;
            lblMonHoc.Text = "Môn học đăng ký :";
            // 
            // clbMonHoc
            // 
            clbMonHoc.ContextMenuStrip = cmsMonHoc;
            clbMonHoc.FormattingEnabled = true;
            clbMonHoc.Items.AddRange(new object[] { "Mạng máy tính", "Hệ điều hành", "Lập trình CSDL", "Lập trình mạng", "Đồ án cơ sở", "Phương pháp NCKH", "Lập trình trên thiết bị di động", "An toàn và bảo mật hệ thống" });
            clbMonHoc.Location = new Point(207, 256);
            clbMonHoc.Margin = new Padding(4, 4, 4, 4);
            clbMonHoc.MultiColumn = true;
            clbMonHoc.Name = "clbMonHoc";
            clbMonHoc.Size = new Size(720, 116);
            clbMonHoc.TabIndex = 20;
            // 
            // cmsMonHoc
            // 
            cmsMonHoc.ImageScalingSize = new Size(20, 20);
            cmsMonHoc.Items.AddRange(new ToolStripItem[] { tsmiThemMonHoc, tsmiXoaMonHoc });
            cmsMonHoc.Name = "cmsMonHoc";
            cmsMonHoc.Size = new Size(282, 68);
            // 
            // tsmiThemMonHoc
            // 
            tsmiThemMonHoc.Name = "tsmiThemMonHoc";
            tsmiThemMonHoc.Size = new Size(281, 32);
            tsmiThemMonHoc.Text = "Thêm môn học mới...";
            tsmiThemMonHoc.Click += tsmiThemMonHoc_Click;
            // 
            // tsmiXoaMonHoc
            // 
            tsmiXoaMonHoc.Name = "tsmiXoaMonHoc";
            tsmiXoaMonHoc.Size = new Size(281, 32);
            tsmiXoaMonHoc.Text = "Xóa môn học được chọn";
            tsmiXoaMonHoc.Click += tsmiXoaMonHoc_Click;
            // 
            // btnNhapFile
            // 
            btnNhapFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhapFile.Location = new Point(38, 412);
            btnNhapFile.Margin = new Padding(4, 4, 4, 4);
            btnNhapFile.Name = "btnNhapFile";
            btnNhapFile.Size = new Size(188, 42);
            btnNhapFile.TabIndex = 21;
            btnNhapFile.Text = "📁 Nhập từ file";
            btnNhapFile.UseVisualStyleBackColor = true;
            btnNhapFile.Click += btnNhapFile_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(438, 412);
            btnTimKiem.Margin = new Padding(4, 4, 4, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 42);
            btnTimKiem.TabIndex = 22;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(575, 412);
            btnThemMoi.Margin = new Padding(4, 4, 4, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(119, 42);
            btnThemMoi.TabIndex = 23;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(706, 412);
            btnCapNhat.Margin = new Padding(4, 4, 4, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(119, 42);
            btnCapNhat.TabIndex = 24;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(838, 412);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 42);
            btnThoat.TabIndex = 25;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // gbxDanhSach
            // 
            gbxDanhSach.Controls.Add(lvSinhVien);
            gbxDanhSach.Location = new Point(25, 469);
            gbxDanhSach.Margin = new Padding(4, 4, 4, 4);
            gbxDanhSach.Name = "gbxDanhSach";
            gbxDanhSach.Padding = new Padding(4, 4, 4, 4);
            gbxDanhSach.Size = new Size(950, 362);
            gbxDanhSach.TabIndex = 26;
            gbxDanhSach.TabStop = false;
            gbxDanhSach.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            lvSinhVien.CheckBoxes = true;
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeaderMSSV, columnHeaderHoTenLot, columnHeaderTen, columnHeaderNgaySinh, columnHeaderLop, columnHeaderCMND, columnHeaderSDT, columnHeaderDiaChi });
            lvSinhVien.ContextMenuStrip = cmsSinhVien;
            lvSinhVien.Dock = DockStyle.Fill;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(4, 28);
            lvSinhVien.Margin = new Padding(4, 4, 4, 4);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(942, 330);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // columnHeaderMSSV
            // 
            columnHeaderMSSV.Text = "MSSV";
            columnHeaderMSSV.Width = 80;
            // 
            // columnHeaderHoTenLot
            // 
            columnHeaderHoTenLot.Text = "Họ và tên lót";
            columnHeaderHoTenLot.Width = 110;
            // 
            // columnHeaderTen
            // 
            columnHeaderTen.Text = "Tên";
            columnHeaderTen.Width = 70;
            // 
            // columnHeaderNgaySinh
            // 
            columnHeaderNgaySinh.Text = "Ngày sinh";
            columnHeaderNgaySinh.Width = 90;
            // 
            // columnHeaderLop
            // 
            columnHeaderLop.Text = "Lớp";
            columnHeaderLop.Width = 70;
            // 
            // columnHeaderCMND
            // 
            columnHeaderCMND.Text = "Số CMND";
            columnHeaderCMND.Width = 90;
            // 
            // columnHeaderSDT
            // 
            columnHeaderSDT.Text = "Số điện thoại";
            columnHeaderSDT.Width = 100;
            // 
            // columnHeaderDiaChi
            // 
            columnHeaderDiaChi.Text = "Địa chỉ liên lạc";
            columnHeaderDiaChi.Width = 160;
            // 
            // cmsSinhVien
            // 
            cmsSinhVien.ImageScalingSize = new Size(20, 20);
            cmsSinhVien.Items.AddRange(new ToolStripItem[] { tsmiXoaSinhVien, tsmiTaiLai });
            cmsSinhVien.Name = "cmsSinhVien";
            cmsSinhVien.Size = new Size(289, 68);
            // 
            // tsmiXoaSinhVien
            // 
            tsmiXoaSinhVien.Name = "tsmiXoaSinhVien";
            tsmiXoaSinhVien.Size = new Size(288, 32);
            tsmiXoaSinhVien.Text = "Xóa các sinh viên đã chọn";
            tsmiXoaSinhVien.Click += tsmiXoaSinhVien_Click;
            // 
            // tsmiTaiLai
            // 
            tsmiTaiLai.Name = "tsmiTaiLai";
            tsmiTaiLai.Size = new Size(288, 32);
            tsmiTaiLai.Text = "Tải lại danh sách";
            tsmiTaiLai.Click += tsmiTaiLai_Click;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 850);
            Controls.Add(gbxDanhSach);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(btnNhapFile);
            Controls.Add(clbMonHoc);
            Controls.Add(lblMonHoc);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDiaChi);
            Controls.Add(mtxtSDT);
            Controls.Add(lblSDT);
            Controls.Add(mtxtCMND);
            Controls.Add(lblCMND);
            Controls.Add(cboLop);
            Controls.Add(lblLop);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(txtHoTenLot);
            Controls.Add(lblHoTenLot);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(mtxtMSSV);
            Controls.Add(lblMSSV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "frmQuanLySinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập thông tin sinh viên";
            Load += frmQuanLySinhVien_Load;
            cmsMonHoc.ResumeLayout(false);
            gbxDanhSach.ResumeLayout(false);
            cmsSinhVien.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMSSV;
        private MaskedTextBox mtxtMSSV;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblHoTenLot;
        private TextBox txtHoTenLot;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblLop;
        private ComboBox cboLop;
        private Label lblCMND;
        private MaskedTextBox mtxtCMND;
        private Label lblSDT;
        private MaskedTextBox mtxtSDT;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblMonHoc;
        private CheckedListBox clbMonHoc;
        private Button btnNhapFile;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private Button btnCapNhat;
        private Button btnThoat;
        private GroupBox gbxDanhSach;
        private ListView lvSinhVien;
        private ColumnHeader columnHeaderMSSV;
        private ColumnHeader columnHeaderHoTenLot;
        private ColumnHeader columnHeaderTen;
        private ColumnHeader columnHeaderNgaySinh;
        private ColumnHeader columnHeaderLop;
        private ColumnHeader columnHeaderCMND;
        private ColumnHeader columnHeaderSDT;
        private ColumnHeader columnHeaderDiaChi;
        private ContextMenuStrip cmsMonHoc;
        private ToolStripMenuItem tsmiThemMonHoc;
        private ToolStripMenuItem tsmiXoaMonHoc;
        private ContextMenuStrip cmsSinhVien;
        private ToolStripMenuItem tsmiXoaSinhVien;
        private ToolStripMenuItem tsmiTaiLai;
    }
}
