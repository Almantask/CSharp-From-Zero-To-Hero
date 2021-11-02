using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void PrintQuestion(string message)
        {
            Console.WriteLine(message);
        }
        static double CalculateBmi(double w, double h)
        {
            double bmi = w / Math.Pow(h/100, 2);

            return bmi;
        }
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 2)
            {
                Console.Clear();

                string message = "What's your name?";
                PrintQuestion(message);
                string name = Console.ReadLine();
                logInfo(message, name);

                message = "What's your surname?";
                PrintQuestion(message);
                string surname = Console.ReadLine();
                logInfo(message, surname);

                message = "How old are you?";
                PrintQuestion(message);
                int age = int.Parse(Console.ReadLine());
                logInfo(message, age.ToString());

                message = "What's your weight? (in kg)";
                PrintQuestion(message);
                double weightInKg = double.Parse(Console.ReadLine());
                logInfo(message, weightInKg.ToString());

                message = "How height are you? (in cm)";
                PrintQuestion(message);
                double heightInCm = double.Parse(Console.ReadLine());
                logInfo(message, heightInCm.ToString());

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm", name, surname, age, weightInKg, heightInCm);

                Console.WriteLine("\nBMI: {0:F} ", CalculateBmi(weightInKg, heightInCm));

                string bmi = CalculateBmi(weightInKg, heightInCm).ToString();
                logInfo("BMI: ", bmi);

                i++;
            }
        }


        public static void logInfo<T>(T message, T value)
        {
            Logger log = new Logger();
            string infoToLog = message.ToString();
            string infoToLogValue = value.ToString();
            string finalInfo = infoToLog + " " + infoToLogValue;
            log.Log(finalInfo);
        }
      


    }
}
