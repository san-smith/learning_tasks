using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Даны два ненулевых числа. Найти их сумму, разность, произведение и частное.
 */

namespace arithmetic_actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0} + {1} = {2}", a, b, a + b));
            Console.WriteLine(String.Format("{0} - {1} = {2}", a, b, a - b));
            Console.WriteLine(String.Format("{0} * {1} = {2}", a, b, a * b));
            Console.WriteLine(String.Format("{0} / {1} = {2}", a, b, a / b));
        }
    }
}
