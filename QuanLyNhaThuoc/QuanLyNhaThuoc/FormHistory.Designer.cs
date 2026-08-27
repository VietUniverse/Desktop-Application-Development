using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class FormHistory
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
            lblCustomerInfo = new Label();
            grpFilter = new GroupBox();
            btnApplyFilter = new Button();
            dtpToDate = new DateTimePicker();
            lblToDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblFromDate = new Label();
            cboFilterType = new ComboBox();
            lblFilterType = new Label();
            dgvHistory = new DataGridView();
            btnClose = new Button();
            lblSummaryStats = new Label();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LỊCH SỬ MUA HÀNG KHÁCH HÀNG";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomerInfo.ForeColor = Color.DarkBlue;
            lblCustomerInfo.Location = new Point(20, 48);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(214, 23);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "Khách hàng: Nguyễn Văn A";
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnApplyFilter);
            grpFilter.Controls.Add(dtpToDate);
            grpFilter.Controls.Add(lblToDate);
            grpFilter.Controls.Add(dtpFromDate);
            grpFilter.Controls.Add(lblFromDate);
            grpFilter.Controls.Add(cboFilterType);
            grpFilter.Controls.Add(lblFilterType);
            grpFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFilter.Location = new Point(20, 80);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(840, 65);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "LỌC GIAO DỊCH THEO THỜI GIAN / GIAI ĐOẠN";
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApplyFilter.Location = new Point(715, 22);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(110, 32);
            btnApplyFilter.TabIndex = 6;
            btnApplyFilter.Text = "Xem Lọc";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Font = new Font("Segoe UI", 9F);
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(570, 24);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(130, 27);
            dtpToDate.TabIndex = 5;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F);
            lblToDate.Location = new Point(525, 28);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(39, 20);
            lblToDate.TabIndex = 4;
            lblToDate.Text = "Đến:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Font = new Font("Segoe UI", 9F);
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(385, 24);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(130, 27);
            dtpFromDate.TabIndex = 3;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F);
            lblFromDate.Location = new Point(350, 28);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(30, 20);
            lblFromDate.TabIndex = 2;
            lblFromDate.Text = "Từ:";
            // 
            // cboFilterType
            // 
            cboFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterType.Font = new Font("Segoe UI", 9F);
            cboFilterType.FormattingEnabled = true;
            cboFilterType.Items.AddRange(new object[] { "Tất cả giao dịch", "Lọc theo Giai Đoạn (Từ - Đến)", "Lọc theo Ngày chọn", "Lọc theo Tháng/Năm", "Lọc theo Năm" });
            cboFilterType.Location = new Point(105, 24);
            cboFilterType.Name = "cboFilterType";
            cboFilterType.Size = new Size(235, 28);
            cboFilterType.TabIndex = 1;
            cboFilterType.SelectedIndexChanged += cboFilterType_SelectedIndexChanged;
            // 
            // lblFilterType
            // 
            lblFilterType.AutoSize = true;
            lblFilterType.Font = new Font("Segoe UI", 9F);
            lblFilterType.Location = new Point(12, 28);
            lblFilterType.Name = "lblFilterType";
            lblFilterType.Size = new Size(87, 20);
            lblFilterType.TabIndex = 0;
            lblFilterType.Text = "Chế độ lọc:";
            // 
            // dgvHistory
            // 
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(20, 155);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(840, 340);
            dgvHistory.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClose.Location = new Point(740, 508);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 4;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblSummaryStats
            // 
            lblSummaryStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSummaryStats.AutoSize = true;
            lblSummaryStats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSummaryStats.Location = new Point(20, 515);
            lblSummaryStats.Name = "lblSummaryStats";
            lblSummaryStats.Size = new Size(270, 21);
            lblSummaryStats.TabIndex = 5;
            lblSummaryStats.Text = "Tổng số hóa đơn: 0 | Tổng tiền: 0đ";
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 560);
            Controls.Add(lblSummaryStats);
            Controls.Add(btnClose);
            Controls.Add(dgvHistory);
            Controls.Add(grpFilter);
            Controls.Add(lblCustomerInfo);
            Controls.Add(lblTitle);
            Name = "FormHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lịch Sử Mua Hàng Khách Hàng";
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomerInfo;
        private GroupBox grpFilter;
        private Label lblFilterType;
        private ComboBox cboFilterType;
        private Label lblFromDate;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private DateTimePicker dtpToDate;
        private Button btnApplyFilter;
        private DataGridView dgvHistory;
        private Button btnClose;
        private Label lblSummaryStats;
    }
}
