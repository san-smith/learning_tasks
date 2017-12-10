using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<int> Series(IEnumerable<int> en)
    {
        int counter = 0;
        int previous = 0;
        foreach (int x in en)
        {
            if (counter != 0 && x != previous)
            {
                yield return counter;
                counter = 0;
            }
            ++counter;
            previous = x;
        }
        yield return counter;
    }

    public static void Main()
    {
        Console.WriteLine(String.Join(", ", Series(new int[] { 1, 2, 2, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 9, 9, 9, 11 })));
    }
}
