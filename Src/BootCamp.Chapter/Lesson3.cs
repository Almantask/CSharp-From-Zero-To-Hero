



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
            // Empty string for name -> return "-".
            // Print error message "Name cannot be empty." in a new line.
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return name;
        }

        public static int PromptUserInt(string message)
        { 
            //Input is not a number -> return -1.
            // Input is a number but 0 -> return 0.
            // Input is valid -> return input.
            Console.WriteLine(message);
            int num = int.Parse(Console.ReadLine());

            //if (num != Int32.TryParse())
            //{
            //    return -1;
            //}
            //else if (num == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return num;
            //}


            //if (num == 0)
            //{
            //    return 0;
            //}

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
