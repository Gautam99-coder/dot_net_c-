using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class sum_of_three_numbers
    {
      static void Main(string[] args)
        {
            int a, b, c, result;
            string str;
            Console.Write("Enter Number 1: ");
            str = Console.ReadLine(); // Taking input from user
            a = Convert.ToInt32(str);//converting string to integer

            Console.Write("Enter Number 2: ");
            str = Console.ReadLine(); 
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            result = a + b + c; // Adding the three numbers
            Console.WriteLine("Sum : " + result);

            Console.Read(); // Wait for user input before closing the console
        }
        static int sum(int x, int y, int z)
        {
            int res;
            res= x + y + z; 
            return res;
        }
    }
}
