using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi4
{
    class ThiSinh
    {
        #region get set

        private string sbd, holot, ten;
        private int namsinh;
        private double toan, van, ngoaingu;

        public string SBD { get { return sbd; } set { sbd = value; } }
        public string HoLot { get { return holot; } set { holot = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public int NamSinh { get { return namsinh; } set { namsinh = value; } }
        public double Toan { get { return toan; } set { toan = value; } }
        public double Van { get { return toan; } set { toan = value; } }
        public double NgoaiNgu { get { return toan; } set { toan = value; } }
        #endregion
        #region Constructors
        public ThiSinh()
        {
            this.sbd = holot = ten = "";
            this.namsinh = 0;
            this.toan = van = ngoaingu = 0.0;
        }

        public ThiSinh(string SBD, string HoLot, string Ten, int NamSinh, double Toan, double Van, double NgoaiNgu)
        {
            this.sbd = SBD;
            this.holot = HoLot;
            this.ten = Ten;
            this.namsinh = NamSinh;
            this.toan = Toan;
            this.van = Van;
            this.ngoaingu = NgoaiNgu;
        }

        public ThiSinh(ThiSinh ts)
        {
            this.sbd = ts.SBD;
            this.holot = ts.HoLot;
            this.ten = ts.Ten;
            this.namsinh = ts.NamSinh;
            this.toan = ts.Toan;
            this.van = ts.Van;
            this.ngoaingu = ts.NgoaiNgu;
        }


        #endregion
        #region input output

        //public void nhap()
        //{
        //    Console.Write("Nhập thông tin sinh viên: ");
        //    Console.Write("Số báo danh: "); SBD = Console.ReadLine();
        //    Console.Write("Họ lót: "); HoLot = Console.ReadLine();
        //    Console.Write("Tên: "); Ten = Console.ReadLine();
        //    Console.Write("Năm Sinh: "); NamSinh = int.Parse(Console.ReadLine());
        //    Console.Write("Toán= "); Toan = double.Parse(Console.ReadLine());
        //    Console.Write("Văn= "); Van = double.Parse(Console.ReadLine());
        //    Console.Write("Ngoại Ngữ= "); NgoaiNgu = double.Parse(Console.ReadLine());
        //}
        public void xuat()
        {
            if ((HoLot + " " + Ten).Length < 15)
                Console.WriteLine("|{0}|{1} {2}\t\t|năm sinh:{3}|toán:{4}|văn:{5}|ngoại ngữ:{6}|", SBD, HoLot, Ten, NamSinh, Toan, Van, NgoaiNgu);
            else
                Console.WriteLine("|{0}|{1} {2}\t|năm sinh:{3}|toán:{4}|văn:{5}|ngoại ngữ:{6}|", SBD, HoLot, Ten, NamSinh, Toan, Van, NgoaiNgu);
        }
        public double tongDiem()
        {
            return Toan + Van + NgoaiNgu * 2;
        }

        #endregion
    }
}
