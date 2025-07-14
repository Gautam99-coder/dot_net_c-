using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class arr1
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int indx = 0; indx < arr.Length; indx++)
            {
                int i = arr[indx];
                Console.WriteLine(indx);
            }
            string input = Console.ReadLine();
        }
    }
}
