using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим N
            int N;
            do
            {

                Console.Write("Размер массива (N) = "); // N должна быть не менее двух
            }

            while ((N = Convert.ToInt32(Console.ReadLine())) < 2);
            // Заполняем массив случайными числами
            Random rnd = new Random();
            int i;
            int[] arr = new int[N];
            for (i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(100);
                // Сразу же выводим массив
                Console.Write(arr[i].ToString() + ' ');
            }
            Console.WriteLine();
            // Счетчик
            int cntr = 0;
            // Флаг состояния:
            // 1 - убывание
            // 2 - возрастание
            // 0 - отсутствие изменений

            int flag = 0;
            for (i = 1; i < N; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    if (flag != 1) cntr++;
                    flag = 1;
                }
                else if (arr[i] > arr[i - 1])
                {
                    if (flag != 2) cntr++;
                    flag = 2;
                }
                else if (flag != 0)
                {
                    cntr++;
                    flag = 0;
                }
            }
            // Выводим результат:
            Console.WriteLine("Количество участков монотонности: " + cntr.ToString());
            Console.ReadLine();
        }
    }
}
