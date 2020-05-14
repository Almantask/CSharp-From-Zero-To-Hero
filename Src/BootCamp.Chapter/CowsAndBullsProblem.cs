using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CowsAndBullsProblem
    {
        private const char Bull = 'A';
        private const char Cow = 'B';

        public static string Solve(string secret, string guess)
        {
            var frequencyTable = new int[10];
            var secretDigits = secret.Select(c => c-'0').ToArray();
            var guessDigits = guess.Select(c => c-'0').ToArray();

            var bulls = CountBulls(secretDigits, guessDigits, frequencyTable);
            var cows = CountCows(secretDigits, guessDigits, frequencyTable);

            var cowsAndBull = $"{bulls}{Bull}{cows}{Cow}";
            return cowsAndBull;
        }

        private static int CountBulls(int[] secret, int[] guess, int[] frequencyTable)
        {
            var bulls = 0;
            for (var i = 0; i < secret.Length; i++)
            {
                var digit = secret[i];
                frequencyTable[digit]++;
                
                var isBull = secret[i] == guess[i];
                if (isBull)
                {
                    bulls++;
                    frequencyTable[digit]--;
                }
            }

            return bulls;
        }

        private static int CountCows(int[] secret, int[] guess, int[] frequencyTable)
        {
            var cows = 0;
            for (var index = 0; index < guess.Length; index++)
            {
                var digit = guess[index];
                if (frequencyTable[digit] > 0 && guess[index] != secret[index])
                {
                    frequencyTable[digit]--;
                    cows++;
                }
            }

            return cows;
        }
    }
}
