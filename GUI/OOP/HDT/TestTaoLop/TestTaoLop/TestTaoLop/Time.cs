using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaoLop
{
    class Time
    {
        // 1/Biến thành viên
        private int hour;
        private int minute;
        private int second;
        // Thuoc tinh
        public int Hour
        {
            get { return hour; }
            set {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Du lieu sai");
                    hour = 0;
                }
                else
                    hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }
        //// Có 3 loại hàm khởi tạo
        ////Loại 1. Hàm khởi tạo mặc định: ko có tham so tường minh
        //// Nếu trong lớp không có hàm khởi tạo nào thì C# sẽ tự cho lớp hàm khởi tạo mặc định
        //public Time()
        //{
        //    hour = minute = second = 99;
        //}
        //Loai 2: Hàm khởi tạo có tham so tương ứng là các thuộc tính của lớp
        public Time(int Hour, int Minute, int Second)
        {
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }
        //Loại 3: Hàm khởi tạo sao chép: có tham số là 1 đối tượng của lớp
        public Time(Time a)
        {
            this.Hour = a.Hour;
            this.Minute = a.Minute;
            this.Second = a.Second;
        }






        //2. Phương thức
        public void nhap()
        {
            Console.WriteLine("Nhap Time: ");
            hour = int.Parse(Console.ReadLine());
            minute = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0}:{1}:{2}", hour, minute, second);
        }

    }
}
