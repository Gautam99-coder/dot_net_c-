using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            int n, fact = 1; //declaring integer variables n and 'fact' initialized to 1 for fact
            Console.Write("Enter a number to find its factorial: ");
            string input = Console.ReadLine(); //taking input from user
            n=Convert.ToInt32(input);//converting string to integer
            if (n < 0)
            {
                Console.WriteLine("facorial of negative number is not possible");
            }
            else
            {
                for(int i=1; i<=n; i++)//looping from 1 to n
                {
                    fact = fact * i; //calculating factorial ,each time multiplying 'fact' with i till i reaches n
                }
                Console.WriteLine($"Factorial of {n} is {fact}"); //printing the factorial
            }
        }
    }
}
