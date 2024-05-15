namespace MyFurnitureLibrary
{
    public class Chair
    {
        public string Material { get; set; }
        public double Price { get; set; }

        public Chair(string material, double price)
        {
            Material = material;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Chair: Material - {Material}, Price - ${Price}");
        }
    }
}
