using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Maths
    {
        public static void mathsCode() {
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0}^{1} = {2}", s1, s2, usAlma(s1, s2));
        }

        public static void mathsCode2() {
            Console.Write("Asal çarpanlarını bulmak istediğin sayıyı gir: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] asalCarpanlar = asalCarpan(a);
            Console.Write("Asal çarpanlar: ");
            for (int i = 0; i < asalCarpanlar.Length; i++)
            {
                Console.Write(asalCarpanlar[i]);
                Console.Write(",");
            }
            Console.WriteLine();
            Console.WriteLine("Asal çarpanlar toplamı: {0}", asalCarpanToplamı(asalCarpanlar));
            Console.WriteLine("Asal çarpanlar çarpımı: {0}", asalCarpanCarpımları(asalCarpanlar));
            

        }

        public static void mathsCode3() {
            Console.Write("EKOK ve EBOB hesaplamak için ilk sayı: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("EKOK ve EBOB hesaplamak için ikinci sayı: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EKOK: {0}", ekok(first, second));
            Console.WriteLine("EBOB: {0}", ebob(first, second));

        }

        public static void mathsCode4() {
            Console.Write("Faktöriyel hesaplamak istediğiniz sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! : {1}", a, faktoriyel(a));
            Console.Write("Faktöriyel ortalaması hesaplamak için ilk sayı: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayı: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç = {0:F2}", faktoriyelOrt(x,y));
        }

        public static double usAlma(double taban, double kuvvet) {
            double s = 1;
            for (int i = 0; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

        public static int[] asalCarpan(int n) {
            string carpanListesi = "";
            int i = 2;
            while (n>1) {

                if (n%i==0) { 
                n = n/i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }

            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(',');

            string s = carpanlar[0];
            string y = s;

            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i])) {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
            {
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            }
            return asalCarpanlar;
        }

        public static int asalCarpanToplamı(int[] asal) {
            int t = 0;
            for (int i = 0; i < asal.Length; i++) { 
            t += asal[i];
            }
            return t;
        }

        public static int asalCarpanCarpımları(int[] asal)
        {
            int t = 1;
            for (int i = 0; i < asal.Length; i++)
            {
                t = t * asal[i];
            }
            return t;
        }

        public static int ekok(int first, int second) {
            int s = 1;
            while (first != 1 || second != 1) {
                int bol = 2;
                for (int i = 1; i <= (first>second ? first : second); i++) {
                    if (first % bol == 0 || second % bol == 0)
                    {
                        s *= bol;
                        if (first % bol == 0)
                            first /= bol;
                        if (second % bol == 0)
                            second /= bol;
                    }
                    else
                        bol++;
                }
            }
            return s;
        }

        public static int ebob(int first, int second)
        {
            while (second != 0)
            {
                int temp = second;
                second = first % second;
                first = temp;
            }
            return first;
        }

        public static int faktoriyel(int a) {
            int s = 1;
            while (a != 1) {
                s *= a;
                a -= 1;
            }
            return s;
        }

        public static double faktoriyelOrt(int a, int b) {
            int s = 0;
            int f = 0;
            for (int i = (a>b ? a : b); i >= (a<b ? a:b); i--) {
                s += faktoriyel(i);
                Console.WriteLine("{0}! : {1}", i, faktoriyel(i));
            }
            f = a - b;
            if (f < 0)
                f *= -1;
            f++;
            return (double)s / f;
        }
    }
}
