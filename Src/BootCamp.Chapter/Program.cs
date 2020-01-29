using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bootcamp.Secret;

namespace BootCamp.Chapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var mumbles = new List<Task>();

            for (var index = 0; index < 14; index++)
            {
                Aysnchromaguss.Mumble();
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
