# Ôn tập vấn đáp giữa kỳ

Tài liệu này dùng để **hiểu và tự trình bày** hai chương trình. Mở mã nguồn bên cạnh khi luyện; đừng học thuộc câu chữ mà không lần theo được hàm.

## Cách luyện theo đúng yêu cầu của giảng viên

Không học thuộc tên hàm hay cú pháp. Với từng chức năng, tự làm ba lượt:

1. **Dự đoán:** trước khi bấm, nói danh sách và tệp sẽ thay đổi thế nào.
2. **Lần theo:** từ control/sự kiện, tìm hàm xử lý, dữ liệu được đọc/ghi, rồi điểm cập nhật giao diện.
3. **Thay đổi:** nhận một yêu cầu nhỏ, chỉ ra vị trí sửa, sửa, chạy lại và giải thích kết quả.

Trong Visual Studio, dùng **Ctrl+Shift+F** tìm tên control hoặc câu thông báo để tìm đúng sự kiện; đặt con trỏ lên hàm rồi nhấn **F12** để đi tới định nghĩa. Đọc theo lời gọi hàm từ trên xuống. Khi bí, hãy nói rõ mình đang xác minh biến nào/hàm nào thay vì đoán.

Mỗi lần luyện, đóng tài liệu này và tự giải thích bằng lời của mình. Chỉ mở phần gợi ý sau khi đã thử lần dấu trong mã. Đạt mức sẵn sàng khi bạn có thể làm bài tương tự với một yêu cầu khác mà không nhìn câu trả lời mẫu.

### Bài tập tự kiểm tra (không cần nhớ cú pháp)

Với mỗi yêu cầu: (a) dự đoán kết quả hiện tại, (b) định vị file/hàm, (c) nêu thay đổi, (d) chạy và kiểm tra cả giao diện lẫn tệp.

1. Chủ đề 2: chọn sinh viên rồi sửa email. Mã nào đưa dữ liệu từ dòng được chọn lên form? Email được ghi xuống tệp ngay khi nhấn **Lưu** hay khi đóng?
2. Chủ đề 2: chọn **No** lúc đóng sau khi sửa. Khi mở lại, email nào xuất hiện? Lần theo cờ `isModified` và nhánh xử lý Yes/No/Cancel.
3. Chủ đề 3: nhập MSSV đã có. Theo dấu từ nút **Thêm mới** tới nơi phát hiện trùng; danh sách, ListView và tệp có thay đổi không?
4. Chủ đề 3: đổi lớp sang CTK45. Tại sao ô MSSV đổi? Chỉ ra sự kiện ComboBox và cách `TaoMSSV` quyết định tiền tố.
5. Chủ đề 3: bỏ CTK42 khỏi danh sách nhưng vẫn mặc định CTK44. Phần tử nào cần bỏ và chỉ số chọn mặc định phải là bao nhiêu? Kiểm tra cả danh sách tìm kiếm có lấy lớp từ dữ liệu hiện có hay không.
6. Chủ đề 3: tìm tên `nga` bằng chữ thường. Vì sao vẫn thấy Nga? Theo dấu điều kiện trong `TimKiem`.
7. Chủ đề 3: xóa một sinh viên. Nêu thứ tự lấy MSSV → xóa khỏi `DanhSach` → ghi tệp → vẽ lại ListView.
8. Đổi tệp mặc định thành `sinhvien.json`. Hãy tìm mọi chỗ đặt tên mặc định, đảm bảo form chính và hộp thoại nhập dùng cùng tệp, sau đó chạy thử.
9. Yêu cầu mới: chỉ cho phép số điện thoại có 10 chữ số. Control nào đang gợi ý khuôn dạng? Kiểm tra hiện nằm ở đâu? Nêu cách từ chối dữ liệu sai trước khi sửa danh sách/tệp.
10. Yêu cầu mới: thêm tìm theo số điện thoại. Chỉ ra cần thêm control/giá trị điều kiện ở form tìm kiếm và nhánh so sánh ở lớp quản lý; giải thích vì sao chỉ thêm ô giao diện chưa đủ.

**Tự chấm mỗi bài:** 1 điểm nếu dự đoán đúng; 1 điểm nếu chỉ đúng đường đi trong source; 1 điểm nếu nêu được sửa ở đúng nơi và tác động phụ; 1 điểm nếu chạy kiểm chứng được. Bài nào chưa đạt 3/4 thì làm lại bằng một dữ liệu khác.

### Khung trả lời khi giảng viên giao yêu cầu lạ

Trả lời theo trình tự: “Tôi sẽ bắt đầu từ control/sự kiện …; dữ liệu hiện nằm ở …; nghiệp vụ cần sửa tại …; sau khi cập nhật danh sách, giao diện được làm mới bằng …; dữ liệu xuống tệp ở …; tôi sẽ kiểm tra trường hợp đúng, sai và trùng.” Sau đó mở source, xác minh từng điểm. Đây là cách thể hiện khả năng định vị và thay đổi chương trình thay vì đọc thuộc.

## Trình diễn trong 5–7 phút

1. Mở `MaNguon/NopBaiGiuaKy.sln`, chỉ ra hai project. Chạy Chủ đề 2: chọn một sinh viên, giải thích vì sao dữ liệu được đưa lên form, sửa một trường và bấm **Lưu**. Chỉ ra `isModified`, hộp thoại khi thoát và đường đi tới `DSNV.txt`. Chọn **No** nếu muốn giữ dữ liệu mẫu.
2. Chạy Chủ đề 3: chỉ ra hai bản ghi đọc từ `students.json`, mã gợi ý `2010003`, tìm tên `Nga`, rồi tải lại danh sách. Mở hộp thoại nhập tệp và giải thích `DuongDanFile`, `LoaiFile`.
3. Kết thúc bằng một tình huống thay đổi yêu cầu: ví dụ cấm MSSV trùng, thêm điều kiện tìm kiếm, hoặc đổi nơi lưu tệp; nêu chính xác lớp và hàm cần sửa.

## 1. Cấu trúc và luồng dữ liệu — 1,5 điểm

**Hỏi: Hai project khác nhau thế nào?** Chủ đề 2 có `frmSinhVienCNTT` quản lý cả giao diện và danh sách `dsSV`, dữ liệu lưu dạng tab trong `DSNV.txt`. Chủ đề 3 tách `frmQuanLySinhVien` (giao diện) khỏi `QuanLySinhVien` (danh sách và nghiệp vụ), hỗ trợ JSON/XML/TXT. Cả hai có lớp `SinhVien` làm mô hình dữ liệu.

**Hỏi: Một thao tác đi qua những đâu?** Ví dụ thêm ở Chủ đề 3: `btnThemMoi_Click` → `KiemTraNhap` → `LayThongTinForm` tạo `SinhVien` → `qlsv.Them` kiểm tra trùng MSSV, thêm vào `DanhSach`, gọi `GhiVaoFile` → `HienThiDanhSach` cập nhật `ListView`. `ListView` là phần hiển thị; `DanhSach` mới là dữ liệu trong bộ nhớ.

**Hỏi: Form Designer dùng để làm gì?** Tệp `.Designer.cs` tạo control, thiết lập thuộc tính và gắn sự kiện. Tệp `.cs` cùng tên chứa cách xử lý các sự kiện. Không nên tự sửa Designer để thay đổi nghiệp vụ.

## 2. Giải thích chức năng — 2 điểm

| Việc | Chủ đề 2 | Chủ đề 3 |
|---|---|---|
| Thêm | `btnLuu_Click` gọi `TimSinhVien`; chưa có MSSV thì thêm vào `dsSV` | `btnThemMoi_Click` gọi `qlsv.Them`; MSSV trùng thì trả `false` |
| Cập nhật | Cùng nút **Lưu**; tìm được MSSV thì chép các trường vào đối tượng cũ | `btnCapNhat_Click` gọi `qlsv.CapNhat`; thay phần tử đúng MSSV |
| Xóa | `cmsiXoa_Click` lấy MSSV dòng chọn, gọi `XoaSinhVien` | `tsmiXoaSinhVien_Click` gom MSSV, gọi `qlsv.Xoa` |
| Tìm kiếm | `TimSinhVien` dùng MSSV để tìm bản ghi khi cập nhật/chọn | `frmTimKiem` nhận điều kiện; `qlsv.TimKiem` duyệt danh sách và trả kết quả |
| Đồng bộ tệp | `isModified` đánh dấu thay đổi; khi thoát hỏi Yes/No/Cancel | `Them`, `CapNhat`, `Xoa` gọi `GhiVaoFile` ngay sau thao tác thành công |

**Hỏi: Vì sao phải gọi hàm hiển thị lại?** Thay đổi `List<SinhVien>` không tự thay đổi các dòng `ListView`. `LoadListView`/`HienThiDanhSach` xóa và dựng lại các dòng từ danh sách hiện tại.

**Hỏi: `mtxtMSSV` lấy giá trị mặc định ở đâu?** Trong Chủ đề 3, `frmQuanLySinhVien_Load` đọc `students.json` rồi đặt `mtxtMSSV.Text = qlsv.TaoMSSV(cboLop.Text)`. `cboLop_SelectedIndexChanged` tính lại khi đổi lớp; nhập tệp khác cũng tính lại. `TaoMSSV` tìm hậu tố lớn nhất của tiền tố lớp và cộng một.

## 3. Lý do thiết kế — 2 điểm

- **Control:** `MaskedTextBox` gợi ý khuôn dạng MSSV/điện thoại; `DateTimePicker` chọn ngày; `ComboBox` chọn lớp; `ListView` xem nhiều sinh viên; `OpenFileDialog` chọn tệp. Control hỗ trợ nhập, còn `KiemTraNhap`/kiểm tra trong nút Lưu quyết định dữ liệu hợp lệ.
- **Danh sách:** `List<SinhVien>` đủ đơn giản cho số bản ghi nhỏ của bài thực hành và thuận tiện giải thích vòng lặp. MSSV là khóa vì họ tên có thể trùng.
- **Tìm kiếm:** Chủ đề 3 duyệt từng sinh viên, bỏ bản ghi không thỏa MSSV, tên hoặc lớp. Tên được so sánh sau khi đổi sang chữ thường.
- **Tệp:** Chủ đề 2 dùng TXT tab để đọc được từng dòng; Chủ đề 3 dùng JSON cho dữ liệu mẫu, cũng có XML/TXT để luyện thao tác tệp. Hai chương trình tìm tệp dữ liệu cạnh ứng dụng khi mở.
- **Điểm đánh đổi:** Chủ đề 2 cho phép hủy thay đổi chưa lưu; Chủ đề 3 ghi ngay nên sau khi thêm/sửa/xóa cần biết chính xác tệp đang mở.

## 4. Tình huống mới — 3 điểm

**Nhập MSSV trùng trong Chủ đề 3:** `QuanLySinhVien.Them` duyệt `DanhSach`, gặp MSSV bằng nhau thì trả `false`. Form báo lỗi và không thêm. Muốn so sánh không phân biệt khoảng trắng đầu/cuối, chuẩn hóa MSSV trong `LayThongTinForm` hoặc ngay trước `Them`.

**Tìm theo lớp nhưng không thấy:** Kiểm tra giá trị `LopTim` từ `frmTimKiem`, nhánh `s.Lop != lop` trong `QuanLySinhVien.TimKiem`, rồi kiểm tra có gọi `HienThiDanhSach(ketQua)` hay không.

**Đổi lớp mà MSSV gợi ý sai:** Xem `cboLop_SelectedIndexChanged`, sau đó xem cách `TaoMSSV` suy ra hai chữ số năm từ tên lớp và tìm hậu tố lớn nhất. Nếu thêm lớp khóa 47, bổ sung ánh xạ tương ứng trong `TaoMSSV`.

**Đổi nơi lưu dữ liệu:** Với Chủ đề 2, sửa nơi ghép đường dẫn trong `DocTuFile` và `LuuVaoFile` cùng một cách. Với Chủ đề 3, sửa đường dẫn mặc định ở `frmQuanLySinhVien_Load` và `frmNhapFile_Load`/radio tương ứng; đảm bảo `DuongDanFile` trỏ đúng tệp trước khi `GhiVaoFile`.

**Xóa nhiều sinh viên:** Duyệt từ cuối danh sách trong `QuanLySinhVien.Xoa` hoặc `XoaSinhVien` để chỉ số các phần tử chưa xét không thay đổi sau `RemoveAt`.

**Tệp dữ liệu không tồn tại:** Kiểm tra tệp có được copy vào thư mục chạy; hàm đọc hiện trả về danh sách rỗng. Nếu giáo viên yêu cầu thông báo lỗi, bổ sung thông báo ở form sau khi kiểm tra `File.Exists`, trước khi gọi hàm đọc.

## 5. Phản biện và làm chủ sản phẩm — 1,5 điểm

Khi trả lời, dùng mẫu: **yêu cầu → control/hàm nhận yêu cầu → dữ liệu đổi thế nào → tệp đổi khi nào → rủi ro/cách sửa**. Nếu chưa chắc, mở đúng hàm để kiểm tra và giải thích từ mã, tránh đoán. Có thể chủ động nêu giới hạn: danh sách dùng vòng lặp tuyến tính phù hợp bài thực hành, còn dữ liệu lớn sẽ cần cách lưu/truy vấn khác; chương trình hiện chưa có chức năng hoàn tác cho Chủ đề 3.

## Trước khi nộp

- Điền họ tên, MSSV, lớp vào trang đầu báo cáo.
- Mở solution đóng gói, chọn từng project làm Startup Project và chạy thử trên máy sẽ trình bày.
- Kiểm tra ảnh minh họa và nội dung trong bản PDF; nộp mã nguồn ZIP và PDF (hoặc DOCX nếu hệ thống chấp nhận).
- Giữ bản sao tệp dữ liệu mẫu để có thể trình diễn lại sau các thao tác ghi tệp.
