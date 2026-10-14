namespace TinhTienHocTrungTam
{
    partial class frmTrungTam
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblMaHV = new Label();
            cboMaHV = new ComboBox();
            lblGioiTinh = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgayDangKy = new Label();
            dtpNgayDangKy = new DateTimePicker();
            chkTinHocA = new CheckBox();
            lblTienTHA = new Label();
            chkTinHocB = new CheckBox();
            lblTienTHB = new Label();
            chkTiengAnhA = new CheckBox();
            lblTienTAA = new Label();
            chkTiengAnhB = new CheckBox();
            lblTienTAB = new Label();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(219, 0, 122);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(456, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaHV
            // 
            lblMaHV.AutoSize = true;
            lblMaHV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaHV.Location = new Point(25, 62);
            lblMaHV.Name = "lblMaHV";
            lblMaHV.Size = new Size(77, 15);
            lblMaHV.TabIndex = 1;
            lblMaHV.Text = "Mã Học Viên";
            // 
            // cboMaHV
            // 
            cboMaHV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaHV.FormattingEnabled = true;
            cboMaHV.Items.AddRange(new object[] { "001", "002", "003", "004", "005" });
            cboMaHV.Location = new Point(125, 59);
            cboMaHV.Name = "cboMaHV";
            cboMaHV.Size = new Size(120, 23);
            cboMaHV.TabIndex = 2;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGioiTinh.Location = new Point(265, 62);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(57, 15);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(335, 60);
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
            rdNu.Location = new Point(395, 60);
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
            lblHoTen.Location = new Point(25, 97);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(46, 15);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(125, 94);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(315, 23);
            txtHoTen.TabIndex = 7;
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayDangKy.Location = new Point(25, 132);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(84, 15);
            lblNgayDangKy.TabIndex = 8;
            lblNgayDangKy.Text = "Ngày Đăng Ký";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(125, 129);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(315, 23);
            dtpNgayDangKy.TabIndex = 9;
            // 
            // chkTinHocA
            // 
            chkTinHocA.AutoSize = true;
            chkTinHocA.Location = new Point(85, 170);
            chkTinHocA.Name = "chkTinHocA";
            chkTinHocA.Size = new Size(77, 19);
            chkTinHocA.TabIndex = 10;
            chkTinHocA.Text = "Tin học A";
            chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // lblTienTHA
            // 
            lblTienTHA.AutoSize = true;
            lblTienTHA.Location = new Point(275, 171);
            lblTienTHA.Name = "lblTienTHA";
            lblTienTHA.Size = new Size(77, 15);
            lblTienTHA.TabIndex = 11;
            lblTienTHA.Text = "300.000 đồng";
            // 
            // chkTinHocB
            // 
            chkTinHocB.AutoSize = true;
            chkTinHocB.Location = new Point(85, 200);
            chkTinHocB.Name = "chkTinHocB";
            chkTinHocB.Size = new Size(76, 19);
            chkTinHocB.TabIndex = 12;
            chkTinHocB.Text = "Tin học B";
            chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // lblTienTHB
            // 
            lblTienTHB.AutoSize = true;
            lblTienTHB.Location = new Point(275, 201);
            lblTienTHB.Name = "lblTienTHB";
            lblTienTHB.Size = new Size(77, 15);
            lblTienTHB.TabIndex = 13;
            lblTienTHB.Text = "500.000 đồng";
            // 
            // chkTiengAnhA
            // 
            chkTiengAnhA.AutoSize = true;
            chkTiengAnhA.Location = new Point(85, 230);
            chkTiengAnhA.Name = "chkTiengAnhA";
            chkTiengAnhA.Size = new Size(92, 19);
            chkTiengAnhA.TabIndex = 14;
            chkTiengAnhA.Text = "Tiếng Anh A";
            chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // lblTienTAA
            // 
            lblTienTAA.AutoSize = true;
            lblTienTAA.Location = new Point(275, 231);
            lblTienTAA.Name = "lblTienTAA";
            lblTienTAA.Size = new Size(77, 15);
            lblTienTAA.TabIndex = 15;
            lblTienTAA.Text = "400.000 đồng";
            // 
            // chkTiengAnhB
            // 
            chkTiengAnhB.AutoSize = true;
            chkTiengAnhB.Location = new Point(85, 260);
            chkTiengAnhB.Name = "chkTiengAnhB";
            chkTiengAnhB.Size = new Size(91, 19);
            chkTiengAnhB.TabIndex = 16;
            chkTiengAnhB.Text = "Tiếng Anh B";
            chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTienTAB
            // 
            lblTienTAB.AutoSize = true;
            lblTienTAB.Location = new Point(275, 261);
            lblTienTAB.Name = "lblTienTAB";
            lblTienTAB.Size = new Size(77, 15);
            lblTienTAB.TabIndex = 17;
            lblTienTAB.Text = "600.000 đồng";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTongTien.Location = new Point(125, 298);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(71, 17);
            lblTongTien.TabIndex = 18;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtTongTien.Location = new Point(215, 295);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(160, 25);
            txtTongTien.TabIndex = 19;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnTinhTien.ForeColor = Color.Blue;
            btnTinhTien.Location = new Point(40, 345);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(115, 38);
            btnTinhTien.TabIndex = 20;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(175, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 38);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(310, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 38);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frmTrungTam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 406);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(lblTienTAB);
            Controls.Add(chkTiengAnhB);
            Controls.Add(lblTienTAA);
            Controls.Add(chkTiengAnhA);
            Controls.Add(lblTienTHB);
            Controls.Add(chkTinHocB);
            Controls.Add(lblTienTHA);
            Controls.Add(chkTinHocA);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(lblNgayDangKy);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(cboMaHV);
            Controls.Add(lblMaHV);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmTrungTam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Drawing";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.ComboBox cboMaHV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.CheckBox chkTinHocA;
        private System.Windows.Forms.Label lblTienTHA;
        private System.Windows.Forms.CheckBox chkTinHocB;
        private System.Windows.Forms.Label lblTienTHB;
        private System.Windows.Forms.CheckBox chkTiengAnhA;
        private System.Windows.Forms.Label lblTienTAA;
        private System.Windows.Forms.CheckBox chkTiengAnhB;
        private System.Windows.Forms.Label lblTienTAB;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private ImageList imageList1;
    }
}
