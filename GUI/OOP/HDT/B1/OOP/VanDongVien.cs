using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class VanDongVien
    {
        private string maso, hoten;
        private int soao;

       public struct TIME
        {
            int hour, second, minute;
        };

        public struct THOIGIAN
        {
            int gio, phut, giay;
        };

        public string MaSo
        {
            get { return maso; }
            set
            {maso = value;}
        }

        public string HoTen
        {
            get { return hoten; }
            set
            { hoten = value; }
        }

        public int SoAo
        {
            get { return soao; }
            set
            { soao = value; }
        }

        public TIME Hour
        {
            get { return Hour; }
            set
            { Hour = value; }
        }

        public TIME Minute
        {
            get { return Minute; }
            set
            { Minute = value; }
        }

        public TIME Second
        {
            get { return Second; }
            set
            { Second = value; }
        }

        
        public THOIGIAN ThanhTich
        {
            get { return ThanhTich; }
            
        }



    }
}
