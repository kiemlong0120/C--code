using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Time
    {
        private int hour,  minute , second;
        private string buoi;
         
        public int Hour
        {
            get { return hour; }
            set 
            {
                if (value < 0 || value > 11)
                    Console.WriteLine("\n Nhập sai!");
                else
                    hour = value;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0 || value > 59)
                    Console.WriteLine("\n Nhập sai!");
                else
                    second = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 59)
                    Console.WriteLine("\n Nhập sai!");
                else
                    minute = value;
            }
        }
        public string Buoi
        {
            get { return buoi; }
            set
            {
                if (value != "AM" && value != "PM")
                    buoi = "AM";
                else
                    buoi = value;
            }
        }
    }
}
