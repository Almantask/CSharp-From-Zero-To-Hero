using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = new string[] {
                @"C:\Users\aa192\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted",
                @"C:\Users\aa192\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.clean" };

            foreach (var file in files)
            {
                var contents = File.ReadAllLines(file);
                if (!CheckValidContents(contents))
                    contents = RepairCorruptFile(contents);

                Console.WriteLine(TextTable.Build($"{BalanceStats.FindHighestBalanceEver(contents)}",3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindPersonWithBiggestLoss(contents)}", 3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindRichestPerson(contents)}", 3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindMostPoorPerson(contents)}", 3));
            }
        }

        public static bool CheckValidContents(string[] Contents)
        {
            Regex validContent = new Regex($"^[a-z0-9, .£-]*$", RegexOptions.IgnoreCase);
            bool isValid = true;
            foreach (var line in Contents)
            {
                if (!validContent.IsMatch(line))
                    isValid = false;
            }
            if (isValid)
                return true;
            else
                return false;
        }

        public static string[] RepairCorruptFile(string[] Contents)
        {
            List<string> newContents = new List<string>();
            foreach (var line in Contents)
            {
                var newline = Regex.Replace(line, @"(?![a-zA-Z0-9, .£-]).", "");
                newContents.Add(newline);
            }
            return newContents.ToArray();
        }

    }
}
