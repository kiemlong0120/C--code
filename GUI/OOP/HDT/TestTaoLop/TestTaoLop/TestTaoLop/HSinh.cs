using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaoLop
{
    class HSinh
    {
        String hten;
        float dtb;
        String xloai;

        public String Hten
        {
            get { return hten; }
            set { hten = value; }
        }
        public float Dtb
        {
            get { return dtb; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai");
                    dtb = 0;
                }
                else
                    dtb = value;
            }
                        
        }
        public String Xloai
        {
            get {
                xetXloai();
                return xloai; }
        }
        void xetXloai()
        {
            if (dtb > 8.5)
                xloai = "Gioi";
            else
                if (dtb > 6.5)
                    xloai = "Kha";
                else xloai = "TB";

        }

    }
}
