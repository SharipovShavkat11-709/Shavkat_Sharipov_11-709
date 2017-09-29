using System;


namespace _2_я_задача_25._09
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 17,10,45 };
            var Max = arr[0];
            var i = 0;
            
            for (i = 0; i < arr.Length; i++) 

            {
                if (Max < arr[i])

                {
                    Max = arr[i];
                    
                    
                }
            }
            Console.WriteLine(Max);

        }
    }
}
