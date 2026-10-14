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

        private void frmNhapFile_Load(object sender, EventArgs e)
        {
            rdoJson.Checked = true;
            txtFilePath.Text = Path.Combine(Application.StartupPath, "students.json");
        }

        private void rdoJson_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJson.Checked)
            {
                LoaiFile = "JSON";
                txtFilePath.Text = Path.Combine(Application.StartupPath, "students.json");
            }
        }

        private void rdoXml_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoXml.Checked)
            {
                LoaiFile = "XML";
                txtFilePath.Text = Path.Combine(Application.StartupPath, "students.xml");
            }
        }

        private void rdoTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTxt.Checked)
            {
                LoaiFile = "TXT";
                txtFilePath.Text = Path.Combine(Application.StartupPath, "students.txt");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (rdoJson.Checked)
            {
                dlg.Filter = "Tệp JSON (*.json)|*.json";
            }
            else if (rdoXml.Checked)
            {
                dlg.Filter = "Tệp XML (*.xml)|*.xml";
            }
            else
            {
                dlg.Filter = "Tệp Text (*.txt)|*.txt";
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập đường dẫn file!");
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("Tập tin không tồn tại!");
                return;
            }

            DuongDanFile = path;
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
