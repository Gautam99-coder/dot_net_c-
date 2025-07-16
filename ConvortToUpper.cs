using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class ConvortToUpper
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            // Convert to uppercase
            string upperName = name.ToUpper();

            // Display the result
            Console.WriteLine("Name in uppercase: " + upperName);

            Console.ReadLine(); // To keep the console window open
        }
    }
}
