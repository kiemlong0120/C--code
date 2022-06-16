using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi7
{
    class MonHoc
    {

        string mamon, tenmon, khoaphutrach;

        public string KhoaPhuTrach
        {
            get { return khoaphutrach; }
            set { khoaphutrach = value; }
        }

        public string TenMon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }

        public string MaMon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        int sotinchi;

        public int SoTinChi
        {
            get { return sotinchi; }
            set { sotinchi = value; }
        }
        double diem;

        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }


        public MonHoc()
        {
            this.mamon = this.tenmon = this.khoaphutrach = "";
            this.sotinchi = 1;
            this.diem = 0;
        }

        public abstract double TinhDiem();
        public abstract double TinhHocPhi();

    }
}
