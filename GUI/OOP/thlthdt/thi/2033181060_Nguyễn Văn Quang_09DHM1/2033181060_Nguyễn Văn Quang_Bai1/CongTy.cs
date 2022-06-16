using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2033181060_Nguyễn_Văn_Quang_Bai1
{
    class CongTy
    {
        #region get set

        string tencongty, diachicongty;
        List<NhanVien> dsNV;

        public string Diachicongty
        {
            get { return diachicongty; }
            set { diachicongty = value; }
        }

        public string Tencongty
        {
            get { return tencongty; }
            set { tencongty = value; }
        }

        #endregion
        #region ham khoi tao
        public CongTy()
        {
            this.Tencongty = "";
            this.Diachicongty = "";
            List<NhanVien> dsNV = new List<NhanVien>();
        }
        #endregion
        #region methods

        public void readFile()
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"..\..\data\dsnv.xml");
            this.Tencongty = read.SelectSingleNode("/CongTy/TenCongTy").InnerText;
            this.Diachicongty = read.SelectSingleNode("/CongTy/DiaChi").InnerText;
            dsNV.Clear();
            XmlNodeList nl = read.SelectNodes("/CongTy/DanhSachNhanVien/NhanVien");
            foreach (XmlNode node in nl)
            {
                NhanVien Nv;
                string loai = node.Attributes["Loai"].InnerText;
                string ma = node["Ma"].InnerText;
                string ten = node["Ten"].InnerText;
                int ns = int.Parse(node["NamSinh"].InnerText);
                string diachi = node["DiaChi"].InnerText;
                double hsluong = double.Parse(node["HeSoLuong"].InnerText);
                int namvaolam = int.Parse(node["NamVaoLam"].InnerText);

                if (loai == "LTV")
                {
                    int overtime = int.Parse(node["SoGioLamVuot"].InnerText);
                    Nv = new LapTrinhVien(ma, ten, ns, diachi, hsluong, namvaolam, overtime);
                }
                else if (loai == "TK")
                {
                    int soduan = int.Parse(node["SoDuAnHoanThanh"].InnerText);
                    Nv = new ChuyenVienThietKe(ma, ten, ns, diachi, hsluong, namvaolam, soduan);
                }
                else
                {
                    int soloi = int.Parse(node["SoLoiPhatHien"].InnerText);
                    Nv = new ChuyenVienKiemThu(ma, ten, ns, diachi, hsluong, namvaolam, soloi);
                }
                dsNV.Add(Nv);
            }
        }



        public void xuatCongTy()
        {
            Console.WriteLine("Ten CT: {0}--- Dia chi CT: {1}", Tencongty, Diachicongty);
            Console.WriteLine("Danh sach nhan vien cua cong ty: ");
            //lstHDs.ForEach(t => t.xuat()); 
            foreach (NhanVien nv in dsNV)
                nv.Xuat();
        }
        public double tinhTongTien()
        { return dsNV.Sum(t => t.tinhLuong()); }
        //public NhanVien timThucLinhThapNhat()
        //{
        //    if (dsNV.Count == 0) return null;
        //    //return dsNV.OrderByDescending(t => t.tinhSoTienThucLinh).First();
        //}
        #endregion

    }
}
