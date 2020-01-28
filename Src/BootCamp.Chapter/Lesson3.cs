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
            string lastName = Lesson3.PromptUserString("Last name: ");
            int age = Lesson3.PromptUserInt("Age: ");
            float height = Lesson3.PromptUserFloat("Height (in m): ");
            float weight = Lesson3.PromptUserFloat("Weight (in kg): ");                      
            float bmi = Lesson3.CalcBmi(weight, height);

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + "m. Their BMI is " + bmi + ".");
            Console.WriteLine();
        }


        public static string PromptUserString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.\n");
                return "-";
            }

            return name;

        }

         public static int PromptUserInt(string message)
        { 
            // Input is not a number -> return -1.
            Console.WriteLine(message);
            int num = int.Parse(Console.ReadLine());

            if (!int.TryParse(message, out num))
                {
                    return -1;
                }

            if (num == 0)
                {
                    return 0;
                }

            return num;
        }

        public static float PromptUserFloat(string message)
        {
            Console.WriteLine(message);
            float measurments = float.Parse(Console.ReadLine());

            if (measurments <= 0) 
            {
                return -1; 
            }
  
            return measurments;
            
        }

        public static float CalcBmi(float weight, float height)
        {

            if (weight <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:\n");
                Console.Write("Weight cannot be equal or less than zero, but was" + weight + "\n");

            }

            if (height <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:\n");
                Console.Write("Height cannot be equal or less than zero, but was" + height + "\n");
               
            }

            float bmi = (height * height) / weight;
            return bmi;

        }
    }
}