﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine( "Точка в 1 четверти");
                    Console.ReadLine(); 
                }
                else
                {
                  Console.WriteLine( "Точка в 4 четверти");
                  Console.ReadLine(); 
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Точка во 2 четверти");
                    Console.ReadLine(); 
                }
                else
                {
                   Console.WriteLine( "Точка в 3 четверти");
                   Console.ReadLine(); 
                }
               
            }
        }
    }
}