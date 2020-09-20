using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bootcamp.Optional;
using Bootcamp.SecretP1;
using Bootcamp.SecretP2;

namespace BootCamp.Chapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Put two // in front of the await to comment out Part1And2 once you solved it.
            // Make sure to note down the secret passcode before. You will need it!
            // await Part1And2();
            OptionalPart();
        }

        // You are not supposed to change anything but "runTests = true" comment here.
        private static void OptionalPart()
        {
            bool runTests = false;

            // Uncomment the next line to run your tests only.
            runTests = true;

            if (runTests)
            {
                // Runs your tests.
                Algorithm.OptionalTestCases();
            }
            else
            {
                // You are not supposed to use Google.
                // You are supposed to write code in the Algorithm.cs file and only there.
                Dialog.StartChallange(Algorithm.Sort, Algorithm.Split, Algorithm.Merge);
            }
        }

        // You are not supposed to change anything in this function.
        private static async Task Part1And2()
        {
            Console.WriteLine("Debug this correctly to move on to part 2 of this homework.");
            Console.WriteLine();
            Console.WriteLine();

            foreach (string question in Prompter.Instance)
            {
                var value = Prompter.Instance.DebugValue(question);

                do
                {
                    Console.WriteLine(question);
                } while (!Prompter.Instance.IsCorrectAnswer(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to part 2.");
            Console.WriteLine();
            Console.WriteLine();

            var mumbles = new List<Task>();

            // A hidden message is up there
            // Debug may help,
            // Or mix with your despair.
            for (var index = 0; index < 14; index++)
            {
                Aysnchromaguss.Mumble();
                await Task.Delay(10);
            }

            await Task.Delay(1000);
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("What's the passcode?");

            var passphrase = Console.ReadLine();
            Aysnchromaguss.CheckPassphrase(passphrase);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("If you didn't note the passcode, you should do it now!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
