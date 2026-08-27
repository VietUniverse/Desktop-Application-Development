using System;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    public enum LoaiTuyChon
    {
        SapXep,
        TimKiem
    }

    public enum TieuChi
    {
        MaSV,
        HoTen,
        NgaySinh
    }

    public partial class frmTuyChon : Form
    {
        public LoaiTuyChon CheDo { get; private set; }
        public TieuChi TieuChiChon { get; private set; } = TieuChi.MaSV;
        public string TuKhoa { get; private set; } = "";

        public frmTuyChon(LoaiTuyChon cheDo)
        {
            InitializeComponent();
            this.CheDo = cheDo;
            if (cheDo == LoaiTuyChon.SapXep)
            {
                this.Text = "Tùy chọn sắp xếp";
                this.lblTuKhoa.Visible = false;
                this.txtTuKhoa.Visible = false;
                this.btnThucHien.Text = "Sắp xếp";
            }
            else
            {
                this.Text = "Tùy chọn tìm kiếm";
                this.lblTuKhoa.Visible = true;
                this.txtTuKhoa.Visible = true;
                this.btnThucHien.Text = "Tìm";
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (CheDo == LoaiTuyChon.TimKiem && string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.TuKhoa = txtTuKhoa.Text.Trim();

            if (rdMaSV.Checked)
                this.TieuChiChon = TieuChi.MaSV;
            else if (rdHoTen.Checked)
                this.TieuChiChon = TieuChi.HoTen;
            else if (rdNgaySinh.Checked)
                this.TieuChiChon = TieuChi.NgaySinh;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
