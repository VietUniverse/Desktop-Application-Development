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
            lblFilterType = new Label();
            cboFilterType = new ComboBox();
            dtpDate = new DateTimePicker();
            btnApplyFilter = new Button();
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
            lblTitle.Size = new Size(372, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📜 LỊCH SỬ MUA HÀNG KHÁCH HÀNG";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustomerInfo.ForeColor = Color.DarkBlue;
            lblCustomerInfo.Location = new Point(20, 45);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(214, 23);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "Khách hàng: Nguyễn Văn A";
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnApplyFilter);
            grpFilter.Controls.Add(dtpDate);
            grpFilter.Controls.Add(cboFilterType);
            grpFilter.Controls.Add(lblFilterType);
            grpFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFilter.Location = new Point(20, 75);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(740, 60);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "LỌC GIAO DỊCH THEO THỜI GIAN";
            // 
            // lblFilterType
            // 
            lblFilterType.AutoSize = true;
            lblFilterType.Font = new Font("Segoe UI", 9F);
            lblFilterType.Location = new Point(15, 26);
            lblFilterType.Name = "lblFilterType";
            lblFilterType.Size = new Size(99, 20);
            lblFilterType.TabIndex = 0;
            lblFilterType.Text = "Chế độ lọc:";
            // 
            // cboFilterType
            // 
            cboFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterType.Font = new Font("Segoe UI", 9F);
            cboFilterType.FormattingEnabled = true;
            cboFilterType.Items.AddRange(new object[] { "Tất cả giao dịch", "Lọc theo Ngày chọn", "Lọc theo Tháng/Năm", "Lọc theo Năm" });
            cboFilterType.Location = new Point(115, 23);
            cboFilterType.Name = "cboFilterType";
            cboFilterType.Size = new Size(180, 28);
            cboFilterType.TabIndex = 1;
            cboFilterType.SelectedIndexChanged += cboFilterType_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Font = new Font("Segoe UI", 9F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(310, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(160, 27);
            dtpDate.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApplyFilter.Location = new Point(485, 21);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(120, 30);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "🔍 Xem Lọc";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(20, 145);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(740, 300);
            dgvHistory.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClose.Location = new Point(640, 455);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblSummaryStats
            // 
            lblSummaryStats.AutoSize = true;
            lblSummaryStats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSummaryStats.Location = new Point(20, 460);
            lblSummaryStats.Name = "lblSummaryStats";
            lblSummaryStats.Size = new Size(270, 21);
            lblSummaryStats.TabIndex = 5;
            lblSummaryStats.Text = "Tổng số hóa đơn: 0 | Tổng tiền: 0đ";
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 505);
            Controls.Add(grpFilter);
            Controls.Add(lblSummaryStats);
            Controls.Add(btnClose);
            Controls.Add(dgvHistory);
            Controls.Add(lblCustomerInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private DateTimePicker dtpDate;
        private Button btnApplyFilter;
        private DataGridView dgvHistory;
        private Button btnClose;
        private Label lblSummaryStats;
    }
}
