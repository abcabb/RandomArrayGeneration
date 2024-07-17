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
            double toplam = sayilariTopla(15.5, 26.8, 45.3, 75.6);
            Console.WriteLine("{0,5:0.##}",toplam); // {0,5:0.##}, toplam değişkenini göstermek için bir format biçimi.
            Console.ReadKey();
        }

        private static double sayilariTopla(params double[] arr)
        {
            double toplam=0.0;
            foreach (double i in arr)
                toplam = toplam+i;
            return toplam;
        }
    }
}