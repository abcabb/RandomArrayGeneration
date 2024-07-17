using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace btkakademicalisma
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("{0}, {1}", x, y);

            degistir(x, y);

            Console.WriteLine("{0}, {1}", x, y);

            //Yukarıda x ve y nin değerlerinin sadece alt fonksiyonun içinde değiştiğini fark ettik, main metodundaki değişkenlerin değil. Bunu şöyle yaparız : 

            Console.WriteLine("---------------------------------");

            refDegistir(ref x, ref y); // Ref x, değişkenlerin adreslerine göre işlem yapılacağını belirtir.

            Console.WriteLine("{0}, {1}", x, y);

            Console.ReadKey();
        }

        private static void degistir(int x, int y)
        {
            int gecici;
            gecici = x;
            x = y;
            y = gecici;

            Console.WriteLine("{0}, {1}", x, y);
        }

        private static void refDegistir(ref int x, ref int y)
        {
            int gecici;
            gecici = x;
            x = y;
            y = gecici;

            Console.WriteLine("{0}, {1}", x, y);
        }
    }
}