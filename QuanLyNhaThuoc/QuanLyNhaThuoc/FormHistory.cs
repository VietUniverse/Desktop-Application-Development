using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class FormHistory : Form
    {
        private Customer _customer;
        private List<Invoice> _allInvoices;

        public FormHistory(Customer customer, List<Invoice> allInvoices)
        {
            InitializeComponent();
            _customer = customer;
            _allInvoices = allInvoices ?? new List<Invoice>();

            lblCustomerInfo.Text = $"Khách hàng: {_customer.Name} | SĐT: {_customer.NumPhone} | Điểm hiện tại: {_customer.Point} điểm";

            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;

            if (cboFilterType.Items.Count > 0)
            {
                cboFilterType.SelectedIndex = 0;
            }

            ApplyHistoryFilter();
        }

        private void ApplyHistoryFilter()
        {
            var customerInvoices = _allInvoices
                .Where(x => x.CustomerPhone == _customer.NumPhone)
                .OrderByDescending(x => x.PurchaseDate)
                .AsQueryable();

            int filterMode = cboFilterType.SelectedIndex;

            if (filterMode == 1) // theo Giai Đoạn (Từ Ngày - Đến Ngày)
            {
                DateTime from = dtpFromDate.Value.Date;
                DateTime to = dtpToDate.Value.Date;
                if (from <= to)
                {
                    customerInvoices = customerInvoices.Where(x => x.PurchaseDate.Date >= from && x.PurchaseDate.Date <= to);
                }
            }
            else if (filterMode == 2) // theo Ngày chọn cụ thể
            {
                DateTime selectedDate = dtpFromDate.Value.Date;
                customerInvoices = customerInvoices.Where(x => x.PurchaseDate.Date == selectedDate);
            }
            else if (filterMode == 3) // theo Tháng/Năm
            {
                DateTime selectedDate = dtpFromDate.Value;
                customerInvoices = customerInvoices.Where(x => x.PurchaseDate.Month == selectedDate.Month && x.PurchaseDate.Year == selectedDate.Year);
            }
            else if (filterMode == 4) // theo Năm
            {
                DateTime selectedDate = dtpFromDate.Value;
                customerInvoices = customerInvoices.Where(x => x.PurchaseDate.Year == selectedDate.Year);
            }

            var listResult = customerInvoices.ToList();

            var displayList = listResult.Select(x => new
            {
                Mã_HD = x.InvoiceId,
                Ngày_Mua = x.DisplayDate,
                Sản_Phẩm = x.ItemsSummary,
                Tổng_Tiền = x.FormattedTotal,
                Điểm_Thưởng = $"+{x.PointsEarned}"
            }).ToList();

            dgvHistory.DataSource = displayList;

            if (dgvHistory.Columns["Mã_HD"] != null) dgvHistory.Columns["Mã_HD"].HeaderText = "Mã Hóa Đơn";
            if (dgvHistory.Columns["Ngày_Mua"] != null) dgvHistory.Columns["Ngày_Mua"].HeaderText = "Ngày Mua";
            if (dgvHistory.Columns["Sản_Phẩm"] != null) dgvHistory.Columns["Sản_Phẩm"].HeaderText = "Sản Phẩm Đã Mua";
            if (dgvHistory.Columns["Tổng_Tiền"] != null) dgvHistory.Columns["Tổng_Tiền"].HeaderText = "Tổng Tiền (VNĐ)";
            if (dgvHistory.Columns["Điểm_Thưởng"] != null) dgvHistory.Columns["Điểm_Thưởng"].HeaderText = "Điểm Tích Lũy";

            float totalSpent = listResult.Sum(x => x.TotalAmount);
            lblSummaryStats.Text = $"Tổng số hóa đơn: {listResult.Count} | Tổng tiền mua: {totalSpent:N0}đ";
        }

        private void cboFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = cboFilterType.SelectedIndex;
            bool enableFrom = (mode > 0);
            bool enableTo = (mode == 1);

            lblFromDate.Visible = enableFrom;
            dtpFromDate.Visible = enableFrom;
            lblToDate.Visible = enableTo;
            dtpToDate.Visible = enableTo;

            if (mode == 2) lblFromDate.Text = "Ngày:";
            else if (mode == 3) lblFromDate.Text = "Tháng:";
            else if (mode == 4) lblFromDate.Text = "Năm:";
            else lblFromDate.Text = "Từ:";

            ApplyHistoryFilter();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyHistoryFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
