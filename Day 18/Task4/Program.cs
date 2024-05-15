using System;
using Task;

namespace Task4
{
    public class Program
    {
        static void Main()
        {
            MusicCatalog catalog = new MusicCatalog();
            catalog.AddDisk("Диск 1");
            catalog.AddSong("Диск 1", "Песня 1");
            catalog.AddSong("Диск 1", "Песня 2");
            catalog.RemoveSong("Диск 1", "Песня 1");
            catalog.DisplayCatalog();

            Console.ReadLine();
        }
    }
}
