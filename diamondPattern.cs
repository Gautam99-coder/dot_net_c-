using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class diamondPattern
    {
        static void Main(string[]arg)
        {
            int n = 5; // Diamond height (max width)

            // Upper part
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            // Lower part
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
