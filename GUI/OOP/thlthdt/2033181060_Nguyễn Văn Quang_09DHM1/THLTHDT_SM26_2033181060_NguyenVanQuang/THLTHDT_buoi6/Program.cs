using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_THLTHDT_buoi6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            CBLanhDao ld1 = new CBLanhDao();
            ld1.tinhThuNhap();
            ld1.xuat();
            //NhanVien nv1 = new NhanVien();
            //nv1.nhap();
            //nv1.tinhThuNhap();
            //nv1.xuat();
            Console.ReadKey();
        }
    }
}
