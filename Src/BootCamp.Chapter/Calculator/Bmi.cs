namespace BootCamp.Chapter.Calculator
{
    public class BmiCalculator
    {
        public Person Person { get; }
        public float Weight { get; }
        public float Height { get; }
        public float Bmi { get; }

        public BmiCalculator(string name, string surname, int age, float weight, float height)
        {
            Person = new Person(name, surname, age);
            Weight = weight;
            Height = height;
            Bmi = Weight / ((Height / 100) * (Height / 100));
        }

        public BmiCalculator(Person person, float weight, float height)
        {
            Person = person;
            Weight = weight;
            Height = height;
            Bmi = Weight / ((Height / 100) * (Height / 100));
        }
    }
}