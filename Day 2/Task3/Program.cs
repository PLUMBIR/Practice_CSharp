using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myPortalAddress = new PostalAddress("BLK", "Grodno", "230009");

            myPortalAddress.DisplayAddress();

            myPortalAddress.ChangeCity("Minsk");
            myPortalAddress.ChangeStreet("Prospect");
            myPortalAddress.ChangeZipCode("240005");

            myPortalAddress.DisplayAddress();

            Console.ReadLine();
        }
    }
}
