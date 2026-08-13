namespace BaiTapWindowForm
{
    partial class frmBai2
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox grpHinhThuc;
        private System.Windows.Forms.RadioButton radChuyenKhoan;
        private System.Windows.Forms.RadioButton radTienMat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblSoTienThanhToan;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grpHinhThuc = new System.Windows.Forms.GroupBox();
            this.radChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.radTienMat = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblSoTienThanhToan = new System.Windows.Forms.Label();
            this.grpHinhThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // cboTenHang
            // 
            this.cboTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cboTenHang.Location = new System.Drawing.Point(105, 22);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(160, 25);
            this.cboTenHang.TabIndex = 1;
            this.cboTenHang.SelectedIndexChanged += new System.EventHandler(this.cboTenHang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(105, 62);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(120, 25);
            this.txtDonGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(105, 102);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(80, 25);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.Text = "2";
            // 
            // grpHinhThuc
            // 
            this.grpHinhThuc.Controls.Add(this.radChuyenKhoan);
            this.grpHinhThuc.Controls.Add(this.radTienMat);
            this.grpHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHinhThuc.Location = new System.Drawing.Point(105, 140);
            this.grpHinhThuc.Name = "grpHinhThuc";
            this.grpHinhThuc.Size = new System.Drawing.Size(180, 80);
            this.grpHinhThuc.TabIndex = 6;
            this.grpHinhThuc.TabStop = false;
            this.grpHinhThuc.Text = "Hình thức thanh toán:";
            // 
            // radChuyenKhoan
            // 
            this.radChuyenKhoan.AutoSize = true;
            this.radChuyenKhoan.Location = new System.Drawing.Point(20, 22);
            this.radChuyenKhoan.Name = "radChuyenKhoan";
            this.radChuyenKhoan.Size = new System.Drawing.Size(102, 19);
            this.radChuyenKhoan.TabIndex = 0;
            this.radChuyenKhoan.Text = "Chuyển khoản";
            this.radChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // radTienMat
            // 
            this.radTienMat.AutoSize = true;
            this.radTienMat.Checked = true;
            this.radTienMat.Location = new System.Drawing.Point(20, 47);
            this.radTienMat.Name = "radTienMat";
            this.radTienMat.Size = new System.Drawing.Size(71, 19);
            this.radTienMat.TabIndex = 1;
            this.radTienMat.TabStop = true;
            this.radTienMat.Text = "Tiền mặt";
            this.radTienMat.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(105, 235);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(110, 32);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblSoTienThanhToan
            // 
            this.lblSoTienThanhToan.AutoSize = true;
            this.lblSoTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienThanhToan.Location = new System.Drawing.Point(25, 285);
            this.lblSoTienThanhToan.Name = "lblSoTienThanhToan";
            this.lblSoTienThanhToan.Size = new System.Drawing.Size(190, 20);
            this.lblSoTienThanhToan.TabIndex = 8;
            this.lblSoTienThanhToan.Text = "Số tiền thanh toán: 200.000";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.lblSoTienThanhToan);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grpHinhThuc);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Thanh Toán Hàng Hóa";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.grpHinhThuc.ResumeLayout(false);
            this.grpHinhThuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
