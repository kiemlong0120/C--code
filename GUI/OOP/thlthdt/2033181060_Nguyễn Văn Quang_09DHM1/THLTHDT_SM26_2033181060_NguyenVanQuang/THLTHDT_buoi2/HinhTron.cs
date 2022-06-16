using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class HinhTron
    {
        #region Thuộc tính
        private double bankinh;
        public double BanKinh
        {
            get { return bankinh; }
            set 
            {
                if(value<0)
                   bankinh = 0.000001;
                else
                bankinh = value; 
            }
        }
        #endregion
        #region Constructor

        public HinhTron()
        {
            this.BanKinh = 0.00001;
        }

        public HinhTron(double BanKinh)
        {
            this.BanKinh = BanKinh;
        }

        public HinhTron(HinhTron ht)
        {
            this.BanKinh = ht.BanKinh;
        }


        #endregion
        #region OutPut
        public void nhap()
        {
            do
            {
                Console.Write("Nhập vào bán kính hình tròn: ");
                BanKinh = double.Parse(Console.ReadLine());
                if (BanKinh < 0)
                    Console.WriteLine("Giá trị {0} sai, vui lòng nhập lại!", BanKinh);
            } while (BanKinh < 0);
        }

        public void xuat()
        {
            Console.WriteLine("Bán kính hình tròn là: {0:0.00}", BanKinh);
            Console.WriteLine("Chu vi hình tròn là: {0:0.00}", 2* Math.PI*BanKinh);
            Console.WriteLine("Diện tích hình tròn là: {0:0.00}", Math.PI * BanKinh*BanKinh);
        }
        
        #endregion
    }
}
