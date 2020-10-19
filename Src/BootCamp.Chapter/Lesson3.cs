using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string NameofPerson()
        {
            string personName = Checks.PromptString("Enter your name: ");
            return personName;
        }

        public static string SurnameofPerson()
        {
            string personSurName = Checks.PromptString("Enter your Surname: ");
            return personSurName;
        }

        public static int AgeofPerson()
        {
            int personAge = Checks.PromptInt("Enter your Age: ");
            return personAge;
        }

        public static float WeightofPerson()
        {
            float personWeight = Checks.PromptFloat("Enter your Weight: ");
            return personWeight;
        }

        public static float HeightofPerson()
        {
            float personHeight = Checks.PromptFloat("Enter your Height: ");
            return personHeight;
        }

        public static float BMIofPerson(float personWeight, float personHight)
        {
            float personBIM = Checks.CalculateBmi(personWeight, personHight);
            return personBIM;
        }

        public static void InfoPerson(string name, string surname, int age, float weight, float height, float bmi)
        {
            Checks.PrintInfo(name, surname, age, weight, height, bmi);
        }
    }
}
