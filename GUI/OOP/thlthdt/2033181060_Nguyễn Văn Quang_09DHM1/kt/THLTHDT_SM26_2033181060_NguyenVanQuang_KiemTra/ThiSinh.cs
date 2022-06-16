using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_SM26_2033181060_NguyenVanQuang_KiemTra
{
        class ThiSinh
        {
            #region get set

            private string mathisinh, hovahodem, ten;
            private double diemlythuyet, diemthuchanh;

            public string MaThiSinh
            {
              get { return mathisinh; }
              set { mathisinh = value; }
            }

            public string HoVaHoDem
            {
              get { return hovahodem; }
              set { hovahodem = value; }
            }
            public string Ten
            {
              get { return ten; }
              set { ten = value; }
            }
            public double DiemLyThuyet
            {
              get { return diemlythuyet; }
              set { diemlythuyet = value; }
            }

            public double DiemThucHanh
            {
              get { return diemthuchanh; }
              set { diemthuchanh = value; }
            }
            #endregion
            #region Constructors
            public ThiSinh()
            {
                this.MaThiSinh = HoVaHoDem = Ten = "";
                this.DiemLyThuyet = DiemThucHanh = 0.0;
            }

            public ThiSinh(string MaThiSinh, string HoVaHoDem, string Ten, double DiemLyThuyet, double DiemThucHanh)
            {
                this.MaThiSinh = MaThiSinh;
                this.HoVaHoDem = HoVaHoDem;
                this.Ten = Ten;
                this.DiemLyThuyet = DiemLyThuyet;
                this.DiemThucHanh = DiemThucHanh;
            }

           public ThiSinh(ThiSinh ts)
            {
                this.MaThiSinh = ts.MaThiSinh;
                this.HoVaHoDem = ts.HoVaHoDem;
                this.Ten = ts.Ten;
                this.DiemLyThuyet = ts.DiemLyThuyet;
                this.DiemThucHanh = ts.DiemThucHanh;
            }
            #endregion
            #region input output
            public void nhap()
            {
                Console.WriteLine("Nhập thông tin sinh viên: ");
                Console.Write("Mã số thí sinh: ");
                MaThiSinh = Console.ReadLine();
                Console.Write("Họ và họ đệm: ");
                HoVaHoDem = Console.ReadLine();
                Console.Write("Tên: ");
                Ten = Console.ReadLine();
                Console.Write("Điểm lý thuyết= ");
                DiemLyThuyet = double.Parse(Console.ReadLine());
                Console.Write("Điểm thực hành= ");
                DiemThucHanh = double.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                Console.Write("Mã số thí sinh: {0}, Họ và tên: {1} {2}\nĐiểm lý thuyết: {3}, Điểm thực hành: {4}, Điểm tổng: {5}", MaThiSinh, HoVaHoDem, Ten, DiemLyThuyet, DiemThucHanh,tinhDiemTong());
            }
            public double tinhDiemTong()
            {
                return this.DiemLyThuyet + this.DiemThucHanh;
            }
            public void xetKetQua()
            {
                if (tinhDiemTong() >= 10.0 && DiemThucHanh >= 5.0 && DiemLyThuyet >= 5.0)
                    Console.WriteLine("Kết quả:  ĐẬU!");
                else
                    Console.WriteLine("Kết quả:  RỚT!");
            }
            #endregion
        }
    }


