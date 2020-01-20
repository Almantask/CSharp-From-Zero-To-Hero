using System;

namespace BootCamp.Chapter
{
    class BMI
    {
        public static void CalculateBmi(float weightInKg, float height)
        {
            float bmi = weightInKg / (height * height);

            Console.WriteLine($"\nYour BMI based on your heigh of {height}m and your weight of {weightInKg}Kg " +
                             $"is {bmi} kg/(m*m)");
        }
    }
}
