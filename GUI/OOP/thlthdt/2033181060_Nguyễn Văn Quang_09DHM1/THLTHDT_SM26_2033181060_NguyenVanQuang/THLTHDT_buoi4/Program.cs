using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi4
{
    class Program
    {
        public static void BaiTap1()
        {
            DanhSachTS dsts1 = new DanhSachTS();
            dsts1.docFile("../../data/dsts.xml");
            dsts1.Xuat();
            
        }
        static void Main(string[] args)
        {
            Console.Title = "Buoi4";
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            BaiTap1();

            Console.ReadKey();
        }
    }
}
