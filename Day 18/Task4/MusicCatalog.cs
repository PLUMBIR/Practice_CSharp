using System;
using System.Collections;

namespace Task
{
    public class MusicCatalog
    {
        private Hashtable catalog;

        public MusicCatalog()
        {
            catalog = new Hashtable();
        }

        public void AddDisk(string diskName)
        {
            if (!catalog.ContainsKey(diskName))
                catalog.Add(diskName, new ArrayList());
        }

        public void RemoveDisk(string diskName)
        {
            if (catalog.ContainsKey(diskName))
                catalog.Remove(diskName);
        }

        public void AddSong(string diskName, string songName)
        {
            if (catalog.ContainsKey(diskName))
                ((ArrayList)catalog[diskName]).Add(songName);
        }

        public void RemoveSong(string diskName, string songName)
        {
            if (catalog.ContainsKey(diskName))
                ((ArrayList)catalog[diskName]).Remove(songName);
        }

        public void DisplayCatalog()
        {
            foreach (DictionaryEntry entry in catalog)
            {
                Console.WriteLine($"Диск: {entry.Key}");
                ArrayList songs = (ArrayList)entry.Value;
                foreach (string song in songs)
                {
                    Console.WriteLine($"  Песня: {song}");
                }
            }
        }
    }
}
