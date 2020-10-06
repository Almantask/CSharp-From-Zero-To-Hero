using System;

namespace BootCamp.Chapter
{
    public class ReadAndWriteData
    {
        public void ReadAndWritePersonData(ILogger logger)
        {
            try
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Please enter your surname: ");
                string surname = Console.ReadLine();
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Please enter your weight (in kg): ");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Please enter your lenght (in cm): ");
                double length = double.Parse(Console.ReadLine());

                double bmi = weight / (length * length / 10000);

                string completeEntry = $"{DateTime.Now} {name} {surname} is {age} years old, his weight is {weight} kg " +
                    $"and his height is {length} cm. BMI: {bmi:F1}";

                logger.LogMessage(completeEntry);
            }
            catch (Exception ex)
            {
                string errorMessage = $"{DateTime.Now} Error reading or calculating data: {ex.Message}";
                logger.LogMessage(errorMessage);
            }
        }
    }
}
