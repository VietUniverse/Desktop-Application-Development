namespace QuanLyNhaThuoc
{
    partial class FormEditCustomer
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
            lblTitle = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblPoints = new System.Windows.Forms.Label();
            nudPoints = new System.Windows.Forms.NumericUpDown();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudPoints).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(50, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(380, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblPhone.Location = new System.Drawing.Point(30, 68);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(115, 21);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPhone.Location = new System.Drawing.Point(150, 64);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(290, 30);
            txtPhone.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblName.Location = new System.Drawing.Point(30, 118);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(88, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtName.Location = new System.Drawing.Point(150, 114);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(290, 30);
            txtName.TabIndex = 4;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblPoints.Location = new System.Drawing.Point(30, 168);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new System.Drawing.Size(113, 21);
            lblPoints.TabIndex = 5;
            lblPoints.Text = "Điểm tích lũy:";
            // 
            // nudPoints
            // 
            nudPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            nudPoints.Location = new System.Drawing.Point(150, 164);
            nudPoints.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPoints.Name = "nudPoints";
            nudPoints.Size = new System.Drawing.Size(290, 30);
            nudPoints.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(80, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(150, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu Cập Nhật";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnCancel.Location = new System.Drawing.Point(250, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(150, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy Bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormEditCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 280);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudPoints);
            Controls.Add(lblPoints);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cập Nhật Thông Tin Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)nudPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.NumericUpDown nudPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
