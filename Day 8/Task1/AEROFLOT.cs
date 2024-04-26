namespace Task1
{
    struct AEROFLOT
    {
        public string destination;
        public int flightNumber;
        public string aircraftType;

        public AEROFLOT(string dest, int number, string type)
        {
            destination = dest;
            flightNumber = number;
            aircraftType = type;
        }
    }
}
