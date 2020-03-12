namespace BootCamp.Chapter
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, float weight, float heigth)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weight;
            Heigth = heigth;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Heigth { get; set; }
    }
}