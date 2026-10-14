using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmTimKiem : Form
    {
        public string MSSVTim { get; set; } = "";
        public string TenTim { get; set; } = "";
        public string LopTim { get; set; } = "";

        public frmTimKiem(List<string> dsLop)
        {
            InitializeComponent();
            // TODO: Nạp danh sách lớp vào cboLop
        }

        // TODO: Sự kiện khi nhấn nút Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
