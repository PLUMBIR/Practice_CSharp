using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AEROFLOT[] flights = new AEROFLOT[2];

            for (int i = 0; i < flights.Length; i++)
            {
                Console.Write("Write destination: ");
                string destination = Console.ReadLine();

                Console.Write("Write flightNumber: ");
                int flightNumber = int.Parse(Console.ReadLine());

                Console.Write("Write aircraftType: ");
                string aircraftType = Console.ReadLine();

                flights[i] = new AEROFLOT(destination, flightNumber, aircraftType);
            }

            Array.Sort(flights, (x, y) => x.flightNumber.CompareTo(y.flightNumber));

            Console.Write("Write your destination: ");
            string userDestination = Console.ReadLine();
            var usersFlights = Array.FindAll(flights, flight => flight.destination == userDestination);

            if (!(usersFlights.Length == 0))
            {
                foreach (var flight in usersFlights)
                {
                    Console.WriteLine($"Destination - {flight.destination}\n" +
                        $"FlightNumber - {flight.flightNumber}\n" +
                        $"AircraftType - {flight.aircraftType}");
                }
            }
            else
            {
                Console.WriteLine("Destinations with your name = 0");
            }

            Console.ReadLine();
        }
    }
}
