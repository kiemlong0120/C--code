using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLop
{
    class ThoiGian
    {
        int gio, phut, giay;
        public int Gio
        {
            get { return gio; }
            set{ 
                if(value<0)
                    gio=0;
                else 
                    gio=value;
                 }
        }
        public int Phut
        {
            get { return gio; }
            set{ 
                if(value<0)
                    gio=0;
                else 
                    gio=value;
                }
        }
        public int Giay
        {
            get { return gio; }
            set
            {
                if (value < 0)
                    gio = 0;
                else
                    gio = value;
            }
        }

       
    }
}
