using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi2
{
    class HinhChuNhat
    {
        #region Thuộc tính
        private float dai, rong;
        #endregion

        #region get set
        public float Dai
        {
            get { return dai; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nhập sai!Đã gán giá trị mặc định(0)");
                }
                else
                    dai = value;
            }
        }

        public float Rong
        {
            get { return rong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nhập sai!Đã gán giá trị mặc định(0)");
                }
                else
                    rong = value;
            }
        }
        #endregion

        #region Constructors
        public HinhChuNhat()
        {
            Dai = Rong = 0;
        }

        //hàm khởi tạo có tham số
        public HinhChuNhat(float Dai, float Rong)
        {

            this.Dai = Dai;
            this.Rong = Rong;

        }

        //hàm khởi tạo sao chép
        public HinhChuNhat(HinhChuNhat a)
        {
            this.Dai = a.Dai;
            this.Rong = a.Rong;

        }
        #endregion

        #region Hàm xử lý
        public void TinhChuVi()
        {
            Console.WriteLine("Chu vi hình chữ nhật: {0}", (this.Dai + this.Rong) * 2);
        }

        //hàm tính diện tích
        public void TinhDienTich()
        {
            Console.WriteLine("Diện tích hình chữ nhật: {0}", this.Dai * this.Rong);

        }


        //hàm tính độ dài đường chéo
        public void TinhDuongCheo()
        {

            Console.WriteLine("Độ dài đường chéo hình chữ nhật: {0}", Math.Round(Math.Pow(Math.Pow(this.Dai, 2) + Math.Pow(this.Rong, 2), 1.0 / 2), 2)); //tính căn bậc 2 của bình phương đường chéo

        }

        //hàm nhập HCN
        public void NhapHinhChuNhat()
        {
            Console.Write("Nhập chiều dài: ");
            this.Dai = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            this.Rong = float.Parse(Console.ReadLine());
        }

        //hàm xuất hình chữ nhật
        public void VeHinhChuNhat()
        {
            Console.WriteLine("Hình chữ nhật: Dài: {0}, Rộng: {1}", this.Dai, this.Rong);
            for (float i = 1; i <= this.Rong; i++)
            {
                Console.Write("        ");
                for (float j = 1; j <= this.Dai; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }
        }

        //hàm tăng kích thước HCN bằng nhập
        public void ChangeSize()
        {
            Console.WriteLine("ChangeSize: bạn muốn tăng hay giảm? (tăng=1, giảm=0): ");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Nhập giá trị cần tăng thêm: ");
                Console.Write("Tăng chiều Dài= ");
                this.Dai = this.Dai + float.Parse(Console.ReadLine());
                Console.Write("Tăng chiều Rộng= ");
                this.Rong = this.Rong + float.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Nhập giá trị cần giảm xuống: ");
                Console.Write("Giảm chiều Dài= ");
                this.Dai = this.Dai + float.Parse(Console.ReadLine());
                Console.Write("Giảm chiều Rộng= ");
                this.Rong = this.Rong + float.Parse(Console.ReadLine());
            }
        }

        //hàm tăng kích thước bằng HCN khác
        public void ChangeSize(HinhChuNhat a)
        {
            Console.WriteLine("ChangeSize: bạn muốn tăng hay giảm? (tăng=1, giảm=0): ");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                this.Dai = this.Dai + a.Dai;
                this.Rong = this.Rong + a.Rong;
            }
            else
            {
                this.Dai = this.Dai - a.Dai;
                this.Rong = this.Rong - a.Rong;
            }    
        }
        #endregion
    }
}
