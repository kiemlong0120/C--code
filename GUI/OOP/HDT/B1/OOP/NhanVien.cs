using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NhanVien
    {
        private string masonhanvien, hoten, chucvu;
        private float hesoluong, luong;

        public string MaSoNhanVien
        {
            get { return masonhanvien; }
            set
            { masonhanvien = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set
            { hoten = value; }
        }

        public string ChucVu
        {
            get { return chucvu; }
            set
            {
                if (value != "Giám đốc" && value != "Phó Giám Đốc" && value != "Trưởng Phòng" && value != "Nhân viên")
                    Console.WriteLine("Nhập sai!");
                else
                chucvu = value; }
        }


        public float HeSoLuong
        {
            get { return hesoluong; }
            set
            {
                if (value <=0)
                    Console.WriteLine("Nhập sai!");
                else
                    hesoluong = value;
            }
        }

        public float Luong
        {
            get { return luong; }
            
            }
        }



    }

