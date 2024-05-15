abstract class Building
{
    protected string Name;

    public Building(string name)
    {
        Name = name;
    }

    public abstract double CalculateFabricConsumption();

    public virtual void DisplayParameters()
    {
        Console.WriteLine($"Building name: {Name}");
    }
}

class Office : Building
{
    private int NumberOfFloors;

    public Office(string name, int numberOfFloors) : base(name)
    {
        NumberOfFloors = numberOfFloors;
    }

    public override double CalculateFabricConsumption()
    {
        return NumberOfFloors * 100;
    }

    public override void DisplayParameters()
    {
        base.DisplayParameters();
        Console.WriteLine($"Number of floors: {NumberOfFloors}");
    }
}

class Factory : Building
{
    private double Weight;

    public Factory(string name, double weight) : base(name)
    {
        Weight = weight;
    }

    public override double CalculateFabricConsumption()
    {
        return Weight / 1000;
    }

    public override void DisplayParameters()
    {
        base.DisplayParameters();
        Console.WriteLine($"Weight: {Weight} tons");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Building[] buildings = new Building[]
        {
            new Office("Office Building", 10),
            new Factory("Factory", 50000),
            new Office("Tech Park", 5),
            new Factory("Heavy Industry", 100000),
            new Office("Business Center", 20)
        };

        double totalFabricConsumption = 0;

        Console.WriteLine("Building Information:");
        Console.WriteLine("---------------------");
        foreach (Building building in buildings)
        {
            building.DisplayParameters();
            double fabricConsumption = building.CalculateFabricConsumption();
            totalFabricConsumption += fabricConsumption;
            Console.WriteLine($"Fabric consumption: {fabricConsumption} square meters");
            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"Total fabric consumption: {totalFabricConsumption} square meters");
    }
}
