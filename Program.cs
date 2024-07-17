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
            ArrayList arrayList = new ArrayList()
            {55, 87,4, false, "Veli"};


            arrayList.Add("Ahmet");
            arrayList.Add(250);
            arrayList.Add(true);
            arrayList.Add(85.4);
            arrayList.Add('s');

            int[] arr1 = new int[] { 22, 33, 44 };
            arrayList.AddRange(arr1);

            foreach(var i in arrayList)
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine(arrayList[6]);

            //Changing an element
            var x = (int)arrayList[6];
            Console.WriteLine(x+10);

            //Deleting an element
            arrayList.RemoveAt(6);
            arrayList.Remove("Veli");
            arrayList.RemoveRange(0, 1);

            foreach (var i in arrayList)
                Console.Write($"{i} ");

            Console.ReadKey();
        }
    }
}