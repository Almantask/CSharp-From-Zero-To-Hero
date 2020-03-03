using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private const string NotAvailable = "N/A.";
        private const decimal EPSILON = 0.00001m;

        public static string FindHighestBalanceEver(string [] peopleAndBalances)
        {
            var people = TransformToPersonType(peopleAndBalances);

            return FindHighestBalanceEver(people);
        }

        private static Person[] TransformToPersonType(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return null;
            }

            var people = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var splitBalances = peopleAndBalances[i].Split(",");

                var person = new Person();
                person.SetName(splitBalances[0]);

                var balances = new decimal[splitBalances.Length - 1];
                for (int j = 0; j < splitBalances.Length - 1; j++)
                {
                    balances[j] = Convert.ToDecimal(splitBalances[j + 1]);
                }

                person.SetBalances(balances);
                people[i] = person;
            }

            return people;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var largestHistoricBalance = GetLargestHistoricBalance(people);
            var largestHistoricBalanceNames = GetLargestHistoricBalanceNames(people, largestHistoricBalance);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var largestHistoricBalanceNoComma = RemoveComma($"{largestHistoricBalance:C0}");
            return $"{FixPlural(largestHistoricBalanceNames)} had the most money ever. {largestHistoricBalanceNoComma}.";
        }


        private static string GetLargestHistoricBalanceNames(Person[] people, decimal largestHistoricBalance)
        {
            var names = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (hasLargestHistoricBalance(people[i].GetBalances(), largestHistoricBalance))
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName()); //Builds list of names with highest historical balance
                }
            }

            return names.ToString();
        }

        private static Person[] Keep_GetLargestCurrentBalancePeople(Person[] people, decimal largestHistoricBalance)
        {
            var names = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (hasLargestHistoricBalance(people[i].GetBalances(), largestHistoricBalance))
                {
                    var person = new Person();
                    person.SetName(people[i].GetName());

                    var balances = new decimal[1];
                    balances[0] = people[i].GetCurrentBalance();
                    person.SetBalances(balances);

                    people[i] = person;
                }
            }

            return people;
        }

        private static bool hasLargestHistoricBalance(decimal[] balances, decimal largestHistoricBalance)
        {
            for (int i = 0; i < balances.Length; i++)
            {
                if (balances[i] == largestHistoricBalance)
                {
                    return true;
                }
            }

            return false;
        }

        private static decimal GetLargestHistoricBalance(Person[] people)
        {
            var maxBalance = decimal.MinValue;

            for (int i = 0; i < people.Length; i++)
            {
                var balance = GetLargestHistoricBalanceForPerson(people[i].GetBalances());

                if (balance > maxBalance)
                {
                    maxBalance = balance;
                }
            }

            return maxBalance;
        }

        private static decimal GetLargestHistoricBalanceForPerson(decimal[] balances)
        {
            var maxBalance = decimal.MinValue;

            for (int i = 0; i < balances.Length; i++)
            {
                if (balances[i] > maxBalance)
                {
                    maxBalance = balances[i];
                }
            }

            return maxBalance;
        }

        private static decimal GetLargestCurrentBalance(Person[] people)
        {
            var maxBalance = 0m;

            for (var i = 0; i < people.Length; i++)
            {
                var currentBalance = people[i].GetCurrentBalance();

                if (currentBalance > maxBalance)
                {
                    maxBalance = currentBalance;
                }
            }

            return maxBalance;
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var people = TransformToPersonType(peopleAndBalances);

            return FindPersonWithBiggestLoss(people);
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var isBiggestLossValid = TryGetBiggestLoss(people, out var biggestLoss);

            if (!isBiggestLossValid)
            {
                return NotAvailable;
            }

            var biggestLossNames = GetBiggestLossNames(people, biggestLoss);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            return $"{biggestLossNames} lost the most money. -{biggestLoss:C0}.";
        }

        private static bool TryGetBiggestLoss(Person[] people, out decimal biggestLoss)
        {
            biggestLoss = decimal.MinValue;

            for (int i = 0; i < people.Length; i++)
            {
                var isBiggestLossForPersonValid = TryGetBiggestLossForPerson(people[i].GetBalances(), out var biggestLossForPerson);

                if (!isBiggestLossForPersonValid)
                {
                    biggestLoss = 0;
                    return false;
                }

                if (biggestLossForPerson > biggestLoss)
                {
                    biggestLoss = biggestLossForPerson;
                }
            }

            return true;
        }

        private static bool TryGetBiggestLossForPerson(decimal[] balances, out decimal biggestLoss)
        {
            biggestLoss = decimal.MinValue;

            if (balances.Length < 2)
            {
                biggestLoss = 0;
                return false;
            }

            for (var i = 0; i < balances.Length; i++)
            {
                for (var j = i + 1; j < balances.Length; j++)
                {
                    var loss = balances[i] - balances[j];

                    if (loss > biggestLoss)
                    {
                        biggestLoss = loss;
                    }
                }
            }

            return true;
        }
        
        private static string GetBiggestLossNames(Person[] people, decimal biggestLoss)
        {
            var names = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                var hasBiggestLoss = HasBiggestLoss(people[i].GetBalances(), biggestLoss);

                if (hasBiggestLoss)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
        }

        private static bool HasBiggestLoss(decimal[] balances, decimal biggestLoss)
        {
            for (var i = 0; i < balances.Length; i++)
            {
                for (var j = i + 1; j < balances.Length; j++)
                {
                    if (isNumberEqual(balances[i] - balances[j], biggestLoss))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool isNumberEqual(decimal num1, decimal num2)
        {
            if (Math.Abs(num1 - num2) < EPSILON)
            {
                return true;
            }
            return false;
        }

        private static string GetBiggestLossName(Person people, decimal biggestLoss)
        {
            var balances = people.GetBalances();
            var length = people.GetBalances().Length;

            for (var i = 1; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    var loss = Math.Abs(balances[i] - balances[j]);

                    if (loss == biggestLoss)
                    {
                        return people.GetName();
                    }
                }
            }

            return null;
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            var people = TransformToPersonType(peopleAndBalances);

            return FindRichestPerson(people);
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var largestCurrentBalance = GetLargestCurrentBalance(people);
            var largestCurrentBalancesNames = GetLargestCurrentNames(people, largestCurrentBalance);



            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var word1 = largestCurrentBalancesNames.ToString().Contains(", ") ? "are" : "is";
            var word2 = largestCurrentBalancesNames.ToString().Contains(", ") ? "people" : "person";
            var largestCurrentBalanceNoComma = RemoveComma($"{largestCurrentBalance:C0}");
            return $"{FixPlural(largestCurrentBalancesNames)} {word1} the richest {word2}. {largestCurrentBalanceNoComma}.";
        }

        private static string GetLargestCurrentNames(Person[] people, decimal largestCurrentBalance)
        {
            var names = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() == largestCurrentBalance)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
        }

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            var people = TransformToPersonType(peopleAndBalances);

            return FindMostPoorPerson(people);
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var smallestCurrentBalance = GetSmallestCurrentBalance(people);
            var smallestCurrentBalancesNames = GetSmallestCurrentNames(people, smallestCurrentBalance);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var minBalanceNoComma = RemoveComma($"{smallestCurrentBalance:C0}").Replace("(", "-").Replace(")", "");
            var word = smallestCurrentBalancesNames.ToString().Contains(", ") ? "have" : "has";
            return $"{FixPlural(smallestCurrentBalancesNames.ToString())} {word} the least money. {minBalanceNoComma}.";
        }



        private static decimal GetSmallestCurrentBalance(Person[] people)
        {
            var minBalance = decimal.MaxValue;
            var name = new StringBuilder();

            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() < minBalance)
                {
                    minBalance = people[i].GetCurrentBalance();
                }
            }

            return minBalance;
        }

        private static string GetSmallestCurrentNames(Person[] people, decimal smallestCurrentBalance)
        {
            var names = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() == smallestCurrentBalance)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
        }

        private static void GetPoorest(ref StringBuilder mostPoorPerson, ref decimal minBalance, string[] peopleBalances, decimal balance)
        {
            if (balance <= minBalance)
            {
                if (balance < minBalance)
                {
                    mostPoorPerson = new StringBuilder();
                }

                if (mostPoorPerson.Length != 0)
                {
                    mostPoorPerson.Append(", ");
                }

                mostPoorPerson.Append(peopleBalances[0]);
                minBalance = balance;
            }
        }

        private static string FixPlural(string name)
        {
            var lastComma = name.LastIndexOf(", ", StringComparison.InvariantCulture);

            if (lastComma > 0)
            {
                name = name.Remove(lastComma, 2).Insert(lastComma, " and ");
            }

            return name;
        }

        private static bool IsArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }

            return false;
        }

        private static string RemoveComma(string data)
        {
            return data.Replace(",", "");
        }
    }
}
