using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число:");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень, в которую хотите возвести число:");
            int k = Convert.ToInt32(Console.ReadLine());

            double b = Math.Pow(n, k);
            Console.WriteLine("Ответ:"+ b);
            Console.ReadKey();
        }
    }
}
