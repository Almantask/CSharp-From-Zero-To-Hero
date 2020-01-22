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
            Checks.PromptString("hello there");
            Checks.PromptInt("300");
            Checks.PromptFloat("10,1");
            Checks.CalculateBmi(72, 1.83f);
            Lesson3.Demo();
        }
    }
}
