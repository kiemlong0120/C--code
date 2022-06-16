using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi7
{
    class MonLyThuyet:MonHoc
    {
        double diemtieuluan, diemgiuaky, diemcuoiky;
        double hstl, hsgk, hsck;

        public double Hsck
        {
            get { return hsck; }
            set { hsck = value; }
        }

        public double Hsgk
        {
            get { return hsgk; }
            set { hsgk = value; }
        }

        public double Hstl
        {
            get { return hstl; }
            set { hstl = value; }
        }

        public double Diemcuoiky
        {
            get { return diemcuoiky; }
            set { diemcuoiky = value; }
        }

        public double Diemgiuaky
        {
            get { return diemgiuaky; }
            set { diemgiuaky = value; }
        }

        public double Diemtieuluan
        {
            get { return diemtieuluan; }
            set { diemtieuluan = value; }
        }


        public MonLyThuyet():base()
        {
            this.hstl = 0.2;
            this.hsgk = 0.3;
            this.hsck = 0.5;
        }
        public override double TinhDiem()
        {
            return Diemtieuluan * Hstl + Diemgiuaky * Hsgk + Diemcuoiky * Hsck;
        }
        public override double TinhHocPhi()
        {
            return 250000 * this.SoTinChi;
        }
    }

}
