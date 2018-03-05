using System;
using System.Collections.Generic;

namespace Composite
{
    /* 
    Composite - spisak ot komponenti ne samo ot pesni
    no i playlisti. Ima ime i opisanie moje da dobavim component kato 
    add cam lista.
    */
    public class Playlist : ISongComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ISongComponent> components { get; set; }
        public Playlist(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            components = new List<ISongComponent>();
        }
        public void Add(ISongComponent component)
        {
            components.Add(component);
        }

        public void Remove(ISongComponent component)
        {
            component.Remove(component);
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("Playlist: {0}, Description: {1}", this.Name, this.Description);

            foreach (ISongComponent component in components)
            {
                component.DisplayInfo();
            }
        }

    }
}
