﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            return Lesson3.PromptInt(message);
        }

        public static string PromptString(string message)
        {
            return Lesson3.PromptString(message);
        }

        public static float PromptFloat(string message)
        {
            return Lesson3.PromptFloat(message);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return Lesson3.CalculateBMI(height, weight);
        }
    }
}

