using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson4
    {
        public static void Demo()
        {
            string name = Checks.PromptString("Entern name");
            int age = Checks.PromptInt("Enter age");
            float weight = Checks.PromptFloat("Enter weight");
            float height = Checks.PromptFloat("Enter height");
            float bmi = Checks.CalculateBmi(weight, (float)(height / 100.0));

            Checks.DisplayDetail(name, age, weight, height, bmi);
        }
    }
}
