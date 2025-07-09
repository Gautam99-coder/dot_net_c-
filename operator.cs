using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class @operator
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            b++; //output will be 6, but b is now 6
            ++b; //output will be 7, but b is now 7 explaining pre-increment and post-increment
            int res = ++a + b++ + ++b; // Pre-increment a to 6, b is 7, then b++ will use the current value of b (7) and then increment it to 8 
            Console.WriteLine("Result of ++a + b++: " + res); // Output will be 12

        }
    }
}
