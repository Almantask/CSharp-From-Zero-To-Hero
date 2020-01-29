using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;

namespace BootCamp.Chapter
{
    class Program
    {
        public static bool Flag = true;
        public static string Status= "Bad";

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue....");
            Console.Read();
            JumpInTimeDemo();
            Console.WriteLine("Not today!");
            //ConditionalBreakpoint();
            //Step1();
            //ScopedWatchDemo();
        }

        // Conditional and actions
        private static void ConditionalBreakpoint()
        {
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers == null)
                {
                    Console.WriteLine("Poof");
                }
                numbers[i] = i;
                if (i == 30)
                {
                    numbers = null;
                }
            }
        }

        // Moving arround, intermediate
        private static void JumpInTimeDemo()
        {
            var words = new[] { "Light", "Gone", "Dark", "Sign", "Willing" };
            var sentence = "";
            foreach (var word in words)
            {
                sentence += word + " ";
            }

            Console.WriteLine(sentence);
        }

        // Watch
        private static void ScopedWatchDemo()
        {
            for (var i = 0; i < 3; i++)
            {
                var a1 = 1;
                {
                    var a2 = 2;
                    {
                        var a3 = 3;
                        {
                            var a4 = 4;
                            {
                                var end = "end";
                            }
                        }
                    }
                }
            }
        }

        private static void Step1()
        {
            Console.WriteLine("step1");
            Step2();
        }

        private static void Step2()
        {
            Console.WriteLine("step2");
            Step3();
        }

        private static void Step3()
        {
             Console.WriteLine("step3");
        }
    }
}
