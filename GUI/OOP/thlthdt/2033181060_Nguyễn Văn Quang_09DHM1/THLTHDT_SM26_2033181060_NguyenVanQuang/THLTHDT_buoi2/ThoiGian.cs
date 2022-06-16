using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class ThoiGian
    {
        private int gio, phut, giay;

        //get,set của thuộc tính
        #region get set

        public int Gio
        {
            get { return gio; }
            set
            {
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

        #endregion
        //hàm khởi tạo mặc định
        #region Constructors

        public ThoiGian()
        {
            Gio = Phut = Giay = 0;
        }

        #endregion
        public void XuatThoiGian()
        {
            Console.WriteLine("Thời gian: {0}:{1}:{2}", this.Gio, this.Phut, this.Giay);
        }
    }
}
