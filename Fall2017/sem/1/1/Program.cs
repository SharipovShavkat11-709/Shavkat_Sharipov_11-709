using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if(Convert.ToInt32(str[0]) + Convert.ToInt32(str[2]) + Convert.ToInt32(str[4]) == Convert.ToInt32(str[1]) + Convert.ToInt32(str[3]) + Convert.ToInt32(str[5]))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
