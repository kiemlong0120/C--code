using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_SM26_2033181060_NguyenVanQuang_KiemTra
{
    class Program
    {
        static void Bai1()
        {
            Console.WriteLine("Bài số 1: ");
            ThiSinh ts1 = new ThiSinh();
            ts1.nhap();
            ts1.xuat();
            ts1.xetKetQua();
        }
        static void Bai2()
        {
            Console.WriteLine("\nBài số 2: ");
            dsThiSinh dsts1 = new dsThiSinh();
            dsts1.docFile("../../data/dsThiSinh.xml");
            dsts1.Xuat();
            dsts1.sort();
            dsts1.Xuat();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            //Bai1();
            Bai2();

            Console.ReadKey();
        }
    }
}
