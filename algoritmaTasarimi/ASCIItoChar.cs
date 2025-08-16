using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class ASCIItoChar
    {
        public static void ASCIItoCharCode() {
            for (int i =33; i <= 300; i++)
            {
                Console.Write("{0,4}",(char)i);
                if (i % 5 == 0)
                    Console.WriteLine();
            }
        }
    }
}
