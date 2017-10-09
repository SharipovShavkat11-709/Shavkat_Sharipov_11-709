using System;

namespace _4 /*Найти сумму всех простых делителей заданного натурального числа(<10000)*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i < 10000; i++)
            {
                if (((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0)) || ((i == 2) || (i == 3) || (i == 5)))
                    if (n%i==0)
                        sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
