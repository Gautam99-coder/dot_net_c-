using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class pattern2
    {
        static void Main(String[] args)
        {
            //half diamond pattern
            // Upper half of the diamond
            int n= 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*"); // Print star
                }
                Console.WriteLine(); // Move to the next line after printing stars in a row
            }
            // Lower half of the diamond
            for (int i = n- 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*"); // Print star
                }
                Console.WriteLine(); // Move to the next line after printing stars in a row
            }
        }
    }
}
