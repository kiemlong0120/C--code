using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class HinhChuNhat
    {
        private float dai, rong;

        public float Dai
        {
            get { return dai; }
            set 
            {
                if(value<0)
                    Console.WriteLine("\nNhap gia tri sai!");
                else
                dai = value; 
            }
        }
        public float Rong
        {
            get { return rong; }
            set 
            { 
                if(value<0)
                    Console.WriteLine("\nNhap gia tri sai!");
                else
                rong = value; 
            }
        }
        public void VeHinhChuNhat()
        {
            for (int i = 1; i <= this.rong; i++)
            {
                Console.Write("");
                for (int j = 1; j <= this.dai; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }
        }

        public void NhapHCN()
        {
            Console.WriteLine("\nNhập chiều dài: ");
            this.dai= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nNhập chiều rộng: ");
            this.rong = float.Parse(Console.ReadLine());
        }

        

    }
}
