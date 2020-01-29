using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Secret
{
    public static class Aysnchromaguss
    {
        private static readonly Random _rnd = new Random();
        public static int WordIndex;

        private readonly static string[] _secretMessage =
        {
            "A", "minore", "ad", "maius",
            "a", "solis", "ortu", "usque", "ad", "occasum",
            "ab", "uno", "disce", "omnes"

        };

        public static async Task Mumble()
        {
            var word = _secretMessage[WordIndex];
            WordIndex = (WordIndex + 1) % _secretMessage.Length;
            var delay = _rnd.Next(100);
            await Task.Delay(delay);

            Console.Write($"{word} ");
        }

        public static void CheckPassphrase(string guess)
        {
            const string passphrase = "A minore ad maius " +
                                      "a solis ortu usque " +
                                      "ad occasum ab uno disce omnes";

            if (passphrase.Equals(guess))
            {
                Console.WriteLine("YOU MAY PROCEED!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("From the smaller to the greater,");
                Console.WriteLine("From sunrise to sunset,");
                Console.WriteLine("From one, learn all.");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
