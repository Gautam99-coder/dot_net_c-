using System;

namespace Gautam_23SOEIT11603
{
    internal class ProfilePage
    {
        static void Main(string[] args)
        {
            var myProfile = new
            {
                Name = "Gautam Tharu",
                DOB = new DateTime(2005, 12, 19), //this timedate is in the format YYYY, MM, DD
                Address = "4, XYZ Society, Kalawad Road",
                City = "Rajkot",
                Pincode = "360001",
                State = "Gujarat",
                Country = "India",
                Email = "gautam@email.com",
            };

            // Display profile information
            Console.WriteLine("Profile Information:");
            Console.WriteLine($"Name: {myProfile.Name}");
            Console.WriteLine($"DOB: {myProfile.DOB:dd/MM/yyyy}");
            Console.WriteLine($"Address: {myProfile.Address}");
            Console.WriteLine($"City: {myProfile.City}");
            Console.WriteLine($"Pincode: {myProfile.Pincode}");
            Console.WriteLine($"State: {myProfile.State}");
            Console.WriteLine($"Country: {myProfile.Country}");
            Console.WriteLine($"Email: {myProfile.Email}");

            Console.ReadLine(); // Keep console window open
        }
    }
}