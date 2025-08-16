using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class ifelse
    {
        public static void ifelseCode() {
            Console.WriteLine("Bir harf giriniz: ");
            char ch = (char)Console.Read();

            if (char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter büyük.");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter küçük.");
            }
            else if (char.IsDigit(ch)) {
                Console.WriteLine("Girilen karakter sayı");
            }
            else
            {
                Console.WriteLine("Karakter alfanumerik bir karakter değildir.");
            }
        }

        public static void ifelseCode2() {
            int m = 9;
            int n = 7;
            int p = 5;

            if (m >= n && m >= p) {
                Console.WriteLine("En büyük m.");
            }

            if (m>n && !(p>m)) {
                Console.WriteLine("En büyük m.");
            }

            if (m>n || m>p) { 
            Console.WriteLine("m en küçük değil. ");
            }

            m = 4;

            if (!(m>=n || m>=p)) { 
            Console.WriteLine("m artrık en küçük.");
            }
        }
    }
}
