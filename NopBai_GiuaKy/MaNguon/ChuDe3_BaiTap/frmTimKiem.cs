using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmTimKiem : Form
    {
        public string MSSVTim
        {
            get { return txtMSSV.Text.Trim(); }
        }

        public string TenTim
        {
            get { return txtTen.Text.Trim(); }
        }

        public string LopTim
        {
            get
            {
                if (cboLop.SelectedItem == null)
                {
                    return "";
                }

                string? lopDaChon = cboLop.SelectedItem.ToString();
                if (lopDaChon == null)
                {
                    return "";
                }
                if (lopDaChon == "--- Tất cả ---")
                {
                    return "";
                }

                return lopDaChon;
            }
        }

        public frmTimKiem(List<string> dsLop)
        {
            InitializeComponent();
            cboLop.Items.Add("--- Tất cả ---");
            foreach (string lop in dsLop)
            {
                if (!string.IsNullOrWhiteSpace(lop))
                {
                    cboLop.Items.Add(lop);
                }
            }
            cboLop.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
