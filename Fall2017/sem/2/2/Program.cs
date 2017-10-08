using System;

namespace _2 /*Возвести вещественное число n в целую степень k(используя алгоритм быстрого возведения в степень – бинарный/справа налево)*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите степень:");
            int k = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            while (k != 0)
                if (k % 2 == 1)
                {
                    result *= n;
                    --k;
                }
                else
                {
                    n *= n;
                    k = k / 2;
                }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
