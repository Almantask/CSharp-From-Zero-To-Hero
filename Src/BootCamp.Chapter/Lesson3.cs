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

            Checks.PromptString();
            Checks.PromptInt();

            Console.WriteLine("Please enter your height(cm):");
            var height = Console.ReadLine();
            var cHeight = Checks.PromptFloat(height);

            Console.WriteLine("Please enter your weight(km):");
            var weight = Console.ReadLine();
            var cWeight = Checks.PromptFloat(weight);

            Checks.CalculateBmi(cWeight, cHeight);

        }
    }
}
