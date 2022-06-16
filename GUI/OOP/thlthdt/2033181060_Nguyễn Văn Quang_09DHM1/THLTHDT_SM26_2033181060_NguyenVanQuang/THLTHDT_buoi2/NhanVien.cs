using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class NhanVien
    {
        #region Thuộc tính
        private string maso, hoten;
        private int songaycong;
        private static double luongngay = 200000;
        #endregion

        #region Get Set
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int SoNgayCong
        {
            get { return songaycong; }
            set
            {
                if (value <= 0)
                    songaycong = 1;
                else
                    songaycong = value;
            }
        }

        public char xeploai
        {
            get
            {
                if (SoNgayCong > 26)
                    return 'A';
                else if (SoNgayCong >= 22)
                    return 'B';
                else return 'C';
            }
        }
        #endregion

        #region Constructors
        public NhanVien()
        {
            MaSo = HoTen = "";
            SoNgayCong = 1;
        }
        public NhanVien(string MaSo, string HoTen, int SoNgayCong)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.SoNgayCong = SoNgayCong;
        }
        public NhanVien(NhanVien nv)
        {
            this.MaSo = nv.MaSo;
            this.HoTen = nv.HoTen;
            this.SoNgayCong = nv.SoNgayCong;
        }
        #endregion
        #region OutPut
        public void nhap()
        {
            Console.Write("Nhập mã số nhân viên: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số ngày công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("\nMã số nhân viên: {0}", MaSo);
            Console.Write("\nHọ tên nhân viên: {0}", HoTen);
            Console.Write("\nSố ngày công: {0}", SoNgayCong);
            Console.Write("\nXếp loại: {0}", xeploai);
        }
        #endregion
        #region Hàm xử lý

        ~NhanVien()
        { }
        public void tinhLuong()
        {
            Console.Write("\nLương: {0}", luongngay * SoNgayCong);
        }
        public void tinhThuong()
        {
            if (xeploai == 'A')
                Console.Write("\nThưởng= {0}", (luongngay * SoNgayCong) * 5 / 100);
            if (xeploai == 'B')
                Console.Write("\nThưởng= {0}", (luongngay * SoNgayCong) * 2 / 100);
            if (xeploai == 'C')
                Console.Write("\nThưởng= 0");
        }
        #endregion
    }
}
