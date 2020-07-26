using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var lowestBalanceEver = float.MaxValue;

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (personBalances.Value.Last() < lowestBalanceEver)
                    {
                        names.Clear();
                        lowestBalanceEver = balance;
                        names.Add(personBalances.Key);
                    }
                    else if (personBalances.Value.Last() == lowestBalanceEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            if (names.Count > 1)
            {
                return $"{BuildNamesString(names)} have the least money. {BuildCurrancy(lowestBalanceEver)}.";
            }

            return $"{BuildNamesString(names)} has the least money. {BuildCurrancy(lowestBalanceEver)}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLastBalance = float.MinValue;

            foreach (var personBalances in peopleBalances)
            {
                {
                    if (personBalances.Value.Last() > biggestLastBalance)
                    {
                        names.Clear();
                        biggestLastBalance = personBalances.Value.Last();
                        names.Add(personBalances.Key);
                    }
                    else if (personBalances.Value.Last() == biggestLastBalance)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            string peopleString = BuildNamesString(names);
            if (names.Count > 1)
            {
                return $"{peopleString} are the richest people. {BuildCurrancy(biggestLastBalance)}.";
            }
            return $"{peopleString} is the richest person. {BuildCurrancy(biggestLastBalance)}.";

        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLostEver = float.MaxValue;

            foreach (var personBalances in peopleBalances)
            {
                for (int i = 0; i < personBalances.Value.Count - 1; i++)
                {
                    var balanceDifferences = personBalances.Value[i + 1] - personBalances.Value[i];
                    if (balanceDifferences < biggestLostEver)
                    {
                        names.Clear();
                        biggestLostEver = balanceDifferences;
                        names.Add(personBalances.Key);
                        continue;
                    }
                    if (Math.Round((decimal)balanceDifferences, 2) == (Math.Round((decimal)biggestLostEver, 2)))
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            if (names.Count == 0)
            {
                return "N/A.";
            }
            return $"{BuildNamesString(names)} lost the most money. {BuildCurrancy(biggestLostEver)}.";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestBalanceEver = float.MinValue;

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (balance > biggestBalanceEver)
                    {
                        names.Clear();
                        biggestBalanceEver = balance;
                        names.Add(personBalances.Key);
                    }
                    if (Math.Round((decimal)balance, 2) == (Math.Round((decimal)biggestBalanceEver, 2)))
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }
            return $"{BuildNamesString(names)} had the most money ever. ¤{biggestBalanceEver}.";
        }

        public static string Build(string message, in int padding)
        {
            string newMessage = message.Replace(System.Environment.NewLine, " ");

            if (String.IsNullOrEmpty(message))
            {
                return message;
            }

            StringBuilder buildMessage = new StringBuilder();
            buildMessage.AppendLine(CreateBorder(FindLongestWordLength(newMessage), padding));
            buildMessage.Append(CreateBody(newMessage, padding, FindLongestWordLength(newMessage)));
            buildMessage.AppendLine(CreateBorder(FindLongestWordLength(newMessage), padding));

            return buildMessage.ToString();
        }
        public static string CreateBody(string message, int padding, int messageLength)
        {
            var messageBody = new StringBuilder();

            if (padding > 0)
            {
                messageBody.Append(CreateEmptyLines(message, padding, messageLength));
                messageBody.Append(CreateMessage(message, padding, messageLength));
                messageBody.Append(CreateEmptyLines(message, padding, messageLength));
            }
            else
            {
                messageBody.Append(CreateMessage(message, padding, messageLength));
            }

            return messageBody.ToString();
        }
        public static string CreateBorder(int messageLength, int padding)
        {
            var topAndBottomBorder = new StringBuilder();
            topAndBottomBorder.Append('+').Append('-', padding).Append('-', messageLength).Append('-', padding).Append('+');
            return topAndBottomBorder.ToString();
        }

        public static string CreateEmptyLines(string message, int padding, int messageLength)
        {
            var emptyLines = new StringBuilder();

            for (int j = 0; j < padding; j++)
            {
                emptyLines.Append("|").Append(' ', padding).Append(' ', messageLength).Append(' ', padding).AppendLine("|");

            }
            return emptyLines.ToString();
        }

        public static string CreateMessage(string message, int padding, int messageLength)
        {
            var messageBody = new StringBuilder();
            string[] words = message.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var emtySpace = messageLength - words[i].Length;
                messageBody.Append("|").Append(' ', padding).Append(words[i]).Append(' ', emtySpace).Append(' ', padding).AppendLine("|");
            }
            return messageBody.ToString();
        }

        public static int FindLongestWordLength(string message)
        {
            string[] words = message.Split(new[] { " " }, StringSplitOptions.None);
            int length = 0;
            foreach (String s in words)
            {
                if (s.Length > length)
                {
                    length = s.Length;
                }
            }
            return length;
        }
    

        public static void Clean(string file, string outputFile)
        {
            if (string.IsNullOrEmpty(file) || string.IsNullOrEmpty(outputFile))
            {
                throw new ArgumentException("File can not be null or empty");
            }

            var insideACorruptedFile = File.ReadAllText(file);

            if (string.IsNullOrEmpty(insideACorruptedFile))
            {
                File.WriteAllText(outputFile, insideACorruptedFile);
                return;
            }

            insideACorruptedFile = insideACorruptedFile.Replace("_", "");
            File.WriteAllText(outputFile, insideACorruptedFile);

            try
            {
                var insideAFile = File.ReadAllText(outputFile);
                string[] arrayString = insideAFile.Split(Environment.NewLine);
                var people = ArrayOfPeople(arrayString);

            }
            catch (Exception)
            {
                throw new InvalidBalancesException();
            }

        }


        public static Dictionary<string, List<float>> ArrayOfPeople(string[] peopleAndBalances)
            {
                Dictionary<string, List<float>> people = new Dictionary<string, List<float>>();


                for (int i = 0; i < peopleAndBalances.Length; i++)
                {
                    string[] splitString = peopleAndBalances[i].Split(",");
                    var name = splitString[0];
                    if (!Regex.IsMatch(name, @"^[\p{L} '\-]+$"))
                    {
                        throw new ArgumentException("Invalid name ");
                    }
                    if (splitString.Length > 1)
                    {
                        people.Add(name, new List<float>());

                        for (int j = 1; j < splitString.Length; j++)
                        {
                            float balances;

                            var isNumber = float.TryParse(splitString[j].Replace("£", ""), out balances);

                            if (!isNumber)
                            {
                                throw new ArgumentException("Bad balance");

                            }

                            people[name].Add(balances);
                        }
                    }
                }
                return people;
            }

            public static string BuildCurrancy(float currancy)
            {
                if (currancy < 0)
                {
                    return $"-¤{Math.Abs(currancy)}";
                }
                return $"¤{currancy}";
            }

            public static string BuildNamesString(List<string> names)
            {
                var uniqeNames = names.Distinct().ToList();
                StringBuilder peopleString = new StringBuilder();
                for (int i = 0; i < uniqeNames.Count; i++)
                {
                    if (i == 0)
                    {
                        peopleString.Append(uniqeNames[i]);
                        continue;
                    }
                    if (i == uniqeNames.Count - 1)
                    {
                        peopleString.Append(" and ").Append(uniqeNames[i]);
                        continue;
                    }
                    peopleString.Append(", ").Append(uniqeNames[i]);
                }
                return peopleString.ToString();
            }
        }
    }


