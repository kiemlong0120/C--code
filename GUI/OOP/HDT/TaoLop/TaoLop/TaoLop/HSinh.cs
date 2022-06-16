using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLop
{
    class HSinh
    {
        String hten;
        float dtb;
        String xloai;
        public String Hten
        {
            get { return hten; }
            set { hten = value; }
        }
        public float Dtb
        {
            get { return dtb; }
            set {
                if (value < 0)
                    dtb = 0;
                else
                dtb = value; }
        }
        public String Xloai
        {
            get {
                xetXepLoai();
                return xloai; }
           
        }
        //------------------------
       public void xetXepLoai()
        {
            if (dtb >= 8.5)
                xloai = "Gioi";
            else
                xloai = "Khong gioi";
        }
    // Hàm khởi tạo của 1 lớp có 3 loại:
        //1. Hàm khởi tạo mặc định: là hàm khởi tạo
        //không có tham số, các thuộc tính của lớp
        //nhận giá trị mặc định
       public HSinh()
       {
           Hten = "";
           Dtb = 0;
           xetXepLoai();
       }
      //2. Hàm khởi tạo có tham số là danh sách các
        //thuộc tính của lớp; 
       public HSinh(String Hten, float Dtb)
       {
           this.Hten = Hten;
           this.Dtb = Dtb;
           xetXepLoai();
       }
        //3/Ham khoi tao (constructor, hàm khởi dựng)
        //sao chep: có tham số là 1 đối tượng
        //của lớp
       public HSinh(HSinh a)
       {
           this.Hten = a.Hten;
           this.Dtb = a.Dtb;
           xetXepLoai();
       }






        
        
        public void xuat()
       {
           Console.WriteLine("{0} - {1} - {2}", hten, dtb, Xloai);
       }
    
    
    
    }
}
