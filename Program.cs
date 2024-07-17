using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkakademicalisma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array :");
            int arr_size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------\n" + "Array :");
            int[] arr = new int[arr_size];

            var ran = new Random();

            for (int i = 0; i < arr_size; i++)
                arr[i] = ran.Next(1,10);

            for(int i = 0;i < arr_size; i++)   
                Console.Write(arr[i] +  " ");

            Console.ReadKey();
        }
    }
}
