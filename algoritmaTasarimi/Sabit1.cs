using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmaTasarimi
{
    internal class Sabit1
    {
        public static void sabit1Code() {
            int a = 3;
            const int c = 23; //static ile const beraber kullanılamaz!
            Console.WriteLine(c);
            // c+=a yapılamaz! const sabittir.
            //c+5 gibi ifadeler yapılabilir. sabitler sabitlere katılabilir.
            // const int c; olarak da bırakılamaz. değer oluşturulduğu yerde verilemli.
            // sabit bir sayı oluşturmak ama değeri sonra vermek isteniyorsa readonly kullanılır;
        }

        //yapılandırıcı sınıf class ile aynı isme sahip olan bir metodtur. readonly ancak burda verilebilir.
        readonly int a;
        public Sabit1() {
            a = 3;
        }
    }
}
