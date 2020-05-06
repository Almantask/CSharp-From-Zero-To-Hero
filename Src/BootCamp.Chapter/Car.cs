namespace BootCamp.Chapter
{
    // This should have the following attribute
    [Textable]
    public class Car
    {
        [Textable]
        public string Brand { get; }

        [Textable]
        public string Name { get; }

        public Car(string brand, string name)
        {
            Brand = brand;
            Name = name;
        }

        // Do not change the bellow
        public override string ToString() => $"{Brand} {Name}";
    }
}