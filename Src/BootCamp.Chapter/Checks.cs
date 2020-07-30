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
        const string arrayIsEmpty = "N/A.";

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return arrayIsEmpty;
            }

            List<PersonWithBalances> people = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestBalanceEver = float.MinValue;

            foreach (var personBalances in people)
            {
                var balance = personBalances.GetHighestBalance();
                if (balance > biggestBalanceEver)
                {
                    names.Clear();
                    biggestBalanceEver = balance;
                    names.Add(personBalances.GetName());
                }
                if (Math.Round((decimal)balance, 2) == (Math.Round((decimal)biggestBalanceEver, 2)))
                {
                    names.Add(personBalances.GetName());
                }

            }
            return $"{BuildNamesString(names)} had the most money ever. ¤{biggestBalanceEver}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return arrayIsEmpty;
            }

            List<PersonWithBalances> person = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLostEver = float.MaxValue;

            foreach (var personBalances in person)
            {
                var personLoss = personBalances.GetBiggestLoss();
                if (personLoss.Item1 == false)
                {
                    continue;
                }
                if (personLoss.Item2 < biggestLostEver)
                {
                    names.Clear();
                    biggestLostEver = personLoss.Item2;
                    names.Add(personBalances.GetName());
                    continue;
                }
                if (Math.Round((decimal)personLoss.Item2, 2) == (Math.Round((decimal)biggestLostEver, 2)))
                {
                    names.Add(personBalances.GetName());
                }

            }

            if (names.Count == 0)
            {
                return arrayIsEmpty;
            }
            return $"{BuildNamesString(names)} lost the most money. {BuildCurrancy(biggestLostEver)}.";
        }
        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return arrayIsEmpty;
            }

            List<PersonWithBalances> people = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLastBalance = float.MinValue;

            foreach (var personBalances in people)
            {
                if (personBalances.GetCurrentBalance() > biggestLastBalance)
                {
                    names.Clear();
                    biggestLastBalance = personBalances.GetCurrentBalance();
                    names.Add(personBalances.GetName());
                }
                else if (personBalances.GetCurrentBalance() == biggestLastBalance)
                {
                    names.Add(personBalances.GetName());
                }

            }

            string peopleString = BuildNamesString(names);
            if (names.Count > 1)
            {
                return $"{peopleString} are the richest people. {BuildCurrancy(biggestLastBalance)}.";
            }
            return $"{peopleString} is the richest person. {BuildCurrancy(biggestLastBalance)}.";
        }


        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return arrayIsEmpty;
            }

            List<PersonWithBalances> people = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var lowestBalanceEver = float.MaxValue;

            foreach (var personBalances in people)
            {
                if (personBalances.GetCurrentBalance() < lowestBalanceEver)
                {
                    names.Clear();
                    lowestBalanceEver = personBalances.GetCurrentBalance();
                    names.Add(personBalances.GetName());
                }
                else if (personBalances.GetCurrentBalance() == lowestBalanceEver)
                {
                    names.Add(personBalances.GetName());
                }

            }

            if (names.Count > 1)
            {
                return $"{BuildNamesString(names)} have the least money. {BuildCurrancy(lowestBalanceEver)}.";
            }

            return $"{BuildNamesString(names)} has the least money. {BuildCurrancy(lowestBalanceEver)}.";
        }


        public static List<PersonWithBalances> ArrayOfPeople(string[] peopleAndBalances)
        {
            List<PersonWithBalances> people = new List<PersonWithBalances>();

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

                    var personBalances = splitString.Skip(1).Select(v =>
                    {
                        float balance;
                        var isNumber = float.TryParse(v.Replace("£", ""), out balance);
                        if (!isNumber)
                        {
                            throw new ArgumentException("Bad balance");
                        }
                        return balance;
                    });

                    var person = new PersonWithBalances(splitString[0], personBalances.ToArray());
                    people.Add(person);

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
        public static string Build(string message, int padding)
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



        public static void Clean(string dirtyFile, string cleanedFile)
        {
            if (string.IsNullOrEmpty(dirtyFile) || string.IsNullOrEmpty(cleanedFile))
            {
                throw new ArgumentException("File can not be null or empty");
            }

            var insideACorruptedFile = File.ReadAllText(dirtyFile);

            if (string.IsNullOrEmpty(insideACorruptedFile))
            {
                File.WriteAllText(cleanedFile, insideACorruptedFile);
                return;
            }

            insideACorruptedFile = insideACorruptedFile.Replace("_", "");
            File.WriteAllText(cleanedFile, insideACorruptedFile);

            try
            {
                var insideAFile = File.ReadAllText(cleanedFile);
                string[] arrayString = insideAFile.Split(Environment.NewLine);
                var people = ArrayOfPeople(arrayString);

            }
            catch (Exception exc)
            {
                throw new InvalidBalancesException("Invalid name or balance", exc);
            }
        }
    }
}







