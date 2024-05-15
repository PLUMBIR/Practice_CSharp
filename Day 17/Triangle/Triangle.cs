namespace TriangleLibrary
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public void InputSides()
        {
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("Сторона A: ");
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Сторона B: ");
            sideB = double.Parse(Console.ReadLine());

            Console.Write("Сторона C: ");
            sideC = double.Parse(Console.ReadLine());
        }

        public bool CheckExistence()
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр треугольника = {sideA + sideB + sideC}");
        }

        public void CalculateArea()
        {
            double halfPerimeter = sideA + sideB + sideC / 2;
            Console.WriteLine($"Периметр треугольника = {Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC))}");
        }

        public void DetermineType()
        {
            if (sideA == sideB && sideB == sideC)
                Console.WriteLine("Равносторонний");
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
                Console.WriteLine("Равнобедренный");
            else
                Console.WriteLine("Разносторонний");
        }
    }
}
