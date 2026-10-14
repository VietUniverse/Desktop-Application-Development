namespace BaiTap
{
    partial class frmTimKiem
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
            lblMSSV = new Label();
            txtMSSV = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            btnTimKiem = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Location = new Point(25, 25);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(50, 20);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "MSSV:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(110, 22);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(250, 27);
            txtMSSV.TabIndex = 1;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(25, 70);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(76, 20);
            lblTen.TabIndex = 2;
            lblTen.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(110, 67);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 27);
            txtTen.TabIndex = 3;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(25, 115);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(37, 20);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(110, 112);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(250, 28);
            cboLop.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(110, 160);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(245, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 35);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTimKiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 215);
            Controls.Add(btnThoat);
            Controls.Add(btnTimKiem);
            Controls.Add(cboLop);
            Controls.Add(lblLop);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(txtMSSV);
            Controls.Add(lblMSSV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTimKiem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tìm kiếm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMSSV;
        private TextBox txtMSSV;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblLop;
        private ComboBox cboLop;
        private Button btnTimKiem;
        private Button btnThoat;
    }
}
