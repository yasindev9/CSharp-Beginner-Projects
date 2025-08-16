using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class String
    {
        public static void stringCode()
        {
            string string1 = "This is a string created by assigment.";
            Console.WriteLine(string1);
            string string2a = "The path is C:\\PublicDocuments\\Report1.doc";
            Console.WriteLine(string2a);
            string string2b = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine(string2b);
            char[] chars = { 'w', 'o', 'r', 'd' };
            sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            string stringChar = new string(chars);
            string stringR = new string('c', 20);
            Console.WriteLine(stringChar);
            Console.WriteLine(stringR);

            string stringFromBytes = null;
            string stringFromChars = null;
            unsafe
            {
                fixed (sbyte* pbytes = bytes) {
                    stringFromBytes = new string(pbytes);
                }
                fixed (char* pchars = chars) { 
                stringFromChars = new string(pchars);
                }
            }
            Console.WriteLine(stringFromBytes);
            Console.WriteLine(stringFromChars);

            //stringler + ile bağlanabilir.
            //IndexOf ile ayıklama yapılabilir.
        }

        /// <summary>
        /// Girilen ifadeyi sayısal olarak ayırıp int türünde bir diziye atar.
        /// </summary>
        public static void stringCode2() { 
            string ifade = Console.ReadLine();

            string[] bolunmusIfade = ifade.Split(',');

            int n = bolunmusIfade.Length;

            int[] sayisaylDizi = new int[n];

            for (int i = 0; i < n; i++) {
                sayisaylDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, sayisaylDizi[i]);
            }
        }

        public static void stringCode3() {
            Console.Write("Sesli harf sayısıı belirlemek istediğiniz kelime: ");
            string ifade = Console.ReadLine();
            int seskiHarf = 0;
            for (int i = 0;i < ifade.Length ; i++) {
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü') {
                    seskiHarf++;}
            }
            Console.WriteLine("{0} ifadesinde {1} sesli harf var.",ifade,seskiHarf);
        }
    }
}
