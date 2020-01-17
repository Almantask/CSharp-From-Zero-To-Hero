using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] firstName = { "Josie", "Daniel", "Liam" };
            string[] lastName = { "Flores", "James", "Jones" };
            int[] age = { 33, 34, 37 };
            float[] weight = { 58.967f, 65.77f, 71.11f }; // in kg
            float[] height = { 167.64f, 177.8f, 182.88f }; // in cm

            Console.WriteLine(firstName[0] + " " + lastName[0] + " is " + age[0] + " years old, her weight is " + weight[0] + "kg and her height is " + height[0] + " cm.");
            Console.WriteLine(firstName[1] + " " + lastName[1] + " is " + age[1] + " years old, his weight is " + weight[1] + "kg and his height is " + height[1] + " cm.");
            Console.WriteLine(firstName[2] + " " + lastName[2] + " is " + age[2] + " years old, his weight is " + weight[2] + "kg and his height is " + height[2] + " cm.");

            // Formula: weight (kg) / [height (m)]2
            // Calculation: [weight(kg) / height(cm) / height(cm)] x 10,000
            // cm to m --> divide by 100

            var toMeters0 = (height[0] / 100);
            var metersSquared0 = (toMeters0 * toMeters0);
            var bmiJosie = (weight[0] / metersSquared0);

            var toMeters1 = (height[1] / 100);
            var metersSquared1 = (toMeters1 * toMeters1);
            var bmiDaniel = (weight[1] / metersSquared1);

            var toMeters2 = (height[2] / 100);
            var metersSquared2 = (toMeters2 * toMeters2);
            var bmiLiam = (weight[2] / metersSquared2);

            Console.WriteLine(); // line break
            Console.WriteLine(firstName[0] + "'s BMI: " + bmiJosie);
            Console.WriteLine(firstName[1] + "'s BMI: " + bmiDaniel);
            Console.WriteLine(firstName[2] + "'s BMI: " + bmiLiam);
        }
    }
}
