namespace BootCamp.Chapter
{
    // This should not have any attributes
    public class Item
    {
        public string Name { get; }

        public Item(string name)
        {
            Name = name;
        }

        // Do not change the bellow
        public override string ToString() => Name;
    }
}