/*заменить все положительные элементы целочисленного 
 * массива размера на значение минимального.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int temp = rand.Next(1000);
            int[] array = new int[temp];

            int min = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);

                if (i == 0)
                {
                    min = array[i];
                }
                else
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = min;
                }
                Console.Write(array[i] + "  ");
            }

            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
