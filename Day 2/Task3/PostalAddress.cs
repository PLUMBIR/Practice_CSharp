using System;

namespace Task3
{
    public class PostalAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public PostalAddress(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        private bool IsValidAddress()
        {
            return !string.IsNullOrEmpty(Street) &&
                   !string.IsNullOrEmpty(City) &&
                   !string.IsNullOrEmpty(ZipCode);
        }

        public void ChangeStreet(string newStreet)
        {
            Street = newStreet;
        }

        public void ChangeCity(string newCity)
        {
            City = newCity;
        }

        public void ChangeZipCode(string newZipCode)
        {
            ZipCode = newZipCode;
        }

        public void DisplayAddress()
        {
            if (IsValidAddress())
            {
                Console.WriteLine($"Почтовый адрес: {Street}, {City}, {ZipCode}.");
            }
            else
            {
                Console.WriteLine("Нет данных.");
            }
        }
    }
}
