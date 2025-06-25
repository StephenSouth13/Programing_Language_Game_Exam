using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.IO;


namespace ConsoleApp2
{
    public class Player
    {
        public string PlayerID { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Score {  get; set; }

        public string CreateAt {  get; set; }
    }
    internal class Program
    {
        private static string firebaseDB_URL = "";
        private static FirebaseClient firebase;
        static async Task Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(firebaseDB_URL)
            });
            firebase = new FirebaseClient(firebaseDB_URL);
            while(true) {
                Console.WriteLine("=====QUẢN LÝ DANH SÁCH PLAYER====");
                Console.WriteLine("1.Thêm 10 player mới vào ");
                Console.WriteLine("2.Hiển thị danh sách toàn bộ player ");
                Console.WriteLine("3.Cập nhật Gold hoặc Score ");
                Console.WriteLine("4.Xóa player theo PlayerID ");
                Console.WriteLine("0.Thoát khỏi chương trình ");
            
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": await 
                    case "2": await
                    case "3": await
                    case "4": await
                    case "0": return;
                    default : Console.WriteLine("Lỗi không hiển thị");break;
                }

    }
}
