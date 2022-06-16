using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_THLTHDT_buoi6
{
    class CBLanhDao:NhanVien
    {
        #region thuoc tinh
        String chucvu;
        int thamnienql;
        public String Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        } 
        public int Thamnienql
        {
            get { return thamnienql; }
            set { thamnienql = value; }
        }
        #endregion
        #region contructor
        public CBLanhDao():base()
        {
            Manv = "NV009";
            Tennv = "Dieu Hien";
            Hsluong = 4.67;
            Chucvu = "Giam Doc";
            Thamnienql = 10;
        }
        public CBLanhDao(String Manv,String Tennv,Double Hsluong,String Chuvu,int Thamnienql):base(Manv,Tennv,Hsluong)
        {
            this.Chucvu=Chucvu;
            this.Thamnienql = Thamnienql;
        }

        #endregion
        #region in/out
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Chuc vu:");
            Chucvu = Console.ReadLine();
            Console.WriteLine("Tham nien quan ly:");
            Thamnienql =int.Parse( Console.ReadLine());
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("Chuc vu: {0}", Chucvu);
            Console.WriteLine("Tham nien quan ly: {0}", Thamnienql);
          
            
        }

        #endregion
        #region process
        
        public override double tinhThuNhap()
        {
            if (Chucvu.Equals("Giam Doc"))
                return base.tinhThuNhap() + (1500 * 7.0);
            else if (Chucvu.Equals("Truong phong"))
                return base.tinhThuNhap() + (1500 * 6.0);
            else if (Chucvu.Equals("Pho phong"))
                return base.tinhThuNhap() + (1500 * 4.5);
            else 
                return base.tinhThuNhap() + (1500 * 1.0);
        }

        #endregion
    }
}
