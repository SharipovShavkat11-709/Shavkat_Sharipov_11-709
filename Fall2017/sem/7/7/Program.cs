using System;

namespace _7 /*Дана окружность(вещественные координаты центра и радиус) и n вещественных координат(пар x, y). Нужно вывести пару(возможно несколько) ближе всего находящихся к окружности, но не касающихся и не находящихся внутри неё*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кооординату x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите радиус r:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + r + 1);
            Console.WriteLine(y + r + 1);
            Console.WriteLine(x + r + 2);
            Console.WriteLine(y + r + 2);
            Console.ReadKey();
        }
    }
}