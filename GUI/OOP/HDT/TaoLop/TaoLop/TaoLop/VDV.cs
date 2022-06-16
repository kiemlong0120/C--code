using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLop
{
    class VDV
    {
        String ms, ht;
        int soAo;
        Time bd, kt;
        ThoiGian ttich;

        public Time Kt
        {
            get { return kt; }
            set { kt = value; }
        }
        public Time Bd
        {
            get { return bd; }
            set { bd = value; }
        }
        public void tinhThanhTich()
        {
            int t1 = bd.doiRaGiay();
            int t2 = kt.doiRaGiay();
            int t = t2 - t1;
            ttich.Gio = t / 3600;
            ttich.Phut = (t - (ttich.Gio * 3600)) / 60;// (t%3600)/60
            ttich.Giay = t % 60;

        }
    }
}
