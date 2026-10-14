using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmNhapFile : Form
    {
        public string DuongDanFile { get; set; } = "";
        public string LoaiFile { get; set; } = "JSON";

        public frmNhapFile()
        {
            InitializeComponent();
        }

        // TODO: Sự kiện nạp Form
        private void frmNhapFile_Load(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện thay đổi chọn RadioButton JSON
        private void rdoJson_CheckedChanged(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện thay đổi chọn RadioButton XML
        private void rdoXml_CheckedChanged(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện thay đổi chọn RadioButton TXT
        private void rdoTxt_CheckedChanged(object sender, EventArgs e)
        {

        }

        // TODO: Nút Browse chọn file
        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Nhập file
        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        // TODO: Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
