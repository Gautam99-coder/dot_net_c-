using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class increasebyone
    {
        static void Main(string[] args)
        {
            int n = 4;
            int number = 1;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(number++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
