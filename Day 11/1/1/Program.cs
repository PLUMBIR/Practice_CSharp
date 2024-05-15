using System;

class Build
{
    protected string name;

    public Build(string _name)
    {
        name = _name;
    }

    public virtual void OutputInfo()
    {
        Console.WriteLine($"Название здания: {name}");
    }
}

class Offic : Build
{
    private int count;

    public Offic(string name, int сount) : base(name)
    {
        this.count = сount;
    }

    public override void OutputInfo()
    {
        base.OutputInfo();
        double height = 0.05 * count;
        Console.WriteLine($"Количество этажей: {count}");
        Console.WriteLine($"Высота фундамента: {height}");
    }
}

class Zavod : Build
{
    private double weight;

    public Zavod(string name, double weight) : base(name)
    {
        this.weight = weight;
    }

    public override void OutputInfo()
    {
        base.OutputInfo();
        double height = 0.000002 * weight;
        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Высота фундамента: {height}");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Build[] builds = new Build[]
        {
            new Build("Обычное здание"),
            new Offic("Офисное здание", 10),
            new Zavod("Завод", 50000),
            new Offic("Технологический парк", 5),
            new Zavod("Тяжелая промышленность", 100000)
        };

        Console.WriteLine("Информация о зданиях:");
        Console.WriteLine("---------------------");
        foreach (var build in builds)
        {
            build.OutputInfo();
            Console.WriteLine("---------------------");
        }
    }
}
