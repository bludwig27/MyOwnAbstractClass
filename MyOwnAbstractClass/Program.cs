using System;
using System.Xml.Linq;

namespace Museum
{
    abstract class Display
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public void Info()
        {
            Console.WriteLine($"I am a museum display named {Name} with ID#{Id}.");
        }
    }

    class Program
    {
        class Painting : Display
        {
            public override int Id { get; set; }
            public override string Name { get; set; }
            public string Medium;
            public string Artist;
            public int Year;

            public Painting()
            {
                Name = string.Empty;
                Id = 0;
                Medium = string.Empty;
                Artist = string.Empty;
                Year = 0;
            }
            public Painting(int id, string name, string medium, string artist, int year)
            {
                Id = id;
                Name = name;
                Medium= medium;
                Artist = artist;
                Year = year;
            }
            public void PaintingInfo()
            {
                Console.WriteLine($"I am a painting made using {Medium} paints by {Artist} in {Year}.");
            }

        }
        static void Main(string[] args)
        { 
            Painting rcan = new Painting();
            rcan.Id = 1327;
            rcan.Name = "Red Canna";
            rcan.Medium = "oil-based";
            rcan.Artist = "Georgia O'Keeffe";
            rcan.Year = 1924;
            rcan.Info();
            rcan.PaintingInfo();
            Console.WriteLine();
            Painting ged= new Painting(8736,"The Garden of Earthly Delights","acrylic","Hieronymus Bosch",1504);
            ged.Info();
            ged.PaintingInfo();
        }
    }
}