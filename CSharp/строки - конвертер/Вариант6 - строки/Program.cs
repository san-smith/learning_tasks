/*Дана строка, изображающая двоичную|десятичную запись 
 * целого числа. Вывести строку, 
 * изображающую десятичную|двоичную запись этого же числа. */

using System;
using System.Collections.Generic;
using System.Text;

namespace Вариант6___строки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Из двоичной в двоичную");
            Console.WriteLine("2 - Из десятичной в двоичную");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.Clear();
                    string str1 = Console.ReadLine();
                    Int64 y = Convert.ToInt64(str1, 2);
                    Console.WriteLine(Convert.ToString(y, 10));
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    string str2 = Console.ReadLine();
                    Int64 x = Convert.ToInt64(str2, 10);

                    Console.WriteLine(Convert.ToString(x, 2));
                    Console.ReadLine();
                    break;
            }

        }
    }
}