using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033181060_Nguyễn_Văn_Quang_Bai1
{
    abstract class NhanVien
    {
        #region thuoc tinh va get set
        public static double LCB = 1000;
        string manv, ten, diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        double hesoluong;
        int namvaolam, namsinh;

        public int Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }

        public int Namvaolam
        {
            get { return namvaolam; }
            set { namvaolam = value; }
        }

        public double Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }

        #endregion
        #region ham khoi tao

        public NhanVien()
        {
            this.manv = this.ten = this.diachi = "";
            this.hesoluong = 1;
            this.namsinh = 2000;
            this.namvaolam = 2020;
        }
        public NhanVien(string MaNV, string Ten, int NamSinh, string DiaChi, double heSoLuong, int NamVaoLam)
        {
            this.manv = MaNV;
            this.ten = Ten;
            this.diachi = DiaChi;
            this.hesoluong = heSoLuong;
            this.namsinh = NamSinh;
            this.namvaolam = NamVaoLam;

        }
        #endregion
        #region methods
        public abstract double tinhTienHoTro();
        public abstract double tinhLuong();
        public abstract double tinhSoTienThucLinh();
        public abstract double tinhThueThuThapCaNhan();
        public virtual void Nhap()
        {
            Console.Write("Nhap ma nhan vien: "); this.Manv = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: "); this.Ten = Console.ReadLine();
            Console.Write("Nhap nam sinh cua nhan vien: "); this.Namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi nhan vien: "); this.Diachi = Console.ReadLine();
            Console.Write("Nhap he so luong cua nhan vien: "); this.Hesoluong = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam vao lam cua nhan vien: "); this.Namvaolam = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: {0}", this.Manv);
            Console.WriteLine("Ten nhan vien: {0}", this.Ten);
            Console.WriteLine("Nam sinh cua nhan vien: {0}", this.Namsinh);
            Console.WriteLine("Dia chi nhan vien: {0}", this.Diachi);
            Console.WriteLine("He so luong cua nhan vien: {0}", this.Hesoluong);
            Console.WriteLine("Nam vao lam cua nhan vien: {0}", this.Namvaolam);
        }
        #endregion
    }
}
