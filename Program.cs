using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class B
    {
        public void function()
        {
            Console.WriteLine("Fb");
        }
    }
    
    class Program
    {
        struct Day
        {
            public int day, month, year;
        }
        public static bool KiemTraNguyenTo(int m)
        {
            int souoc = 0;
            for (int i = 1; i <= m; i++)
                if (m % i == 0)
                    souoc++;
            if (souoc == 2)
                return true;
            else
                return false;
        }
        public static bool KiemTraSoChinhPhuong(int k)
        {
            int i = 1;
            while (i * i <= k)
            {
                if (i * i == k)
                    return true;
                i++;
            }
            return false;
        }
        public static int TinhTong(int[,] a, int i, int cot)
        {
            int tong = 0;
            for (int j = 0; j < cot; j++)
                tong += a[i,j];
            return tong;
        }
        public static void TimDongCoTongMax(int[,] a, int dong, int cot)
        {
            int[] b = new int[dong];
            for(int i=0;i<dong;i++)
            {
                b[i] = TinhTong(a,i, cot);
            }

            int Max = b[0];

            for(int i = 1; i < dong; i++)
            {
                if (b[i] > Max)
                    Max = b[i];
            }
            for(int i=0;i<dong;i++)
            {
                if (b[i] == Max)
                    Console.WriteLine("Dong co tong lon nhat la: " + i);
            }
        }
       
        
         public static bool KTNamNhuan(int i)
        {
            if (i % 4 == 0 && i % 100 != 0)
                return true;
            if (i % 400 == 0)
                return true;
            return false;
        }
         static int TimNgayTrongThang(Day a)
        {
            int ngay = 0;
            switch (a.month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    ngay = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    ngay = 30;
                    break;
                case 2:
                    if (KTNamNhuan(a.year) == true)
                        ngay = 29;
                    else
                        ngay = 28;
                    break;
            }
            return ngay;
            Console.WriteLine(ngay);
        }
        public static void XoaDong(int [,]a, ref int dong, int cot, int vitrixoa)
        {
            for (int i = vitrixoa; i < dong - 1; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }
            dong--;
        }

            static void Main(string[] args)
        {

            //bai 3, bai 4, bai 5
            Day a = new Day();
            Console.Write("Nhap nam: ");
            a.year = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap thang: ");
                a.month = int.Parse(Console.ReadLine());
                if (a.month < 1 || a.month > 12)
                    Console.WriteLine("Du lieu sai, xin nhap lai!");
            } while (a.month < 1 || a.month > 12);
            int ngay = TimNgayTrongThang(a);
            do
            {
                Console.Write("Nhap ngay: ");
                a.day = int.Parse(Console.ReadLine());
                if (a.day < 1 || a.day > ngay)
                    Console.WriteLine("Du lieu sai, xin nhap lai!");
            } while (a.day < 1 || a.day > ngay);
            Console.WriteLine(a.day + "/" + a.month + "/" + a.year);
            Console.WriteLine("So ngay trong thang do: " + ngay);
            a.year -= (14 - a.month) / 12;
            a.month += 12 * ((14 - a.month) / 12) - 2;

            int dayofweek = (a.day + a.year + a.year / 4 - a.year / 100 + a.year / 400 + (31 * a.month) / 12) % 7;

            if (dayofweek == 0)
                Console.WriteLine("Chu nhat");
            else
                Console.WriteLine("Thu " + (dayofweek + 1));
            ////bai 1
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int tong = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] % 2 != 0)
            //    {
            //        tong += a[i];
            //    }
            //}
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (KTNT(a[i]) == true)
            //        count++;
            //}
            //long min = 1000000;
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] < min && KTSCP(a[i]) == true)
            //    {
            //        min = a[i];
            //    }
            //}
            //Console.WriteLine(min);
            //Console.Write(count);
            //bai 2
            //int n = int.Parse(Console.ReadLine());
            //int kq = 0;
            //for (int i = 2; i < n; i++)
            //{
            //    if (KTNT(i) == true)
            //    {
            //        kq += i;
            //    }
            //}
            //Console.Write(kq);
            //bai6


            //int min = a[0, 0];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (a[i, j] < min)
            //            min = a[i, j];
            //    }
            //}
            //Console.WriteLine(min);
            //int kq = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (KTNT(a[i, j]) == false)
            //        {
            //            kq += a[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(kq);
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n,m];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
//                    Console.Write(a[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("Nhap dong can xoa: ");
//            int vitrixoa = int.Parse(Console.ReadLine());
            
           
//            XoaDong(a, ref n, m, vitrixoa);
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    Console.Write(a[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//            //TimDongCoTongMax(a, n, m);

       }
  }

}
