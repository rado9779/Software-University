using System;

using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] phoneNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Dialing(phoneNumber));
                }
                else if (phoneNumber.Length == 10)
                {
                    Console.WriteLine(smartphone.Calling(phoneNumber));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            string[] sites = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.Browsing(site));
            }
        }
    }
}
