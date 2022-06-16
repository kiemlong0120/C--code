using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GiaiThuatMaHoa
{
    class NguonTin
    {
        #region Khai báo và get set
        List<double> xacxuattin = new List<double>();
        public List<double> Xacxuattin { get { return xacxuattin; } set { xacxuattin = value; } }
        #endregion
        #region Output Input

        #region hàm nhập giá trị int kiểm tra phải số hay không
        //public int Nhap()
        //{
        //    string a;
        //    int i = 1;
        //    Console.Write("Nhập vào xác xuất (nhập \"end\" để dừng) : ");
        //    do
        //    {
        //        Console.Write("Nhập xác xuất a{0}: ", i);
        //        a = Console.ReadLine();
        //        int b;
        //        if (!int.TryParse(a, out b))
        //        {
        //            if (a == "end")
        //            {
        //                if (i == 1)
        //                {
        //                    Console.WriteLine("Bạn chưa nhập gì cả? ");
        //                    continue;
        //                }
        //                return 0;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Chỉ được nhập số hoặc từ end!");
        //                continue;
        //            }

        //        }
        //        xacxuattin.Add(b);
        //        i++;
        //    } while (true);

        //}
        #endregion
        #region Nhập dãy xác xuất
        public int Nhap()
        {
            double b;
            Console.WriteLine("Nhập vào xác xuất (dùng dấu , để nhập số thâp phân, nhập 2 để dừng nhập) : ");
            while (true)
            {
                xacxuattin.Clear();
                int i = 1;
                while (true)
                {
                    Console.Write("Nhập xác xuất a{0}: ", i);
                    b = double.Parse(Console.ReadLine());
                    if (b == 2)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("Bạn chưa nhập gì cả? ");
                            continue;
                        }
                        else if (Math.Round(KiemTraBang1(), 3) != 1)
                        {
                            Console.WriteLine("Tổng = {0} Nhập sai!, tổng xác xuất phải bằng 1! (gợi ý: bạn dùng dấu , để nhập số thập phân)", Math.Round(KiemTraBang1(), 3));
                            break;
                        }
                        return 0;
                    }
                    if (b <= 0 || b > 1)
                    {
                        Console.WriteLine("Giá trị phải lớn hơn 0 và nhỏ hơn 1!");
                        continue;
                    }
                    xacxuattin.Add(b);
                    i++;
                }
            }

        }
        public void SapXep()
        {
            xacxuattin.Sort();
            xacxuattin.Reverse();
        }
        public double KiemTraBang1()
        {
            double tong = 0;
            foreach (double x in xacxuattin)
                tong += x;
            return tong;
        }
        #endregion
        public void XuatXacXuat()
        {
            Console.WriteLine("Danh sách xác xuất: ");
            foreach (double x in xacxuattin)
                Console.Write(x + " ");
        }
        #endregion
        #region Phương pháp Shannon
        public void ppShannon()
        {
            Console.Clear();
            List<double> shannon2 = new List<double>(xacxuattin.Count);//cột 2 của bảng
            List<int> shannon3 = new List<int>();                 //cột 3
            List<int> shannon4 = new List<int>(xacxuattin.Count);//cột 4
            shannon2.Add(0);
            for (int i = 0; i < xacxuattin.Count - 1; i++)
            {
                shannon2.Add(shannon2[i] + xacxuattin[i]);
            }
            for (int i = 0; i < xacxuattin.Count; i++)
            {
                shannon4.Add((int)Math.Ceiling(-Math.Log(xacxuattin[i], 2)));
            }
            #region Xuất bảng kết quả ra màn hình
            Console.WriteLine("\nTạo bảng mã theo phương pháp shannon: ");          //xuất bảng+Kq
            Console.WriteLine("\t\t___________________________________________________");
            for (int i = 0; i <= xacxuattin.Count - 1; i++)
            {
                shannon3.Clear();
                Console.Write("\t\t| a{0} |", i + 1);
                Console.Write(" {0:0.00} |", xacxuattin[i]);
                Console.Write(" {0:0.00} |", shannon2[i]);
                ChuyenDoiSoNhiPhan(shannon3, shannon2, i);
                Console.Write("| " + shannon4[i] + " |");
                XuatKQShannon(shannon3, shannon4, i);
                Console.WriteLine("");
            }
            Console.WriteLine("\t\t---------------------------------------------------");
            TinhHieuSuat(xacxuattin, shannon4);
            #endregion
        }
        #region các hàm hỗ trợ pp Shannon
        public void XuatKQShannon(List<int> shannon3, List<int> shannon4, int i) //tính cột kq
        {
            for (int u = 0; u < shannon4[i]; u++)
            {
                Console.Write("{0}", shannon3[u]);
            }
            Console.Write("\t\t|");
        }
        public void XuatShannon3(List<int> shannon3) //xuất từng giá trị nhị phân
        {
            foreach (int x in shannon3)
                Console.Write("{0}", x);
        }
        public void ChuyenDoiSoNhiPhan(List<int> shannon3, List<double> shannon2, int i)     //chuyển cột 2 thành nhị phân rồi lưu và cột 3
        {
            double flag = shannon2[i];
            while (shannon3.Count < 8)
            {
                flag *= 2;
                shannon3.Add((int)(flag));
                if (flag >= 1)
                    flag = flag % 1;
            }
            XuatShannon3(shannon3);
        }
        #endregion
        #region Hiệu suất tạo mã
        public void TinhHieuSuat(List<double> xacxuattin, List<int> shannon4)
        {
            double H = TinhEntropy(xacxuattin);
            double L = TinhChieuDai(xacxuattin, shannon4);
            Console.Write("\t\th = H/l = {0:0.00}/{1:0.00} = {2:0.00} ~ {3}%", H, L, H / L, Math.Round((H / L * 100), 0));
        }
        public double TinhChieuDai(List<double> xacxuattin, List<int> shannon4)
        {
            double L = 0;
            for (int i = 0; i < xacxuattin.Count; i++)
                L += xacxuattin[i] * shannon4[i];
            return L;
        }
        public double TinhEntropy(List<double> xacxuattin)
        {
            double H = 0;
            foreach (double x in xacxuattin)
                H += x * Math.Abs(Math.Log(x, 2));
            return H;
        }

        #endregion
        #endregion
        #region Phương pháp Fano
        public void ppFano()
        {
            int demSoLanXuat = 0;
            List<string> fano2 = new List<string>(xacxuattin.Count);
            List<string> fano = new List<string>(xacxuattin.Count);
            ChiaNhomXacXuat(xacxuattin, fano);


            for (int h = 0; ktCotCu(fano); h++)
            {
                List<double> XacXuatClone = new List<double>(xacxuattin.Count);
                fano2.Clear();
                for (int i = 0; i < xacxuattin.Count; i++)
                {
                    XacXuatClone.Add(xacxuattin[i]);
                    if (i < xacxuattin.Count - 1)
                    {
                        if (fano[i].Equals(" ") || !fano[i].Equals(fano[i + 1]))    //kt gtr 0-1 hoặc rỗng
                        {
                            if (XacXuatClone.Count > 1)
                            {
                                ChiaNhomXacXuat2(XacXuatClone, fano2);
                                XacXuatClone.Clear();
                                if (fano2.Count == xacxuattin.Count)
                                    break;
                                continue;
                            }
                            else
                            {
                                fano2.Add(" ");
                                XacXuatClone.Clear();
                                if (fano2.Count == xacxuattin.Count)
                                    break;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if (XacXuatClone.Count > 1)
                        {
                            ChiaNhomXacXuat2(XacXuatClone, fano2);
                            XacXuatClone.Clear();
                            if (fano2.Count == xacxuattin.Count)
                                break;
                            continue;
                        }
                        else
                        {
                            fano2.Add(" ");
                            XacXuatClone.Clear();
                        }
                    }
                }

               
                xuatKQFano(ref demSoLanXuat, fano, fano2, h);
                //TinhHieuSuat(xacxuattin, fano4);
                fano = copyList(fano2);
            }
            Console.WriteLine("\t\t---------------------------------------------------");
            #endregion
        }
        public int xuatKQFano(ref int demSoLanXuat, List<string> fano, List<string> fano2, int i)
        {
            if (demSoLanXuat == 0)
            {
                Console.WriteLine("\nTạo bảng mã theo phương pháp fano: ");          //xuất bảng+Kq
                Console.WriteLine("\t\t___________________________________________________");
                Console.Write("\t\t| a{0} |", i + 1);
                Console.Write(" {0:0.00} |", xacxuattin[i]);
                Console.Write(" {0} |", fano[i]);
                xuatCot(fano2, i);
                demSoLanXuat++;
                return 0;
            }
            else
            {
                xuatCot(fano2, i);
                return 0;
            }
        }
        public void xuatCot(List<string> fano2, int i)
        {
            Console.Write("| " + fano2[i] + " |");
        }

        public double TinhTrungBinh(List<double> xacxuattin)
        {
            double tong = 0;
            for (int i = 0; i < xacxuattin.Count; i++)
            {
                tong += xacxuattin[i];
            }
            return tong / 2;
        }
        public Boolean ktCotCu(List<string> lst)
        {
            for (int i = 0; i < lst.Count; i++)
                if (i != lst.Count - 1)
                    if (!lst[i].Equals(" ") && lst[i].Equals(lst[i + 1]))
                        return true;
            return false;
        }
        public int ChiaNhomXacXuat(List<double> xacxuat, List<string> lst)
        {
            double tb = TinhTrungBinh(xacxuat);
            double flag = xacxuat[0];
            int dem = 1;
            for (int i = 0; i < xacxuat.Count; i++)
            {
                if (flag >= tb)
                {
                    GanGT1(lst, dem);
                    return 0;
                }
                else
                {
                    if (flag + xacxuat[i + 1] > tb)
                    {
                        if (Math.Abs(flag - tb) > Math.Abs(flag + xacxuat[i + 1] - tb))
                        {
                            GanGT1(lst, dem + 1);
                            return 0;
                        }
                        else
                        {
                            GanGT1(lst, dem);
                            return 0;
                        }
                    }

                    else
                    {
                        dem++;
                        flag += xacxuat[1];
                    }
                }
            }
            return 0;
        }
        public int ChiaNhomXacXuat2(List<double> xacxuat, List<string> lst)
        {
            double tb = TinhTrungBinh(xacxuat);
            double flag = xacxuat[0];
            int dem = 1;
            for (int i = 1; i < xacxuat.Count; i++)
            {
                if (flag >= tb)
                {
                    GanGT2(lst, dem, xacxuat.Count);
                    return 0;
                }
                else
                {
                    if (i < xacxuat.Count - 1)
                    {
                        if (flag + xacxuat[i] > tb)
                        {
                            if (Math.Abs(flag - tb) > Math.Abs(flag + xacxuat[i] - tb))
                            {
                                GanGT2(lst, dem + 1, xacxuat.Count);
                                return 0;
                            }
                            else
                            {
                                GanGT2(lst, dem, xacxuat.Count);
                                return 0;
                            }
                        }
                    }
                    else
                    {
                        dem++;
                        flag += xacxuat[1];
                    }
                }
            }
            return 0;
        }
        public void GanGT1(List<string> lst, int dem)
        {
            for (int run = 0; run < dem; run++)
                lst.Add("0");
            for (int run = dem; run < xacxuattin.Capacity; run++)
            {
                lst.Add("1");
            }
        }
        public void GanGT2(List<string> lst, int dem, int i)
        {
            for (int run = 0; run < dem; run++)
                lst.Add("0");
            for (int run = dem; run < i; run++)
            {
                lst.Add("1");
            }
        }
        public List<string> copyList(List<string> list)
        {
            List<string> m = new List<string>(list.Count);
            foreach (string x in list)
                m.Add(x);
            return m;
        }
    }
}

//tìm cách xuất ra bảng ngang hàng

