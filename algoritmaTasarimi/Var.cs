using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    class Var
    {
        public static void varCode() {
            var x = 23; // Implicitly typed. örtülü tip

            string[] meyveler = { "elma", "armut", "muz", "üzüm", "şeftali" };
            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;   

            foreach(string m in meyve)
                Console.Write(m);

        }
    }
}
