using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Cember
    {
        public const double pi = 3.14;

        /// <summary>
        /// Dairenin çevresini hesaplar
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Çevre değeridir</returns>
        public static double cevresi(double r) { 
        return 2*pi*r;
        }

        /// <summary>
        /// Dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Alan değeridir</returns>
        public static double alan(double r) {
            return pi * r * r;
        }

        /// <summary>
        /// Dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <param name="aci">Gördüğü açı</param>
        /// <returns>Alan değeridir</returns>
        public static double alan(double r, double aci)
        {
            return pi * r * r * aci/360;
        }

        public static void cemberCode() {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 * {0:F2} * {1:F2} = {2:F2}", pi , r , cevresi(r));
            Console.WriteLine("{0:F2} * {1:F2} * {1:F2} = {2:F2}", pi , r , alan(r));
            Console.Write("Dilim açısı: ");
            double aci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dilim alanı = {0:F2}", alan(r, aci));
        }
    }
}
