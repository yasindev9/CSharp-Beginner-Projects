using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class For
    {
        public static void forCode(){

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} -> {1}", i , i*i);
            }
        }

        public static void forCode2() {

            Console.Write("Limit değer giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int tekToplam = 0, ciftToplam = 0;
            Console.WriteLine("tek sayılar");
            for (int i = 1; i < limit; i+=2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i;
            }
            Console.WriteLine($"\n\ntek sayılar toplamı = {tekToplam}");

            Console.WriteLine("çift sayılar");
            for (int i = 0; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i;
            }
            Console.WriteLine($"\n\nçift sayılar toplamı = {ciftToplam}");
        }

        public static void forCode3() {
            int sayiAdet= 0;
            for (int i = 1000; i >= 0; i-=5) {
                Console.WriteLine("5'in katları -> {0}", i);
                sayiAdet += 1;
            }
            Console.WriteLine("Adet -> {0}", sayiAdet);
        }

        public static void forCode4() {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i , j , i*j);
                }
                Console.WriteLine("\n\n----------------------------------------\n\n");
            }
        }
    }
}
