using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Array
    {
        public static void arrayCode() {

            int[] array1 = new int[] { 1,2,3,4,5,6};
            string[] askim = new string[] {"aşkım", "seni", "çok", "seviyorum" };

            for (int i = 0; i < array1.Length; i++) {
                if (i != 2)
                    Console.WriteLine(askim[i]);
                else
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.WriteLine(askim[2]);
                    }
                }
            } 
        }

        public static void arrayCode2() {
            Console.Write("n değerini giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sayilar = diziOlsutur(limit);
            double ort = aritmetikOrt(sayilar, limit);
            int[] ciftDizi = ciftDiziOlustur(sayilar, limit);
            int[] tekDizi = tekDiziOlustur(sayilar, limit);
            Console.WriteLine("\n");
            Console.WriteLine("Dizinin en büyük elemanı = {0}", enBuyuk(sayilar));
            Console.WriteLine("Dizinin en küçük elemanı = {0}", enKucuk(sayilar));
            Console.WriteLine("Dizinin aritmetik ortalaması = {0:F2}", ort);
            Console.WriteLine("Dizinin standart sapması = {0:F2}", standartSapma(sayilar, ort));
            Console.WriteLine("Dizinin çift eleman sayisi = {0}", diziSay(ciftDizi));
            Console.Write("Dizinin çift elemanları = "); diziYaz(ciftDizi);
            Console.WriteLine("Dizinin tek eleman sayısı = {0}", diziSay(tekDizi));
            Console.Write("Dizinin tek elemanları = "); diziYaz(tekDizi);  
        }


        /// <summary>
        /// Verilen limit değer ile dizi oluşturur.
        /// </summary>
        /// <param name="limit">limit değer</param>
        /// <returns>dizi değeridir</returns>
        public static int[]  diziOlsutur(int limit) {
            Random rnd = new Random();
            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.Write("{0,4}", sayilar[i]);
            }
            return sayilar;
        }
        /// <summary>
        /// Verilen dizinin en büyük elemanını bulur.
        /// </summary>
        /// <param name="dizi">Verilen dizidir</param>
        /// <returns>En büyük değerdir</returns>
        public static int enBuyuk(int[] dizi) {
            int eb = dizi[0];
            for (int i = 1; i < dizi.Length; i++) {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
        }
        /// <summary>
        /// Verilen dizinin en küçük elemanını bulur.
        /// </summary>
        /// <param name="dizi">Verilen dizidir</param>
        /// <returns>En küçük değerdir</returns>
        public static int enKucuk(int[] dizi) { 
            int ek = dizi[0];
            for(int i = 1;i < dizi.Length; i++){
                if (dizi[i] < ek)
                    ek = dizi[i];
            }
            return ek;
        }
        /// <summary>
        /// Verilen dizinin aritmetik ortalamasını hesaplar.
        /// </summary>
        /// <param name="dizi">Verilen dizidir</param>
        /// <param name="limit">Dizi eleman sayısıdır</param>
        /// <returns>Aritmetik ortalama değeridir</returns>
        public static double aritmetikOrt(int[] dizi, int limit) {
            double toplam = 0;
            for (int i = 0; i < limit; i++) {
                toplam += dizi[i];
            }
            return toplam / limit;
        }
        /// <summary>
        /// Verilen dizinin standart sapmasını hesaplar
        /// </summary>
        /// <param name="dizi">Verilen dizi</param>
        /// <param name="ort">Aritmetik ortalama değeri</param>
        /// <returns>Standart sapma değeridir</returns>
        public static double standartSapma(int[] dizi, double ort) {
            double t = 0 , f = 0;
            double std = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                f = dizi[i] - ort;
                t += Math.Pow(f, 2);
            }
            std = t / (dizi.Length - 1);
            std = Math.Sqrt(std);
            return std;
        }

        public static int[] ciftDiziOlustur(int[] dizi, int limit) 
        {
            int[] cift = new int[limit];
            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0){
                    cift[sayac] = dizi[i];
                    sayac++;
                }
            }
            return cift;
        }

        public static int[] tekDiziOlustur(int[] dizi, int limit)
        {
            int[] tek = new int[limit];
            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 != 0)
                {
                    tek[sayac] = dizi[i];
                    sayac++;
                }
            }
            return tek;
        }

        public static int diziSay(int[] verilenDizi)
        {
            int eleman = 0;
            for (int i = 0; i < verilenDizi.Length; i++)
            {
                if (verilenDizi[i] != 0)
                    eleman++;
                     
            }
            return eleman;
        }

        public static string diziYaz(int[] verilenDizi) 
        {
            for (int i = 0; i < verilenDizi.Length; i++)
            {
                if (verilenDizi[i] != 0)
                    Console.Write("{0,4}", verilenDizi[i]);
            }
            Console.WriteLine();
            return " ";
        }
    }
}
