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
            var Sehirler = new List<string>()
            {
                "Istanbul",
                "Ankara",
                "Samsun",
                "Sakarya",
                "Çanakkale"
            };
            // Yeni ForEach gösterim formatı :
            Sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-', 50)); // Uzuun uzun uğraşmana gerek yok!

            var Iller = Sehirler;
            Iller.ForEach(i  => Console.WriteLine(i));

            Console.WriteLine();
            Sehirler.Add("Mugla");
            Sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            Iller.ForEach(i => Console.WriteLine(i)); // Illerde de muğla eklenmiş. Bunun sebebi listelerin Referans Tipli çalışmasıdır.

            Console.WriteLine();
            Iller.Remove("Ankara");
            Iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            Sehirler.ForEach(s => Console.WriteLine(s)); // Ankara Sehirlerde de silinmiş. Bunun sebebi listelerin Referans Tipli çalışmasıdır.

            Console.ReadKey();
        }
    }
}