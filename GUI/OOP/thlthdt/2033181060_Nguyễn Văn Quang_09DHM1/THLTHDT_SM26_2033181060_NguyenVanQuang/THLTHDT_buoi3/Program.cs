using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi3
{
    class Program
    {
        public static void BaiTap1()
        {
            SoPhuc sp1 = new SoPhuc();
            sp1.nhap();
            sp1.xuat("z1");

            SoPhuc sp2 = new SoPhuc();
            sp2.nhap();
            sp2.xuat("z2");

            Console.WriteLine("Cộng và so sánh theo hàm truyền thống: ");
            SoPhuc kq = sp1.cong(sp2);
            kq.xuat("kq");

            Console.Write("So sánh sp1 và sp2: ");
            if (sp1.soSanh(sp2))
                Console.WriteLine("z1 = z2");
            else
                Console.WriteLine("z1 khác z2");

            Console.WriteLine("Tính toán và so sánh dùng operator: ");
            kq = (sp1 + sp2);
            kq.xuat("tổng");
            kq = sp1 - sp2;
            kq.xuat("hiệu");
            kq = sp1 * sp2;
            kq.xuat("thương");
            if (sp1==sp2)
                Console.WriteLine("z1 = z2");
            else
                Console.WriteLine("z1 khác z2");

        }

        public static void BaiTap2()
        {
            PhanSo ps1 = new PhanSo();
            ps1.NhapPhanSo();
            ps1.RutGonPhanSo();
            ps1.XuatPhanSo("ps1");

            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();
            ps2.RutGonPhanSo();
            ps2.XuatPhanSo("ps2");

            Console.WriteLine("phép tính phân số: ");
            PhanSo kq = ps1.CongPhanSo(ps2);
            kq.XuatPhanSo("tổng");

            kq = ps1.TruPhanSo(ps2);
            kq.XuatPhanSo("hiệu");

            kq = ps1.NhanPhanSo(ps2);
            kq.XuatPhanSo("tích");

            kq = ps1.ChiaPhanSo(ps2);
            kq.XuatPhanSo("thương");


        }

        public static void BaiTap3()
        {
            PhanSo ps1 = new PhanSo();
            ps1.NhapPhanSo();
            ps1.RutGonPhanSo();
            ps1.XuatPhanSo("ps1");

            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();
            ps2.RutGonPhanSo();
            ps2.XuatPhanSo("ps2");

            Console.WriteLine("phép tính phân số: ");
            PhanSo kq = ps1.CongPhanSo(ps2);
            kq.XuatPhanSo("tổng");

            kq = ps1.TruPhanSo(ps2);
            kq.XuatPhanSo("hiệu");

            kq = ps1.NhanPhanSo(ps2);
            kq.XuatPhanSo("tích");

            kq = ps1.ChiaPhanSo(ps2);
            kq.XuatPhanSo("thương");


        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BaiTap1();
            //BaiTap2();

            Console.ReadKey();
        }
    }
}
