using System;
using System.Collections.Generic;
using System.Text;

namespace DES
{
    class Program
    {
        #region methods
        static void editConsole()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "DES - GAURED";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("                                     MÃ HOÁ GIẢI THUẬT DES");
        }
        static void ReadFile(string Location, List<int> a,int file)
        {
            string[] read;

            if (System.IO.File.Exists(Location))
            {

                read = System.IO.File.ReadAllLines(Location);
                foreach (string c in read)
                {
                    a.Add(int.Parse(c));
                }
            }
            else
            {
                Console.WriteLine("File {0} does not exist", Location);
            }
            if (file == 0)
            {
                if (a.Count < 64)
                {
                    Console.WriteLine("Lỗi Input hoặc KEY (chuyển về dạng nhị phân 64 bit)!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

        static void xuat(List<int> list)
        {
            Console.WriteLine("\nsố lượng bit: {0}",list.Count);
            foreach (int i in list)
            {
                Console.Write("{0}  ", i);
            }
        }

        static List<int> fusion(List<int> a, List<int> b)
        {
            List<int> c = new List<int>();
            for(int i=0;i<b.Count;i++)
            {
                c.Add(a[b[i] - 1]);
            }
            return c;
        }

        static void copyList(List<int> a, List<int> b)
        {
            b.Clear();
            foreach (int i in a)
            {
                b.Add(i);
            }

        }

        static void tinhKhoaK(List<int> k, int bit,List<int> c, List<int> d)
        {

            leftShift(c, bit);      //dịch trái
            leftShift(d, bit);



            k.Clear();
            for (int i = 0; i < c.Count; i++)
            {
                k.Add(c[i]);
            }                                   // gộp c d thành key
            
            for(int i=0; i<d.Count;i++)
            {
                k.Add(d[i]); 
            }


        }

        static void leftShift(List<int> temp, int bit)
        {
            if (bit == 1)
            {
                int gtdau = temp[0];
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    temp[i] = temp[i + 1];
                }
                temp[temp.Count - 1] = gtdau;
            }

            else
            {
                int gt1 = temp[0];
                int gt2 = temp[1];
                for (int i = 0; i < temp.Count - 2; i++)
                {
                    temp[i] = temp[i + 2];
                }
                temp[temp.Count - 2] = gt1;
                temp[temp.Count - 1] = gt2;
            }

        }

        static List<int> xor(List<int> a, List<int> b)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                {
                    temp.Add(0);
                }
                else { temp.Add(1); }
            }
            return temp;
        }

        static void ChuyenDoiNhiPhan(List<int> temp3)
        {
            List<int> flag = new List<int>();
            copyList(temp3, flag);
            temp3.Clear();
            int soDu;

            for (int i = flag.Count - 1; i >= 0; i--)    // duyệt từ dưới lên của dãy flag
            {
                for (int sobit = 3; sobit >= 0; sobit--)    // cố định số bit là 4
                {
                    if (flag[i] > 0)
                    {
                        soDu = flag[i] % 2;
                        temp3.Add(soDu);                //add vào list temp3 và đảo ngược vì khi chia lấy bit dư đi từ dưới lên
                        flag[i] = flag[i] / 2;
                    }
                    else
                        temp3.Add(0);
                }
            }
            temp3.Reverse();
        }

        static List<int> gopRL16(List<int> R, List<int> L,List<int> Output)
        {
            for (int i = 0; i < L.Count; i++)
            {
                Output.Add(L[i]);
            }
            for (int i = 0; i < R.Count; i++)
            {
                Output.Add(R[i]);
            }
            return Output;
        }
        #endregion
        static void Main(string[] args)
        {
            editConsole();

            #region ListData
            List<int> Input = new List<int>();
            List<int> KeyBD = new List<int>();
            List<int> Key = new List<int>();
            List<int> Output = new List<int>();
            List<int> IP = new List<int>();
            List<int> S1 = new List<int>();
            List<int> S2 = new List<int>();
            List<int> S3 = new List<int>();
            List<int> S4 = new List<int>();
            List<int> S5 = new List<int>();
            List<int> S6 = new List<int>();
            List<int> S7 = new List<int>();
            List<int> S8 = new List<int>();
            List<int> P = new List<int>();
            List<int> IP2 = new List<int>();
            List<int> E = new List<int>();
            List<int> PC1 = new List<int>();
            List<int> leftShift = new List<int>();
            List<int> PC2 = new List<int>();
            List<int> L = new List<int>();
            List<int> R = new List<int>();
            List<int> temp = new List<int>();
            List<int> temp2 = new List<int>();
            List<int> temp3 = new List<int>();
            List<int> L2 = new List<int>();         // giữ giá trị vòng tiếp theo
            List<int> R2 = new List<int>();         // giữ giá trị vòng tiếp theo
            List<int> C = new List<int>();         // giữ giá trị vòng tiếp theo
            List<int> D = new List<int>();         // giữ giá trị vòng tiếp theo


            #endregion

            #region LoadData

            ReadFile("../../data/program/E.txt", E,1);
            ReadFile("../../data/program/IP.txt", IP,1);
            ReadFile("../../data/program/S1.txt", S1,1);
            ReadFile("../../data/program/S2.txt", S2,1);
            ReadFile("../../data/program/S3.txt", S3,1);
            ReadFile("../../data/program/S4.txt", S4,1);
            ReadFile("../../data/program/S5.txt", S5,1);
            ReadFile("../../data/program/S6.txt", S6,1);
            ReadFile("../../data/program/S7.txt", S7,1);
            ReadFile("../../data/program/S8.txt", S8,1);
            ReadFile("../../data/program/P.txt", P,1);
            ReadFile("../../data/program/IP2.txt", IP2,1);
            ReadFile("../../data/program/PC1.txt", PC1,1);
            ReadFile("../../data/program/LeftShifts.txt", leftShift,1);
            ReadFile("../../data/program/PC2.txt", PC2,1);
            ReadFile("../../data/user/Input.txt", Input,0);
            ReadFile("../../data/user/Key.txt", Key,0);
            ReadFile("../../data/user/Key.txt", KeyBD,0);


            #endregion

            #region Key fusion PC1

            Key = fusion(Key, PC1);                                     //key từ 64 thành 56 bit
            Console.WriteLine("\n\nKey sau khi qua pc1: ");
            xuat(Key);

            #endregion

            #region Qua IP
            temp = fusion(Input, IP);                           //Input sẽ hoán đổi thứ tự
            Console.WriteLine("\n\nInput qua bảng ip: ");
            xuat(Input);
            #endregion

            #region Chia L,R
            for (int i = 0; i < temp.Count; i++)            //tách input thành L và R
            {
                if (i <= 31)
                {
                    L.Add(temp[i]);
                }
                else
                    R.Add(temp[i]);
            }
            Console.WriteLine("\n\nL0: ");
            xuat(L);
            Console.WriteLine("\n\nR0: ");
            xuat(R);
            #endregion

            #region vong lap

            for (int vonglap = 0; vonglap < 16; vonglap++)
            {
                L2.Clear();
                R2.Clear();

                #region tinh L2
                copyList(R, L2);            //L vòng sau bằng R vòng trước
                #endregion

                #region tinh R2 = ( ( ( ( R fusion E)  + key) fusion s1s2s3,...) fusion P)

                    #region R+ key                              

                    #region vòng đàu tiên tính riêng c0 d0
                
                    if (vonglap == 0)
                    {
                        for (int i = 0; i < Key.Count; i++)
                        {
                            if (i <= 27)
                            {
                                C.Add(Key[i]);
                            }
                            else
                                D.Add(Key[i]);
                        }
                        Console.WriteLine("\n\nC0: ");
                        xuat(C); 
                        Console.WriteLine("\n\nD0: ");
                        xuat(D);

                    }
                    #endregion


                    #region tính key

                    Console.WriteLine("\n\nC{0} trước khi dịch trái: ", vonglap + 1);
                    xuat(C);
                    Console.WriteLine("\n\nD{0} trước khi dịch trái: ", vonglap + 1);
                    xuat(D);
                    tinhKhoaK(Key, leftShift[vonglap], C, D);             // tra thứ tự vòng lặp trong bảng leftshift để ra số bit cần dịch trái
                    Console.WriteLine("\n\nC{0} sau khi dịch trái (dịch {1} bit): ", vonglap + 1,leftShift[vonglap]);
                    xuat(C);
                    Console.WriteLine("\n\nD{0} sau khi dịch trái (dịch {1} bit): ", vonglap + 1,leftShift[vonglap]);
                    xuat(D);

                    Console.WriteLine("\n\nKey{0} trước khi qua pc2: ", vonglap + 1);
                    xuat(Key);
                    Key = fusion(Key, PC2);

                    Console.WriteLine("\n\nKey{0}: ", vonglap + 1);
                    xuat(Key);
                    
                    #endregion

                    R = fusion(R, E);
                    Console.WriteLine("\n\nR0 sau khi qua E: ", vonglap + 1);
                    xuat(R);
                    


                    temp.Clear();
                    temp = xor(R, Key);
                    Console.WriteLine("\n\nR+key: ");
                    xuat(temp);
                    

                    #endregion

                        #region xu ly 8 block và tra bảng
                        temp2.Clear();
                        temp3.Clear();
                        for (int i = 0; i <= temp.Count; i++)
                        {
                            if (temp2.Count < 6)
                                temp2.Add(temp[i]);
                            else
                            {
                                int gr1 = (int)(temp2[5] * Math.Pow(2, 0) + temp2[0] * Math.Pow(2, 1));

                                int gr2 = (int)(temp2[1] * Math.Pow(2, 3) + temp2[2] * Math.Pow(2, 2) + temp2[3] * Math.Pow(2, 1) + temp2[4] * Math.Pow(2, 0));

                                #region tra bang

                                switch ((i + 1) / 6)
                                {
                                    case 1:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S1[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S1[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S1[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S1[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 2:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S2[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S2[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S2[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S2[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 3:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S3[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S3[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S3[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S3[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 4:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S4[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S4[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S4[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S4[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 5:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S5[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S5[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S5[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S5[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 6:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S6[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S6[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S6[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S6[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 7:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S7[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S7[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S7[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S7[gr2 + 48]);
                                        }
                                        i--;
                                        break;
                                    case 8:
                                        if (gr1 == 0)
                                        {
                                            temp3.Add(S8[gr2]);
                                        }
                                        if (gr1 == 1)
                                        {
                                            temp3.Add(S8[gr2 + 16]);
                                        }
                                        if (gr1 == 2)
                                        {
                                            temp3.Add(S8[gr2 + 32]);
                                        }
                                        if (gr1 == 3)
                                        {
                                            temp3.Add(S8[gr2 + 48]);
                                        }
                                        break;
                                    default: break;
                                }
                                #endregion

                                temp2.Clear();
                            }

                        }

                        Console.WriteLine("\n\ndãy số sau khi tra bảng: ");
                        xuat(temp3);

                        #region chuyển gt sau khi tra bảng thành nhị phân

                        ChuyenDoiNhiPhan(temp3);
                        Console.WriteLine("\n\ntemp3 nhị phân: ");
                        xuat(temp3);

                        #endregion
                    #endregion

                #region qua P
                temp3=fusion(temp3, P);
                Console.WriteLine("\n\ntemp3 qua P: ");
                xuat(temp3);
                #endregion

                #region xor L => R2
                R2 = xor(L, temp3);             ////////R2 bị sai?
                Console.WriteLine("\n\n L vòng trên: ");
                xuat(L);
                
                Console.WriteLine("\n\nR{0}: ", vonglap + 1);
                xuat(R2);
                Console.WriteLine("\n\nL{0}: ", vonglap + 1);
                xuat(L2);
                #endregion
                #endregion

               
                copyList(R2, R);
                copyList(L2, L);


                Console.WriteLine("\n=============================================================================================");
            }

            #endregion

            #region đưa kết quả qua ip -1

            Output = gopRL16(L, R, Output);


            Console.Write("\n\nBản rõ đưa vào: ");
            xuat(Input);
            Console.Write("\n\nKey ban đầu để mã hoá: ");
            xuat(KeyBD);
            Console.Write("\n\nkết quả cuối cùng: ");
            xuat(Output);

            #endregion


            Console.ReadKey();


        }

    }
}
