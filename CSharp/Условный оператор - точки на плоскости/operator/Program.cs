using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Даны целочисленные координаты точки на плоскости. Если точка не лежит на координатных осях, то вывести 0. Если точка совпадает с началом координат, то вывести 1. Если точка не совпадает с началом координат, но лежит на оси OX или OY, то вывести соответственно 2 или 3.");
            Console.WriteLine("Введите значение x");
            int x = int.Parse( Console.ReadLine());
            Console.WriteLine("Введите значение y");
            int y = int.Parse(Console.ReadLine());
            if (x != 0 && y != 0)
            {
                Console.WriteLine("Ответ: 0");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Ответ: 1");
            }
            else if (x != 0 && y == 0) 
            {
                Console.WriteLine("Ответ: 2");
            }
            else 
            {
                Console.WriteLine("Ответ: 3");
            }
            Console.ReadLine();
        }
    }
}
