using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class reArrange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            string str = Console.ReadLine();//taking input from user
            int x = Convert.ToInt32(str);//converting string to integer

            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");

            Console.Read();
        }
    }
}
