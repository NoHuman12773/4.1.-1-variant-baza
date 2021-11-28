using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] mas = new int [14];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1000);
                Console.Write(mas[i] + " ");
                if (mas[i] % 2 == 0) count++;
            }
            Console.WriteLine();
            Console.WriteLine("количество чётных элементов в данном массиве={0}", count);

            Console.ReadKey();
        }
    }
}
