using System;
using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    public partial class frmSearchGiangVien : Form
    {
        public string TuKhoa { get; private set; } = "";
        public KieuTim KieuTimKiem { get; private set; } = KieuTim.TheoMa;

        public frmSearchGiangVien()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.TuKhoa = txtTuKhoa.Text.Trim();

            if (rdTheoMa.Checked)
                this.KieuTimKiem = KieuTim.TheoMa;
            else if (rdTheoHoTen.Checked)
                this.KieuTimKiem = KieuTim.TheoHoTen;
            else if (rdTheoSoDT.Checked)
                this.KieuTimKiem = KieuTim.TheoSoDT;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
