namespace BootCamp.Chapter
{
    public class Person
    {
        [TextTable(1, '=', 'x', '*')]
        public string Name { get; }

        [TextTable(1, '=', 'x', '*')]
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Do not change the bellow
        public override string ToString() => $"{Name} - {Age}";
    }
}