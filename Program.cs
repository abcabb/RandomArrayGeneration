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
            int[,] matris = new int[,] { { 12, 13, 14 }, { 15, 16, 17 } , {18, 19, 20} };

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                        matris[i, j] = -1;
                    Console.Write(matris[i, j]+" ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}