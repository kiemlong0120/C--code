using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi7
{
    class MonThucHanh:MonHoc
    {
        double diem1, diem2, diem3, diem4;

        public double Diem4
        {
            get { return diem4; }
            set { diem4 = value; }
        }

        public double Diem3
        {
            get { return diem3; }
            set { diem3 = value; }
        }

        public double Diem2
        {
            get { return diem2; }
            set { diem2 = value; }
        }

        public double Diem1
        {
            get { return diem1; }
            set { diem1 = value; }
        }

        public MonThucHanh():base()
        {
            
        }
        public override double TinhDiem()
        {
            return (Diem1 + Diem2 + Diem3 + Diem4) / 4;
        }
        public override double TinhHocPhi()
        {
            return 350000 * SoTinChi + 100000;
        }
    }
}
