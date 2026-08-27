using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class FormCustomerChoice
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnNewCustomer = new Button();
            btnExistingCustomer = new Button();
            btnGuestCheckout = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHƯA NHẬP THÔNG TIN KHÁCH HÀNG!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.Location = new Point(50, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(390, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Vui lòng chọn hình thức thanh toán & tích điểm bên dưới:";
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewCustomer.Location = new Point(30, 88);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(440, 44);
            btnNewCustomer.TabIndex = 2;
            btnNewCustomer.Text = "Đăng Ký Tích Điểm Khách Hàng Mới";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnExistingCustomer
            // 
            btnExistingCustomer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExistingCustomer.Location = new Point(30, 142);
            btnExistingCustomer.Name = "btnExistingCustomer";
            btnExistingCustomer.Size = new Size(440, 44);
            btnExistingCustomer.TabIndex = 3;
            btnExistingCustomer.Text = "Chọn Khách Hàng Cũ Trong Danh Sách";
            btnExistingCustomer.UseVisualStyleBackColor = true;
            btnExistingCustomer.Click += btnExistingCustomer_Click;
            // 
            // btnGuestCheckout
            // 
            btnGuestCheckout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuestCheckout.Location = new Point(30, 196);
            btnGuestCheckout.Name = "btnGuestCheckout";
            btnGuestCheckout.Size = new Size(440, 44);
            btnGuestCheckout.TabIndex = 4;
            btnGuestCheckout.Text = "Thanh Toán Vãng Lai (Không Tích Điểm)";
            btnGuestCheckout.UseVisualStyleBackColor = true;
            btnGuestCheckout.Click += btnGuestCheckout_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(30, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(440, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy Bỏ / Quay Lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormCustomerChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 310);
            Controls.Add(btnCancel);
            Controls.Add(btnGuestCheckout);
            Controls.Add(btnExistingCustomer);
            Controls.Add(btnNewCustomer);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCustomerChoice";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn Khách Hàng Thanh Toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnNewCustomer;
        private Button btnExistingCustomer;
        private Button btnGuestCheckout;
        private Button btnCancel;
    }
}
