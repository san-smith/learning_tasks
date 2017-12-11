using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите строку:");
            string s2 = Console.ReadLine();
            int indexFirst = s1.IndexOf(s2);
            s1 = s1.Remove(indexFirst, s2.Length);
            Console.WriteLine(s1);
        }

    }
}