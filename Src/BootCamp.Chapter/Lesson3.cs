using System;
namespace BootCamp.Chapter
{
    public class Lesson3
    {

        public static void Demo()
        {

            EnterUserData();
            EnterUserData();

        }


        public static void EnterUserData()
        {

            string firstName = Lesson3.PromptUserString("First name: ");
            Console.WriteLine();

            string lastName = Lesson3.PromptUserString("Last name: ");
            Console.WriteLine();

            int age = Lesson3.PromptUserInt("Age: ");
            Console.WriteLine();

            float weight = Lesson3.PromptUserFloat("Weight (in kg): ");
            Console.WriteLine();

            float height = Lesson3.PromptUserFloat("Height (in m): ");
            Console.WriteLine();

            float bmi = Lesson3.CalcBmi(weight, height);
            Console.WriteLine();

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + "m. Their BMI is " + bmi + ".");
            Console.WriteLine();
        }

        public static string PromptUserString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }

        public static int PromptUserInt(string message)
        {
            Console.WriteLine(message);
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public static float PromptUserFloat(string message)
        {
            Console.WriteLine(message);
            float measurments = float.Parse(Console.ReadLine());
            return measurments;
        }

        public static float CalcBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }
    }
}
