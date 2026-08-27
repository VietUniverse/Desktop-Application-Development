namespace NhapThongTinGiangVien
{
    partial class frmGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblMaSo = new Label();
            cboMaSo = new ComboBox();
            lblGioiTinh = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSoDT = new Label();
            mtxtSoDT = new MaskedTextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblMail = new Label();
            txtMail = new TextBox();
            lblNgoaiNgu = new Label();
            chklbNgoaiNgu = new CheckedListBox();
            lblDanhSachHP = new Label();
            lbDanhSachHP = new ListBox();
            btnChon = new Button();
            btnXoa = new Button();
            lblHocPhanDay = new Label();
            lbHocPhanDay = new ListBox();
            btnThem = new Button();
            btnTim = new Button();
            btnThongBao = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            lblWebsite = new Label();
            linklbLienHe = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(170, 0, 170);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSo.Location = new Point(30, 65);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(41, 15);
            lblMaSo.TabIndex = 1;
            lblMaSo.Text = "Mã Số";
            // 
            // cboMaSo
            // 
            cboMaSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaSo.FormattingEnabled = true;
            cboMaSo.Items.AddRange(new object[] { "001", "002", "003", "004" });
            cboMaSo.Location = new Point(120, 62);
            cboMaSo.Name = "cboMaSo";
            cboMaSo.Size = new Size(120, 23);
            cboMaSo.TabIndex = 2;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGioiTinh.Location = new Point(270, 65);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(57, 15);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(340, 63);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(400, 63);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 5;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.Location = new Point(30, 100);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(46, 15);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 97);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(160, 23);
            txtHoTen.TabIndex = 7;
            // 
            // lblSoDT
            // 
            lblSoDT.AutoSize = true;
            lblSoDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoDT.Location = new Point(300, 100);
            lblSoDT.Name = "lblSoDT";
            lblSoDT.Size = new Size(40, 15);
            lblSoDT.TabIndex = 8;
            lblSoDT.Text = "Số ĐT";
            // 
            // mtxtSoDT
            // 
            mtxtSoDT.Location = new Point(360, 97);
            mtxtSoDT.Mask = "(0633).000.000";
            mtxtSoDT.Name = "mtxtSoDT";
            mtxtSoDT.Size = new Size(160, 23);
            mtxtSoDT.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(30, 135);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(62, 15);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(120, 132);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(160, 23);
            dtpNgaySinh.TabIndex = 11;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMail.Location = new Point(300, 135);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(70, 15);
            lblMail.TabIndex = 12;
            lblMail.Text = "Địa chỉ mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(380, 132);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(160, 23);
            txtMail.TabIndex = 13;
            // 
            // lblNgoaiNgu
            // 
            lblNgoaiNgu.AutoSize = true;
            lblNgoaiNgu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgoaiNgu.Location = new Point(30, 170);
            lblNgoaiNgu.Name = "lblNgoaiNgu";
            lblNgoaiNgu.Size = new Size(66, 15);
            lblNgoaiNgu.TabIndex = 14;
            lblNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // chklbNgoaiNgu
            // 
            chklbNgoaiNgu.FormattingEnabled = true;
            chklbNgoaiNgu.Items.AddRange(new object[] { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật", "Tiếng Nga" });
            chklbNgoaiNgu.Location = new Point(120, 170);
            chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            chklbNgoaiNgu.Size = new Size(160, 94);
            chklbNgoaiNgu.TabIndex = 15;
            // 
            // lblDanhSachHP
            // 
            lblDanhSachHP.AutoSize = true;
            lblDanhSachHP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDanhSachHP.Location = new Point(90, 285);
            lblDanhSachHP.Name = "lblDanhSachHP";
            lblDanhSachHP.Size = new Size(114, 15);
            lblDanhSachHP.TabIndex = 16;
            lblDanhSachHP.Text = "Danh sách môn học";
            // 
            // lbDanhSachHP
            // 
            lbDanhSachHP.FormattingEnabled = true;
            lbDanhSachHP.ItemHeight = 15;
            lbDanhSachHP.Items.AddRange(new object[] { "Tin học cơ sở", "Lập trình cấu trúc C/C++", "Cơ sở dữ liệu", "Tiếng Anh B1", "Tiếng Anh B2", "Lập trình hướng đối tượng", "Mạng máy tính", "Công nghệ phần mềm", "Phân tích TKHĐT" });
            lbDanhSachHP.Location = new Point(90, 305);
            lbDanhSachHP.Name = "lbDanhSachHP";
            lbDanhSachHP.SelectionMode = SelectionMode.MultiExtended;
            lbDanhSachHP.Size = new Size(190, 154);
            lbDanhSachHP.TabIndex = 17;
            // 
            // btnChon
            // 
            btnChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChon.Location = new Point(295, 340);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(45, 30);
            btnChon.TabIndex = 18;
            btnChon.Text = ">>";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(295, 380);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 30);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "<<";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblHocPhanDay
            // 
            lblHocPhanDay.AutoSize = true;
            lblHocPhanDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHocPhanDay.Location = new Point(350, 285);
            lblHocPhanDay.Name = "lblHocPhanDay";
            lblHocPhanDay.Size = new Size(130, 15);
            lblHocPhanDay.TabIndex = 20;
            lblHocPhanDay.Text = "Môn học giáo viên dạy";
            // 
            // lbHocPhanDay
            // 
            lbHocPhanDay.FormattingEnabled = true;
            lbHocPhanDay.ItemHeight = 15;
            lbHocPhanDay.Location = new Point(350, 305);
            lbHocPhanDay.Name = "lbHocPhanDay";
            lbHocPhanDay.SelectionMode = SelectionMode.MultiExtended;
            lbHocPhanDay.Size = new Size(190, 154);
            lbHocPhanDay.TabIndex = 21;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.Blue;
            btnThem.Location = new Point(30, 465);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 36);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTim.ForeColor = Color.Blue;
            btnTim.Location = new Point(120, 465);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 36);
            btnTim.TabIndex = 23;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThongBao
            // 
            btnThongBao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongBao.ForeColor = Color.Blue;
            btnThongBao.Location = new Point(210, 465);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(100, 36);
            btnThongBao.TabIndex = 24;
            btnThongBao.Text = "Thông báo";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(320, 465);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 36);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(425, 465);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 36);
            btnExit.TabIndex = 26;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWebsite.Location = new Point(515, 476);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(53, 15);
            lblWebsite.TabIndex = 27;
            lblWebsite.Text = "Website";
            // 
            // linklbLienHe
            // 
            linklbLienHe.AutoSize = true;
            linklbLienHe.Location = new Point(570, 476);
            linklbLienHe.Name = "linklbLienHe";
            linklbLienHe.Size = new Size(45, 15);
            linklbLienHe.TabIndex = 28;
            linklbLienHe.TabStop = true;
            linklbLienHe.Text = "Liên hệ";
            linklbLienHe.LinkClicked += linklbLienHe_LinkClicked;
            // 
            // frmGiangVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 521);
            Controls.Add(linklbLienHe);
            Controls.Add(lblWebsite);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnThongBao);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(lbHocPhanDay);
            Controls.Add(lblHocPhanDay);
            Controls.Add(btnXoa);
            Controls.Add(btnChon);
            Controls.Add(lbDanhSachHP);
            Controls.Add(lblDanhSachHP);
            Controls.Add(chklbNgoaiNgu);
            Controls.Add(lblNgoaiNgu);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(mtxtSoDT);
            Controls.Add(lblSoDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(cboMaSo);
            Controls.Add(lblMaSo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGiangVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giảng viên";
            Load += frmGiangVien_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.Label lblDanhSachHP;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblHocPhanDay;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.LinkLabel linklbLienHe;
    }
}
