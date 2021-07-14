using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {

            Checks.PromptString("Please enter your name:");
            Checks.PromptInt("Please enter your age:");

            var cHeight = Checks.PromptFloat("Please enter your height(m):");
            var cWeight = Checks.PromptFloat("Please enter your weight(kg)");

            Checks.CalculateBmi(cWeight, cHeight);

        }
    }
}
