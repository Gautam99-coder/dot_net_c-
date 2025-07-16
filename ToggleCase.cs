using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class ToggleCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();
            string result = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else if (char.IsLower(c))
                    result += char.ToUpper(c);
                else
                    result += c;
            }

            Console.WriteLine("Toggle case: " + result);
            Console.ReadLine();
        }
    }
}
