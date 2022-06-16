using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btt2
{
    class PhanSo
    {

        private float tuSo, mauSo;

        //get,set của thuộc tính
        public float TUSO
        {
            get { return tuSo; }
            set
            {
                tuSo = value;
            }
        }

        public float MAUSO
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Nhập sai!Đã gán giá trị mặc định(1)");
                    mauSo = 1;
                }
                else
                    mauSo = value;
            }
        }

        //hàm khởi tạo mặc định
        public PhanSo()
        {
            TUSO = 0;
            MAUSO = 1;
        }

        //hàm khởi tạo có tham số
        public PhanSo(float TUSO, float MAUSO)
        {
            this.TUSO = TUSO;
            this.MAUSO = MAUSO;
        }

        //hàm khởi tạo sao chép
        public PhanSo(PhanSo q)
        {
            this.TUSO = q.TUSO;
            this.MAUSO = q.MAUSO;
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            this.TUSO = float.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            this.MAUSO = float.Parse(Console.ReadLine());
        }

        public void XuatPhanSo()
        {
            if (MAUSO == 1 || TUSO == 0)
                Console.WriteLine("Phân số của bạn: {0}", this.TUSO);
            else
                Console.WriteLine("Phân số của bạn: {0}/{1}", this.TUSO, this.MAUSO);
        }

        public float TimUocChungLonNhat()
        {
            float a = this.TUSO, b = this.mauSo;
            while (a != b && b != 0 && a != 0)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public void RutGonPhanSo()
        {
            float uoc = TimUocChungLonNhat();
            if (uoc != 0)
            {
                this.TUSO = TUSO / uoc;
                this.MAUSO = MAUSO / uoc;
            }
        }

        public int KiemTraLonHon1()
        {
            if (TUSO / MAUSO > 1)
                return 1;
            else
                return 0;
        }

        public void NghichDaoPhanSo()
        {
            if (TUSO != 0)
            {
                float a = TUSO;
                TUSO = MAUSO;
                MAUSO = a;
                Console.WriteLine("Phân số sau khi nghịch đảo: ");
                this.XuatPhanSo();
            }
            else
                Console.WriteLine("Phân số này không thể nghịch đảo (tử = 0)");
        }

        public void tangPS()
        {
            this.MAUSO += 1;
            this.TUSO += 1;
        }


        public void tangPS(int a)
        {
            this.MAUSO += a;
            this.TUSO += a;
        }

        public void CongPhanSo(PhanSo b)
        {
            
                this.TUSO = b.TUSO * MAUSO + b.MAUSO * this.TUSO;
                this.MAUSO = b.MAUSO * this.MAUSO;
           
        }

        public PhanSo TruPhanSo(PhanSo b)
        {
            if (this.TUSO != 0)
            {
                PhanSo ps1 = new PhanSo();
                ps1.TUSO = TUSO * b.MAUSO - MAUSO * b.TUSO;
                ps1.MAUSO = MAUSO * b.MAUSO;
                return ps1;
            }
            else
            {
                PhanSo ps = new PhanSo();
                ps.TUSO = -b.TUSO;
                ps.MAUSO = b.MAUSO;
                return ps;
            }
        }


        public void NhanPhanSo(PhanSo b)
        {
            this.TUSO *= b.TUSO;
            this.MAUSO *= b.MAUSO;

        }
        public void ChiaPhanSo(PhanSo b)
        {
            this.TUSO *= b.MAUSO;
            this.MAUSO *= b.TUSO;

        }
    }
}
