using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace THLTHDT_buoi4
{
    class DanhSachTS
    {
        #region get set

        List<ThiSinh> dsts = new List<ThiSinh>();

        public List<ThiSinh> Dsts
        {
            get { return dsts; }
            set { dsts = value; }
        }

        #endregion
        #region Hàm xử lý
        public void docFile(string Location)
        {
            XmlDocument read=new XmlDocument();
            read.Load(Location);
            XmlNodeList nodelst = read.SelectNodes("/DanhSachThiSinh/TS");
            foreach (XmlNode a in nodelst)
            {
                ThiSinh ts = new ThiSinh();
                ts.SBD = a["SBD"].InnerText;
                ts.HoLot = a["Holot"].InnerText;
                ts.Ten = a["Ten"].InnerText;
                ts.NamSinh = int.Parse(a["NamSinh"].InnerText);
                ts.Toan = double.Parse(a["Toan"].InnerText);
                ts.Van = double.Parse(a["Van"].InnerText);
                ts.NgoaiNgu = double.Parse(a["NgoaiNgu"].InnerText);
                dsts.Add(ts);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Danh sách thí sinh: ");
            foreach (ThiSinh ts0 in dsts)
                ts0.xuat();
        }

        //public void tinhTong()
        //{
        //    foreach(ThiSinh a in dsts)
        //    {
        //        a.
        //    }
        //}

        #endregion
    }
}
