using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        private static string PeopleToNameList(List<Person> People)
        {
            if (People.Count <= 1) return People.First().GetName();
            
            string list = People.First().GetName();
            foreach (var person in People.SkipLast(1).Skip(1))
            {
                list += $", {person.GetName()}";
            }
            list += $" and {People.Last().GetName()}";
            
            return list;
        }
        
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            List<Person> poorestPeople;
            try
            {
                 poorestPeople= new Database(peopleAndBalances).getPoorestPeople();
            }
            catch (Exception)
            {
                return "N/A.";
            }
            var balance = poorestPeople.First().GetCurrentBalance();
            
            string haveHas = (poorestPeople.Count > 1) ? "have" : "has";

            var negative = "";
            if (balance < 0)
            {
                negative = "-";
                balance *= -1;
            }
            return $"{PeopleToNameList(poorestPeople)} {haveHas} the least money. {negative}¤{balance}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            List<Person> richestPeople;
            try
            {
                richestPeople= new Database(peopleAndBalances).getRichestPeople();
            }
            catch (Exception)
            {
                return "N/A.";
            }
            var balance = richestPeople.First().GetCurrentBalance();
            
            string isAre = (richestPeople.Count > 1) ? "are" : "is";
            string personPeople = (richestPeople.Count > 1) ? "people" : "person";

            return $"{PeopleToNameList(richestPeople)} {isAre} the richest {personPeople}. ¤{balance}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            Person personWithBiggestLoss;
            int amountLoss;
            try
            {
                var tuple = new Database(peopleAndBalances).getPersonWithBiggestLoss();
                personWithBiggestLoss = tuple.Item1;
                amountLoss = tuple.Item2;
            }
            catch (Exception)
            {
                return "N/A.";
            }
            
            return $"{personWithBiggestLoss.GetName()} lost the most money. -¤{amountLoss}.";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            List<Person> richestPeopleEver;
            try
            {
                richestPeopleEver= new Database(peopleAndBalances).getPersonWithHighestHistoricBalance();
            }
            catch (Exception)
            {
                return "N/A.";
            }
            var balance = richestPeopleEver.First().GetHighestBalance();
            
            string personPeople = (richestPeopleEver.Count > 1) ? "people" : "person";

            return $"{PeopleToNameList(richestPeopleEver)} had the most money ever. ¤{balance}.";
        }

        public static string Build(string message, in int padding)
        {
            const string Side = "|";
            const char Top = '-';
            const string Corner = "+";
            
            if (string.IsNullOrEmpty(message)) return "";
            //Creates message part of table
            message = message.Replace("\r", "");
            var msgArray = message.Split("\n");
            var longestLineLength = msgArray.OrderByDescending(s => s.Length).First().Length;
            var firstLine = msgArray[0].PadLeft(longestLineLength + padding - Convert.ToInt32(Math.Ceiling((longestLineLength - msgArray[0].Length) / 2.0))).PadRight(longestLineLength + padding * 2);
            var messageTable = $"{Side}{firstLine}{Side}";

            foreach (var line in msgArray[1..])
            {
                var linePadding = line.PadLeft(longestLineLength + padding - Convert.ToInt32(Math.Ceiling((longestLineLength - line.Length) / 2.0))).PadRight(longestLineLength + padding * 2);
                messageTable += $"\r\n{Side}{linePadding}{Side}";
            }
			
			
            //Creates the top and bottom part of the table
            var width = longestLineLength + padding * 2;
            var horizontalLine = new string(Top, width);
            var topBottomTable = $"{Corner}{horizontalLine}{Corner}";
			
			
            //Creates empty line part of the table
            var emptySpace = new string(' ', width);
            var emptyLineTable = $"{Side}{emptySpace}{Side}\r\n";


            var table = $"{topBottomTable}\r\n"; // Top layer
			
            for (var i = 0; i < padding; i++) // Empty layers
            {
                table += emptyLineTable;
            }
			
            table += $"{messageTable}\r\n"; // Message layer
			
            for (var i = 0; i < padding; i++) // Empty layers
            {
                table += emptyLineTable;
            }

            table += $"{topBottomTable}\r\n"; // Bottom layer
			
            return table;
        }

        public static void Clean(string file, string outputFile)
        {
            var dirty = File.ReadAllText(file);
            if (dirty == "")
            {
                File.WriteAllText(outputFile, "");
                return;
            }

            if (outputFile == "" || outputFile == null) throw new ArgumentException();

            var clean = dirty.Replace("_", "");
            
            var split = clean.Split(",");
            if (!split[0].All(x => char.IsLetter(x) || x == ' ')) throw new InvalidBalancesException();
            //if (!int.TryParse(split[1], out _)) throw new InvalidBalancesException("This is not a number", new Exception());
            if (split[1].Any(Char.IsLetter)) throw new InvalidBalancesException();
            
            File.WriteAllText(outputFile, clean);
        }
    }
}
