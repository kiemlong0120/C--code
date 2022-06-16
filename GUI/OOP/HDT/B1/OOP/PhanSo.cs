using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PhanSo
    {
        private int tuso, mauso;

        public int Tuso
        {
            get { return tuso; }
            set
            { tuso = value; }
        }

        public int Mauso
        {
            get { return mauso; }
            set
            {
                if (value == 0)
                    Console.WriteLine("Nhập sai!");
                else
                    mauso = value;
            }
        }

    }
}
