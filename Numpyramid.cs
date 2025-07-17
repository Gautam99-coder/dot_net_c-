using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class Numpyramid
    {
        static void Main()
        {
            int rows = 4, num = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write(num++ + " ");
                Console.WriteLine();
            }
        }

    }
}
