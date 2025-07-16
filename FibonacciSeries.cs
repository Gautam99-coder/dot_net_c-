using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i;
            int count = 11;

            Console.Write(n1 + " " + n2 + " ");

            for (i = 2; i < count; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}
