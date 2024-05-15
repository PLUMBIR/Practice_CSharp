using System;

namespace Task1
{
    public class Animal
    {
        private string name;
        private double height;

        public Animal(string name, double height)
        {
            this.name = name;
            this.height = height;
        }

        public virtual double CalculateWeight(double coefficient)
        {
            return coefficient * Math.Pow(height, 3);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Animal name: {name}");
            Console.WriteLine($"Height: {height} meters");
        }
    }
}
