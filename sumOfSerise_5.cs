using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class sumOfSerise_5
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int term = 0;

            for (int i = 1; i <= terms; i++)
            {
                term = term * 10 + num;
                Console.Write(term);
                if (i != terms) Console.Write(" + ");
                sum += term;
            }

            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
