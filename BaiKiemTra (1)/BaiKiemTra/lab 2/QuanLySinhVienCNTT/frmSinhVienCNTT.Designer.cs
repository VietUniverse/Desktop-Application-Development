namespace QuanLySinhVienCNTT
{
    partial class frmSinhVienCNTT
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
            this.components = new System.ComponentModel.Container();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.gbTTSV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.lblHinh = new System.Windows.Forms.Label();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblPhai = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.gbDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colPhai = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colLop = new System.Windows.Forms.ColumnHeader();
            this.colSoDT = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colHinh = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStripLV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiTaiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbTTSV.SuspendLayout();
            this.gbDSSV.SuspendLayout();
            this.contextMenuStripLV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHinh.Location = new System.Drawing.Point(15, 20);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(160, 200);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // gbTTSV
            // 
            this.gbTTSV.Controls.Add(this.btnThoat);
            this.gbTTSV.Controls.Add(this.btnLuu);
            this.gbTTSV.Controls.Add(this.btnMacDinh);
            this.gbTTSV.Controls.Add(this.btnChonHinh);
            this.gbTTSV.Controls.Add(this.txtHinh);
            this.gbTTSV.Controls.Add(this.lblHinh);
            this.gbTTSV.Controls.Add(this.mtxtSoDT);
            this.gbTTSV.Controls.Add(this.lblSoDT);
            this.gbTTSV.Controls.Add(this.cboLop);
            this.gbTTSV.Controls.Add(this.lblLop);
            this.gbTTSV.Controls.Add(this.rdNu);
            this.gbTTSV.Controls.Add(this.rdNam);
            this.gbTTSV.Controls.Add(this.lblPhai);
            this.gbTTSV.Controls.Add(this.dtpNgaySinh);
            this.gbTTSV.Controls.Add(this.lblNgaySinh);
            this.gbTTSV.Controls.Add(this.txtDiaChi);
            this.gbTTSV.Controls.Add(this.lblDiaChi);
            this.gbTTSV.Controls.Add(this.txtEmail);
            this.gbTTSV.Controls.Add(this.lblEmail);
            this.gbTTSV.Controls.Add(this.txtHoTen);
            this.gbTTSV.Controls.Add(this.lblHoTen);
            this.gbTTSV.Controls.Add(this.mtxtMSSV);
            this.gbTTSV.Controls.Add(this.lblMSSV);
            this.gbTTSV.Location = new System.Drawing.Point(185, 12);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Size = new System.Drawing.Size(545, 210);
            this.gbTTSV.TabIndex = 1;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(455, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 26);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(370, 175);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 26);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(285, 175);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 26);
            this.btnMacDinh.TabIndex = 20;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(450, 141);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(80, 25);
            this.btnChonHinh.TabIndex = 19;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(85, 142);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(360, 23);
            this.txtHinh.TabIndex = 18;
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Location = new System.Drawing.Point(15, 145);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(33, 15);
            this.lblHinh.TabIndex = 17;
            this.lblHinh.Text = "Hình";
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(400, 112);
            this.mtxtSoDT.Mask = "0000.000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(130, 23);
            this.mtxtSoDT.TabIndex = 16;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(315, 115);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(76, 15);
            this.lblSoDT.TabIndex = 15;
            this.lblSoDT.Text = "Số điện thoại";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cboLop.Location = new System.Drawing.Point(400, 82);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(130, 23);
            this.cboLop.TabIndex = 14;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(320, 85);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(27, 15);
            this.lblLop.TabIndex = 13;
            this.lblLop.Text = "Lớp";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(445, 54);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(41, 19);
            this.rdNu.TabIndex = 12;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(380, 54);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(51, 19);
            this.rdNam.TabIndex = 11;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(320, 55);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(30, 15);
            this.lblPhai.TabIndex = 10;
            this.lblPhai.Text = "Phái";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(400, 22);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(130, 23);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(320, 25);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 15);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(85, 112);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 115);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 15);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 15);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(85, 22);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(220, 23);
            this.mtxtMSSV.TabIndex = 1;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(15, 25);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 15);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // gbDSSV
            // 
            this.gbDSSV.Controls.Add(this.lvSinhVien);
            this.gbDSSV.Location = new System.Drawing.Point(15, 230);
            this.gbDSSV.Name = "gbDSSV";
            this.gbDSSV.Size = new System.Drawing.Size(715, 245);
            this.gbDSSV.TabIndex = 2;
            this.gbDSSV.TabStop = false;
            this.gbDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTen,
            this.colPhai,
            this.colNgaySinh,
            this.colLop,
            this.colSoDT,
            this.colEmail,
            this.colDiaChi,
            this.colHinh});
            this.lvSinhVien.ContextMenuStrip = this.contextMenuStripLV;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 19);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(709, 223);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 75;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ và tên";
            this.colHoTen.Width = 130;
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            this.colPhai.Width = 55;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 85;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 60;
            // 
            // colSoDT
            // 
            this.colSoDT.Text = "Số điện thoại";
            this.colSoDT.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 110;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 110;
            // 
            // colHinh
            // 
            this.colHinh.Text = "Hình";
            this.colHinh.Width = 75;
            // 
            // contextMenuStripLV
            // 
            this.contextMenuStripLV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiXoa,
            this.cmsiTaiLai});
            this.contextMenuStripLV.Name = "contextMenuStripLV";
            this.contextMenuStripLV.Size = new System.Drawing.Size(161, 48);
            // 
            // cmsiXoa
            // 
            this.cmsiXoa.Name = "cmsiXoa";
            this.cmsiXoa.Size = new System.Drawing.Size(160, 22);
            this.cmsiXoa.Text = "Xóa";
            this.cmsiXoa.Click += new System.EventHandler(this.cmsiXoa_Click);
            // 
            // cmsiTaiLai
            // 
            this.cmsiTaiLai.Name = "cmsiTaiLai";
            this.cmsiTaiLai.Size = new System.Drawing.Size(160, 22);
            this.cmsiTaiLai.Text = "Tải lại danh sách";
            this.cmsiTaiLai.Click += new System.EventHandler(this.cmsiTaiLai_Click);
            // 
            // openFileDialogHinh
            // 
            this.openFileDialogHinh.Filter = "Image File(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            // 
            // frmSinhVienCNTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 485);
            this.Controls.Add(this.gbDSSV);
            this.Controls.Add(this.gbTTSV);
            this.Controls.Add(this.pbHinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSinhVienCNTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin sinh viên khoa CNTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVienCNTT_FormClosing);
            this.Load += new System.EventHandler(this.frmSinhVienCNTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbTTSV.ResumeLayout(false);
            this.gbTTSV.PerformLayout();
            this.gbDSSV.ResumeLayout(false);
            this.contextMenuStripLV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.GroupBox gbTTSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblHinh;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbDSSV;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colPhai;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colSoDT;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colHinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLV;
        private System.Windows.Forms.ToolStripMenuItem cmsiXoa;
        private System.Windows.Forms.ToolStripMenuItem cmsiTaiLai;
        private System.Windows.Forms.OpenFileDialog openFileDialogHinh;
    }
}
