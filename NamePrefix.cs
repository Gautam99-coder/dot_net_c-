using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class NamePrefix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Gender M/F: ");
            char gender = Convert.ToChar(Console.ReadLine().ToUpper());

            string prefix = (gender == 'M') ? "Mr." : (gender == 'F') ? "Ms." : "";

            Console.WriteLine($" Full Name {prefix} {name}");

            Console.ReadLine();

        }
    }
}
