﻿using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private const string InValidOutput = "N/A.";
        private readonly StringBuilder _persons;
        private readonly decimal _amount;
        public const string culture = "en-GB";

        public BalanceStats(StringBuilder persons, decimal amount)
        {
            _persons = persons;
            _amount = amount;
        }

        public StringBuilder GetPersons()
        {
            return _persons;
        }

        public decimal GetAmount()
        {
            return _amount;
        }

        public static Person[] FindHighestBalanceEver(string[] peopleAndBalances)
        {
            var parsedFile = BalanceParser.Parser(peopleAndBalances);
            return FindHighestBalance(parsedFile);
        }

        public static Person[] FindHighestBalance(Person[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            var persons = new Person[0];
            var highestBalanceEver = decimal.MinValue;

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPerson = balances[i];

                var highestAmountOfPerson = currentPerson.HighestBalance();

                if (highestAmountOfPerson > highestBalanceEver)
                {
                    highestBalanceEver = highestAmountOfPerson;
                    persons = new Person[0];
                }

                if (highestAmountOfPerson >= highestBalanceEver)
                {
                    persons = AddPerson(currentPerson, persons);
                }
            }

            return persons;
        }

        private static Person[] AddPerson(Person person, Person[] persons)
        {
            var newArray = new Person[persons.Length + 1];
            for (int i = 0; i < persons.Length; i++)
            {
                newArray[i] = persons[i];
            }

            newArray[^1] = person;
            return newArray;
        }

        public static Person[] FindMostPoorPerson(string[] peopleAndBalances)
        {
            var parsedFile = BalanceParser.Parser(peopleAndBalances);
            return FindPoorest(parsedFile);
        }

        internal static Person[] FindPoorest(Person[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            var persons = new Person[0];
            var lowestAmount = decimal.MaxValue;

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPerson = balances[i];
                var lowestAmountOfPerson = currentPerson.CurrentBalance();

                if (lowestAmount > lowestAmountOfPerson)
                {
                    lowestAmount = lowestAmountOfPerson;

                    persons = new Person[0];
                }

                if (lowestAmount >= lowestAmountOfPerson)
                {
                    persons = AddPerson(currentPerson, persons);
                }
            }
            return persons;
        }

        public static Person[] FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var parsedFile = BalanceParser.Parser(peopleAndBalances);

            return FindBiggestLoss(parsedFile);  
        }

        private static Person[] FindBiggestLoss(Person[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            var persons = new Person[0];
            var biggestLoss = decimal.MinValue; 

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPerson = balances[i]; 

                if (currentPerson.GetBalance().Length <= 1)
                {
                    return new Person[0];
                }

                 var biggestLossPerson = currentPerson.BiggestLoss(); 
                
                if (biggestLossPerson > biggestLoss)
                {
                    biggestLoss = biggestLossPerson;
                    persons = new Person[0]; 
                }

                if (biggestLossPerson >= biggestLoss)
                {
                    persons = AddPerson(currentPerson, persons);
                }
            }

            return persons;
        }


        private static decimal FindBiggestLossPerson(decimal[] allAmounts)
        {
            var biggestLossPerson = decimal.MinValue;
            for (int j = 0; j < allAmounts.Length - 1; j++)
            {
                var amount1 = allAmounts[j];
                var amount2 = allAmounts[j + 1]; 
                var lossForCurrentPerson = amount1 - amount2;

                //check if loss is greater then the current highest loss
                if (lossForCurrentPerson > biggestLossPerson)
                {
                    biggestLossPerson = lossForCurrentPerson;
                }
            }

            return biggestLossPerson;
        }


        //    public static string FindRichestPerson(string[] peopleAndBalances)
        //    {
        //        if (IsInValidInput(peopleAndBalances))
        //        {
        //            return InValidOutput;
        //        }

        //        var answer = BalanceParser.FindRichest(peopleAndBalances);

        //        if (answer.GetPersons().ToString().Contains(", "))
        //        {
        //            BalanceParser.ReplaceCommaWithAnd(answer.GetPersons());
        //            return $"{answer.GetPersons()} are the richest people. ¤{answer.GetAmount()}.";
        //        }
        //        else
        //        {
        //            return $"{answer.GetPersons()} is the richest person. ¤{answer.GetAmount()}.";
        //        }

        //    }
    }
}