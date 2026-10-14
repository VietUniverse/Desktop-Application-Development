# Bài luyện tập sửa lỗi C# WinForms

Hai solution `lab 2` và `lab 3` đã được điền code hoàn chỉnh rồi cài lỗi để luyện tập. Mở từng tệp `.sln` bằng Visual Studio. Hãy tự tìm và sửa lỗi; tài liệu này không chứa đáp án. Các dự án gốc bên ngoài `BaiKiemTra` không bị chỉnh sửa.

## Bài 1 — Mở và chạy được nhưng xử lý sai

Solution: `lab 3/Lab03_ThaoTacTapTin.sln`. Đặt `BaiTap` làm **Startup Project**. Dự án này mở và chạy được nhưng có lỗi logic. Dữ liệu mẫu nằm trong `lab 3/BaiTap/students.json`. Sau mỗi lần thêm hoặc cập nhật, chương trình ghi lại tệp dữ liệu của bản luyện tập; có thể chép lại `students.json` từ `Lab03_ThaoTacTapTin/BaiTap` bên ngoài `BaiKiemTra` để làm lại từ đầu.

1. Khi mở chương trình với hai sinh viên mẫu có MSSV `2010001` và `2010002`, mã gợi ý tiếp theo của lớp CTK44 phải là bao nhiêu? Vì sao mã trên form lại khác?
2. Nếu thêm một sinh viên mới có **MSSV khác** nhưng tên là `Nga`, chương trình báo gì? Việc kiểm tra trùng sinh viên nên dựa trên trường nào?
3. Nếu thêm một sinh viên có **MSSV trùng** nhưng tên khác, kết quả có đúng không? Hãy chỉ ra điều kiện gây lỗi.
4. Trong danh sách có nhiều sinh viên lớp CTK44. Khi chọn sinh viên thứ hai và cập nhật địa chỉ, bản ghi nào thực sự bị thay đổi? Vì sao?
5. Khi tìm kiếm theo lớp CTK44, những sinh viên nào xuất hiện? Điều kiện lọc hiện tại loại bản ghi đúng hay sai?
6. Hàm `Xoa` duyệt danh sách từ cuối về đầu. Nếu đổi sang duyệt từ đầu, chuyện gì có thể xảy ra khi xóa nhiều sinh viên liên tiếp?
7. Sau khi sửa, hãy kiểm tra lại bốn thao tác: sinh MSSV, thêm, cập nhật, tìm kiếm. Với mỗi thao tác, ghi một ví dụ đầu vào và kết quả mong đợi.

## Bài 2 — Mở được dự án nhưng chưa biên dịch được

Solution: `lab 2/Lab02.sln`. Đặt `QuanLyThongTinSinhVien` làm **Startup Project**. Dự án này chưa biên dịch được; ba dự án còn lại trong solution là code hoàn chỉnh. Hãy thử Build để đọc thông báo lỗi. Mục tiêu là sửa cho dự án biên dịch được rồi mở form.

1. Trong `QuanLySinhVien.Them`, `DanhSach` là kiểu gì? Kiểu đó có những phương thức nào để thêm phần tử?
2. Trong `frmSinhVien.ResetControls`, thuộc tính `Text` cần kiểu dữ liệu gì? Giá trị hiện tại thuộc kiểu gì?
3. Trong `frmSinhVien.tsmiSort_Click`, khai báo của `SapXep` yêu cầu bao nhiêu tham số? Giá trị cần truyền lấy từ đâu?
4. Sau khi sửa các lỗi biên dịch, hãy mô tả luồng xử lý từ lúc bấm **Thêm** đến lúc sinh viên xuất hiện trên `ListView`.
5. Vì sao nút **Sửa** cần tìm sinh viên theo mã số, thay vì chỉ thay đổi dòng đang hiển thị trên `ListView`?

## Gợi ý cách làm bài

Với mỗi lỗi, hãy ghi: **hiện tượng → hàm liên quan → nguyên nhân → một thay đổi nhỏ nhất → kết quả sau sửa**. Ở Bài 1, đừng sửa giao diện khi nguyên nhân nằm trong `QuanLySinhVien.cs`.
