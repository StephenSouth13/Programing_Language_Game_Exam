📝 Nội Dung Đề Thi Giữa Kỳ – Lập Trình C# & Firebase
⏱ Thời gian: 120 phút
🔧 Nền tảng: Firebase Realtime Database + Ứng dụng Console C#
🎯 Mục tiêu: Thành thạo thao tác dữ liệu qua Firebase API bằng C#

1️⃣ Quản Lý Danh Sách Người Chơi (6 điểm)
📌 Mục tiêu: Kiểm tra khả năng thao tác dữ liệu cơ bản (CRUD) với Firebase từ ứng dụng C#.

✅ Yêu cầu:
Tạo chương trình cho phép nhập thông tin người chơi:

PlayerID (chuỗi)

Name (chuỗi)

Gold (số nguyên)

Score (số nguyên)

Thực hiện các chức năng:

➕ Thêm 10 người chơi mới vào node /Players (2 điểm)

👀 Hiển thị toàn bộ danh sách người chơi (2 điểm)

✏️ Cập nhật Gold hoặc Score của một người chơi (1 điểm)

❌ Xoá người chơi theo PlayerID (1 điểm)

⚠️ Dữ liệu phải đa dạng về Gold và Score để đảm bảo sắp xếp hiệu quả ở các phần sau.

2️⃣ Bảng Xếp Hạng Theo Gold (2 điểm)
📌 Mục tiêu: Kiểm tra kỹ năng truy vấn, lọc và sắp xếp dữ liệu.

✅ Yêu cầu:
Truy xuất toàn bộ danh sách từ Firebase.

Hiển thị Top 5 người chơi có Gold cao nhất.

Dữ liệu được sắp xếp giảm dần theo Gold.

3️⃣ Bảng Xếp Hạng Theo Score & Lưu Trữ Kết Quả (2 điểm)
📌 Mục tiêu: Vận dụng kỹ năng xử lý dữ liệu, ghi dữ liệu mới vào Firebase.

✅ Yêu cầu:
Truy xuất danh sách người chơi từ Firebase.

Sắp xếp danh sách theo Score giảm dần.

Lấy Top 5 người chơi có Score cao nhất.

Ghi danh sách này vào một node mới /TopScore, kèm theo chỉ số thứ hạng (index từ 1 đến 5).

🎓 Tổng kết:
Đề thi giúp bạn luyện tập toàn diện từ thao tác CRUD, xử lý truy vấn cho đến tổ chức dữ liệu theo thứ hạng — tất cả đều áp dụng thực tế trên Firebase và C#. Hãy chuẩn bị dữ liệu hợp lý để đạt kết quả tối ưu nhất!

Cách làm:
using Firebase.Database;
using Firebase.Database.Query;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirebase
{
    public class Player
    {
        public string PlayerID { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Score { get; set; }
    }

    internal class Program
    {
        private static string firebaseDB_URL = "https://your-database-url.firebaseio.com/";
        private static FirebaseClient firebase;

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("serviceAccountKey.json")
            });

            firebase = new FirebaseClient(firebaseDB_URL);

            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Thêm 10 Player mới");
                Console.WriteLine("2. Hiển thị toàn bộ danh sách Player");
                Console.WriteLine("3. Cập nhật Gold hoặc Score theo PlayerID");
                Console.WriteLine("4. Xoá Player theo PlayerID");
                Console.WriteLine("5. Hiển thị Top 5 Gold cao nhất");
                Console.WriteLine("6. Ghi Top 5 Score cao nhất vào node TopScore");
                Console.WriteLine("0. Thoát");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": await AddPlayers(); break;
                    case "2": await ShowPlayers(); break;
                    case "3": await UpdatePlayer(); break;
                    case "4": await DeletePlayer(); break;
                    case "5": await ShowTopGold(); break;
                    case "6": await SaveTopScore(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
                }
            }
        }

        // 1. Thêm 10 player mới vào /Players
        public static async Task AddPlayers()
        {
            var rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                var player = new Player
                {
                    PlayerID = $"P{i:D3}",
                    Name = $"Player_{i}",
                    Gold = rand.Next(50, 1000),
                    Score = rand.Next(100, 10000)
                };

                await firebase
                    .Child("Players")
                    .Child(player.PlayerID)
                    .PutAsync(player);

                Console.WriteLine($"✔ Đã thêm: {player.PlayerID} - {player.Name}");
            }
        }

        // 2. Hiển thị toàn bộ danh sách player
        public static async Task ShowPlayers()
        {
            var all = await firebase.Child("Players").OnceAsync<Player>();
            Console.WriteLine("\n📄 Danh sách toàn bộ Player:");
            foreach (var item in all)
            {
                var p = item.Object;
                Console.WriteLine($"ID: {p.PlayerID} | Name: {p.Name} | Gold: {p.Gold} | Score: {p.Score}");
            }
        }

        // 3. Cập nhật Gold hoặc Score
        public static async Task UpdatePlayer()
        {
            Console.Write("Nhập PlayerID cần cập nhật: ");
            var id = Console.ReadLine();

            var player = await firebase.Child("Players").Child(id).OnceSingleAsync<Player>();
            if (player == null)
            {
                Console.WriteLine("❌ Không tìm thấy Player.");
                return;
            }

            Console.WriteLine("Cập nhật:\n1. Gold\n2. Score");
            var option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Nhập Gold mới: ");
                if (int.TryParse(Console.ReadLine(), out int newGold))
                {
                    player.Gold = newGold;
                }
            }
            else if (option == "2")
            {
                Console.Write("Nhập Score mới: ");
                if (int.TryParse(Console.ReadLine(), out int newScore))
                {
                    player.Score = newScore;
                }
            }
            else
            {
                Console.WriteLine("❌ Tuỳ chọn không hợp lệ.");
                return;
            }

            await firebase.Child("Players").Child(id).PutAsync(player);
            Console.WriteLine("✔ Đã cập nhật thành công.");
        }

        // 4. Xoá player theo PlayerID
        public static async Task DeletePlayer()
        {
            Console.Write("Nhập PlayerID cần xoá: ");
            var id = Console.ReadLine();

            await firebase.Child("Players").Child(id).DeleteAsync();
            Console.WriteLine("🗑️ Đã xoá player.");
        }

        // 2 - Bảng xếp hạng Gold (hiển thị top 5 theo Gold)
        public static async Task ShowTopGold()
        {
            var all = await firebase.Child("Players").OnceAsync<Player>();
            var topGold = all
                .Select(p => p.Object)
                .OrderByDescending(p => p.Gold)
                .Take(5)
                .ToList();

            Console.WriteLine("\n🏆 Top 5 Player có Gold cao nhất:");
            foreach (var p in topGold)
            {
                Console.WriteLine($"{p.PlayerID} | {p.Name} | Gold: {p.Gold} | Score: {p.Score}");
            }
        }

        // 3 - Lưu Top 5 Score vào node TopScore (có chỉ số thứ hạng)
        public static async Task SaveTopScore()
        {
            var all = await firebase.Child("Players").OnceAsync<Player>();
            var topScore = all
                .Select(p => p.Object)
                .OrderByDescending(p => p.Score)
                .Take(5)
                .ToList();

            await firebase.Child("TopScore").DeleteAsync(); // xoá cũ nếu có

            int index = 1;
            foreach (var p in topScore)
            {
                await firebase
                    .Child("TopScore")
                    .Child(index.ToString())
                    .PutAsync(new
                    {
                        Rank = index,
                        p.PlayerID,
                        p.Name,
                        p.Gold,
                        p.Score
                    });

                index++;
            }

            Console.WriteLine("✔ Đã lưu Top 5 Score vào node TopScore.");
        }
    }
}
✅ Hướng dẫn sử dụng nhanh
Tạo project C# Console mới

Cài thư viện bằng NuGet:

mathematica
Copy
Edit
Install-Package FirebaseAdmin
Install-Package FirebaseDatabase.net
Thêm file serviceAccountKey.json từ Firebase → đặt trong thư mục dự án.

Thay đổi firebaseDB_URL bằng URL của bạn (định dạng: https://<project-id>.firebaseio.com/)

Chạy chương trình, thực hiện theo menu.
