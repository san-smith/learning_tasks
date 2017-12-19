/*Значения переменных X, Y, Z поменять местами так, 
 *чтобы они оказались упорядоченными по убыванию. */
using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Введите Х");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Z");
            z = Convert.ToInt32(Console.ReadLine());
            int vrem;
            if ((x > y) && (y < z) && (x > z))
            {
                vrem = y;
                y = z;
                z = vrem;
            }
            else if ((x > y) && (y < z) && (x < z))
            {
                vrem = y;
                y = z;
                z = vrem;

                vrem = y;
                y = x;
                x = vrem;
            }
            else if ((x < y) && (y > z) && (x > z))
            {
                vrem = y;
                y = x;
                x = vrem;
            }
            else if ((x < y) && (y > z) && (x < z))
            {
                vrem = y;
                y = x;
                x = vrem;

                vrem = y;
                y = z;
                z = vrem;
            }
            else if ((x < y) && (y < z))
            {
                vrem = z;
                z = x;
                x = vrem;
            }
            Console.WriteLine("x = " + x + "y = " + y + "z = " + z);
            Console.ReadLine();
        }
    }
}
