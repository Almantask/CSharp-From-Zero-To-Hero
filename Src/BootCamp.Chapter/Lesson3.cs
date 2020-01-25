using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        private const float mathTolerance = 0.0000001f;

        public static void Demo()
        {
            const int numOfPerson = 2;

            for (var num = 0; num < numOfPerson; num++)
            {
                Console.WriteLine("Calculate BMI for a person.");

                var name = PromptString("Enter name: ");
                var surname = PromptString("Enter surname: ");
                var age = PromptInt("Enter age: ");
                var weightKg = PromptFloat("Enter weight (kg): ");
                var heightCm = PromptFloat("Enter height (cm): ");

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weightKg + " kg and his height is " + heightCm + " cm.");

                float bmi = CalculateBmi(weightKg, heightCm / 100);
                if (bmi >= 0)
                {
                    Console.WriteLine("Body-mass index (BMI) is " + bmi + ".");
                }
            }
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return 0;

            bool isNumber = int.TryParse(input, out var number);
            if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            bool isNumber = float.TryParse(input, out var number);
            if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            if (weightKg <= 0 || heightM <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (Math.Abs(weightKg) < mathTolerance && Math.Abs(heightM) < mathTolerance)
                {
                    //To handle special test case where if user enters 0 for both Weight and Height then
                    //let user know Height cannot be less than 0 for the 0 Height entered by the user.
                    Console.WriteLine("Weight cannot be equal or less than zero, but was 0.");
                    Console.WriteLine("Height cannot be less than zero, but was 0.");
                }
                else
                {
                    if (weightKg <= 0)
                    {
                        Console.WriteLine("Weight cannot be equal or less than zero, but was " + weightKg + ".");
                    }
                    if (heightM <= 0)
                    {
                        Console.WriteLine("Height cannot be equal or less than zero, but was " + heightM + ".");
                    }
                }

                return -1;
            }

            //BMI is weight (kg) / [height (m)] ^ 2
            return (float)(weightKg / Math.Pow(heightM, 2));
        }
    }
}
