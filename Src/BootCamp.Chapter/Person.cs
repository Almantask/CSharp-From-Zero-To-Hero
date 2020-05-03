namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public float Weight { get; }
        public float Height { get; }

        public Person(string name, string surname, int age, float weight, float height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }
    }
}