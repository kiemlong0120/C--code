using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace code_THLTHDT_buoi6
{
    class NhanVien
    {
        #region thuoc tinh
        String manv, tennv;    
        Double hsluong;
        static Double luongcb = 1150;
        //int n;
        public String Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        //public String Manv
        //{
        //    get { return manv; }
        //    set 
        //    {
        //        if(ktMaNv(Manv)==true )
        //            manv = value;
        //        else
        //            value = "NV001";
        //    }
        //}

        public String Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }    

        public Double Hsluong
        {
            get { return hsluong; }
            set { hsluong = value; }
        }

        #endregion
        #region contructor
        public NhanVien()
        {
            Manv = "NV001";
            Tennv = " ";
            Hsluong = 2.34;
        }
        public NhanVien(String Manv,String Tennv,Double Hsluong)
        {
            this.Manv = Manv;
            this.Tennv = Tennv;
            this.Hsluong = Hsluong;
        }
        #endregion
        #region in/Out 
        public void nhap()
        {
               Console.WriteLine("Ten:");
               Tennv = Console.ReadLine();
               Console.WriteLine("Ma nhan vien:");
               Manv = Console.ReadLine();
        }
        public virtual void xuat()
        {
           
                Console.WriteLine("Ten: {0},\nMa so nhan vien: {1},\nHe so luong: {2},\nThu nhap: {3}", Tennv, Manv, Hsluong, tinhThuNhap());
            
        }

        #endregion
        #region process
        public bool isNumber(string pValue)
        {
            foreach(char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool isString(string pValue)
        {
            foreach (char c in pValue)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public Boolean ktMaNv(String Manv)
        {
            string str1 = Manv.Substring(0, 2);
            if (!str1.Equals("NV"))
                return false;
            return true;
        }
        public virtual double tinhThuNhap()
        {
            return Hsluong * luongcb;
        }
        #endregion
    }
}
