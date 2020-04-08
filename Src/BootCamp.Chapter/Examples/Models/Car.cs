using System.Drawing;

namespace BootCamp.Chapter.Examples.Models
{
    public class Car
    {
        public string Name { get; }
        public string Model { get; }
        public Color Color { get; set; }
        public long? OwnerId { get; set; }

        public Car(string name, string model, Color color)
        {
            Name = name;
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Model} {Name}";
        }
    }
}