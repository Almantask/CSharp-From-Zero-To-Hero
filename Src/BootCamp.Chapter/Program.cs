using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bootcamp.SecretP1;
using Bootcamp.SecretP2;

namespace BootCamp.Chapter
{
    class Program
    {
        static async Task Main(string[] args)
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
                await Task.Delay(100);
            }

            await Task.Delay(1000);
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("What's the passcode?");
            
            var passphrase = Console.ReadLine();
            Aysnchromaguss.CheckPassphrase(passphrase);
        }
    }
}
