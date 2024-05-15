using RectangleLibrary;
using TriangleLibrary;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rec = Rectangle.Create();
            rec.CalculatePerimeter();
            rec.CalculateArea();

            var tr = new Triangle();
            tr.InputSides();

            if (tr.CheckExistence())
            {
                tr.CalculatePerimeter();
                tr.CalculateArea();
                tr.DetermineType();
            }
        }
    }
}
