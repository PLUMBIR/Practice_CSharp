namespace RectangleLibrary
{
    public class Rectangle
    {
        private double length;
        private double width;

        public static Rectangle Create()
        {
            Console.WriteLine("Введите длину и ширину прямоугольника:");
            Console.Write("Длина: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Ширина: ");
            var width = double.Parse(Console.ReadLine());

            return new Rectangle(length, width);
        }

        private Rectangle()
        {

        }

        private Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр прямоугольника = {2 * (length + width)}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Площадь прямоугольника = {length * width}");
        }
    }
}
