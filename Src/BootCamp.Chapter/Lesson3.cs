using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {
        }

        public static float BMICalculator(float weightcal, float heightcal)
        {
            var heightmeter = heightcal;
            var heightsquared = heightmeter * heightmeter;
            var totalbmi = weightcal / heightsquared;
            Console.WriteLine("Your bmi is: " + totalbmi);
            return totalbmi;
        }

        public static float BMiRequests(string prompt)
        {
            Console.WriteLine(prompt);
            var bm = Console.ReadLine();
            var bm_1 = float.Parse(bm);

            return bm_1;
        }

        public static int ageRequests(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var ageconv = int.Parse(input);

            return ageconv;
        }

        public static string StringRequests(string messagestring)
        {
            Console.WriteLine(messagestring);
            var stringinput = Console.ReadLine();

            return stringinput;
        }
    }
}