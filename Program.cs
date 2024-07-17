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
            //Declaration
            var sayilar = new List<int>();

            int x = 55;

            int[] arr1 = new int[] { 100, 200, 300 };
            //Addition
            sayilar.Add(10); //You cannot add anything but integers. Because you specified that List is <int>. Lists do have variable datatype safety.
            sayilar.Add(50);
            sayilar.Add(x);
            sayilar.AddRange(new int[] { 20, 30, 40 });
            sayilar.AddRange(arr1);

            //araya ekleme
            sayilar.Insert(3, 150);
            sayilar.InsertRange(4, new int[] { 66, 77, 88 });

            //eleman silme
            sayilar.RemoveAt(3);
            sayilar.RemoveAt(sayilar.IndexOf(66));
            sayilar.Remove(77);

            foreach (int s in sayilar)
                Console.Write($"{s,-5}"); //-5 her bir elemanın çıktıda kendisinden sonrasına 5 boşluk bırakması s,5 yazsaydı hepsi kendinden önceki yere 5 boşluk bırakırdı.

            Console.ReadKey();
        }
    }
}