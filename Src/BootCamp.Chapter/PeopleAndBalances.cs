using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class PeopleAndBalances
    {
        private List<Person> _people = new List<Person>();

        public int GetNumberOfPeople()
        {
            return _people.Count;
        }
        public Person GetPerson(int index)
        {
            return _people[index];
        }

        private const string NotFound = "not found";

        public PeopleAndBalances(string informationOnPeopleBalances)
        {
            _people = GetPeopleFromInput(informationOnPeopleBalances);
        }

        private List<Person> GetPeopleFromInput(string informationOnPeopleBalances)
        {
            string[] peopleInformation = informationOnPeopleBalances.Split(Environment.NewLine);
            if (peopleInformation.Length <= 0) throw new InvalidBalancesException("Balances are invalid: not possible to split input into seperate people");

            List<Person> people = new List<Person>();

            for (int i = 0; i <= peopleInformation.Length -1; i++)
            {
                Person person = new Person(peopleInformation[i]);
                people.Add(person);
            }

            return people;
        }

        //public string FindHighestBalanceEver()
        //{
        //    string[] peopleAndBalances = _people;

        //    string personWithHighestBalanceEver = NotFound;
        //    double highestBalance = double.MinValue;


        //    foreach (string personInformation in peopleAndBalances)
        //    {
        //        string[] personInformationSplit = GetPersonInformationSplitted(personInformation);

        //        const int FirstBalanceIndex = 1;

        //        for (int i = FirstBalanceIndex; i <= personInformationSplit.Length - 1; i++)
        //        {
        //            bool isNumber = double.TryParse(personInformationSplit[i], out double balance);

        //            if (!isNumber)
        //            {
        //                break;
        //            }
        //            else if (balance > highestBalance)
        //            {
        //                highestBalance = balance;
        //                personWithHighestBalanceEver = $"{personInformationSplit[0]} (current balance: {personInformationSplit[^1]})";
        //            }
        //        }

        //    }
        //    string informationOnHighestBalance = $"{personWithHighestBalanceEver} had the biggest historic balance: {highestBalance}";

        //    return informationOnHighestBalance;
        //}

        private static string[] GetPersonInformationSplitted(string personInformation)
        {
            return personInformation.Replace("£", "").Split(",");
        }


    }
}
