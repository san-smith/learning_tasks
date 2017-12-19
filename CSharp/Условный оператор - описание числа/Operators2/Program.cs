using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators2
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                var num = String.Empty;
                if (number.ToString().Length > 4) Console.WriteLine("Число должно быть в диапазоне от 1 до 9999");
                else
                {
                    if (number % 2 == 0) num += "Четное ";
                    else num += "Нечетное ";
                    if (number.ToString().Length == 1)
                    {
                        num += "однозначное число";
                    }
                    if (number.ToString().Length == 2)
                    {
                        num += "двузначное число";
                    }
                    if (number.ToString().Length == 3)
                    {
                        num += "трехзначное число";
                    }
                    else
                    {
                        num += "четырехзначное число";
                    }                    
                    Console.WriteLine(num);
                }
            }
        }
    }
}