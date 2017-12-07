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
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Method q = new Method();
            Console.WriteLine(q.SubStrDel(str));
            Console.Read();
        }

    }
    class Method
    {
        public string SubStrDel(String stroka)
        {
            Console.Write("Введите подстроку: ");
            string sub = Console.ReadLine();
            return stroka.Replace(sub, "");
        }
    }
}