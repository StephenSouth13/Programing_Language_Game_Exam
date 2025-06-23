🚀 Đồ Án Giữa Kỳ: Quản Lý Người Chơi Game Với C# & Firebase 🎮
Chào mừng bạn đến với dự án Console Application "Quản Lý Người Chơi Game" đầy thú vị, được phát triển bằng C# và tích hợp sức mạnh của Firebase Realtime Database! 🚀 Đây là bài tập giữa kỳ được thiết kế đặc biệt để củng cố kỹ năng của bạn trong việc tương tác với Firebase API, từ các thao tác CRUD cơ bản cho đến việc xử lý dữ liệu nâng cao như lọc, sắp xếp để tạo ra những bảng xếp hạng hoành tráng.

Bạn đã sẵn sàng để khám phá chưa? ✨

🎯 Mục Tiêu Chính Của Dự Án
Firebase API Mastery: 🌐 Nắm vững cách thức tương tác mượt mà với Firebase Realtime Database từ ứng dụng C# của bạn.
Quản Lý Player Toàn Diện: 🛠️ Triển khai đầy đủ các chức năng Create, Read, Update, Delete (CRUD) cho đối tượng Player, đảm bảo dữ liệu luôn được kiểm soát.
Sức Mạnh Của Dữ Liệu: 📊 Học cách lọc và sắp xếp dữ liệu hiệu quả bằng Firebase Queries để xây dựng các bảng xếp hạng đỉnh cao dựa trên Gold và Score.
Lưu Trữ Thông Minh: 💾 Ghi lại kết quả bảng xếp hạng trở lại Firebase với cấu trúc rõ ràng, dễ dàng truy xuất sau này.
✨ Điểm Nổi Bật Của Dự Án
Dự án này được chia thành ba phần chính, mỗi phần tập trung vào việc phát triển và kiểm tra một khía cạnh quan trọng của kỹ năng lập trình:

1. Quản Lý Danh Sách Player: Trái Tim Của Game 💖
Phần này là nền tảng, giúp bạn làm quen với các thao tác cơ bản nhưng cực kỳ quan trọng trên Firebase.

Thông Tin Player Chi Tiết: Bạn sẽ tạo chương trình cho phép nhập các thông tin sau cho mỗi người chơi:
PlayerID (chuỗi định danh duy nhất)
Name (tên người chơi)
Gold (số vàng sở hữu)
Score (điểm số đạt được)
Bộ Chức Năng CRUD Đầy Đủ:
➕ Thêm mới: Dễ dàng thêm 10 người chơi mới vào node /Players trên Firebase.
👀 Hiển thị: Xem toàn bộ danh sách người chơi hiện có chỉ với một cú nhấp chuột (hoặc dòng lệnh!).
✏️ Cập nhật: Thay đổi giá trị Gold hoặc Score của bất kỳ người chơi nào.
❌ Xóa: Gỡ bỏ một người chơi khỏi cơ sở dữ liệu dựa trên PlayerID.
💡 Mẹo: Hãy nhập dữ liệu Gold và Score thật đa dạng để các bảng xếp hạng sau này thêm phần kịch tính nhé!

2. Bảng Xếp Hạng Gold: Ai Là Triệu Phú? 💰🏆
Kiểm tra khả năng của bạn trong việc sắp xếp và hiển thị dữ liệu một cách trực quan.

Top 5 Triệu Phú Vàng: Chương trình sẽ hiển thị Top 5 người chơi có số Gold cao nhất.
Hiển Thị Giảm Dần: Dữ liệu sẽ được lấy từ Firebase và trình bày một cách gọn gàng theo thứ tự Gold giảm dần.
3. Bảng Xếp Hạng Score và Lưu Trữ Kết Quả: Vinh Danh Người Dẫn Đầu! 🌟💾
Phần này thử thách bạn với sự kết hợp của việc đọc, ghi và xử lý logic dữ liệu nâng cao.

Thu Thập Dữ Liệu: Lấy toàn bộ danh sách người chơi từ Firebase.
Sắp Xếp Đỉnh Cao: Sắp xếp người chơi theo Score giảm dần một cách chính xác.
Chọn Lọc 5 Ngôi Sao: Chỉ chọn Top 5 người chơi có Score cao nhất.
Lưu Trữ Lịch Sử: Ghi danh sách Top 5 này vào một node mới trên Firebase có tên /TopScore, mỗi người chơi sẽ kèm theo chỉ số index tương ứng với thứ hạng của họ.
🛠️ Công Nghệ & Công Cụ
Ngôn ngữ lập trình: 💙 C#
Nền tảng: .NET Core Console Application
Cơ sở dữ liệu: 🔥 Firebase Realtime Database
Thư viện/SDK: FirebaseDatabase.net
🚀 Hướng Dẫn Thiết Lập & Chạy Dự Án
Làm theo các bước đơn giản sau để dự án hoạt động trên máy của bạn:

Clone Repository:
Bash

git clone https://github.com/StephenSouth13/Programing_Language_Game_Exam.git
cd Programing_Language_Game_Exam
Cấu hình Firebase Của Bạn:
Tạo Dự Án Firebase: Ghé thăm Firebase Console và tạo một dự án mới tinh.
Kích Hoạt Realtime Database: Trong dự án Firebase của bạn, vào tab Realtime Database và tạo cơ sở dữ liệu mới (nếu bạn chưa có).
Tải Khóa Bí Mật: Đi tới Project settings (biểu tượng bánh răng cưa) > Service accounts > và nhấp vào Generate new private key để tải xuống file JSON chứa khóa bí mật của bạn.
Đặt File JSON: Đặt file JSON này vào thư mục dự án C# của bạn (ví dụ: trong thư mục ConsoleApp1). Đảm bảo đường dẫn tới file được cấu hình chính xác trong mã nguồn của bạn.
Thiết Lập Rules (Quan trọng cho Dev): Để cho phép ứng dụng đọc/ghi dữ liệu trong quá trình phát triển, hãy cấu hình Rules cho Realtime Database như sau (lưu ý: KHÔNG sử dụng cấu hình này cho môi trường production):
JSON

{
  "rules": {
    ".read": true,
    ".write": true
  }
}
Cài Đặt Dependencies:
Mở dự án trong Visual Studio hoặc VS Code.
Đảm bảo bạn đã cài đặt package NuGet FirebaseDatabase.net. Bạn có thể chạy lệnh sau trong Terminal (đảm bảo bạn đang ở trong thư mục ConsoleApp1):
Bash

dotnet add package FirebaseDatabase.net
Chạy Ứng Dụng:
Trong thư mục ConsoleApp1 của dự án, mở Terminal và chạy lệnh:
Bash

dotnet run
Thế là xong! Ứng dụng Console của bạn đã sẵn sàng hoạt động.
👨‍💻 Tác Giả
✨ Được thực hiện bởi StephenSouth13 ✨
