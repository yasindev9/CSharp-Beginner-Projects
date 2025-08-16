using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Boxing
    {
        public static void boxingCode() {
            // kutulama - boxing 
            int i = 23;
            object obj = i; // = (object)i olarak da yapılabilir (cast) explicit boxing - açıktan kutulama


            // kutudan çıkarma - unboxing
            i *= 2;
            Console.WriteLine("Unboxing oncesi deger: {0}", i);
            i = (int)obj; // cast
            Console.WriteLine("Deger turu: {0}", i);
            Console.WriteLine("Referans turu: {0}", obj);
        }
    }
}
