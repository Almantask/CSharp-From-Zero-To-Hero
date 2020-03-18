using System;

namespace BootCamp.Chapter.Examples.NullConditional
{
    public class Dog
    {
        public string Name { get; } = "Sparky";
        public bool IsHungry { get; set; } = false;

        public void Bark()
        {
            Console.WriteLine($"Bark bark {Name}!");
        }
    }
}
