using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string separator = ",";

        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            RandomizeInput();
        }

        private static void RandomizeInput()
        {
            var sbClean = new StringBuilder();
            var sbCorrupted = new StringBuilder();
            var linesOriginal = File.ReadAllLines(@"Input/Balances.in");
            for (var i = 0; i < linesOriginal.Length; i++)
            {
                var sanitizedPerson = SanitizeLine(linesOriginal[i]);
                sbClean.AppendLine(sanitizedPerson);
                sbCorrupted.AppendLine(MessUp(sanitizedPerson));
            }

            sbCorrupted.Replace(",", "_,");

            File.WriteAllText(@"Input/Balances.clean", sbClean.ToString());
            File.WriteAllText(@"Input/Balances.dirty", sbCorrupted.ToString());
        }

        private static string SanitizeLine(string line)
        {
            var parts = line.Split(',');
            var name = string.Join(" ", parts[..^1]);
            var balance = decimal.Parse(parts[^1]) + GenerateFraction();
            var newBalances = GenerateBalanceSequence(balance);

            parts = new[] { name, newBalances }.Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

            return string.Join(separator, parts);
        }

        private static string GenerateBalanceSequence(decimal balance)
        {
            var balances = new List<string>();
            var balancesCount = random.Next(0, 50);
            for (var i = 0; i < balancesCount; i++)
            {
                var newBalance = GenerateBalanace(balance);
                balances.Add(newBalance.ToString("C2", new CultureInfo("en-GB")));
            }

            return string.Join(separator, balances);
        }

        private static decimal GenerateBalanace(decimal balance)
        {
            var newBalanceCoeficient = (decimal)random.Next(-100, 100) / 10;
            if (newBalanceCoeficient == 1)
            {
                newBalanceCoeficient += 0.1M;
            }

            return newBalanceCoeficient * balance;
        }

        private static decimal GenerateFraction()
        {
            return (decimal)random.Next(1, 10) / 10;
        }

        private static string MessUp(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return word;

            var messTimes = random.Next(0, word.Length) / 10;
            for (var i = messTimes; i > 0; i--)
            {
                var index = random.Next(0, word.Length);
                word = ReplaceAt(word, index);
            }

            return word;
        }

        private static string ReplaceAt(string word, int index)
        {
            var chars = word.ToCharArray().ToList();
            chars.Insert(index, '_');

            return new string(chars.ToArray());
        }
    }
}
