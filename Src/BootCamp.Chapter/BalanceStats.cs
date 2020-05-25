using BootCamp.Chapter.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsStringArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            //Convert to Person-Object
            Person[] people = DataToObject(peopleAndBalances);

            //Find highest value and number of people with same balance
            float highestValue = 0;
            int numPeopleHighBalance = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                for (int b = 0; b < p.Balances.Length; b++)
                {
                    if (p.Balances[b] > highestValue)
                    {
                        highestValue = p.Balances[b];
                        numPeopleHighBalance = 1;
                    }
                    else if (p.Balances[b] == highestValue)
                    {
                        numPeopleHighBalance++;
                    }
                }
            }

            //Add to Array of people with highest balance
            Person[] personHighestBalance = new Person[numPeopleHighBalance];
            int personHighestBalanceIndex = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                for (int b = 0; b < p.Balances.Length; b++)
                {
                    if (p.Balances[b] == highestValue)
                    {
                        personHighestBalance[personHighestBalanceIndex] = p;
                        personHighestBalanceIndex++;
                    }
                }
            }

            return $"{GenerateNameString(personHighestBalance)} had the most money ever. {ConvertBalanceToText(highestValue)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsStringArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            Person[] people = DataToObject(peopleAndBalances);

            //Find highest loss and number of people with the same amount
            Single highestLoss = 0;
            int numPeopleHighLoss = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Single highestBalance = 0;
                for (int b = 0; b < people[i].Balances.Length; b++)
                {
                    if (people[i].Balances[b] > highestBalance)
                    {
                        highestBalance = people[i].Balances[b];
                    }
                }

                if (IsFloatArrayNullOrEmpty(people[i].Balances) != true)
                {
                    var currentBalance = people[i].Balances[^1];
                    var loss = highestBalance - currentBalance;

                    if (loss > highestLoss * -1)
                    {
                        highestLoss = loss * -1;
                        numPeopleHighLoss = 1;
                    }
                    else if (loss == highestLoss * -1)
                    {
                        numPeopleHighLoss++;
                    }
                }
            }

            if (highestLoss == 0)
                return "N/A.";

            //Add to array of people with the same loss
            Person[] highLossPersonArray = new Person[numPeopleHighLoss];
            int p = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Single highestBalance = 0;
                for (int b = 0; b < people[i].Balances.Length; b++)
                {
                    if (people[i].Balances[b] > highestBalance)
                    {
                        highestBalance = people[i].Balances[b];
                    }
                }

                if (IsFloatArrayNullOrEmpty(people[i].Balances) != true)
                {
                    var loss = highestBalance - people[i].Balances[^1];

                    if (loss == highestLoss * -1)
                    {
                        highLossPersonArray[p] = people[i];
                        p++;
                    }
                }
            }

            return $"{GenerateNameString(highLossPersonArray)} lost the most money. {ConvertBalanceToText(highestLoss)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsStringArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            Person[] people = DataToObject(peopleAndBalances);

            //Find highest value and number of people with the same value
            float highestValue = 0;
            int numRichPeople = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                if (i == 0)
                {
                    highestValue = p.Balances[^1];
                    numRichPeople = 1;
                }
                else if (IsFloatArrayNullOrEmpty(people[i].Balances) != true && p.Balances[^1] > highestValue)
                {
                    highestValue = p.Balances[^1];
                    numRichPeople = 1;
                }
                else if (IsFloatArrayNullOrEmpty(people[i].Balances) != true && p.Balances[^1] == highestValue)
                {
                    numRichPeople++;
                }
            }

            //Add to Array of people with highest balance
            Person[] richPeople = new Person[numRichPeople];
            int richPeopleIndex = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                if (IsFloatArrayNullOrEmpty(p.Balances) != true && p.Balances[^1] == highestValue)
                {
                    richPeople[richPeopleIndex] = p;
                    richPeopleIndex++;
                }
            }

            if (richPeople.Length > 1)
                return $"{GenerateNameString(richPeople)} are the richest people. {ConvertBalanceToText(highestValue)}.";
            else
                return $"{GenerateNameString(richPeople)} is the richest person. {ConvertBalanceToText(highestValue)}.";


        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsStringArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            Person[] people = DataToObject(peopleAndBalances);

            //Find lowest value
            float lowesValue = 0;
            int numPoorPeople = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                if (i == 0)
                {
                    lowesValue = p.Balances[^1];
                    numPoorPeople = 1;
                }
                else if (IsFloatArrayNullOrEmpty(p.Balances) != true && p.Balances[^1] < lowesValue)
                {
                    lowesValue = p.Balances[^1];
                    numPoorPeople = 1;
                }
                else if (IsFloatArrayNullOrEmpty(p.Balances) != true && p.Balances[^1] == lowesValue)
                {
                    numPoorPeople++;
                }
            }

            //Add to Array of people with highest balance
            Person[] poorPeople = new Person[numPoorPeople];
            int poorPeopleIndex = 0;
            for (int i = 0; i < people.Length; i++)
            {
                Person p = people[i];
                if (IsFloatArrayNullOrEmpty(p.Balances) != true && p.Balances[^1] == lowesValue)
                {
                    poorPeople[poorPeopleIndex] = p;
                    poorPeopleIndex++;
                }
            }

            if (poorPeople.Length > 1)
                return $"{GenerateNameString(poorPeople)} have the least money. {ConvertBalanceToText(lowesValue)}.";
            else
                return $"{GenerateNameString(poorPeople)} has the least money. {ConvertBalanceToText(lowesValue)}.";
        }

        /// <summary>
        /// Convert string array to List of Person objects
        /// </summary>
        /// <param name="input">array of people and balances</param>
        /// <returns>List of Person objects</returns>
        public static Person[] DataToObject(string[] input)
        {
            Person[] people = new Person[input.Length];
            for (int l = 0; l < input.Length; l++)
            {
                var personArray = input[l].Split(',').ToArray();
                Single[] Balances = new Single[personArray.Length - 1];
                Person person = new Person
                {
                    Name = personArray[0]
                };
                int j = 0;
                for (int i = 1; i < personArray.Count(); i++, j++)
                {
                    if (personArray[i].Contains('£'))
                    {
                        Single.TryParse(personArray[i], NumberStyles.Currency, CultureInfo.GetCultureInfoByIetfLanguageTag("en-GB"), out float singleValue);
                        Balances[j] = singleValue;
                    }
                    else
                    {
                        Single.TryParse(personArray[i], NumberStyles.Currency, CultureInfo.InvariantCulture, out float singleValue);
                        Balances[j] = singleValue;
                    }
                }
                person.Balances = Balances;
                people[l] = person;
            }
            return people;
        }

        /// <summary>
        /// Generate formated list for output
        /// </summary>
        /// <param name="people">list of people</param>
        /// <returns>formated names-list</returns>
        public static string GenerateNameString(Person[] people)
        {
            StringBuilder peopleString = new StringBuilder();
            var firstPerson = people.FirstOrDefault();
            var lastPerson = people.LastOrDefault();
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] != firstPerson && people[i] != lastPerson)
                    peopleString.Append(", ");
                else if (people[i] == lastPerson && people.Length > 1)
                    peopleString.Append(" and ");
                peopleString.Append(people[i].Name);

            }

            return peopleString.ToString();
        }

        /// <summary>
        /// Check if string array is null or empty
        /// </summary>
        /// <param name="array">string array</param>
        /// <returns>is array null or empty</returns>
        public static bool IsStringArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check if float array is null or empty
        /// </summary>
        /// <param name="array">float array</param>
        /// <returns>is array null or empty</returns>
        public static bool IsFloatArrayNullOrEmpty(float[] array)
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Convert numeric value to "balance text"
        /// </summary>
        /// <param name="balance">numeric value</param>
        /// <returns>balance text</returns>
        public static string ConvertBalanceToText(Single balance)
        {
            if (balance < 0)
                return $"-¤{balance.ToString().Remove(0, 1)}";
            else
                return $"¤{balance}";
        }
    }
}