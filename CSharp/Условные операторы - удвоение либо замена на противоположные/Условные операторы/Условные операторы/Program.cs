using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] inp = new float[3];
            // Loop three times, asking for a different number each time.
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Input number " + (i + 1) + ": ");
                // Make sure to parse since Console.ReadLine is String
                inp[i] = float.Parse(Console.ReadLine());
            }
            if (inp[0] > inp[1])
                if (inp[1] > inp[2])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        inp[i] = 2 * inp[i];
                        Console.WriteLine(inp[i].ToString());
                    }
                }
            if (inp[0] < inp[1])
                if (inp[1] < inp[2])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        inp[i] = 2 * inp[i];
                        Console.WriteLine(inp[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        inp[i] = -inp[i];
                        Console.WriteLine(inp[i].ToString());

                    }
                }
        }
    }
}