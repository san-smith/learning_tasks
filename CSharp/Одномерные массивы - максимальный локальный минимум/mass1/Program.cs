using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int[] min = new int[n];
            int i, k = 0, max; 
            Console.WriteLine("Исходный массив");
            for (i = 0; i < n; i++)
            {
                Console.Write("A[{0}]= ", i + 1);
                mass[i] = int.Parse(Console.ReadLine());
            }

            for (i = 1; i < n - 1; i++)
            {
                if ((mass[i] < mass[i - 1]) && (mass[i] < mass[i + 1]))
                {
                    min[k] = mass[i];
                    k++;
                }
            }
            max = min[0];
            for (i = 0; i < k; i++)
            {
                if (max < min[i]) max = min[i];
            }

            Console.WriteLine("Максимальный среди локальных минимумов: " + max);
            Console.ReadKey();
        }
    }
}
