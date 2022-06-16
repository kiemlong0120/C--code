using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Threading;



namespace nụ_cười_tỏa_nắng
{
    
    class Program
    {
        static void StartProgram()
        {
            

            Console.OutputEncoding = Encoding.Unicode;  //cái này để in ra tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            DateTime now = DateTime.Now;
            Console.Title = "Nụ cười tỏa nắng";
            Console.WriteLine("                   Now is: " + now+ " TPHCM");
        }

        static void Lyric()
        {
            Console.WriteLine("                                Nụ cười tỏa nắng - Trình bày: MR.SIRO\n\n");
            Thread.Sleep(3500);
            Console.WriteLine("                                Be happy always smile");
            Thread.Sleep(3500);
            Console.WriteLine("                                We'll never forget you");
            Thread.Sleep(3500);
            Console.WriteLine("                                We miss you so");
            Thread.Sleep(3500);  
            Console.WriteLine("                                W-A-N-B-I");
            Thread.Sleep(3300);
            Console.WriteLine("                               ____    __    ____  ___       __   __   ______    __   ");
            Thread.Sleep(1900);
            Console.WriteLine(@"                               \   \  /  \  /   / /   \     |  \ |  | |   _  \  |  | ");
            Thread.Sleep(1900);
            Console.WriteLine(@"                                \   \/    \/   / /  ^  \    |   \|  | |  |_)  | |  | ");
            Thread.Sleep(1800);
            Console.WriteLine(@"                                 \            / /  /_\  \   |  . `  | |   _  <  |  | ");
            Thread.Sleep(1800);
            Console.WriteLine(@"                                  \    /\    / /  _____  \  |  |\   | |  |_)  | |  | ");
            Thread.Sleep(1800);
            Console.WriteLine(@"                                   \__/  \__/ /__/     \__\ |__| \__| |______/  |__| ");
            Thread.Sleep(4800);
            Console.WriteLine("  \n                               Thời gian không làm phai mờ đi những giấc mơ em để lại");
            Thread.Sleep(7400);
            Console.WriteLine("                               Gửi vào mây bao nhớ thương, biết bao nhiêu hồi ức ngọt ngào");
            Thread.Sleep(7400);
            Console.WriteLine("                               Nhẹ như nắng lấp lánh, mà sâu lắng bao kỷ niệm khó phai");
            Thread.Sleep(6100);
            Console.WriteLine("                               Ngày xưa em chưa từng biết dỗi hờn");
            Thread.Sleep(4000);
            Console.WriteLine("                               Chưa từng làm ai tổn thương\n");
            Thread.Sleep(3400);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                               NỤ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Thread.Sleep(400);
            Console.Write(" CƯỜI");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(400);
            Console.Write(" TỎA");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(400);
            Console.Write(" NẮNG!");
            Console.ResetColor();
            Thread.Sleep(1400);
            Console.Write(" NHẸ");
            Thread.Sleep(500);
            Console.WriteLine(" NHÀNG...\n");
            Thread.Sleep(1600);
            Console.WriteLine("                               Sưởi ấm cho bao con tim thêm\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(3100);
            Console.Write("                               NIỀM");
            Thread.Sleep(400);
            Console.Write(" TIN");
            Thread.Sleep(400);
            Console.Write(" với");
            Thread.Sleep(1300);
            Console.WriteLine(" CUỘC ĐỜI...\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Write("                               Có biết không em nơi này\n");
            Thread.Sleep(3200);
            Console.WriteLine("                               NHỚ em biết bao");
            Thread.Sleep(3200);
            Console.WriteLine("                               Và mọi người ai cũng rất trân trọng\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(3900);
            Console.Write("                               TỪNG");
            Thread.Sleep(400);
            Console.Write(" GIÂY");
            Thread.Sleep(400);
            Console.Write(" PHÚT");
            Thread.Sleep(1300);
            Console.WriteLine(" TUYỆT VỜI...\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.WriteLine("                               Dẫu đứng bên nhau chưa lâu để gần để thấu hết cuộc đời");
            Thread.Sleep(7600);
            Console.WriteLine("                               Những khó khăn và bộn bề");
            Thread.Sleep(2300);
            Console.WriteLine("                               Vì em chỉ muốn mỗi lần nghĩ đến em");
            Thread.Sleep(6500);
            Console.WriteLine("                               Là nụ cười toả nắng thân thương hôm nào");
            Thread.Sleep(5200);
            Console.WriteLine("                               Vẫn yêu thương vẹn nguyên, đong đầy…");
            Thread.Sleep(5000);
            Console.WriteLine("                               --------------------------------------------------------");
            Console.WriteLine("                               --------------DESIGNED BY NGUYỄN VĂN QUANG--------------");
        }

        static void Main(string[] args)
        {
            //hàm đọc file nhạc
            Audio audio = new Audio();
            Computer c = new Computer();
            c.Audio.Play(@"../../data/Nu-Cuoi-Toa-Nang-Mr-Siro_2.wav", Microsoft.VisualBasic.AudioPlayMode.Background);
            StartProgram();
            Lyric();
           
            Console.ReadKey();
            Console.ReadLine();


        }



        public static bool False { get; set; }
    }
}
