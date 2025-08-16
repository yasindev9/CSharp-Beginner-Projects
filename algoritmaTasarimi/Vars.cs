using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Vars
    {
        public static void varsCode() {
            int min16, maks16;
            min16 = System.Int16.MinValue;
            maks16 = System.Int16.MaxValue;
            int min32 = System.Int32.MinValue;
            int maks32 = System.Int32.MaxValue;
            byte minByte = System.Byte.MinValue;
            byte maksByte = System.Byte.MaxValue;
            //int sayi = 23;
            //sayi = sayi * 2;
            //Console.WriteLine(sayi);
            Console.WriteLine("Int16 -> Min = {0} \t Maks = {1}", min16, maks16);
            Console.WriteLine("Int32 -> Min32 = {0} \t Maks32 = {1}", min32, maks32);
            Console.WriteLine("Byte -> MinByte = {0} \t MaksByte = {1}", minByte, maksByte);
        }
    }
}
