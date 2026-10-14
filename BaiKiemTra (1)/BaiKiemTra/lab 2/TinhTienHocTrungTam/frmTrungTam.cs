using System;
using System.Windows.Forms;

namespace TinhTienHocTrungTam
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent(); //Thiếu cái này form sẽ không mở được
        }

        // TODO: Sự kiện khi nhấn nút Tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        //{
        //    if(cboMaHV.SelectedIndex < 0) //Nếu cái hộp chọn mã số học viên chưa được chọn (mặc đinh chưa chọn là -1 nên phải cho nó nhỏ hơn 0)
        //    { 
        //        MessageBox.Show("Vui long chon ma so hoc vien");
        //        cboMaHV.Focus(); //Hàm này để khi mà tắt cái hộp thoại mở lên thì nó sẽ đưa con trỏ chuột vào cái hộp chọn
        //        return; //Nhớ phải return để kết thúc sự kiện này.
        //    }

        //    if(string.IsNullOrWhiteSpace(txtHoTen.Text) ) //Kiểm tra xem thử hộp ghi tên đã ghi tên chưa, nếu chưa thì thực hiện
        //    {
        //        MessageBox.Show("Vui long nhap ho va ten hoc vien");
        //        txtHoTen.Focus();
        //        return;
        //    }
        //    int tongTien = 0; //Set up so tien mac dinh la 0

        //    if (chkTiengAnhA.Checked) tongTien += 400;
        //    if (chkTiengAnhB.Checked) tongTien += 600;
        //    if (chkTinHocA.Checked) tongTien += 300;
        //    if (chkTinHocB.Checked) tongTien += 500;
        //    //Kiểm tra thử xem đã chọn các môn học nào rồi cộng tiền vô tổng tiền

        //    txtTongTien.Text = tongTien.ToString() + ".000 đồng"; //Gán tổng tiền cho hiển thị số tiền
        //}
        { //Làm đi nè
            if(cboMaHV.SelectedIndex > 0)
            {
                MessageBox.Show("Vui lòng nhập mã học viên:");
                cboMaHV.Focus();
                return;
            }    if(string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên: ");
                txtHoTen.Focus();
                return;
            }    int tongtien = 0;
            {
                if (chkTiengAnhA.Checked) tongtien += 400;
                if (chkTiengAnhB.Checked) tongtien += 600;
                if (chkTinHocA.Checked) tongtien += 300;
                if (chkTinHocB.Checked) tongtien += 500;
            } txtTongTien.Text = tongtien.ToString() + ".000 đồng";
        }

        // TODO: Sự kiện khi nhấn nút Cancel (Hủy / Xóa thông tin đã nhập)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Gọi hàm đặt lại bên dưới
            ReSet();
        }

        // TODO: Hàm đặt lại tất cả các ô nhập liệu về trạng thái ban đầu
        private void ReSet()
        //{
        //    cboMaHV.SelectedIndex = -1; //Xóa học viên đã chọn
        //    txtHoTen.Clear();           // Xóa tên đã ghi
        //    rdNam.Checked = true;       // Chọn lại nút radio giói tính nam
        //    dtpNgayDangKy.Value = DateTime.Today;   //Chuyển hộp chọn ngày thành ngày hôm nay
        //    chkTiengAnhA.Checked = false;
        //    chkTiengAnhB.Checked = false;   //Xóa nút chọn
        //    chkTinHocA.Checked = false;
        //    chkTinHocB.Checked = false;
        //    txtTongTien.Clear();            //Xóa tổng tiền
        //}
        {
            cboMaHV.SelectedIndex = -1;
            txtHoTen.Clear();
            dtpNgayDangKy.Value = DateTime.Today;
            rdNam.Checked = true;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;
            chkTinHocA.Checked = false;
            chkTinHocB.Checked = false;
            txtTongTien.Clear();
        }
        // TODO: Sự kiện khi nhấn nút Exit (Thoát ứng dụng)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //Đóng cái form này
        }
    }
}
