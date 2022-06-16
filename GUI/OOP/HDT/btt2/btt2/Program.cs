using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btt2
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignConsole();
            int chon, chon1, chon2, chon3, chon4;
            
           

            while (true)
            {
                Console.Clear();
                chon = menu();
                Console.Clear();
                switch (chon)
                {
                    case 1:
                        {

                            do
                            {
                                HinhChuNhat a = new HinhChuNhat();
                                HinhChuNhat b = new HinhChuNhat();
                                Console.Clear();
                                Console.Write("                     ___________________________________________________________________________");
                                Console.Write("\n                    |--------------------------------BÀI 1-------------------------------------|");
                                Console.Write("\n                    |--------------------------------------------------------------------------|");
                                Console.Write("\n                    |                         Xin moi chon chuc nang:                          |");
                                Console.Write("\n                    | 1> nhập vào kích thước 1 HCN, xuất ra chu vi, diện tích và đường chéo    | ");
                                Console.Write("\n                    | 2> tăng kích thước HCN b bằng cách nhập từ bàn phím OR cộng thêm từ HCN a|");
                                Console.Write("\n                    | 0> BACK                                                                  |");
                                Console.Write("\n                    | 9> EXIT                                                                  |");
                                Console.Write("\n                    | Lựa chọn của bạn là: ");
                                chon1 = int.Parse(Console.ReadLine());

                                Console.Clear();
                                switch (chon1)
                                {
                                    case 1:

                                        a.NhapHinhChuNhat();
                                        a.VeHinhChuNhat();
                                        a.TinhChuVi();
                                        a.TinhDienTich();
                                        a.TinhDuongCheo();
                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;

                                    case 2:
                                        Console.WriteLine("nhập hình chữ nhật a: ");
                                        a.NhapHinhChuNhat();
                                        a.VeHinhChuNhat();
                                        Console.WriteLine("nhập hình chữ nhật b: ");
                                        b.NhapHinhChuNhat();
                                        b.VeHinhChuNhat();
                                        b.ChangeSize();
                                        Console.WriteLine("Hình chữ nhật b sau khi nhập thêm: ");
                                        b.VeHinhChuNhat();
                                        b.ChangeSize(a);
                                        Console.WriteLine("Hình chữ nhật b sau khi cộng thêm từ HCN a: ");
                                        b.VeHinhChuNhat();
                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 0:
                                        break;
                                    case 9:
                                        return;
                                    default:
                                        Console.WriteLine("Nhập sai!");
                                        Console.ReadLine();
                                        continue;
                                }
                            } while (chon1 != 0);
                            continue;
                        }

                    case 2:
                        {

                            do
                            {
                                Time t = new Time();
                                Console.Clear();
                                Console.Write("                     ___________________________________________________________________________");
                                Console.Write("\n                    |--------------------------------BÀI 2-------------------------------------|");
                                Console.Write("\n                    |--------------------------------------------------------------------------|");
                                Console.Write("\n                    |                         Xin moi chon chuc nang:                          |");
                                Console.Write("\n                    | 1> nhập/xuất, tăng/giảm thời gian theo dạng 24 giờ                       | ");
                                Console.Write("\n                    | 2> nhập/xuất, tăng/giảm thời gian theo dạng 12 giờ                       |");
                                Console.Write("\n                    | 0> BACK                                                                  |");
                                Console.Write("\n                    | 9> EXIT                                                                  |");
                                Console.Write("\n                    | Lựa chọn của bạn là: ");
                                chon2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (chon2)
                                {
                                    case 1:
                                        t.NhapThoiGian24();
                                        t.XuatThoiGian(24);
                                        Console.WriteLine("");
                                        t.TangThoiGian();
                                        Console.WriteLine("Thời gian sau khi tăng là: ");
                                        t.XuatThoiGian(24);
                                        Console.WriteLine("");
                                        t.GiamThoiGian();
                                        Console.WriteLine("Thời gian sau khi giảm là: ");
                                        t.XuatThoiGian(24);


                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 2:
                                        t.NhapThoiGian12();
                                        t.XuatThoiGian(12);
                                        Console.WriteLine("");
                                        t.TangThoiGian12();
                                        Console.WriteLine("Thời gian sau khi tăng là: ");
                                        t.XuatThoiGian(12);
                                        Console.WriteLine("");
                                        t.GiamThoiGian12();
                                        Console.WriteLine("Thời gian sau khi giảm là: ");
                                        t.XuatThoiGian(12);

                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 0:
                                        break;
                                    case 9:
                                        return;
                                    default:
                                        Console.WriteLine("Nhập sai!");
                                        Console.ReadLine();
                                        continue;
                                }
                            } while (chon2 != 0);

                            continue;
                        }

                    case 3:
                        {

                            do
                            {

                                VanDongVien j = new VanDongVien();

                                Console.Clear();
                                Console.Write("                     ___________________________________________________________________________");
                                Console.Write("\n                    |--------------------------------BÀI 3-------------------------------------|");
                                Console.Write("\n                    |--------------------------------------------------------------------------|");
                                Console.Write("\n                    |                         Xin moi chon chuc nang:                          |");
                                Console.Write("\n                    | 1> nhập/xuất thông tin vận động viên                                     | ");
                                Console.Write("\n                    | 0> BACK                                                                  |");
                                Console.Write("\n                    | 9> EXIT                                                                  |");
                                Console.Write("\n                    | Lựa chọn của bạn là: ");
                                chon3 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (chon3)
                                {
                                    case 1:
                                        j.NhapVDV();
                                        j.XuatVDV();


                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 0:
                                        break;
                                    case 9:
                                        return;
                                    default:
                                        Console.WriteLine("Nhập sai!");
                                        Console.ReadLine();
                                        continue;
                                }
                            } while (chon3 != 0);

                            continue;
                        }
                        
                    case 4:
                        {
                            do
                            {
                                PhanSo q = new PhanSo();
                                PhanSo b = new PhanSo();
                                PhanSo kq = new PhanSo();
                                Console.Clear();
                                Console.Write("                     ___________________________________________________________________________");
                                Console.Write("\n                    |--------------------------------BÀI 4-------------------------------------|");
                                Console.Write("\n                    |--------------------------------------------------------------------------|");
                                Console.Write("\n                    |                         Xin moi chon chuc nang:                          |");
                                Console.Write("\n                    | 1> nhập/xuất phân số, rút gọn và kiểm tra phân số có lơn hơn 1 hay không | ");
                                Console.Write("\n                    | 2> cộng thêm giá trị vào phân số                                         | ");
                                Console.Write("\n                    | 3> cộng 2 phân số                                                        | ");
                                Console.Write("\n                    | 4> trừ 2 phân số                                                         | ");
                                Console.Write("\n                    | 5> nhân 2 phân số                                                        | ");
                                Console.Write("\n                    | 6> chia 2 phân số                                                        | ");
                                Console.Write("\n                    | 0> BACK                                                                  |");
                                Console.Write("\n                    | 9> EXIT                                                                  |");
                                Console.Write("\n                    | Lựa chọn của bạn là: ");
                                chon4 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (chon4)
                                {
                                    case 1:
                                        q.NhapPhanSo();
                                        q.XuatPhanSo();
                                        q.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        q.XuatPhanSo();

                                        if (q.KiemTraLonHon1() == 1)
                                            Console.WriteLine("Phân số có giá trị lớn hơn 1");
                                        else
                                            Console.WriteLine("Phân số nhỏ hơn 1");
                                        q.NghichDaoPhanSo();
                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 2:
                                        q.NhapPhanSo();
                                        q.RutGonPhanSo();
                                        q.XuatPhanSo();
                                        q.tangPS();
                                        Console.WriteLine("Phân số sau khi tăng 1 đơn vị: ");
                                        q.XuatPhanSo();
                                        

                                        Console.WriteLine("Nhập đơn vị muốn tăng: ");
                                        int a = int.Parse(Console.ReadLine());
                                        q.tangPS(a);
                                        q.XuatPhanSo();
                                        q.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        q.XuatPhanSo();

                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;

                                    case 3:
                                        q.NhapPhanSo();
                                        q.RutGonPhanSo();
                                        q.XuatPhanSo();

                                        Console.WriteLine("Nhập phân số thứ 2: ");
                                        b.NhapPhanSo();
                                        b.RutGonPhanSo();
                                        b.XuatPhanSo();

                                        kq = q;
                                        kq.CongPhanSo(b);
                                        Console.Write("kết quả: ");
                                        kq.XuatPhanSo();
                                        kq.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        kq.XuatPhanSo();

                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 4:
                                        q.NhapPhanSo();
                                        q.RutGonPhanSo();
                                        q.XuatPhanSo();

                                        Console.WriteLine("Nhập phân số thứ 2: ");
                                        b.NhapPhanSo();
                                        b.RutGonPhanSo();
                                        b.XuatPhanSo();

                                        kq = q;
                                        kq=kq.TruPhanSo(b);
                                        Console.Write("kết quả: ");
                                        kq.XuatPhanSo();
                                        kq.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        kq.XuatPhanSo();

                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 5:
                                        q.NhapPhanSo();
                                        q.RutGonPhanSo();
                                        q.XuatPhanSo();
                                        Console.WriteLine("Nhập phân số thứ 2: ");
                                        b.NhapPhanSo();
                                        b.RutGonPhanSo();
                                        b.XuatPhanSo();

                                        kq = q;
                                        kq.NhanPhanSo(b);
                                        Console.Write("kết quả: ");
                                        kq.XuatPhanSo();
                                        kq.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        kq.XuatPhanSo();

                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 6:
                                        q.NhapPhanSo();
                                        q.RutGonPhanSo();
                                        q.XuatPhanSo();
                                        Console.WriteLine("Nhập phân số thứ 2: ");
                                        b.NhapPhanSo();
                                        b.RutGonPhanSo();
                                        b.XuatPhanSo();

                                        kq = q;
                                        kq.ChiaPhanSo(b);
                                        Console.Write("kết quả: ");
                                        kq.XuatPhanSo();
                                        kq.RutGonPhanSo();
                                        Console.WriteLine("Phân số sau khi rút gọn: ");
                                        kq.XuatPhanSo();
                                        Console.ReadLine();
                                        Console.ReadLine();
                                        continue;
                                    case 0:
                                        break;
                                    case 9:
                                        return;
                                    default:
                                        Console.WriteLine("Nhập sai!");
                                        Console.ReadLine();
                                        continue;
                                } 
                            } while (chon4 != 0);

                            continue;
                        }

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Nhập sai!");
                        Console.ReadLine();
                        continue;
                
                }
            }
            
        }
        


        static void DesignConsole()
        {
            Console.Title = "____________________________________________________________________________________________BÀI TẬP TẠO CLASS____________________________________________________________________________________________";
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.CursorVisible = false;
        }
        static int menu()
        {

            Console.Write("                     __________________________________________________________________________");
            Console.Write("\n                    |-----------Lập trình hướng đối tượng - GV: Nguyễn Thị Bích Ngân----------|");
            Console.Write("\n                    |--------------------------------WELLCOME---------------------------------|");
            Console.Write("\n                    |-----------------------------DESIGNED BY GẤU-----------------------------|");
            Console.Write("\n                    |                         Xin moi chon chuc nang:                         |");
            Console.Write("\n                    | 1> Xây dựng lớp hình chữ nhật                                           |");
            Console.Write("\n                    | 2> Xây dựng lớp Time                                                    |");
            Console.Write("\n                    | 3> Xây dựng lớp chứa thông tin của các vận động viên                    |");
            Console.Write("\n                    | 4> Xây dựng lớp phân số                                                 |");
            Console.Write("\n                    | 0> EXIT                                                                 |");
            Console.Write("\n                    | Lựa chọn của bạn là: ");
            return int.Parse(Console.ReadLine());
        }
    }
}


