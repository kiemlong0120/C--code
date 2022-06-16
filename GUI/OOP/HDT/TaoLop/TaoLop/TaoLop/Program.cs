using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLop
{
    class Program
    {
        static void Main(string[] args)
        {
            HSinh a = new HSinh();
            a.xuat();
            HSinh b = new HSinh("Ngan", 9f);
            b.xuat();

            HSinh c = new HSinh(b);
            c.xuat();
            
           

            Console.ReadLine();

        }
    }

}
