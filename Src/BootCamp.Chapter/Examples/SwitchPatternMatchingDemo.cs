using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using BootCamp.Chapter.Examples.NullCoalecingDemo;

namespace BootCamp.Chapter.Examples
{
    public static class SwitchPatternMatchingDemo
    {
        public static void Run()
        {
            // bad
            for (var i = 0; i < 11; i++)
            {
                var number = GetNumberName1(i);
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");

            // good
            for (var i = 0; i < 11; i++)
            {
                var number = GetNumberName2(i);
                Console.WriteLine(number);
            }

            DemoEnumPatternMatching();
        }

        private static string GetNumberName1(int number)
        {
            var numericString = number switch
            {
                0 => "Zero",
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => "?"
            };

            return numericString;
        }

        private static string GetNumberName2(int number)
        {
            string numericString;
            if (number == 0)
                numericString = "Zero";
            else if (number == 1)
                numericString = "One";
            else if (number == 2)
                numericString = "Two";
            else if (number == 3)
                numericString = "Three";
            else if (number == 4)
                numericString = "Four";
            else if (number == 5)
                numericString = "Five";
            else if (number == 6)
                numericString = "Six";
            else if (number == 7)
                numericString = "Seven";
            else if (number == 8)
                numericString = "Eight";
            else if (number == 9)
                numericString = "Nine";
            else
                numericString = "?";

            return numericString;
        }

        private static void DemoEnumPatternMatching()
        {
            var genders = new[] {Gender.F, Gender.M, Gender.O};

            foreach (var gender in genders)
            {
                var genderString = gender switch
                {
                    Gender.F => "Female",
                    Gender.M => "Male",
                    Gender.O => "Other",
                    _ => "?"
                };

                Console.WriteLine($"{gender} -> {genderString}");
            }
        }
    }
}
