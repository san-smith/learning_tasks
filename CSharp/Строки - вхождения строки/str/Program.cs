using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
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
            if (startIndex >= 0)
            {
                char[] result = new char[s1.Length - s2.Length + s3.Length];
 
                int idx = 0;
                for (int i = 0; i < startIndex; result[idx++] = s1[i++]) ;
                for (int i = 0; i < s3.Length; result[idx++] = s3[i++]) ;
                for (int i = startIndex + s2.Length; i < s1.Length; result[idx++] = s1[i++]) ;
                s1 = new String(result);
            }
 
            Console.WriteLine(s1);
          
            Console.ReadLine();
       
        }
    }
}
