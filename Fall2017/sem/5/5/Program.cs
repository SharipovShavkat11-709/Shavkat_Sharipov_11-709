using System;

namespace _5 /*Перевести число n(n<10^18) в шестнадцатеричную систему счисления(0123456789ABCDEF)*/

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string t = "";

            while (n>1)
            {
                if (n % 16 == 10)
                    t = "A" + t;

                else if (n % 16 == 11)
                    t = "B" + t;

                else if (n % 16 == 12)
                    t = "C" + t;

                else if (n % 16 == 13)
                    t = "D" + t;

                else if (n % 16 == 14)
                    t = "E" + t;

                else if (n % 16 == 15)
                    t = "F" + t;

                else
                {
                    int a = n % 16;
                    t = a.ToString() + t;
                }

                n = n / 16;
            }

            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
