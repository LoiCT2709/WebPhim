# WebPhim - Hướng dẫn tạo Database bằng Code-First (EF Core)

## 1. Cấu hình kết nối CSDL
Mở file `appsettings.json` và chỉnh lại chuỗi kết nối SQL Server:

```json
"ConnectionStrings": {
  "WebPhimHayDB": "Server=TRANKHIETLOI\\SQLEXPRESS01;Database=WebPhimDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
##2.Tạo Migration:
Mở Package Manager Console trong Visual Studio
Chạy:
Add-Migration InitialCreate
##3. Tạo Database:
Chạy:
Update-Database

##4.Kiểm tra:
Mở SQL Server Management Studio (SSMS)

Refresh và xem database WebPhimHay đã được tạo.

## Lưu ý khi tải project về
- Nếu bạn vừa clone project từ GitHub và muốn tạo lại database mới:
  1. Xóa thư mục `Migrations` trong dự án.
  2. Tạo migration mới:
     ```
     Add-Migration InitialCreate
     ```
  3. Cập nhật database:
     ```
     Update-Database
     ```
