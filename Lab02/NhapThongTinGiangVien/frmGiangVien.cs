using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    public partial class frmGiangVien : Form
    {
        public QuanLyGiangVien qlgv;

        public frmGiangVien()
        {
            InitializeComponent();
            CreateCancelIcon();
            qlgv = new QuanLyGiangVien();
        }

        private void CreateCancelIcon()
        {
            try
            {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Brush b = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(b, 1, 1, 18, 18);
                    }
                    using (Pen p = new Pen(Color.White, 2.5f))
                    {
                        g.DrawLine(p, 6, 6, 14, 14);
                        g.DrawLine(p, 14, 6, 6, 14);
                    }
                }
                btnCancel.Image = bmp;
                btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
                btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            catch
            {
                // Do nothing
            }
        }

        private GiangVien GetGiangVienFromForm()
        {
            string gt = rdNam.Checked ? "Nam" : "Nữ";
            List<string> listNn = new List<string>();
            for (int i = 0; i < chklbNgoaiNgu.CheckedItems.Count; i++)
            {
                string? nn = chklbNgoaiNgu.CheckedItems[i]?.ToString();
                if (!string.IsNullOrEmpty(nn))
                    listNn.Add(nn);
            }

            DanhMucHocPhan dsHP = new DanhMucHocPhan();
            foreach (var item in lbHocPhanDay.Items)
            {
                if (item != null)
                    dsHP.Them(new HocPhan(item.ToString() ?? ""));
            }

            return new GiangVien(
                cboMaSo.Text,
                mtxtSoDT.Text,
                txtMail.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                dsHP,
                gt,
                listNn.ToArray()
            );
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            if (this.cboMaSo.Items.Count > 0)
                this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                var item = lbDanhSachHP.SelectedItems[i];
                if (item != null)
                {
                    this.lbHocPhanDay.Items.Add(item);
                    this.lbDanhSachHP.Items.Remove(item);
                }
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                var item = lbHocPhanDay.SelectedItems[i];
                if (item != null)
                {
                    this.lbDanhSachHP.Items.Add(item);
                    this.lbHocPhanDay.Items.Remove(item);
                }
                i--;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGiangVienFromForm();
            bool result = qlgv.Them(gv);
            if (!result)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (frmSearchGiangVien frmSearch = new frmSearchGiangVien())
            {
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    GiangVien? gvFound = qlgv.TimKiem(frmSearch.TuKhoa, frmSearch.KieuTimKiem);
                    if (gvFound != null)
                    {
                        frmTBGiangVien frmTB = new frmTBGiangVien();
                        frmTB.SetText(gvFound.ToString());
                        frmTB.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giảng viên thỏa điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGiangVienFromForm();
            frmTBGiangVien frmTB = new frmTBGiangVien();
            frmTB.SetText(gv.ToString());
            frmTB.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }

        private void ReSet()
        {
            if (cboMaSo.Items.Count > 0)
                cboMaSo.SelectedIndex = 0;
            txtHoTen.Text = "";
            mtxtSoDT.Text = "";
            txtMail.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            rdNu.Checked = false;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }

            foreach (var item in lbHocPhanDay.Items)
            {
                lbDanhSachHP.Items.Add(item);
            }
            lbHocPhanDay.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link?.LinkData as string ?? "https://cntt.dlu.edu.vn/";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
            }
            catch
            {
                // Ignore if process fail
            }
        }
    }
}
