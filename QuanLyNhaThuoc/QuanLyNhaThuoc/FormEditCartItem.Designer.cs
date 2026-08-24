using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class FormEditCartItem
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
            grpMedInfo = new GroupBox();
            lblMedName = new Label();
            lblManufacturer = new Label();
            lblPriceInfo = new Label();
            lblStockInfo = new Label();
            grpEditCart = new GroupBox();
            lblUnit = new Label();
            cboUnit = new ComboBox();
            lblQty = new Label();
            nudQuantity = new NumericUpDown();
            lblTotal = new Label();
            lblTotalPrice = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            grpMedInfo.SuspendLayout();
            grpEditCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHI TIẾT & CHỈNH SỬA THUỐC TRONG ĐƠN HÀNG";
            // 
            // grpMedInfo
            // 
            grpMedInfo.Controls.Add(lblMedName);
            grpMedInfo.Controls.Add(lblManufacturer);
            grpMedInfo.Controls.Add(lblPriceInfo);
            grpMedInfo.Controls.Add(lblStockInfo);
            grpMedInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpMedInfo.Location = new Point(15, 45);
            grpMedInfo.Name = "grpMedInfo";
            grpMedInfo.Size = new Size(450, 150);
            grpMedInfo.TabIndex = 1;
            grpMedInfo.TabStop = false;
            grpMedInfo.Text = "1. Thông Tin Chi Tiết Thuốc";
            // 
            // lblMedName
            // 
            lblMedName.AutoSize = true;
            lblMedName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMedName.Location = new Point(15, 25);
            lblMedName.Name = "lblMedName";
            lblMedName.Size = new Size(95, 21);
            lblMedName.TabIndex = 0;
            lblMedName.Text = "Tên thuốc: ";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Segoe UI", 9F);
            lblManufacturer.Location = new Point(15, 52);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(102, 20);
            lblManufacturer.TabIndex = 1;
            lblManufacturer.Text = "Nhà sản xuất: ";
            // 
            // lblPriceInfo
            // 
            lblPriceInfo.AutoSize = true;
            lblPriceInfo.Font = new Font("Segoe UI", 9F);
            lblPriceInfo.Location = new Point(15, 80);
            lblPriceInfo.Name = "lblPriceInfo";
            lblPriceInfo.Size = new Size(137, 20);
            lblPriceInfo.TabIndex = 2;
            lblPriceInfo.Text = "Bảng giá quy đổi: ";
            // 
            // lblStockInfo
            // 
            lblStockInfo.AutoSize = true;
            lblStockInfo.Font = new Font("Segoe UI", 9F);
            lblStockInfo.Location = new Point(15, 115);
            lblStockInfo.Name = "lblStockInfo";
            lblStockInfo.Size = new Size(141, 20);
            lblStockInfo.TabIndex = 3;
            lblStockInfo.Text = "Tồn kho nhà thuốc: ";
            // 
            // grpEditCart
            // 
            grpEditCart.Controls.Add(lblUnit);
            grpEditCart.Controls.Add(cboUnit);
            grpEditCart.Controls.Add(lblQty);
            grpEditCart.Controls.Add(nudQuantity);
            grpEditCart.Controls.Add(lblTotal);
            grpEditCart.Controls.Add(lblTotalPrice);
            grpEditCart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpEditCart.Location = new Point(15, 205);
            grpEditCart.Name = "grpEditCart";
            grpEditCart.Size = new Size(450, 130);
            grpEditCart.TabIndex = 2;
            grpEditCart.TabStop = false;
            grpEditCart.Text = "2. Điều Chỉnh Số Lượng & Đơn Vị Tính";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 9F);
            lblUnit.Location = new Point(15, 32);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(91, 20);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "Đơn vị tính:";
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.Font = new Font("Segoe UI", 9.5F);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Hộp", "Vỉ", "Viên" });
            cboUnit.Location = new Point(110, 28);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(110, 29);
            cboUnit.TabIndex = 1;
            cboUnit.SelectedIndexChanged += cboUnit_SelectedIndexChanged;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 9F);
            lblQty.Location = new Point(240, 32);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(72, 20);
            lblQty.TabIndex = 2;
            lblQty.Text = "Số lượng:";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 9.5F);
            nudQuantity.Location = new Point(320, 28);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(110, 29);
            nudQuantity.TabIndex = 3;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(15, 80);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 23);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Thành tiền mua mới:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(195, 76);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(38, 28);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "0đ";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Location = new Point(15, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu Thay Đổi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.Location = new Point(185, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa Khỏi Đơn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(345, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy Bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormEditCartItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 400);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(grpEditCart);
            Controls.Add(grpMedInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditCartItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi Tiết & Chỉnh Sửa Thuốc";
            Load += FormEditCartItem_Load;
            grpMedInfo.ResumeLayout(false);
            grpMedInfo.PerformLayout();
            grpEditCart.ResumeLayout(false);
            grpEditCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpMedInfo;
        private Label lblMedName;
        private Label lblManufacturer;
        private Label lblPriceInfo;
        private Label lblStockInfo;
        private GroupBox grpEditCart;
        private Label lblUnit;
        private ComboBox cboUnit;
        private Label lblQty;
        private NumericUpDown nudQuantity;
        private Label lblTotal;
        private Label lblTotalPrice;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
    }
}
