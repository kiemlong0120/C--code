using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class Program
    {
        public static void BaiTap1()
        {
            HinhTron ht1 = new HinhTron();
            ht1.nhap();
            ht1.xuat();
        }

        public static void BaiTap2()
        {
            NhanVien nv1 = new NhanVien();
            nv1.nhap();
            nv1.xuat();
            nv1.tinhLuong();
            nv1.tinhThuong();
        }

        public static void BaiTap3()
        {
            NuocGiaiKhat ngk1 = new NuocGiaiKhat();
            ngk1.nhap();
            ngk1.xuat();

        }
        public static void BaiTap4()
        {
            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.NhapHinhChuNhat();
            hcn1.VeHinhChuNhat();
            hcn1.TinhChuVi();
            hcn1.TinhDienTich();
            hcn1.TinhDuongCheo();
            hcn1.ChangeSize();
            Console.WriteLine("Hình chữ nhật sau khi thay đổi kích thước: ");
            hcn1.VeHinhChuNhat();
            Console.WriteLine("Nhập hình chữ nhật a để tăng giảm: ");
            HinhChuNhat a = new HinhChuNhat();
            a.NhapHinhChuNhat();
            a.VeHinhChuNhat();
            hcn1.ChangeSize(a);
            Console.WriteLine("Hình chữ nhật sau khi thay đổi kích thước: ");
            hcn1.VeHinhChuNhat();
        }
        public static void BaiTap5()
        {
            int chon;
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
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (chon)
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
            } while (chon != 0);
        }

        public static void BaiTap6()
        {
            VanDongVien j = new VanDongVien();
            j.NhapVDV();
            j.XuatVDV();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //BaiTap1();
            //BaiTap2();
            //BaiTap3();
            //BaiTap4();
            //BaiTap5();
            //BaiTap6();
            Console.ReadKey();
        }
    }
}
