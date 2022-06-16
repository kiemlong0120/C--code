using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;

namespace btt2
{
    class NhanVien
    {
        #region thuộc tính và get set
        string manv, hoten;
        int hesoluong, namvaolam;
        static double mltt;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Hoten { get { return hoten; } set { hoten = value; } }
        public int Hesoluong { get { return hesoluong; } set { hesoluong = value; } }
        public int Namvaolam { get { return namvaolam; } set { namvaolam = value; } }
        #endregion
        #region Constructors
        public NhanVien()
        {
            Manv = Hoten = "";
            Hesoluong = 0;
            Namvaolam = 0;
        }
        public NhanVien(string Manv, string Hoten, int Hesoluong, int Namvaolam)
        {
            this.Manv = Manv;
            this.Hoten = Hoten;
            this.Hesoluong = Hesoluong;
            this.Namvaolam = Namvaolam;
        }
        public NhanVien(NhanVien a)
        {
            this.Manv = a.Manv;
            this.Hoten = a.Hoten;
            this.Hesoluong = a.Hesoluong;
            this.Namvaolam = a.Namvaolam;
        }
        #endregion
        #region Hàm
        
        #endregion

    }
}
