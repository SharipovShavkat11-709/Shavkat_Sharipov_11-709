using System;

namespace _6 /*Считывая числа пока не встретится 0, найти максимальное число и сколько раз оно встречается в последовательности*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            int Max = Convert.ToInt32(Console.ReadLine()), numberOfMax = 1;
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    break;
                if (number > Max)
                {
                    Max = number;
                    numberOfMax = 1;
                }
                else if (number == Max)
                {
                    numberOfMax++;
                }
            }
            Console.WriteLine("Максимальное число " + Max + " встречается " + numberOfMax + " раз ");
            Console.ReadKey();
        }
    }
}
