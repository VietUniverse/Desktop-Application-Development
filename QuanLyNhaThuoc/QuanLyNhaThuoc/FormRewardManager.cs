using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class FormRewardManager : Form
    {
        private List<RewardItem> _rewards;
        private Action _onDataChanged;
        private RewardItem? _selectedReward = null;

        public FormRewardManager(List<RewardItem> rewards, Action onDataChanged)
        {
            _rewards = rewards ?? new List<RewardItem>();
            _onDataChanged = onDataChanged;
            InitializeComponent();
        }

        private void FormRewardManager_Load(object sender, EventArgs e)
        {
            HienThiDanhSachQua();
        }

        private void HienThiDanhSachQua()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên Quà Tặng");
            dt.Columns.Add("Số Điểm Cần Đổi");
            dt.Columns.Add("Tồn Kho Hiện Tại");
            dt.Columns.Add("Trạng Thái Kích Hoạt");

            for (int i = 0; i < _rewards.Count; i++)
            {
                var r = _rewards[i];
                string statusStr;
                if (!r.IsActive)
                {
                    statusStr = "⛔ TẠM DỪNG";
                }
                else if (r.StockQuantity <= 0)
                {
                    statusStr = "⚠️ HẾT KHO QUÀ";
                }
                else
                {
                    statusStr = "✅ Đang Kích Hoạt";
                }

                dt.Rows.Add(i + 1, r.Name, r.PointsRequired + " điểm", r.StockQuantity + " phần", statusStr);
            }

            dgvRewards.DataSource = dt;

            if (dgvRewards.Columns["STT"] != null)
            {
                dgvRewards.Columns["STT"].Width = 50;
                dgvRewards.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvRewards.Columns["Tên Quà Tặng"] != null)
            {
                dgvRewards.Columns["Tên Quà Tặng"].Width = 230;
            }
            if (dgvRewards.Columns["Số Điểm Cần Đổi"] != null)
            {
                dgvRewards.Columns["Số Điểm Cần Đổi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvRewards.Columns["Tồn Kho Hiện Tại"] != null)
            {
                dgvRewards.Columns["Tồn Kho Hiện Tại"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvRewards.Columns["Trạng Thái Kích Hoạt"] != null)
            {
                dgvRewards.Columns["Trạng Thái Kích Hoạt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvRewards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _rewards.Count)
            {
                _selectedReward = _rewards[e.RowIndex];
                txtName.Text = _selectedReward.Name;
                nudPoints.Value = _selectedReward.PointsRequired;
                nudStock.Value = _selectedReward.StockQuantity;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _selectedReward = null;
            txtName.Text = "";
            nudPoints.Value = 50;
            nudStock.Value = 20;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int points = (int)nudPoints.Value;
            int stock = (int)nudStock.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên phần quà tặng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (_selectedReward != null)
            {
                _selectedReward.Name = name;
                _selectedReward.PointsRequired = points;
                _selectedReward.StockQuantity = stock;
                MessageBox.Show($"Đã cập nhật thông tin quà '{name}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RewardItem? existing = _rewards.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (existing != null)
                {
                    existing.PointsRequired = points;
                    existing.StockQuantity = stock;
                    existing.IsActive = true;
                    MessageBox.Show($"Đã cập nhật & kích hoạt lại quà '{name}' có sẵn trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _rewards.Add(new RewardItem(name, points, stock, isActive: true));
                    MessageBox.Show($"Đã thêm phần quà mới '{name}' vào danh mục đổi quà!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            _onDataChanged?.Invoke();
            HienThiDanhSachQua();
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng chọn quà cần tạm dừng hoặc kích hoạt lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RewardItem? target = _rewards.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (target != null)
            {
                target.IsActive = !target.IsActive;
                string newStatusStr = target.IsActive ? "ĐANG KÍCH HOẠT" : "TẠM DỪNG";
                MessageBox.Show($"Đã chuyển trạng thái phần quà '{target.Name}' sang: {newStatusStr}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _onDataChanged?.Invoke();
                HienThiDanhSachQua();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
