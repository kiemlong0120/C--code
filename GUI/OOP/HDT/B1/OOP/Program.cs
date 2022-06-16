using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                    HinhChuNhat hcn1 = new HinhChuNhat();
                    hcn1.NhapHCN();
                    Console.WriteLine("\n Chiều rộng và chiều dài của hình chữ nhật: {0}, {1}", hcn1.Rong,hcn1.Dai);
                    hcn1.VeHinhChuNhat();
                    Time tg1 = new Time();
                    VanDongVien vdv1 = new VanDongVien();



            Console.ReadLine();
        }

    }
}
