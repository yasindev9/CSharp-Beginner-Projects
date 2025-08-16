using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Desen
    {
        public static void desenCode() {
            Console.Write("Desen oluşturucuyu başlatmak için bir karakter girin: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write("Sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            desen1(c,n);
            karakterSeti();
        }

        public static void desenCode2() {
            karakterSeti();
            karakterSeti(128,255);
            karakterSeti(128,255,10);
        }

        public static void desenCode3()
        {
            string ifade = " Yasin ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a','e'));
        }

        public static void desen1(char c = '!', int n = 1) {
            for (int i = 0; i < n; i++) { 
            Console.WriteLine("{0,20}", new string(c,i));
            }
        }

        public static void karakterSeti(int baslangicIndis = 65, int bitisIndis = 95, int satirKarakterSayi = 5) {

            for (int i = baslangicIndis; i <= bitisIndis; i++)
            {
                Console.Write("{0,4}",(char)i);
                if (i % satirKarakterSayi == 0)
                    Console.WriteLine();
            }
        }
    }
}
