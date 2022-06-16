using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace THLTHDT_SM26_2033181060_NguyenVanQuang_KiemTra
{
    class dsThiSinh
    {
        #region get set
       
        List<ThiSinh> dsts1=new List<ThiSinh>();

        public List<ThiSinh> DSTS1
        {
          get { return dsts1; }
          set { dsts1 = value; }
        }
 
        #endregion
        #region Hàm
          public void docFile(string Location)
        {
            XmlDocument read=new XmlDocument();
            read.Load(Location);
            XmlNodeList nodelst = read.SelectNodes("/DSThiSinh/TS");
            foreach (XmlNode a in nodelst)
            {
                ThiSinh ts = new ThiSinh();
                ts.MaThiSinh = a["MaTS"].InnerText;
                ts.HoVaHoDem = a["Holot"].InnerText;
                ts.Ten = a["Ten"].InnerText;
                ts.DiemLyThuyet = double.Parse(a["Diemlythuyet"].InnerText);
                ts.DiemThucHanh = double.Parse(a["Diemthuchanh"].InnerText);
                dsts1.Add(ts);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Danh sách thí sinh: ");
            foreach (ThiSinh ts0 in dsts1)
            {
                ts0.xuat();
                Console.WriteLine("");
            }
        }
        public class SoSanhTenThiSinh : IComparer<ThiSinh>
        {
            public int Compare(ThiSinh x, ThiSinh y)
            {
                return x.Ten.CompareTo(y.Ten);
            }
        }
        public void sort()
        {
            Console.WriteLine("\nDanh sách thí sinh sau khi sort: ");
            dsts1.Sort(new SoSanhTenThiSinh());
        }
        #endregion
    }
}
