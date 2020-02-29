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
            var parser = new BalanceParser();
            var parsedFile = parser.Parser(peopleAndBalances); 
            var person = FindHighestBalance(parsedFile);

            return person ;
        }

        public static Person[] FindHighestBalance(Person[] balances)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            var persons = new Person[0];
            var highestBalanceEver = decimal.MinValue;
            var personWithHighestBalance = new Person("", new decimal[0]); 

            for (int i = 0; i <= balances.Length - 1; i++)
            {
                var currentPerson = balances[i];

                var highestAmountOfPerson = currentPerson.HighestBalance(); 

                if (highestAmountOfPerson > highestBalanceEver)
                {
                    personWithHighestBalance = currentPerson;
                    highestBalanceEver = highestAmountOfPerson; 
                   
                }

                if (highestAmountOfPerson >= currentPerson.HighestBalance())
                {
                    persons = AddPerson(personWithHighestBalance, persons);
                }
            }

            return persons ;
        }

        private static Person[] AddPerson(Person person, Person[] persons)
        {
            var newArray = new Person[persons.Length + 1];
            for (int i = 0; i < persons.Length - 1; i++)
            {
                newArray[i] = persons[i]; 
            }

            newArray[^1] = person;
            return newArray; 
        }

        //    public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        //    {
        //        if (IsInValidInput(peopleAndBalances))
        //        {
        //            return InValidOutput;
        //        }

        //        var answer = BalanceParser.FindBiggestLoss(peopleAndBalances);

        //        if (String.IsNullOrEmpty(answer.GetPersons().ToString()))
        //        {
        //            return InValidOutput; 
        //        }

        //        return $"{answer.GetPersons()} lost the most money. -¤{answer.GetAmount()}.";
        //    }

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

        //    public static string FindMostPoorPerson(string[] peopleAndBalances)
        //    {
        //        if (IsInValidInput(peopleAndBalances))
        //        {
        //            return InValidOutput;
        //        }

        //        var answer = BalanceParser.FindPoorest(peopleAndBalances);

        //        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        //        NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
        //        noParens.CurrencyNegativePattern = 1;
        //        var lowestBalanceString = answer.GetAmount().ToString("C0", noParens);

        //        if (answer.GetPersons().ToString().Contains(','))
        //        {
        //            BalanceParser.ReplaceCommaWithAnd(answer.GetPersons());
        //            return $"{answer.GetPersons().ToString()} have the least money. {lowestBalanceString}.";
        //        }
        //        else
        //        {
        //            return $"{answer.GetPersons().ToString()} has the least money. {lowestBalanceString}.";
        //        }

        //    }
    }
}