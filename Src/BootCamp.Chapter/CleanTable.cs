using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class CleanTable
    {
        private const char DollarSign = '£';
        private readonly string _corruptedBalanceFile;
        private readonly string _fixedBalanceFile;

        public CleanTable(string corruptedBalanceFile, string fixedBalanceFile)
        {
            if (!File.Exists(corruptedBalanceFile))
            {
                throw new ArgumentException($"The corrupted balance file does not exist: {corruptedBalanceFile}.");
            }
            _corruptedBalanceFile = corruptedBalanceFile;

            if (File.Exists(fixedBalanceFile))
            {
                File.Delete(fixedBalanceFile);
            }
            _fixedBalanceFile = fixedBalanceFile;
        }

        public void Clean()
        {
            var corruptedBalanceLines = File.ReadAllLines(_corruptedBalanceFile);
            var fixedBalanceLines = new string[corruptedBalanceLines.Length];
            FixCorruptedBalanceFile(corruptedBalanceLines, fixedBalanceLines);

            DisplayStasticalData(CreateBalanceLinesForTextTable(fixedBalanceLines));
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

        private void FixCorruptedBalanceFile(string[] corruptedBalanceLines, string[] fixedBalanceLines)
        {
            var buildLines = new StringBuilder();
            var skipCarriageReturn = corruptedBalanceLines.Length - 1;

            for (var i = 0; i < corruptedBalanceLines.Length; i++)
            {
                fixedBalanceLines[i] = corruptedBalanceLines[i].Replace("_", "");

                if (!IsValidLine(fixedBalanceLines[i]))
                {
                    throw new InvalidBalancesException("Invalid Balance");
                }

                buildLines.Append(fixedBalanceLines[i]);

                if (i < skipCarriageReturn)
                {
                    buildLines.Append("\r\n");
                }
            }

            File.WriteAllText(_fixedBalanceFile, buildLines.ToString());
        }

        private static bool IsValidLine(string line)
        {
            var words = line.Split(",");

            if (!IsValidName(words[0]))
            {
                throw new InvalidBalancesException($"Invalid Name {words[0]}");
            }

            for (var i = 1; i < words.Length; i++)
            {
                if (!IsValidBalance(words[i]))
                {
                    throw new InvalidBalancesException($"Invalid Balance {words[i]}");
                }
            }

            return true;
        }

        private static bool IsValidName(string name)
        {
            for (var i = 0; i < name.Length; i++)
            {
                if (!IsValidLetter(name[i]) && !HasPeriodAtEnd(name))
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
            if (name[name.Length - 1] == '.')
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

        private void DisplayStasticalData(string[] peopleBalances)
        {
            var textTable = new TextTable();
            var balanceStats = new BalanceStats();

            // Using FindHighestBalanceEver, print the statistical output using Text Table with padding 3.
            Console.WriteLine(textTable.Build(balanceStats.FindHighestBalanceEver(peopleBalances), 3));

            // Using FindPersonWithBiggestLoss, print the statistical output using Text Table with padding 3.
            Console.WriteLine(textTable.Build(balanceStats.FindPersonWithBiggestLoss(peopleBalances), 3));

            // Using FindRichestPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(textTable.Build(balanceStats.FindRichestPerson(peopleBalances), 3));

            // Using FindMostPoorPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(textTable.Build(balanceStats.FindMostPoorPerson(peopleBalances), 3));
        }
    }
}
