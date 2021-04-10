using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

            ProgramBoot(logger);
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    string firstName = ReadAndWriteString("First Name: ", logger);
                    string sureName = ReadAndWriteString("Sure Name: ", logger);
                    int age = ReadAndWriteInt("Age: ", logger);
                    double weight = ReadAndWriteDouble("Weight: ", logger);
                    double height = ReadAndWriteDouble("Height: ", logger);

                    var bmi = BMICalc(weight, height);

                    logger.Log($"{firstName} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
                    logger.Log($"Your BMI - {bmi:N2}");
                }
            }
            catch(Exception e)
            {
                logger.Log(e.ToString());
            }
            finally
            {            
                ProgramShutdown(logger);
            }         
        }

        static double BMICalc(double weight, double height)
        {
            return weight / ((height / 100) * (height / 100));
        }

        static string ReadAndWriteString(string text, ILogger logger)
        {
            logger.Log(text);
            string str = Console.ReadLine();
            logger.Log(str);
            return str;
        }

        static int ReadAndWriteInt(string text, ILogger logger)
        {
            logger.Log(text);
            int str = int.Parse(Console.ReadLine());
            logger.Log(str.ToString());
            return str;
        }

        static double ReadAndWriteDouble(string text, ILogger logger)
        {
            logger.Log(text);
            double str = double.Parse(Console.ReadLine());
            logger.Log(str.ToString());
            return str;
        }

        static void ProgramBoot(ILogger logger)
        {
            logger.Log("Program Booted UP!!");
        }

        static void ProgramShutdown(ILogger logger)
        {
            logger.Log("Program Shutdown!!");
        }
    }
}
