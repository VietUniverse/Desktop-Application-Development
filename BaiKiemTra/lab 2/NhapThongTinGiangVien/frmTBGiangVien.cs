using System.Windows.Forms;

namespace NhapThongTinGiangVien
{
    public partial class frmTBGiangVien : Form
    {
        public frmTBGiangVien()
        {
            InitializeComponent();
        }

        // Gán chuỗi s cho thuộc tính Text của lblThongBao
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
    }
}
