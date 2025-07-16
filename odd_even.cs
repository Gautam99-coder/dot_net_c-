using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class odd_even
    {
        public static void Main(string[] args)
        {
            int num = 4;
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }else if(num == 0)
            {
                Console.WriteLine($"{num} is zero, which is neither even nor odd.");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
    }
}
