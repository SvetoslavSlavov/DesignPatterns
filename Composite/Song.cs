using System;
using System.Collections.Generic;

// Listo
namespace Composite
{
    public class Song : ISongComponent
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public Song(string name, string Author, int year)
        {
            this.Name = name;
            this.Author = Author;
            this.ReleaseDate = year;
        }
        public void Add(ISongComponent component)
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Song: {0}, Author: {1}, Year: {2}", this.Name, this.Author, this.ReleaseDate);
        }

        public void Remove(ISongComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
