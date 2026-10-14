# Mã nguồn bài thực hành giữa kỳ

Mở `NopBaiGiuaKy.sln` bằng Visual Studio 2022. Solution gồm hai project WinForms .NET 8:

- `ChuDe2_QuanLySinhVienCNTT`: bài quản lý sinh viên Chủ đề 2. Dữ liệu mẫu: `DSNV.txt`.
- `ChuDe3_BaiTap`: bài quản lý sinh viên và tập tin Chủ đề 3. Dữ liệu mẫu: `students.json`.

Chọn project muốn chạy bằng **Set as Startup Project**, rồi bấm **F5**. Hai tệp dữ liệu được sao chép cạnh tệp chạy khi build. Cần có .NET 8 SDK và kết nối để khôi phục gói NuGet `Newtonsoft.Json` của Chủ đề 3 lần đầu.

Chủ đề 2 giữ thay đổi trong bộ nhớ và hỏi lưu khi thoát. Chủ đề 3 ghi vào tệp đang mở ngay sau khi thêm, cập nhật hoặc xóa. Khi trình diễn, nên sao chép `DSNV.txt` và `students.json` trước để có thể khôi phục dữ liệu mẫu.
