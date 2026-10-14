namespace NhapThongTinGiangVien
{
    partial class frmSearchGiangVien
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
            this.gbKieuTim = new System.Windows.Forms.GroupBox();
            this.rdTheoSoDT = new System.Windows.Forms.RadioButton();
            this.rdTheoHoTen = new System.Windows.Forms.RadioButton();
            this.rdTheoMa = new System.Windows.Forms.RadioButton();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbKieuTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKieuTim
            // 
            this.gbKieuTim.Controls.Add(this.rdTheoSoDT);
            this.gbKieuTim.Controls.Add(this.rdTheoHoTen);
            this.gbKieuTim.Controls.Add(this.rdTheoMa);
            this.gbKieuTim.Location = new System.Drawing.Point(20, 15);
            this.gbKieuTim.Name = "gbKieuTim";
            this.gbKieuTim.Size = new System.Drawing.Size(345, 60);
            this.gbKieuTim.TabIndex = 0;
            this.gbKieuTim.TabStop = false;
            this.gbKieuTim.Text = "Tìm theo";
            // 
            // rdTheoSoDT
            // 
            this.rdTheoSoDT.AutoSize = true;
            this.rdTheoSoDT.Location = new System.Drawing.Point(240, 25);
            this.rdTheoSoDT.Name = "rdTheoSoDT";
            this.rdTheoSoDT.Size = new System.Drawing.Size(84, 19);
            this.rdTheoSoDT.TabIndex = 2;
            this.rdTheoSoDT.Text = "Số ĐT";
            this.rdTheoSoDT.UseVisualStyleBackColor = true;
            // 
            // rdTheoHoTen
            // 
            this.rdTheoHoTen.AutoSize = true;
            this.rdTheoHoTen.Location = new System.Drawing.Point(130, 25);
            this.rdTheoHoTen.Name = "rdTheoHoTen";
            this.rdTheoHoTen.Size = new System.Drawing.Size(89, 19);
            this.rdTheoHoTen.TabIndex = 1;
            this.rdTheoHoTen.Text = "Họ Tên";
            this.rdTheoHoTen.UseVisualStyleBackColor = true;
            // 
            // rdTheoMa
            // 
            this.rdTheoMa.AutoSize = true;
            this.rdTheoMa.Checked = true;
            this.rdTheoMa.Location = new System.Drawing.Point(20, 25);
            this.rdTheoMa.Name = "rdTheoMa";
            this.rdTheoMa.Size = new System.Drawing.Size(89, 19);
            this.rdTheoMa.TabIndex = 0;
            this.rdTheoMa.TabStop = true;
            this.rdTheoMa.Text = "Mã GV";
            this.rdTheoMa.UseVisualStyleBackColor = true;
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 95);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(53, 15);
            this.lblTuKhoa.TabIndex = 1;
            this.lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(90, 92);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(185, 23);
            this.txtTuKhoa.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(290, 90);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmSearchGiangVien
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 140);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.gbKieuTim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSearchGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin giảng viên";
            this.gbKieuTim.ResumeLayout(false);
            this.gbKieuTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKieuTim;
        private System.Windows.Forms.RadioButton rdTheoSoDT;
        private System.Windows.Forms.RadioButton rdTheoHoTen;
        private System.Windows.Forms.RadioButton rdTheoMa;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTim;
    }
}
