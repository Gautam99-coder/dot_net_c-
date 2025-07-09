using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class pattern1
    {
        static void Main(String []args)
        {
            int n = 5; // Number of rows
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*"); // Print star
                }
                Console.WriteLine(); // Move to the next line after printing stars in a row 
            }
        }

    }
}
