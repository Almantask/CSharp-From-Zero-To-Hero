using System;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        
        private static string ArrayToList(string[] array)
        {
            string list = array[0];
            if (array.Length <= 1) return list;
            for (var i = 1; i < array.Length - 1; i++)
            {
                list += $", {array[i]}";
            }
            list += $" and {array[^1]}";
            return list;
        }
        
        
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";
            var highestPeople = new string[256];
            var highestPeopleAmount = 0;
            double highestBalance = 0.0;
            foreach (var personHistory in peopleAndBalances)
            {
                var array = personHistory.Split(", ");
                var name = array[0];
                var balanceHistory = array[1..];
                var highest = 0.0;
                
                foreach (var balance in balanceHistory)
                {
                    var parsed = double.TryParse(balance, out double money);
                    if (!parsed) continue;
                    
                    if (money > highest) highest = money;
                }

                if (highest > highestBalance)
                {
                    highestBalance = highest;
                    Array.Clear(highestPeople, 0, highestPeople.Length);
                    highestPeople[0] = name;
                    highestPeopleAmount = 1;
                }
                if (highest == highestBalance)
                {
                    highestPeople[highestPeopleAmount] = name;
                    highestPeopleAmount++;
                }
            }
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            highestPeople = highestPeople.Distinct().ToArray(); //Remove duplicates
            highestPeople = highestPeople.Where(x => !string.IsNullOrEmpty(x)).ToArray(); //Remove nulls
            
            var peopleString = ArrayToList(highestPeople);
            
            var highestBalanceCurrency = $"{highestBalance:C0}";
            return $"{peopleString} had the most money ever. {highestBalanceCurrency.Replace(",","")}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";
            var biggestLossPerson = "";
            var biggestLoss = 0;
            foreach (var personHistory in peopleAndBalances)
            {
                var array = personHistory.Split(", ");
                var name = array[0];
                var balanceHistory = array[1..];
                var personsBiggestLoss = 0;

                for (var i = 0; i < balanceHistory.Length - 1; i++)
                {
                    var parsed = int.TryParse(balanceHistory[i], out var balance);
                    var parsedFuture = int.TryParse(balanceHistory[i + 1], out var futureBalance);
                    if (!(parsed || parsedFuture)) continue;
                    if (balance - futureBalance > biggestLoss) personsBiggestLoss = balance - futureBalance;
                }

                if (personsBiggestLoss <= biggestLoss) continue;
                biggestLoss = personsBiggestLoss;
                biggestLossPerson = name;
            }

            if (biggestLoss == 0) return "N/A.";
            
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            return $"{biggestLossPerson} lost the most money. -{biggestLoss:C0}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";
            var highestPeople = new string[256];
            var highestPeopleAmount = 0;
            var highestBalance = 0;
            foreach (var personHistory in peopleAndBalances)
            {
                var array = personHistory.Split(", ");
                var name = array[0];

                var parsed = int.TryParse(array[^1], out var currentBalance);
                if (!parsed) continue;

                if (currentBalance > highestBalance)
                {
                    highestBalance = currentBalance;
                    Array.Clear(highestPeople, 0, highestPeople.Length);
                    highestPeople[0] = name;
                    highestPeopleAmount = 1;
                }

                if (currentBalance != highestBalance) continue;
                highestPeople[highestPeopleAmount] = name;
                highestPeopleAmount++;
            }
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            highestPeople = highestPeople.Distinct().ToArray(); //Remove duplicates
            highestPeople = highestPeople.Where(x => !string.IsNullOrEmpty(x)).ToArray(); //Remove nulls
            var peopleString = ArrayToList(highestPeople);
            
            var highestBalanceCurrency = $"{highestBalance:C0}";

            var isAre = "is";
            var personPeople = "person";
            if (highestPeople.Length > 1)
            {
                isAre = "are";
                personPeople = "people";
            }
            return $"{peopleString} {isAre} the richest {personPeople}. {highestBalanceCurrency.Replace(",","")}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";
            var lowestPeople = new string[256];
            var lowestPeopleAmount = 0;
            var lowestBalance = 32767;
            foreach (var personHistory in peopleAndBalances)
            {
                var array = personHistory.Split(", ");
                var name = array[0];
                var parsed = int.TryParse(array[^1], out var currentBalance);
                if (!parsed) continue;

                if (currentBalance < lowestBalance)
                {
                    lowestBalance = currentBalance;
                    Array.Clear(lowestPeople, 0, lowestPeople.Length);
                    lowestPeople[0] = name;
                    lowestPeopleAmount = 1;
                }

                if (currentBalance != lowestBalance) continue;
                lowestPeople[lowestPeopleAmount] = name;
                lowestPeopleAmount++;
            }
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            lowestPeople = lowestPeople.Distinct().ToArray(); //Remove duplicates
            lowestPeople = lowestPeople.Where(x => !string.IsNullOrEmpty(x)).ToArray(); //Remove nulls
            var peopleString = ArrayToList(lowestPeople);

            var hasHave = "has";
            var negative = "";
            if (lowestPeople.Length > 1) hasHave = "have";

            if (lowestBalance < 0)
            {
                negative = "-";
                lowestBalance *= -1;
            }
            return $"{peopleString} {hasHave} the least money. {negative}¤{lowestBalance}.";
        }
    }
}
