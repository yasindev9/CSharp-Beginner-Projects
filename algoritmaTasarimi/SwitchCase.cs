using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class SwitchCase
    {
        public enum Renkler { Kırmızı, Yeşil, Mavi }
        public static void switchCaseCode() {
            Renkler r = (Renkler)(new Random()).Next(0, 3);

            switch (r)
            {
                case Renkler.Kırmızı:
                    Console.WriteLine("renk kırmızı");
                    break;
                case Renkler.Yeşil:
                    Console.WriteLine("renk yeşil");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("renk mavi");
                    break;
                default:
                    Console.WriteLine("renk bilinmiyor");
                    break;
            }
        }

        public static void switchCaseCode2() {
            Random rnd = new Random();

            int caseSwitch = rnd.Next(1,4);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                case 3:
                    Console.WriteLine("Durum 3");
                    break;
                case 4:
                    Console.WriteLine("Durum 4");
                    break;
                default:
                    break;
            }

        }
    }
}
