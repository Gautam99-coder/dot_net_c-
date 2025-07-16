using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class arr4
    {
        static void Main(string[] args)
        {
            string[] str = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
            //reversing the array
            //Array.Reverse(str);
            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = temp;
            }
            int g = 0;
            foreach(string temp in str)
            {
                g++;
                Console.WriteLine(g+" "+temp);
            }
        }
    }
}
