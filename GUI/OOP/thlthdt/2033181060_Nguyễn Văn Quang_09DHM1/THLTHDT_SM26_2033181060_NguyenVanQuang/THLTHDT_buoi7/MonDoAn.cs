using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi7
{
    class MonDoAn:MonHoc
    {
        double diemGVDH, diemGVPB;

        public double DiemGVPB
        {
            get { return diemGVPB; }
            set { diemGVPB = value; }
        }

        public double DiemGVDH
        {
            get { return diemGVDH; }
            set { diemGVDH = value; }
        }

        public MonDoAn():base()
        {

        }
        public override double TinhDiem()
        {
            return (DiemGVDH * 2 + DiemGVPB) / 3;
        }
        public override double TinhHocPhi()
        {
            return 2000000;
        }
    }
}
