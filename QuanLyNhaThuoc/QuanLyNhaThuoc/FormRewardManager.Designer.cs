using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class FormRewardManager
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
            dgvRewards = new DataGridView();
            grpEditBox = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPoints = new Label();
            nudPoints = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            btnSave = new Button();
            btnAddNew = new Button();
            btnToggleActive = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRewards).BeginInit();
            grpEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH MỤC & TỒN KHO QUÀ TẶNG";
            // 
            // dgvRewards
            // 
            dgvRewards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRewards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRewards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRewards.Location = new Point(20, 50);
            dgvRewards.Name = "dgvRewards";
            dgvRewards.ReadOnly = true;
            dgvRewards.RowHeadersWidth = 51;
            dgvRewards.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRewards.Size = new Size(680, 210);
            dgvRewards.TabIndex = 1;
            dgvRewards.CellClick += dgvRewards_CellClick;
            // 
            // grpEditBox
            // 
            grpEditBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpEditBox.Controls.Add(lblName);
            grpEditBox.Controls.Add(txtName);
            grpEditBox.Controls.Add(lblPoints);
            grpEditBox.Controls.Add(nudPoints);
            grpEditBox.Controls.Add(lblStock);
            grpEditBox.Controls.Add(nudStock);
            grpEditBox.Controls.Add(btnSave);
            grpEditBox.Controls.Add(btnAddNew);
            grpEditBox.Controls.Add(btnToggleActive);
            grpEditBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpEditBox.Location = new Point(20, 270);
            grpEditBox.Name = "grpEditBox";
            grpEditBox.Size = new Size(680, 165);
            grpEditBox.TabIndex = 2;
            grpEditBox.TabStop = false;
            grpEditBox.Text = "THÔNG TIN CHI TIẾT QUÀ TẶNG (CẤU HÌNH / KÍCH HOẠT / TẠM DỪNG)";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(15, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Tên phần quà tặng:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(150, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(510, 29);
            txtName.TabIndex = 1;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Segoe UI", 9F);
            lblPoints.Location = new Point(15, 72);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(129, 20);
            lblPoints.TabIndex = 2;
            lblPoints.Text = "Số điểm cần đổi:";
            // 
            // nudPoints
            // 
            nudPoints.Font = new Font("Segoe UI", 9.5F);
            nudPoints.Location = new Point(150, 68);
            nudPoints.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPoints.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPoints.Name = "nudPoints";
            nudPoints.Size = new Size(150, 29);
            nudPoints.TabIndex = 3;
            nudPoints.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F);
            lblStock.Location = new Point(340, 72);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(125, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Tồn kho hiện tại:";
            // 
            // nudStock
            // 
            nudStock.Font = new Font("Segoe UI", 9.5F);
            nudStock.Location = new Point(470, 68);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(150, 29);
            nudStock.TabIndex = 5;
            nudStock.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNew.Location = new Point(15, 115);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(150, 36);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Tạo Quà Mới";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(180, 115);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu Thông Tin Quà";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToggleActive.Location = new Point(435, 115);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new Size(225, 36);
            btnToggleActive.TabIndex = 8;
            btnToggleActive.Text = "Tạm Dừng / Kích Hoạt";
            btnToggleActive.UseVisualStyleBackColor = true;
            btnToggleActive.Click += btnToggleActive_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClose.Location = new Point(580, 448);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormRewardManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 495);
            Controls.Add(btnClose);
            Controls.Add(grpEditBox);
            Controls.Add(dgvRewards);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRewardManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Danh Mục & Tồn Kho Quà Tặng";
            Load += FormRewardManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRewards).EndInit();
            grpEditBox.ResumeLayout(false);
            grpEditBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvRewards;
        private GroupBox grpEditBox;
        private Label lblName;
        private TextBox txtName;
        private Label lblPoints;
        private NumericUpDown nudPoints;
        private Label lblStock;
        private NumericUpDown nudStock;
        private Button btnAddNew;
        private Button btnSave;
        private Button btnToggleActive;
        private Button btnClose;
    }
}
