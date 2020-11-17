using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Lesson_4.PromptString("Enter your name: ");
            int age = Lesson_4.PromptInt("Enter your age: ");
            float weight = Lesson_4.PromptFloat("Enter your weight,unit is kg: ");
            float height = Lesson_4.PromptFloat("Enter your height,unit is meters: ");
        }
    
    }
}
