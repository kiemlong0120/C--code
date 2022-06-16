using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2033181060_Nguyễn_Văn_Quang_Bai1
{
    class Program
    {
        public static void Bai1()
        {
            LapTrinhVien dev1 = new LapTrinhVien();
            dev1.Nhap();
            dev1.Xuat();
            ChuyenVienKiemThu tester1 = new ChuyenVienKiemThu();
            tester1.Nhap();
            tester1.Xuat();
            ChuyenVienThietKe designer1 = new ChuyenVienThietKe();
            designer1.Nhap();
            designer1.Xuat();
        }

        public static void Bai2()
        {
            CongTy cty = new CongTy();
            cty.readFile();
            cty.xuatCongTy();
            Console.Write("tong tien luong phai tra cho nv: {0}", cty.tinhTongTien());
            

        }
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
        }
        
    }
}
