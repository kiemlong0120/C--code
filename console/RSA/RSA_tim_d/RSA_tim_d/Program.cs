using System;
using System.Text;
using System.Collections.Generic;


namespace RSA_tim_d
{
    class Program
    {
        #region Hàm xử lý

                                                                    // mấy cái này làm màu mè thôi
        static void editConsole()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "RSA - GAURED";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("                                     Tìm khoá công khai RSA");
        }

        static int KTSNT(long item)                             // hàm kiểm tra số nguyên tố, trả về 1 nếu đùng, trả về 0 nếu sai
        {
            if (item < 2)
                return 0;
            int j = 2;
            while (item % j != 0)
                j++;
            if (item == j)
                return 1;
            else
                return 0;
        }

      
        static void nhapPQ(ref long p,ref  long q)                      // hàm nhập số nguyên tố p và q ban đầu
        {
                do                                                       // lòng lặp nhập p
                {
                    Console.Write(" Nhập vào số nguyên tố p: ");            // dùng vòng lặp để kiểm tra số nhập là số nguyên tố, sai thì nó lặp lại bắt nhập lại
                try
                {
                    p = long.Parse(Console.ReadLine());
                }
                catch 
                {
                    continue;
                }
                    
                    if (KTSNT(p) == 0)
                    {
                        Console.WriteLine(" {0} không phải số nguyên tố, Vui lòng nhập số nguyên tố để tiếp tục!", p);
                    }

                } while (KTSNT(p) == 0);

                
            do
            {
                Console.Write("\n Nhập vào số nguyên tố q khác với p vừa nhập: ");         //giống ở trên nhưng là vòng lặp nhập Q
                try
                {
                    q = long.Parse(Console.ReadLine());
                }
                catch 
                {
                    continue;
                }
                
                if (KTSNT(q) == 0)
                {
                    Console.WriteLine(" {0} không phải số nguyên tố, vui lòng nhập lại", q);
                }
                if (q == p)
                    Console.WriteLine(" q phải khác với p");

            } while (KTSNT(q)==0 || q==p);
        }

        static long tinhN(long p, long q)                   //hàm tính N = p.q
        {
            return p * q;
        }
        static long TinhPhiN(long p, long q)                // hàm tính phi N
        {
            return (p - 1) * (q - 1);
        }

        static int IsElementExistInList(int n, List<long> a)            //hàm kiểm tra xem số đó có trong list hay chưa
        {
            foreach (int item in a)
            {
                if (n == item)
                    return 1;
            }
            return 0;
        }
        static void xuatList(List<long> a)                      //hàm xuất list
        {
            foreach (int  item in a)
            {
                Console.Write(" "+ item);
            }
        }
        static void phanTichThuaSo(long phiN,List<long> thuaso)         // hàm tách số phi N thành luỹ thừa và xuất ra dạng 2^2x3^2.... 
        {
            int demSoMu;

            for (int i = 2; i <= phiN; i++)
            {
                demSoMu = 0;
                while (phiN % i == 0)
                {
                    ++demSoMu;
                    phiN = phiN / i;
                }
                if (demSoMu != 0)
                {
                    if (IsElementExistInList(i, thuaso) == 0)
                        thuaso.Add(i);
                    Console.Write(i);
                    if (demSoMu > 1) Console.Write("^" + demSoMu);
                    if (phiN > i)
                    {
                        Console.Write(" * ");
                    }
                }
            }
        }

        static void xuatDSKhoaE(long phiN, List<long> thuaso, List<long> khoaE)                 // hàm xuất danh sach khoá e có thể tạo được bằng p và q ở trên (e là khoá bí mật)
        {

            for (int i = 1; i < phiN; i++)
            {
                int temp = 0;
                for (int j = 0; j < thuaso.Count; j++)
                {
                    if (i % thuaso[j] == 0)
                    {
                        temp++;
                        break;
                    }

                }
                if (temp == 0)
                    khoaE.Add(i);

            }

            xuatList(khoaE);
        }
        static long randomE(List<long> khoaE)                               //hàm khởi tạo số random
        {
            Random r = new Random();
            
            return khoaE[r.Next(0, khoaE.Count - 1)];
        }

        static long choseE(List<long> khoaE)                                    // hàm để khách hàng tự chọn 1 e trong danh sách khoá e ở trên
        {
            long n;

            do
            {
                Console.Write("\n   Chọn 1 khoá công khai e bạn muốn (nhập 0 để chọn random): ");
                try
                {
                    n = long.Parse(Console.ReadLine());
                }
                catch 
                {
                    continue;
                }
                
                if (khoaE.Contains(n))
                    return n;
                else if (n==0)                              // hàm chọn random 1 trong các e có trong list khoá e ở trên  (e là khoá bí mật) khi khách hàng nhập 0
                {
                    return randomE(khoaE);
                }
                else Console.WriteLine("Vui lòng chọn lại!");

            } while (true);

        }



        static long tinhKhoaBiMat(long phiN,long e)                             //bảng euclid mở rộng
        {
            long r1 = phiN, r2 = e, t1 = 0, t2 = 1, q, r, t;

            Console.WriteLine("|\tq(thương)|\tr1(phiN)|\tr2(e)\t|\tr(dư)\t|\tt1\t|\tt2\t|\tt\t|");      // in ra các cột
            #region tính toán

            while (r2 != 0)
            {
                q = r1 / r2;                                                                            //công thức tính
                r = r1 % r2;
                t = t1 - (t2 * q);

                Console.WriteLine("\n|\t{0}\t |\t{1}\t|\t{2}\t|\t{3}\t|\t{4}\t|\t{5}\t|\t{6}\t|", q,r1,r2,r,t1,t2,t);           // dịch trái

                r1 = r2;
                r2 = r;
                t1 = t2;
                t2 = t;
            }

            Console.WriteLine("\n|\tX\t |\t{0}\t|\t{1}\t|\tX\t|\t{2}\t|\t{3}\t|\tX\t|", r1, r2, t1, t2);

            if (t1==e)
            {
                Console.WriteLine("\nKhoá bí mật là {0} trùng với khoá công khai nên khoá bí mật là phiN+d= {1}",t1,t1+phiN);           //bước kiểm tra xem khoá bí mật d tính xong có bằng khoá công khai e không, nếu có thì phải thay d bằng số nghịc đảo
                return t1 + phiN;
            }
            if (t1<0)
            {
                return phiN + t1;
            }
            return t1;
            #endregion

        }



        #endregion

        static void Main(string[] args)
        {
            #region edit console
            editConsole();
            #endregion

            #region KhaiBao

            long p = 0, q = 0, n, phiN;
            List<long> thuaso = new List<long>(); //list chứa thừa số phân tách từ Zn*
            List<long> khoaE = new List<long>();  //list chứa danh sách các khoá công khai e tạo được từ p,q

            
            long KhoaCongKhai;
            long KhoaBiMat;

            #endregion
            #region PhuongThuc

            while (true)
            {

            Console.WriteLine("\nBước 1: chọn 2 số nguyên tố p và q (p khác q): ");
            nhapPQ(ref p,ref q);
            Console.WriteLine(" Hai số nguyên tố đã chọn: {0} , {1}",p,q);

            n = tinhN(p, q);
            Console.WriteLine("\nBước 2: tính n=p*q = {0}",n);

            phiN = TinhPhiN(p, q);
            Console.WriteLine("\nBước 3: tính phi của n({0})=(p-1)*(q-1) = {1}",n,phiN);
            
            Console.WriteLine("\nBước 4: chọn một khoá công khai e dùng để mã hoá sao cho e thuộc Z({0})*",phiN);
            Console.Write("\n   Tiến hành phân tích Z({0}) thành các thừa số = ", phiN);
            phanTichThuaSo(phiN,thuaso);


            #region option chọn khoá công khai
            Console.Write("\n Danh sách các thừa số: ");
            xuatList(thuaso);

            Console.WriteLine("\n Danh sách các khoá công khai e có thể chọn: ");
            xuatDSKhoaE(phiN, thuaso, khoaE);

            KhoaCongKhai = choseE(khoaE);
            Console.WriteLine("\n Khoá công khai đã chọn: {0}", KhoaCongKhai);
            #endregion

            

            #region bước tìm khoá bí mật với khoá công khai đã biết

            KhoaBiMat = tinhKhoaBiMat(phiN,KhoaCongKhai);
            Console.WriteLine("Khoá bí mật là: {0}", KhoaBiMat);

            #endregion



            #endregion



            Console.ReadKey();
            }

        }
    }
}
