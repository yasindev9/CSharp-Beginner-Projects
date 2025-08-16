using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    public class Sayi
    {
        /// <summary>
        /// parametre olarak aldığı sayının tek mi olduğunu kontrol eder. 
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise true aksi durumda false</returns>
        public static bool tekMi(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }

        /// <summary>
        /// parametre olarak aldığı sayının çift mi olduğunu kontrol eder.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Çift ise true aksi durumda false</returns>
        public static bool ciftMi(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        /// <summary>
        /// parametre olarak aldığı değerin mutlak değerini verir.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Girilen sayının mutlak değeri dönüş ifadesidir.</returns>
        public static int mutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else
                return 0;
        }

        /// <summary>
        /// Girilen sayının asal olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Asal ise true değil ise false</returns>
        public static bool asalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayı 2'dir.");
            }

            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }

        /// <summary>
        /// Girilen sayının rakamları toplamını hesaplar.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Rakamları toplamıdır</returns>
        public static int rakamlarToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }

        public static int nEKadarOlanSayilarToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t += i;
            }
            return t;
        }

        public static int nEkadarOlanSayilarFormulleToplami(int n)
        {

            return n * (n + 1) / 2;
        }

        public static int nEKadarOlanTekSayilarFormulleToplam(int n)
        {
            n = n + 1;
            n = n / 2;
            return n * n;
        }

        public static int nEkadarOlanCiftSayilarFormulleToplami(int n)
        {
            n = n / 2;
            return n * (n + 1);
        }
        public static void sayiCode()
        {
            Console.WriteLine("Sayi gir: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Sayi.tekMi(n))
                Console.WriteLine("Girilen sayı tek. {0}", n);

            if (Sayi.ciftMi(n))
                Console.WriteLine("Girilen sayı çift {0}", n);

            Console.WriteLine("{0} = girilen sayının mutlak değeri.", Sayi.mutlakDeger(n));

            Console.WriteLine("{0} sayısı asal mı? : {1}", n, Sayi.asalMi(n));
            //Sayi.asalMi(n) ? "Asal sayı." : "Asal sayı değil."

            Console.WriteLine("{0} sayısının rakamları toplamı : {1}", n, Sayi.rakamlarToplami(n));

            Console.WriteLine("1'den {0}'e kadar olan sayıların toplamı: {1}", n, nEkadarOlanSayilarFormulleToplami(n));

            Console.WriteLine("1'den {0}'e kadar olan tek sayıların toplamı: {1}", n, nEKadarOlanTekSayilarFormulleToplam(n));

            Console.WriteLine("1'den {0}'e kadar olan çift sayıların toplamı: {1}", n, nEkadarOlanCiftSayilarFormulleToplami(n));


        }

        public static void sayiCode2() { 
            string ikilikSayi = Console.ReadLine();
            int n = ikilikSayi.Length;
            int[] basamaklar = new int[n];
            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++) {
                if (!(ikilikSayi[i] == '0' || ikilikSayi[i] == '1')) {
                    Console.WriteLine("\aHatalı giriş"); // \a ses için
                    kontrol = false;
                    break;
                }

                basamaklar[i] = (ikilikSayi[i] - '0');
            }

            //2'lik sistemden 10'luk sisteme geçiş
            if (kontrol) {
                for (int i = 0; i < n; i++) {
                    sayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                }
                Console.WriteLine("({0}) ikilik sayi = {1}", ikilikSayi,sayi);
            }
        }
    }

}
