using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class arr2
    {
        static void Main(string[] args)
        {
            //find the maximum element in an array
            int[] arr = { 1, 2, 3, 4, 5 };
            int max = arr[0];
            // Assume first element is the maximum
            foreach(int i in arr)
            {
                if (i > max)
                {
                    max = i; //Update max if current element is greater
                }
            }
            Console.WriteLine("Maximum element in the array is: " + max);

        }
    }
}
