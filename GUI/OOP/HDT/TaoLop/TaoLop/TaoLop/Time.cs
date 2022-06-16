using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLop
{
    class Time
    {   //24 gio
        private int hour, minute, second;
        String buoi; //AM, PM

        public int Hour
        {
            get { return hour; }
            set {
                if (value < 0 || value > 11)
                {
                    Console.WriteLine("Du lieu sai");
                    hour = 0;
                }
                else 
                    hour = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }
        public int doiRaGiay()
        {
            return hour * 3600 + minute * 60 + second;
        }

        public Time()
        {
            Hour = Minute = Second = 0;
            buoi = "";
        }
        public Time(int Hour, int Minute, int Second, String Buoi)
        {
            this.Hour = Hour;
            //...

        }
        public Time(Time t)
        {
            this.Hour = t.Hour;
            //...
        }


    }
}
