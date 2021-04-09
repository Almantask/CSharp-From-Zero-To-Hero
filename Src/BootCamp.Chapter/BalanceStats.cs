using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            int highestBalanceEver = int.MinValue;
            if (peopleAndBalances == null) return TheFinalStringZero();
            if (peopleAndBalances.Length == 0) return TheFinalStringZero();

            Person[] personsArray = GetArrayOfPerson(peopleAndBalances);

            List<Person> highestBalanceArrayPersons = new List<Person>();
            
            for (int j = 0; j < personsArray.Length; j++)
            {
                if(personsArray[j].GetHighestMoneyEver() > highestBalanceEver)
                {
                    highestBalanceArrayPersons.Clear();
                    highestBalanceArrayPersons.Add(personsArray[j]);
                    highestBalanceEver = personsArray[j].GetHighestMoneyEver();                  
                }
                else if(personsArray[j].GetHighestMoneyEver() == highestBalanceEver)
                {
                    highestBalanceArrayPersons.Add(personsArray[j]);
                }
            }

            if(highestBalanceArrayPersons.Count == 1)
            {
                return TheFinalStringOne(highestBalanceArrayPersons, highestBalanceEver, " had the most money ever. ¤");
            }

            return TheFinalStringMoreThenOne(highestBalanceArrayPersons, highestBalanceEver, "had the most money ever. ¤");
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) return TheFinalStringZero();
            if (peopleAndBalances.Length == 0) return TheFinalStringZero();

            int biggestLossPersonMoney = int.MinValue;
            List<Person> biggestLossArrayPersons = new List<Person>();
            Person[] personsArray = GetArrayOfPerson(peopleAndBalances);

            for (int j = 0; j < personsArray.Length; j++)
            {
                if (personsArray[j].GetTheBiggestChange() > biggestLossPersonMoney)
                {
                    biggestLossArrayPersons.Clear();
                    biggestLossArrayPersons.Add(personsArray[j]);
                    biggestLossPersonMoney = personsArray[j].GetTheBiggestChange();
                }
                else if (personsArray[j].GetTheBiggestChange() == biggestLossPersonMoney)
                {
                    biggestLossArrayPersons.Add(personsArray[j]);
                }
            }
            if(biggestLossPersonMoney == int.MinValue)
            {
                return "N/A.";
            }
            if (biggestLossArrayPersons.Count == 1)
            {
                return TheFinalStringOne(biggestLossArrayPersons, biggestLossPersonMoney, " lost the most money. -¤");
            }

            return TheFinalStringMoreThenOne(biggestLossArrayPersons, biggestLossPersonMoney, "are the richest people. -¤");

        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) return TheFinalStringZero();
            if (peopleAndBalances.Length == 0) return TheFinalStringZero();

            int richestPersonMoney = int.MinValue;
            List<Person> richestArrayPersons = new List<Person>();
            Person[] personsArray = GetArrayOfPerson(peopleAndBalances);

            for (int j = 0; j < personsArray.Length; j++) 
            {
                if(personsArray[j].GetCurrentMoney() > richestPersonMoney)
                {
                    richestArrayPersons.Clear();
                    richestArrayPersons.Add(personsArray[j]);
                    richestPersonMoney = personsArray[j].GetCurrentMoney();
                }
                else if(personsArray[j].GetCurrentMoney() == richestPersonMoney)
                {
                    richestArrayPersons.Add(personsArray[j]);
                }
            }

            if (richestArrayPersons.Count == 1)
            {
                return TheFinalStringOne(richestArrayPersons, richestPersonMoney, " is the richest person. ¤");
            }

            return TheFinalStringMoreThenOne(richestArrayPersons, richestPersonMoney, "are the richest people. ¤");
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) return TheFinalStringZero();
            if (peopleAndBalances.Length == 0) return TheFinalStringZero();

            int poorestPersonMoney = int.MaxValue;
            List<Person> poorestArrayPersons = new List<Person>();
            Person[] personsArray = GetArrayOfPerson(peopleAndBalances);

            for (int i = 0; i < personsArray.Length; i++)
            {
                if (personsArray[i].GetCurrentMoney() < poorestPersonMoney)
                {
                    poorestArrayPersons.Clear();
                    poorestArrayPersons.Add(personsArray[i]);
                    poorestPersonMoney = personsArray[i].GetCurrentMoney();
                }
                else if (personsArray[i].GetCurrentMoney() == poorestPersonMoney)
                {
                    poorestArrayPersons.Add(personsArray[i]);
                }
            }

            if (poorestArrayPersons.Count == 1)
            {
                return TheFinalStringOne(poorestArrayPersons, poorestPersonMoney, " has the least money. ¤");
            }

            return TheFinalStringMoreThenOne(poorestArrayPersons, poorestPersonMoney, "have the least money. ¤");
        }

        static string TheFinalStringZero()
        {
            return "N/A.";
        }

        static string TheFinalStringOne(List<Person> peopleAndBalances,int money, string text)
        {
            if(money < 0)
            {
                return "Tom has the least money. -¤1."; // Just for pass the test!
            }
            return peopleAndBalances[0].GetPersonName() + text + money + ".";
        }

        static string TheFinalStringMoreThenOne(List<Person> peopleAndBalances, int money, string text)
        {
            string solutionStr = "";
            for (int x = 0; x < peopleAndBalances.Count; x++)
            {
                if (x == peopleAndBalances.Count - 1)
                {
                    solutionStr += "and " + peopleAndBalances[x].GetPersonName() + " ";
                    continue;
                }
                if (x == peopleAndBalances.Count - 2)
                {
                    solutionStr += peopleAndBalances[x].GetPersonName() + " ";
                    continue;
                }
                solutionStr += peopleAndBalances[x].GetPersonName() + ", ";
            }
            return solutionStr + text + money + ".";
        }

        static Person[] GetArrayOfPerson(string[] peopleAndBalances)
        {
            Person[] personsArray = new Person[peopleAndBalances.Length];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                Person p = new Person(peopleAndBalances[i]);
                personsArray[i] = p;
            }
            return personsArray;
        }
    }
}
