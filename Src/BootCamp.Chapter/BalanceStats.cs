using System;
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

        internal static Person[] FindRichestPerson(string[] contents)
        {
            var parsedFile = BalanceParser.Parser(contents);
            return FindRichest(parsedFile);
        }

        internal static Person[] FindRichest(Person[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            var persons = new Person[0];
            var lowestAmount = decimal.MinValue;

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPerson = balances[i];
                var amountOfPerson = currentPerson.CurrentBalance();

                if (lowestAmount < amountOfPerson)
                {
                    lowestAmount = amountOfPerson;

                    persons = new Person[0];
                }

                if (lowestAmount <= amountOfPerson)
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
                var amountOfPerson = currentPerson.CurrentBalance();

                if (lowestAmount > amountOfPerson)
                {
                    lowestAmount = amountOfPerson;

                    persons = new Person[0];
                }

                if (lowestAmount >= amountOfPerson)
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
            var biggestLoss = decimal.MaxValue; 

            for (int i = 0; i < balances.Length; i++)
            {
                var currentPerson = balances[i]; 

                if (currentPerson.GetBalance().Length <= 1)
                {
                    return new Person[0];
                }

                 var biggestLossPerson = currentPerson.BiggestLoss(); 
                
                if (biggestLossPerson < biggestLoss)
                {
                    biggestLoss = biggestLossPerson;
                    persons = new Person[0]; 
                }

                if (biggestLossPerson <= biggestLoss)
                {
                    persons = AddPerson(currentPerson, persons);
                }
            }

            return persons;
        }


       


        
    }
}