using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class NuocGiaiKhat
    {
        #region thuộc tính
        private string tenhang, donvitinh;
        private int soluong;
        private double dongia;
        private static double thueVAT = 0.1;
        #endregion

        #region get set
        public string TenHang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }
        public string DonViTinh
        {
            get { return donvitinh; }
            set
            {
                if (value.Equals("kết") || value.Equals("thùng") || value.Equals("chai") || value.Equals("lon"))
                    donvitinh = value;
                else donvitinh = "kết";
            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                if (value <= 0)
                    soluong = 1;
                else
                    soluong = value;
            }
        }
        public double DonGia
        {
            get { return dongia; }
            set
            {
                if (value <= 0)
                    dongia = 1;
                else
                    dongia = value;
            }
        }
        #endregion

        #region Constructors
        public NuocGiaiKhat()
        {
            TenHang = DonViTinh = "";
            SoLuong = 1;
            DonGia = 1;
        }
        public NuocGiaiKhat(string TenHang, string DonViTinh, int SoLuong, double DonGia)
        {
            this.TenHang = TenHang;
            this.DonViTinh = DonViTinh;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }
        public NuocGiaiKhat(NuocGiaiKhat ngk)
        {
            this.TenHang = ngk.TenHang;
            this.DonViTinh = ngk.DonViTinh;
            this.SoLuong = ngk.SoLuong;
            this.DonGia = ngk.DonGia;
        }
        #endregion

        #region Hàm xử lý

        public void nhap()
        {
            Console.Write("Nhập vào tên hàng: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhập vào đơn vị tính ( thùng, kết, chai, lon): ");
            DonViTinh = Console.ReadLine();
            Console.Write("Nhập vào số lượng: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());

        }

        public void xuat()
        {
            Console.Write("Tên hàng: {0}", this.TenHang);
            Console.Write("\nĐơn vị tính: {0}", this.DonViTinh);
            Console.Write("\nSố lượng: {0}", this.SoLuong);
            Console.Write("\nĐơn giá: {0}", this.DonGia);
            tinhTien();
        }
        public void tinhTien()
        {
            Console.WriteLine("\nThành tiền: {0:0}, thuế= {1}", SoLuong * DonGia + SoLuong * DonGia * thueVAT, SoLuong * DonGia * thueVAT);
        }

        #endregion
    }
}
