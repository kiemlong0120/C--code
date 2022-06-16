using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi3
{
    class PhanSo
    {
        #region thuộc tính và get set

        private double tuSo, mauSo;

        //get,set của thuộc tính
        public double TUSO
        {
            get { return tuSo; }
            set
            {
                tuSo = value;
            }
        }

        public double MAUSO
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Nhập sai!Đã gán giá trị mặc định(1)");
                    mauSo = 1;
                }
                else
                    mauSo = value;
            }
        }

        #endregion
        #region Constructors

        //hàm khởi tạo mặc định
        public PhanSo()
        {
            TUSO = 0;
            MAUSO = 1;
        }

        //hàm khởi tạo có tham số
        public PhanSo(double TUSO, double MAUSO)
        {
            this.TUSO = TUSO;
            this.MAUSO = MAUSO;
        }

        //hàm khởi tạo sao chép
        public PhanSo(PhanSo q)
        {
            this.TUSO = q.TUSO;
            this.MAUSO = q.MAUSO;
        }

        #endregion
        #region Hàm

        #region input output

        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            this.TUSO = double.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            this.MAUSO = double.Parse(Console.ReadLine());
        }

        public void XuatPhanSo(string Namevar)
        {
            if (MAUSO == 1 || TUSO == 0)
                Console.WriteLine("{0} = {1}", Namevar, this.TUSO);
            else
                Console.WriteLine("{0} = {1}/{2}", Namevar, this.TUSO, this.MAUSO);
        }

        #endregion
        #region Xử lý
       
        public double TimUocChungLonNhat()
        {
            double a = this.TUSO, b = this.mauSo;
            while (a != b && b != 0 && a != 0)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public PhanSo RutGonPhanSo()
        {
            double uoc = TimUocChungLonNhat();
            if (uoc != 0)
            {
                return new PhanSo(TUSO / uoc, MAUSO / uoc);
            }
            else
                return new PhanSo(TUSO, MAUSO);
        }

        public int KiemTraLonHon1()
        {
            if (TUSO / MAUSO > 1)
                return 1;
            else
                return 0;
        }

        public void NghichDaoPhanSo()
        {
            if (TUSO != 0)
            {
                double a = TUSO;
                TUSO = MAUSO;
                MAUSO = a;
                Console.WriteLine("Phân số sau khi nghịch đảo: ");
                this.XuatPhanSo("ps= ");
            }
            else
                Console.WriteLine("Phân số này không thể nghịch đảo (tử = 0)");
        }

        public void tangPS()
        {
            this.MAUSO += 1;
            this.TUSO += 1;
        }


        public void tangPS(int a)
        {
            this.MAUSO += a;
            this.TUSO += a;
        }

        public PhanSo CongPhanSo(PhanSo b)
        {
            return (new PhanSo(b.TUSO * MAUSO + b.MAUSO * this.TUSO, b.MAUSO * this.MAUSO)).RutGonPhanSo();
        }

        public PhanSo TruPhanSo(PhanSo b)
        {
            if (this.TUSO != 0)
            {
                return (new PhanSo(TUSO * b.MAUSO - MAUSO * b.TUSO, MAUSO * b.MAUSO)).RutGonPhanSo();
            }
            else
            {
                return (new PhanSo(-b.TUSO, b.MAUSO)).RutGonPhanSo();
            }
        }


        public PhanSo NhanPhanSo(PhanSo b)
        {
            return (new PhanSo(this.TUSO * b.TUSO, this.MAUSO * b.MAUSO)).RutGonPhanSo();
        }
        public PhanSo ChiaPhanSo(PhanSo b)
        {
            return (new PhanSo(this.TUSO * b.MAUSO, this.MAUSO * b.TUSO)).RutGonPhanSo();
        }

        #endregion
        #region operators
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return (new PhanSo(b.TUSO * a.MAUSO + b.MAUSO * a.TUSO, b.MAUSO * a.MAUSO)).RutGonPhanSo();
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            if (a.TUSO != 0)
            {
                return (new PhanSo(a.TUSO * b.MAUSO - a.MAUSO * b.TUSO, a.MAUSO * b.MAUSO)).RutGonPhanSo();
            }
            else
            {
                return (new PhanSo(-b.TUSO, b.MAUSO)).RutGonPhanSo();
            }
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return (new PhanSo(a.TUSO * b.TUSO, a.MAUSO * b.MAUSO)).RutGonPhanSo();
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return (new PhanSo(a.TUSO * b.MAUSO, a.MAUSO * b.TUSO)).RutGonPhanSo();
        }

        public static Boolean operator ==(PhanSo a, PhanSo b)
        {
            return (a.MAUSO / a.TUSO == b.MAUSO / b.TUSO);
        }
        public static Boolean operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }

        public static Boolean operator >(PhanSo a, PhanSo b)
        {
            return (a.MAUSO / a.TUSO > b.MAUSO / b.TUSO);
        }
        public static Boolean operator <(PhanSo a, PhanSo b)
        {
            return (a.MAUSO / a.TUSO < b.MAUSO / b.TUSO);
        }

        public static Boolean operator >=(PhanSo a, PhanSo b)
        {
            return (a.MAUSO / a.TUSO >= b.MAUSO / b.TUSO);
        }

        public static Boolean operator <=(PhanSo a, PhanSo b)
        {
            return (a.MAUSO / a.TUSO <= b.MAUSO / b.TUSO);
        }

        public static PhanSo operator ++(PhanSo a)
        {
            return (new PhanSo(a.TUSO + 1, a.MAUSO)).RutGonPhanSo();
        }

        public static PhanSo operator --(PhanSo a)
        {
            return (new PhanSo(a.TUSO - 1, a.MAUSO)).RutGonPhanSo();
        }

        public static PhanSo operator ^(PhanSo a, int n)
        {
            return (new PhanSo(Math.Pow(a.TUSO, n), Math.Pow(a.MAUSO, n))).RutGonPhanSo();
        }


        #endregion
        #endregion

    }
}