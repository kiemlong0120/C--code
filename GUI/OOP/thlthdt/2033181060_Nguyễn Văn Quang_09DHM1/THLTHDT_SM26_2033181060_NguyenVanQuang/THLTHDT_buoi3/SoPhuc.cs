using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi3
{
    class SoPhuc
    {
        #region thuộc tính và get set
        private double a, b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        #endregion
        #region Constructors
        public SoPhuc()
        {
            A = B = 0;
        }
        public SoPhuc(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public SoPhuc(SoPhuc x)
        {
            this.A = x.A;
            this.B = x.B;
        }
        #endregion
        #region input output
        public void nhap()
        {
            Console.Write("Nhập a= ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Nhập b= ");
            B = double.Parse(Console.ReadLine());
        }
        public void xuat(string NameVar)
        {
            if (B >= 0)
                Console.WriteLine("{0} = {1:0.00} + {2:0.00}", NameVar, this.A, this.B);
            else
                Console.WriteLine("{0} = {1:0.00} - {2:0.00}", NameVar, this.A, Math.Abs(this.B));
        }

        public SoPhuc cong(SoPhuc x)
        {
            return new SoPhuc(this.a + x.a, this.b + x.b);
        }

        public Boolean soSanh(SoPhuc x)
        {
            if (this.a == x.a && this.b == x.b)
                return true;
            else
                return false;
        }

        #endregion
        #region operators
        public static SoPhuc operator+(SoPhuc sp1, SoPhuc sp2)
        {
            return new SoPhuc(sp1.a + sp2.a, sp1.b + sp2.b);
        }
        public static Boolean operator ==(SoPhuc sp1, SoPhuc sp2)
        {
            return (sp1.a == sp2.a && sp1.b == sp2.b);
        }
        public static Boolean operator !=(SoPhuc sp1, SoPhuc sp2)
        {
            return !(sp1 == sp2);
        }
        public static SoPhuc operator -(SoPhuc sp1, SoPhuc sp2)
        {
            return new SoPhuc(sp1.a - sp2.a, sp1.b - sp2.b);
        }

        public static SoPhuc operator *(SoPhuc sp1, SoPhuc sp2)
        {
            return new SoPhuc(sp1.a * sp2.a, sp1.b * sp2.b);
        }


        #endregion

    }
}
