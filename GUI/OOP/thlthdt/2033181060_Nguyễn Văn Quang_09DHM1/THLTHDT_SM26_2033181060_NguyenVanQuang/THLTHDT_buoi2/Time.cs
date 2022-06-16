using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class Time
    {
        #region thuộc tính và get set
        private int gio, phut, giay;
        private string buoi;
        
        public int Gio
        {
            get { return gio; }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Nhập sai! Đã gán giá trị mặc định(0)");
                }
                else
                    gio = value;
            }
        }

        public int Phut
        {
            get { return phut; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Nhập sai! Đã gán giá trị mặc định(0)");
                }
                else
                    phut = value;
            }
        }
        public int Giay
        {
            get { return giay; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Nhập sai! Đã gán giá trị mặc định(0)");
                }
                else
                    giay = value;
            }
        }

        public string Buoi
        {
            get { return buoi; }
            set
            {
                if (value != "AM" && value != "PM" && value != "am" && value != "pm")
                {
                    Console.WriteLine("Nhập sai!  Đã gán giá trị mặc định(AM)");
                    buoi = "AM";
                }
                else
                    buoi = value;
            }
        }

        #endregion

        #region Constructors

        public Time()
        {
            Gio = Phut = Giay = 0;
            buoi = "";
        }

        //hàm khởi tạo có tham số
        public Time(int Gio, int Phut, int Giay, string Buoi)
        {

            this.Gio = Gio;
            this.Phut = Phut;
            this.Giay = Giay;
            this.Buoi = buoi;
        }

        //hàm khởi tạo sao chép
        public Time(Time t)
        {
            this.Gio = t.Gio;
            this.Phut = t.Phut;
            this.Giay = t.Giay;
            this.Buoi = t.buoi;
        }

        #endregion

        #region hàm

        public void NhapThoiGian12()
        {
            int flag = 0;
            Console.Write("Nhập Giờ: ");
            this.Gio = int.Parse(Console.ReadLine());
            if (this.Gio > 11)
            {
                this.Gio = this.Gio - 12;
                flag = 1;
                this.Buoi = "PM";
            }
            Console.Write("Nhập Phút: ");
            this.Phut = int.Parse(Console.ReadLine());
            while (this.Phut > 59) ;
            Console.Write("Nhập Giây: ");
            this.Giay = int.Parse(Console.ReadLine());
            while (this.Giay > 59) ;
            if (flag == 0)
            {
                Console.Write("Nhập Buổi(AM hoặc PM): ");
                this.Buoi = Console.ReadLine();
            }

        }
        public void NhapThoiGian24()
        {

            Console.Write("Nhập Giờ: ");
            this.Gio = int.Parse(Console.ReadLine());
            Console.Write("Nhập Phút: ");
            this.Phut = int.Parse(Console.ReadLine());
            while (this.Phut > 59) ;
            Console.Write("Nhập Giây: ");
            this.Giay = int.Parse(Console.ReadLine());
        }

        public void XuatThoiGian(int dinhdang)
        {
            if (dinhdang == 12)
                Console.WriteLine("Thời gian: {0}:{1}:{2},{3}", Gio, Phut, Giay, Buoi);
            else
                Console.WriteLine("Thời gian: {0}:{1}:{2}", Gio, Phut, Giay);
        }

        public void TangThoiGian()
        {
            Time u = new Time();
            Console.WriteLine("Nhập thời gian bạn muốn tăng: ");
            u.NhapThoiGian24();
            u.XuatThoiGian(24);


            //kiểm tra giá trị giây
            if (this.Giay + u.Giay > 59)
            {
                if (this.Phut + 1 > 59)
                {
                    if (this.Gio + 1 > 23)
                    {
                        this.Gio = 0;

                        this.Phut = 0;
                        int flag2 = 60 - this.Giay;
                        if (u.Giay - flag2 < 0)
                            this.Giay = 0;
                        else
                            this.Giay = u.Giay - flag2;


                    }
                    else
                    {
                        this.Gio = this.Gio + 1;
                        int flag2 = 60 - this.Phut;
                        if (u.Phut - flag2 < 0)
                            this.Phut = 0;
                        else
                            this.Phut = u.Phut - flag2;
                        this.Giay = 0;
                    }
                }
                else
                {
                    this.Phut = this.Phut + 1;
                    int flag2 = 60 - this.Giay;
                    if (u.Giay - flag2 < 0)
                        this.Giay = 0;
                    else
                        this.Giay = u.Giay - flag2;
                }
            }
            else
            {
                this.Giay = this.Giay + u.Giay;
            }
            //kiểm tra giá trị phút
            if (this.Phut + u.Phut > 59)
            {

                if (this.Gio + 1 > 23)
                {
                    this.Gio = 0;
                }
                else
                {
                    this.Gio = this.Gio + 1;
                }
                int flag2 = 60 - this.Phut;
                if (u.Phut - flag2 < 0)
                    this.Phut = 0;
                else
                    this.Phut = u.Phut - flag2;

            }
            else
            {
                this.Phut = this.Phut + u.Phut;
            }
            //kiểm tra giá trị giờ
            if (this.Gio + u.Gio > 23)
            {
                int flag2 = 24 - this.Gio;
                if (u.Gio - flag2 < 0)
                    this.Gio = 0;
                else
                    this.Gio = u.Gio - flag2;
            }
            else
                this.Gio = this.Gio + u.Gio;
        }

        public void GiamThoiGian()
        {
            Time o = new Time();
            Console.WriteLine("Nhập thời gian bạn muốn giảm: ");
            o.NhapThoiGian24();
            o.XuatThoiGian(24);
            if (this.Giay - o.Giay < 0)
            {
                if (this.Phut - 1 < 0)
                {
                    if (this.Gio - 1 < 0)
                    {
                        this.Gio = 24 - o.Gio;
                        this.Phut = 0;
                        this.Giay = 0;
                    }
                    else
                    {
                        this.Gio = this.Gio - 1;
                        this.Phut = 60 - o.Phut;
                        this.Giay = 0;
                    }
                }
                else
                {
                    this.Phut = this.Phut - 1;
                    int flag = this.Giay - o.Giay;
                    if (flag < 0)
                        this.Giay = 60 + flag;
                    else
                        this.Giay = this.Giay - o.Giay;
                }
            }
            else
            {
                this.Giay = this.Giay - o.Giay;
            }


            //kiểm tra giá trị phút
            if (this.Phut - o.Phut < 0)
            {

                if (this.Gio - 1 < 0)
                {
                    this.Gio = 24 - o.Gio;
                    this.Phut = 0;
                }
                else
                {
                    this.Gio = this.Gio - 1;
                    this.Phut = this.Phut + 60 - o.Phut;
                }
            }
            else
            {
                this.Phut = this.Phut - o.Phut;
            }

            //kiểm tra giá trị giờ
            if (this.Gio - o.Gio < 0)
            {

                this.Gio = this.Gio + 24 - o.Gio;
            }
            else
                this.Gio = this.Gio - o.Gio;
        }

        public void TangThoiGian12()
        {
            Time u = new Time();
            Console.WriteLine("Nhập thời gian bạn muốn tăng: ");
            u.NhapThoiGian12();
            u.XuatThoiGian(12);


            //kiểm tra giá trị giây
            if (this.Giay + u.Giay > 59)
            {
                if (this.Phut + 1 > 59)
                {
                    if (this.Gio + 1 > 23)
                    {
                        this.Gio = 0;

                        this.Phut = 0;
                        int flag2 = 60 - this.Giay;
                        if (u.Giay - flag2 < 0)
                            this.Giay = 0;
                        else
                            this.Giay = u.Giay - flag2;


                    }
                    else
                    {
                        this.Gio = this.Gio + 1;
                        int flag2 = 60 - this.Phut;
                        if (u.Phut - flag2 < 0)
                            this.Phut = 0;
                        else
                            this.Phut = u.Phut - flag2;
                        this.Giay = 0;
                    }
                }
                else
                {
                    this.Phut = this.Phut + 1;
                    int flag2 = 60 - this.Giay;
                    if (u.Giay - flag2 < 0)
                        this.Giay = 0;
                    else
                        this.Giay = u.Giay - flag2;
                }
            }
            else
            {
                this.Giay = this.Giay + u.Giay;
            }
            //kiểm tra giá trị phút
            if (this.Phut + u.Phut > 59)
            {

                if (this.Gio + 1 > 23)
                {
                    this.Gio = 0;
                }
                else
                {
                    this.Gio = this.Gio + 1;
                }
                int flag2 = 60 - this.Phut;
                if (u.Phut - flag2 < 0)
                    this.Phut = 0;
                else
                    this.Phut = u.Phut - flag2;

            }
            else
            {
                this.Phut = this.Phut + u.Phut;
            }
            //kiểm tra giá trị giờ
            if (this.Gio + u.Gio > 12)
            {
                int flag2 = 12 - this.Gio;
                if (u.Gio - flag2 < 0)
                    this.Gio = 0;
                else
                {
                    this.Gio = u.Gio - flag2;
                    if (this.Buoi == "am" || this.Buoi == "AM")
                        this.Buoi = "PM";
                    if (this.Buoi == "pm" || this.Buoi == "PM")
                        this.Buoi = "AM";
                }
            }
            else
                this.Gio = this.Gio + u.Gio;
        }

        public void GiamThoiGian12()
        {
            Time o = new Time();
            Console.WriteLine("Nhập thời gian bạn muốn giảm: ");
            o.NhapThoiGian24();
            o.XuatThoiGian(24);
            if (this.Giay - o.Giay < 0)
            {
                if (this.Phut - 1 < 0)
                {
                    if (this.Gio - 1 < 0)
                    {
                        this.Gio = 24 - o.Gio;
                        this.Phut = 0;
                        this.Giay = 0;
                    }
                    else
                    {
                        this.Gio = this.Gio - 1;
                        this.Phut = 60 - o.Phut;
                        this.Giay = 0;
                    }
                }
                else
                {
                    this.Phut = this.Phut - 1;
                    int flag = this.Giay - o.Giay;
                    if (flag < 0)
                        this.Giay = 60 + flag;
                    else
                        this.Giay = this.Giay - o.Giay;
                }
            }
            else
            {
                this.Giay = this.Giay - o.Giay;
            }


            //kiểm tra giá trị phút
            if (this.Phut - o.Phut < 0)
            {

                if (this.Gio - 1 < 0)
                {
                    this.Gio = 24 - o.Gio;
                    this.Phut = 0;
                }
                else
                {
                    this.Gio = this.Gio - 1;
                    this.Phut = this.Phut + 60 - o.Phut;
                }
            }
            else
            {
                this.Phut = this.Phut - o.Phut;
            }

            //kiểm tra giá trị giờ
            if (this.Gio - o.Gio < 0)
            {

                this.Gio = this.Gio + 12 - o.Gio;
                if (this.Buoi == "am" || this.Buoi == "AM")
                    this.Buoi = "PM";
                if (this.Buoi == "pm" || this.Buoi == "PM")
                    this.Buoi = "AM";
            }
            else
                this.Gio = this.Gio - o.Gio;
        }
        #endregion


    }


}


