using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку S1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите строку S2");
            string s2 = Console.ReadLine();
            Console.WriteLine("Введите строку s3");
            string s3 = Console.ReadLine();

            int startIndex = s1.IndexOf(s2);
            if (startIndex != -1)
                Console.WriteLine(s1.Remove(startIndex, s2.Length).Insert(startIndex, s3));
            else
                Console.WriteLine(s1);

            Console.ReadKey();
       
        }
    }
}
