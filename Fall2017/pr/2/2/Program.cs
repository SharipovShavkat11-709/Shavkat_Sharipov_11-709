using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 7, 15, 22, 10, 9 };
            var max = arr[0];
            var i = 0;

            for (i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }                    
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }        
    }
}

