using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((Math.Pow(x, 2)) - Math.Pow(y, 2) >= 0) 
            Console.WriteLine("yes"); 
            else Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
