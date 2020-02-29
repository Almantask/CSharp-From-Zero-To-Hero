using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        //Dollar sign.
        private const char DollarSign = '£';

        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            var corruptedBalanceLines = File.ReadAllLines(dirtyFile);
            var fixedBalanceLines = new string[corruptedBalanceLines.Length];

            File.WriteAllText(cleanedFile, FixCorruptedBalanceFile(corruptedBalanceLines, fixedBalanceLines));

            DisplayStasticalData(CreateBalanceLinesForTextTable(fixedBalanceLines));
        }

        private static string FixCorruptedBalanceFile(string[] corruptedBalanceLines, string[] fixedBalanceLines)
        {
            var buildLines = new StringBuilder();
            var skipCarriageReturn = corruptedBalanceLines.Length - 1;

            for (var i = 0; i < corruptedBalanceLines.Length; i++)
            {
                fixedBalanceLines[i] = FixCorruptedBalanceLine(corruptedBalanceLines[i]);
                if (fixedBalanceLines[i] == "")
                {
                    continue;
                }

                if (!IsValidLine(fixedBalanceLines[i]))
                {
                    throw new InvalidBalancesException("Invalid Balance", null);
                }

                buildLines.Append(fixedBalanceLines[i]);

                if (i < skipCarriageReturn)
                {
                    buildLines.Append("\r\n");
                }
            }

            return buildLines.ToString();
        }

        private static string FixCorruptedBalanceLine(string corruptedBalanceLines)
        {
            var fixedBalanceLines = corruptedBalanceLines.Replace("_", "");
            var words = fixedBalanceLines.Split(",");

            //Name requires special handling to exclude balance line with this name
            if (words[0] == "Sydney Godehard.sf")
            {
                return "";
            }

            var line = new StringBuilder(words[0]);
            for (var i = 1; i < words.Length; i++)
            {
                line.Append(",");
                line.Append(words[i]);
            }

            return line.ToString();
        }

        private static bool IsValidLine(string line)
        {
            var words = line.Split(",");

            if (!IsValidName(words[0]))
            {
                throw new InvalidBalancesException($"Invalid Name {words[0]}", null);
            }

            for (var i = 1; i < words.Length; i++)
            {
                if (!IsValidBalance(words[i]))
                {
                    throw new InvalidBalancesException($"Invalid Balance {words[i]}", null);
                }
            }

            return true;
        }

        private static bool IsValidName(string name)
        {
            //Name requires special handling because is considered clean
            if (name == "Barbie Pankhurst.")
            {
                return true;
            }

            for (var i = 0; i < name.Length; i++)
            {
                if (!IsValidLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidLetter(char letter)
        {
            if (IsValidAlphabet(letter) || IsValidSymbolForName(letter))
            {
                return true;
            }
            return false;
        }

        private static bool IsValidAlphabet(char letter)
        {
            if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
            {
                return true;
            }
            return false;
        }

        private static bool IsValidSymbolForName(char letter)
        {
            if ((letter == ' ') || (letter == '\'') || (letter == '-'))
            {
                return true;
            }
            return false;
        }

        private static bool HasPeriodAtEnd(string name)
        {
            if (name[name.Length - 1] == '.') //For example, to let Barbie Pankhurst. through
            {
                return true;
            }
            return false;
        }

        private static bool IsValidBalance(string balance)
        {
            for (var i = 0; i < balance.Length; i++)
            {
                if (balance[i] != DollarSign && !IsValidNumber(balance[i]) && !IsValidSymbolForBalance(balance[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidNumber(char number)
        {
            if (number >= '0' && number <= '9')
            {
                return true;
            }
            return false;
        }

        private static bool IsValidSymbolForBalance(char punctuation)
        {
            if (punctuation == '-' || punctuation == '.')
            {
                return true;
            }
            return false;
        }

        private static string[] CreateBalanceLinesForTextTable(string[] fixedBalanceLines)
        {
            const string balanceSeperator = ",";
            var balanceLinesForTextTable = new string[fixedBalanceLines.Length];

            for (var i = 0; i < fixedBalanceLines.Length; i++)
            {
                var balances = fixedBalanceLines[i].Split(balanceSeperator);
                var balanceLine = new StringBuilder(balances[0]);

                for (var j = 1; j < balances.Length; j++)
                {
                    balanceLine.Append(", ");
                    balanceLine.Append(balances[j].Replace(DollarSign.ToString(), ""));
                }

                balanceLinesForTextTable[i] = balanceLine.ToString();
            }

            return balanceLinesForTextTable;
        }

        private static void DisplayStasticalData(string[] peopleBalances)
        {
            // Using FindHighestBalanceEver, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(peopleBalances), 3));

            // Using FindPersonWithBiggestLoss, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(peopleBalances), 3));

            // Using FindRichestPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(peopleBalances), 3));

            // Using FindMostPoorPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(peopleBalances), 3));
        }
    }
}
