using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033181060_Nguyễn_Văn_Quang_Bai1
{
    class LapTrinhVien : NhanVien
    {
        #region get set

        int overtime;

        public int Overtime
        {
            get { return overtime; }
            set { overtime = value; }
        }

        #endregion
        #region ham khoi tao
        public LapTrinhVien()
            : base()
        {
            this.Overtime = 0;
        }
        public LapTrinhVien(string MaNV, string Ten, int NamSinh, string DiaChi, double heSoLuong, int NamVaoLam,int Overtime):base(MaNV,Ten,NamSinh,DiaChi,heSoLuong,NamVaoLam)
        {
            this.Overtime = Overtime;
        }
        #endregion
        #region methods
        public override double tinhTienHoTro()
        {
            return Overtime * 80;
        }
        public override double tinhLuong()
        {
            return Hesoluong * LCB * tinhTienHoTro();
        }
        public override double tinhThueThuThapCaNhan()
        {
            if (tinhLuong() > 0 && tinhLuong() <= 5000)
                return tinhLuong() * 5 / 100;
            else if (tinhLuong() > 5000 && tinhLuong() <= 10000)
                return tinhLuong() * 10 / 100;
            else if (tinhLuong() > 10000 && tinhLuong() <= 18000)
                return tinhLuong() * 15 / 100;
            else if (tinhLuong() > 18000)
                return tinhLuong() * 20 / 100;
            else
                return 0;
        }
        public override double tinhSoTienThucLinh()
        {
            return tinhLuong() - tinhThueThuThapCaNhan();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap overtime cua nhan vien: "); this.Overtime = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("overtime cua nhan vien: {0}", this.Overtime);
            Console.WriteLine("Tien ho tro cua nhan vien: {0}",this.tinhTienHoTro());
             Console.WriteLine("Luong cua nhan vien: {0}",this.tinhLuong());
             Console.WriteLine("Thue thu thap ca nhan cua nhan vien: {0}",this.tinhThueThuThapCaNhan());
             Console.WriteLine("Thuc linh cua nhan vien: {0}",this.tinhSoTienThucLinh());
        }
        #endregion
    }
}
