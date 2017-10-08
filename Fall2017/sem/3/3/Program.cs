using System;

namespace _3 /*По коэффициентам квадратного уравнения ax^2+bx+c=0 найти количество действительных корней уравнения и сами корни.Если корней бесконечно много, вывести -1.*/ 
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x;
            Console.Write("Ввести коэффицент a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввести коэффицент b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввеcти коэффицент c:");
            c = Convert.ToDouble(Console.ReadLine());
           
            double D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                x1 = (-b + (Math.Sqrt(D) / (2 * a)));
                Console.WriteLine(x1);
                x2 = (-b - (Math.Sqrt(D) / (2 * a)));
                Console.WriteLine(x2);
            }

            else if (D==0)
                x = -b / (2 * a);

            else if (D<0)
                Console.WriteLine("Уравнение не имеет корней");
        }
    }
}
