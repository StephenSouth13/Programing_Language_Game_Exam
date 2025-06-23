ĐỀ THI GIỮA KỲ – LẬP TRÌNH C# & FIREBASE
Thời gian: 120 phút 
Nền tảng: Firebase Realtime Database + ứng dụng Console C# 
 Mục tiêu: Thực hành thao tác dữ liệu qua Firebase API 
1 – Quản lý danh sách Player (6P)
Mục tiêu: Kiểm tra khả năng thao tác CRUD với Firebase bằng C#.
Yêu cầu:
1. Tạo chương trình C# nhập thông tin người chơi gồm:
o PlayerID (chuỗi)
o Name (chuỗi)
o Gold (int)
o Score (int)
2. Thực hiện các chức năng:
o Thêm 10 player mới vào /Players (2P)
o Hiển thị toàn bộ danh sách player (2P)
o Cập nhật Gold hoặc Score (1P)
o Xóa player theo PlayerID (1P)
3. Dữ liệu được lưu và truy xuất từ Firebase Realtime Database.
4. Dữ liệu cần đa dạng (giá trị khác nhau để sắp xếp được)
![image](https://github.com/user-attachments/assets/166be45c-0803-4f24-b89f-cec9f8f8ef32)
-Bảng xếp hạng Gold (2P)
Mục tiêu: Kiểm tra khả năng lọc và sắp xếp dữ liệu.
Yêu cầu:
1. Viết chương trình hiển thị Top 5 người chơi có Gold cao nhất.
2. Dữ liệu lấy từ Firebase và hiển thị theo thứ tự giảm dần
![image](https://github.com/user-attachments/assets/f43fc034-f1af-438c-ad77-361b0f4a9d56)
- Bảng xếp hạng Score và lưu trữ kết quả (2P)
Mục tiêu: Vận dụng thao tác đọc/ghi dữ liệu và logic sắp xếp.
Yêu cầu:
1. Lấy toàn bộ danh sách player từ Firebase.
2. Sắp xếp theo Score giảm dần.
3. Chỉ lấy 5 player có điểm cao nhất và ghi danh sách này vào một node khác trong 
Firebase có tên: TopScore thêm vào chỉ số index là thứ hạng trong TopScore.
![image](https://github.com/user-attachments/assets/03f6f553-039d-4b13-a4fc-1d309e8122f3)


