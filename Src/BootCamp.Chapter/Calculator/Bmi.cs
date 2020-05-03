namespace BootCamp.Chapter.Calculator
{
    public static class Bmi
    {
        public static float CalculatePersonBmi(Person person)
        {
            var weight = person.Weight;
            var height = person.Height;
            return weight / ((height / 100) * (height / 100));
        }
    }
}