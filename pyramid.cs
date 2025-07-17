using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class pyramid
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=4; i++)
            {
                for(int j=1; j<=4+i-1; j++)
                {
                    if (j <= 4 - i)
                        Console.Write(" ");
                    else if ((j - (4 - i)) % 2 == 1)
                        Console.Write(j+" ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
