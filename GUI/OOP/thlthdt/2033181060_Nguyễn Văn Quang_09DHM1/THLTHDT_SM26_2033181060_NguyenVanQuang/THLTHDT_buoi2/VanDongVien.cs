using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class VanDongVien
    {
        #region thuộc tính và get set

        private int maso, soao;
        private string hoten;
        Time tgbd = new Time();
        Time tgkt = new Time();
        ThoiGian thanhtich = new ThoiGian();
        static int thanhtichchuan = 90;
        public int MaSo
        {

            get { return this.maso; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nhập sai! Đã gán giá trị mặc định(0)");
                    this.maso = 0;
                }
                else
                    this.maso = value;
            }
        }

        public int SoAo
        {
            get { return this.soao; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nhập sai! Đã gán giá trị mặc định(0)");
                    this.soao = 0;
                }
                else
                    this.soao = value;
            }
        }

        public string HoTen
        {
            get { return this.hoten; }
            set
            {
                if (value == " ")
                {
                    Console.WriteLine("Nhập sai!");
                    this.hoten = "";
                }
                else
                    this.hoten = value;
            }
        }

        public Time TGBD
        {


            get { return tgbd; }
            set
            {
                this.tgbd.Gio = value.Gio;
                this.tgbd.Phut = value.Phut;
                this.tgbd.Giay = value.Giay;

            }
        }
        public Time TGKT
        {

            get { return tgkt; }
            set
            {
                int ss = SoSanh();
                if (ss != 1)
                {
                    Console.WriteLine("Nhập sai!");
                    this.tgkt.Gio = 0;
                    this.tgkt.Phut = 0;
                    this.tgkt.Giay = 0;
                }
                else
                {
                    this.tgkt.Gio = value.Gio;
                    this.tgkt.Phut = value.Phut;
                    this.tgkt.Giay = value.Giay;
                }
            }
        }

        #endregion

        #region Hàm xử lý

        int SoSanh()
        {
            if (this.TGBD.Buoi == "AM")
                if (this.TGKT.Buoi == "PM")
                {
                    return 1;
                }
                else
                {
                    int flag1 = ChuyenSangGiay(this.TGKT);
                    int flag2 = ChuyenSangGiay(this.TGBD);
                    if (flag1 - flag2 > 0)
                    {
                        return -1;
                    }
                    else if (flag1 - flag2 == 0)
                        return 0;
                    else
                        return 1;

                }
            else
            {
                if (this.TGKT.Buoi == "PM")
                {
                    int flag1 = ChuyenSangGiay(this.TGKT);
                    int flag2 = ChuyenSangGiay(this.TGBD);
                    if (flag1 - flag2 > 0)
                    {
                        return -1;
                    }
                    else if (flag1 - flag2 == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    return -1;
                }
            }


        }

        int ChuyenSangGiay(Time a)
        {
            return a.Gio * 3600 + a.Phut * 60 + a.Giay;
        }

        void ChuyenSangGio(int giay)
        {
            this.thanhtich.Gio = (giay / 3600);
            int flag = (giay % 3600);
            this.thanhtich.Phut = (flag / 60);
            this.thanhtich.Giay = (flag % 60);
        }

        void XetThanhTich()
        {
            int n;
            n = ChuyenSangGiay(this.tgkt) - ChuyenSangGiay(this.tgbd);
            ChuyenSangGio(n);
        }

        #endregion

        #region output input

        public void NhapThoiGianBD()
        {
            int flag = 0;
            Console.Write("Nhập Giờ: ");
            TGBD.Gio = int.Parse(Console.ReadLine());
            if (TGBD.Gio > 11)
            {
                TGBD.Gio = TGBD.Gio - 12;
                flag = 1;
                TGBD.Buoi = "PM";
            }
            Console.Write("Nhập Phút: ");
            TGBD.Phut = int.Parse(Console.ReadLine());
            while (TGBD.Phut > 59) ;
            Console.Write("Nhập Giây: ");
            TGBD.Giay = int.Parse(Console.ReadLine());
            while (TGBD.Giay > 59) ;
            if (flag == 0)
            {
                Console.Write("Nhập Buổi(AM hoặc PM): ");
                TGBD.Buoi = Console.ReadLine();
            }

        }
        public void NhapThoiGianKT()
        {
            int flag = 0;
            Console.Write("Nhập Giờ: ");
            TGKT.Gio = int.Parse(Console.ReadLine());
            if (TGKT.Gio > 11)
            {
                TGKT.Gio = TGKT.Gio - 12;
                flag = 1;
                TGKT.Buoi = "PM";
            }
            Console.Write("Nhập Phút: ");
            TGKT.Phut = int.Parse(Console.ReadLine());
            while (TGKT.Phut > 59) ;
            Console.Write("Nhập Giây: ");
            TGKT.Giay = int.Parse(Console.ReadLine());
            while (TGKT.Giay > 59) ;
            if (flag == 0)
            {
                Console.Write("Nhập Buổi(AM hoặc PM): ");
                TGKT.Buoi = Console.ReadLine();
            }

        }

        public void NhapVDV()
        {
            Console.WriteLine("Nhập thông tin: ");
            Console.Write("Nhập tên: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhập số áo: ");
            this.MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thời gian bắt đầu: ");
            NhapThoiGianBD();
            Console.WriteLine("Nhập thời gian kết thúc: ");
            NhapThoiGianKT();
            XetThanhTich();
        }

        public void XuatVDV()
        {
            Console.WriteLine("Tên: {0}", this.HoTen);
            Console.WriteLine("Mã số: {0}", this.MaSo);
            Console.WriteLine("Số áo: {0}", this.SoAo);
            Console.WriteLine("TGBD: ");
            TGBD.XuatThoiGian(12);
            Console.WriteLine("TGKT: ");
            TGKT.XuatThoiGian(12);
            Console.WriteLine("Thành tích:");
            thanhtich.XuatThoiGian();
            if ((thanhtich.Gio * 3600 + thanhtich.Phut * 60) < thanhtichchuan)
                Console.WriteLine("Vận động viên có thành tích nhỏ hơn 1:30:00 nên không đạt");
        }
        #endregion

        #region Constructors

        public VanDongVien()
        {
            this.HoTen = "";
            this.MaSo = this.SoAo = 0;
            this.TGBD.Gio = 0;
            this.TGBD.Phut = 0;
            this.TGBD.Giay = 0;
            this.TGKT.Gio = 0;
            this.TGKT.Gio = 0;
            this.TGKT.Gio = 0;
            XetThanhTich();
        }
        public VanDongVien(int MaSo, int SoAo, string HoTen, Time TGBD, Time TGKT)
        {
            this.HoTen = HoTen;
            this.MaSo = MaSo;
            this.TGBD.Gio = TGBD.Gio;
            this.TGBD.Phut = TGBD.Phut;
            this.TGBD.Giay = TGBD.Giay;
            this.TGKT.Gio = TGKT.Gio;
            this.TGKT.Gio = TGKT.Gio;
            this.TGKT.Gio = TGKT.Gio;


            XetThanhTich();
        }

        public VanDongVien(VanDongVien p)
        {
            this.HoTen = p.HoTen;
            this.MaSo = p.MaSo;
            this.TGBD.Gio = p.TGBD.Gio;
            this.TGBD.Phut = p.TGBD.Phut;
            this.TGBD.Giay = p.TGBD.Giay;
            this.TGKT.Gio = p.TGKT.Gio;
            this.TGKT.Gio = p.TGKT.Gio;
            this.TGKT.Gio = p.TGKT.Gio;
            XetThanhTich();
        }

        #endregion
        
    }
}

