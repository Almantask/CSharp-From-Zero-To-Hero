using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class BMI
    {
        public static void CalculateBMI(float weightInKg, float height)
        {
            float bmi = weightInKg / (height * height);

            Console.WriteLine($"\nYour BMI based on your heigh of {height}m and your weight of {weightInKg}Kg " +
                             $"is {bmi} kg/(m*m)");
        }
    }
}
