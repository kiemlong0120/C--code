using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThuatMaHoa
{
    class Program
    {
        static void DesignConsole()
        {
            Console.Title = "____________________________________________________________________________________________MÃ HOÁ NGUỒN TIN____________________________________________________________________________________________";
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        static void NhapVaSortXacXuat(NguonTin s1)
        {
            s1.Nhap();
            s1.XuatXacXuat();
            Console.WriteLine("\nDanh sách xác xuất sau sort: ");
            s1.SapXep();
            s1.XuatXacXuat();
            Console.WriteLine("ENTER để tiếp tục...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            DesignConsole();
            NguonTin s1 = new NguonTin();
            NhapVaSortXacXuat(s1);
            s1.ppShannon();
            s1.ppFano();


            Console.ReadKey();
        }
    }
}
