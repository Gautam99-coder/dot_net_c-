using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gautam_23SOEIT11603
{
    internal class MaskMobile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile number:");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Masked Mobile: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid mobile number.");
            }

            Console.ReadLine();
        }
    }
}
