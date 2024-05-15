using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Cat : Animal
    {
        private string breed;

        public Cat(string name, double height, string breed) : base(name, height)
        {
            this.breed = breed;
        }

        public override double CalculateWeight(double coefficient)
        {
            double weightInKilograms = base.CalculateWeight(coefficient);
            double weightInGrams = weightInKilograms * 1000;
            return weightInGrams;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Breed: {breed}");
        }
    }
}
