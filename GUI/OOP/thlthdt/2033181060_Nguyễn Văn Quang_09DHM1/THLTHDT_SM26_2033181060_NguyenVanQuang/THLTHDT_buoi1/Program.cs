using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi1
{
    class Program
    {

        public static void BaiTap1()
        {
            Console.WriteLine("Bài tập 1: ");
            int a, b, tong, hieu;
            double tich, thuong;
            Console.Write("Nhập số thứ nhất: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            b = int.Parse(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = (double)a / b;
            Console.WriteLine("Tổng:   {0} + {1} = {2}", a, b, tong);
            Console.WriteLine("Hiệu:   {0} - {1} = {2}", a, b, hieu);
            Console.WriteLine("Tích:   {0} * {1} = {2}", a, b, tich);
            Console.WriteLine("Thương: {0} : {1} = {2:0.00}", a, b, thuong);
        }

        public static void BaiTap2()
        {
            Console.WriteLine("Bài tập 2: ");
            string mssv, hoten;
            double dtb;
            Console.WriteLine("Nhập họ và tên: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhập mã số sinh viên: ");
            mssv = Console.ReadLine();
            Console.WriteLine("Nhập điểm trung bình: ");
            dtb = double.Parse(Console.ReadLine());

            if (dtb >= 8)
                Console.WriteLine("Loại giỏi!");
            else if (dtb >= 6.5)
                Console.WriteLine("Loại khá!");
            else if (dtb >= 5)
                Console.WriteLine("Loại trung bình!");
            else
                Console.WriteLine("Loại yếu kém!");

        }
        public static void xuatList(List<int> mang)
        {
            Console.Write("\nGiá trị của mảng: ");
            foreach (int x in mang)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("");
        }
        
        public static void creatListRandom(List<int> mang)
        {
            Random a = new Random();
            for (int i = 0; i < mang.Capacity; i++)
            {
                mang.Add(a.Next(100));
            }
        }
        public static void BaiTap3()
        {
            int n;
            Console.Write("Nhập số phần tử: ");
            n = int.Parse(Console.ReadLine());
            List<int> mang = new List<int>(n);
            creatListRandom(mang);
            xuatList(mang);
        }

        public static void BaiTap4()
        {
            double a, b;
            Console.WriteLine("Phương trình bậc 1 có dạng: ax + b = c");
            Console.Write("Nhập a= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b= ");
            b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phương trình có vô số nghiệm");
                else
                    Console.WriteLine("Phương trình vô nghiệm");
            }
            else
                Console.WriteLine("Phương trình có nghiệm= {0:0.00}", (double)-b / a);
        }

        public static void BaiTap5()
        {
            Console.WriteLine("Bài tập 5: ");
            double a, b, c;
            Console.WriteLine("Phương trình bậc 2 có dạng: ax^2 + bx + c = 0");
            Console.Write("Nhập a= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhập c= ");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm");
                    else
                        Console.WriteLine("Phương trình vô nghiệm");
                }

                else
                    Console.WriteLine("Phương trình có 1 nghiệm: {0}", (double)-c / b);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                Console.WriteLine("delta= {0}", delta);
                if (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                if (delta == 0)
                    Console.WriteLine("Phương trình có nghiệm kép: x1=x2= {0}", (double)(-b / 2 * a));
                if (delta > 0)
                    Console.WriteLine("Phương trình có 2 nghiệm: x1= {0}, x2= {1}", (double)(-b - Math.Sqrt(delta)) / 2 * a, (-b + Math.Sqrt(delta)) / 2 * a);
            }
        }

        public static void BaiTap6()
        {
            Console.WriteLine("Bài tập 6: ");
            int thu, ngay, thang, nam;
            Console.Write("Nhập ngày= ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng= ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập nam= ");
            nam = int.Parse(Console.ReadLine());

            while (thang < 3)
            {
                thang += 12;
                nam -= 1;
            }

            thu = (ngay + 2 * thang + (3 * (thang + 1)) / 5 + nam + (nam / 4)) % 7;
            if (thu == 1)
                Console.WriteLine("Chủ nhật");
            else
                Console.WriteLine("thứ {0}", thu + 1);

        }

        public static void BaiTap7()
        {
            Console.WriteLine("Bài tập 7: ");
            int n;
            Console.WriteLine("Nhập số nguyên dương n: ");
            n = int.Parse(Console.ReadLine());
            PhanTichThuaSoNT(n);
        }
        public static void PhanTichThuaSoNT(int n)
        {
            for (int i = 2; n > 1;)
            {
                if (n % i == 0)
                {
                    Console.Write("{0}", i);
                    n /= i;                           // nếu n chia hết cho i, giảm n cho đến khi n=1
                    if (n > 1)
                        Console.Write("*");
                }
                else i++;
            }
        }

        public static int kiemTraSoChinhPhuong(double n)
        {
            int t = (int)Math.Sqrt(n);
            if (t * t == n)
                return 1;
            else return 0;
        }

        public static void BaiTap8()
        {
            Console.WriteLine("Bài tập 8: ");
            double n;
            do
            {
                Console.WriteLine("Nhập số nguyên dương n: ");
                n = double.Parse(Console.ReadLine());
                Console.WriteLine("n là số chính phương của {0}^2", Math.Sqrt(n));
                if (kiemTraSoChinhPhuong(n) == 0)
                    Console.WriteLine("n không phải số chính phương!");
            } while (kiemTraSoChinhPhuong(n) == 0);
        }


        public static int ktNamNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)     //năm nhuận là năm chia hết cho 400 và 4 nhưng không chia hết cho 100
            {
                return 1;
            }
            return 0;
        }


        public static int tinhSoNgayTrongThang(int thang, int nam)
        {
            int ngaytrongthang;

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngaytrongthang = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngaytrongthang = 30;
                    break;
                case 2:
                    if (ktNamNhuan(nam)==1)
                    {
                        ngaytrongthang = 29;
                    }
                    else
                    {
                        ngaytrongthang = 28;
                    }
                    break;
                default:    ngaytrongthang = 0; break;
            }

            return ngaytrongthang;
        }


        public static int kiemTraNgayHopLe(int ngay,int thang, int nam)
        {
                // Kiểm tra năm
                if (nam<=0||thang<=0)
                {
                return 0;
                }
                // Kiểm tra tháng
                if (!(thang >= 1 && thang <= 12))
                {
                return 0;
                }
                // Kiểm tra ngày
                if (!(ngay >= 1 && ngay <= tinhSoNgayTrongThang(thang, nam)))
                {
                return 0;
                }
                return 1; 
            }
        public static void timNgayHomTruoc(ref int nDay,ref int nMonth,ref int nYear)
        {
            nDay--;
            if (nDay == 0)
            {
                nMonth--;
                if (nMonth == 0)
                {
                    nMonth = 12;
                    nYear--;
                }

                nDay = tinhSoNgayTrongThang(nMonth, nYear);
            }
        }

        // Hàm tìm ngày hôm sau của một ngày dd/mm/yyyy cho trước (đã hợp lệ)
        public static void timNgayHomSau(ref int ngay,ref int thang,ref int nam)
        {
            ngay++;
            if (ngay > tinhSoNgayTrongThang(thang, nam))
            {
                ngay = 1;
                thang++;
                if (thang > 12)
                {
                    thang = 1;
                    nam++;
                }
            }
        }
        public static void BaiTap9()
        {
            Console.WriteLine("Bài tập 9: ");
            int  ngay, thang, nam;
            Console.Write("Nhập ngày= ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng= ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm= ");
            nam = int.Parse(Console.ReadLine());
            if (kiemTraNgayHopLe(ngay, thang, nam)==1)
            {
                int tmpDay = ngay;
                int tmpMonth = thang;
                int tmpYear = nam;
                // Tìm ngày hôm trước
                timNgayHomTruoc(ref tmpDay,ref tmpMonth,ref tmpYear);
               Console.WriteLine("Yesterday: {0} / {1} / {2} ",tmpDay,tmpMonth,tmpYear);
                tmpDay = ngay;
                tmpMonth = thang;
                tmpYear = nam;
                // Tìm ngày hôm sau
                timNgayHomSau(ref tmpDay,ref tmpMonth,ref tmpYear);
               Console.WriteLine("Tomorrow: {0} / {1} / {2}",tmpDay,tmpMonth,tmpYear);
            }
            else
            {
                Console.WriteLine(" Ngay khong hop le");
            }
        }
        public static void kiemTraXuatHien(List<int> mang)
        {
            int x;
            Console.WriteLine("Nhập vào số muốn kiểm tra: ");
            x = int.Parse(Console.ReadLine());
            if (mang.Contains(x) == true)
                Console.WriteLine("Tìm thấy giá trị x={0} trong mảng!",x);
            else
                Console.WriteLine("Không thấy giá trị x={0} trong mảng!",x);
        }
        public static Boolean kiemTraSoCo2ChuSo(int x)
        {
            int dem = 1;
            while (x >= 10)
            {
                x /= 10;
                dem++;
            }
            if (dem == 2)
                return true;
            else return false;
        }

        public static Boolean kiemTraSoDeuChan(int x)
        {
            while (x > 0)
            {
                if ((x % 10) % 2 != 0)
                    return false;
                x /= 10;
            }
            return true;
        }
        public static void xuatList2ChuSo(List<int> mang)
        {
            Console.Write("Các số có 2 chữ số: ");
            foreach (int x in mang)
            {
                if (kiemTraSoCo2ChuSo(x))
                    Console.Write(x + " ");
            }
            Console.WriteLine("");
        }

        public static void xuatCacChuSoDeuLaChan(List<int> mang)
        {
            Console.Write("Các số chữ số đều là số chẵn: ");
            foreach (int x in mang)
            {
                if (kiemTraSoDeuChan(x))
                    Console.Write(x + " ");
            }
            Console.WriteLine("");
        }

        public static Boolean kiemTraSoNguyenTo(int x)
        {
            int j = 2;
            while (x % j != 0)
                j++;
            if (x == j)
                return true;
            else return false;
        }
        public static void xuatListSNT(List<int> mang)
        {
            Console.Write("Các số nguyên tố: ");
            foreach (int x in mang)
            {
                if (kiemTraSoNguyenTo(x))
                    Console.Write(x + " ");
            }
            Console.WriteLine("");
        }

        public static void xoaSoLeVaBoiCua3(List<int> mang)
        {
            for(int i=0;i<mang.Count;i++)
            {
                if (mang[i] % 2 != 0 && mang[i] % 3 == 0)
                    mang.Remove(mang[i]);
            }
            Console.Write("Dãy số sau khi xóa: ");
            xuatList(mang);
            Console.WriteLine("");
        }

        public static void sortA(List<int> mang)
        {
            mang.Sort();
            xuatList(mang);
        }
        public static void sortB(List<int> mang)
        {
            mang.Sort();
            mang.Reverse();
            xuatList(mang);
        }

        public static void BaiTap10()
        {
            Console.WriteLine("Bài tập 10: ");
            List<int> dayso = new List<int>(20);
            creatListRandom(dayso);
            xuatList(dayso);
            dayso.Reverse();
            Console.WriteLine("Dãy số sau khi đảo: ");
            xuatList(dayso);
            kiemTraXuatHien(dayso);
            xuatList2ChuSo(dayso);
            xuatCacChuSoDeuLaChan(dayso);
            xuatListSNT(dayso);
            xoaSoLeVaBoiCua3(dayso);
            Console.Write("dãy số sắp xếp giảm dần: ");
            sortA(dayso);
            Console.Write("dãy số sắp xếp tăng dần: ");
            sortB(dayso);
        }
            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "THLTHDT - Nguyễn Văn Quang - 2033181060";
            //BaiTap1();
            //BaiTap2();
            //BaiTap3();
            //BaiTap4();
            //BaiTap5();
            //BaiTap6();
            //BaiTap7();
            //BaiTap8();
            //BaiTap9();
            BaiTap10();
            Console.ReadKey();
        }
    }
}





