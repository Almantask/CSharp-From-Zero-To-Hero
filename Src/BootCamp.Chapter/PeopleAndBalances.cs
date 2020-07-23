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


        public string FindHighestBalanceEver()
        {
            double highestBalance = double.MinValue;
            Person personWithHighestBalance = new Person(NotFound);


            foreach (Person person in _people)
            {
                if (person.GetHighestBalanceEver() > highestBalance)
                {
                    highestBalance = person.GetHighestBalanceEver();
                    personWithHighestBalance = person;
                }
            }

            string informationOnHighestBalance = $"{personWithHighestBalance.GetName()} had the biggest historic balance: {highestBalance}";
            return informationOnHighestBalance;
        }

        public string FindPersonWithBiggestLoss()
        {
            double biggestLoss = double.MinValue;
            Person personWithBiggestLoss = new Person(NotFound);


            foreach (Person person in _people)
            {
                if (person.GetBiggestLoss() > biggestLoss)
                {
                    biggestLoss = person.GetBiggestLoss();
                    personWithBiggestLoss = person;
                }
            }

            string informationOnBiggestLoss = $"The person with the biggest loss was: {personWithBiggestLoss.GetName()}: {biggestLoss}";
            return informationOnBiggestLoss;
        }

        public string FindRichestPerson()
        {
            double highestCurrentBalance = double.MinValue;
            Person richestPerson = new Person(NotFound);


            foreach (Person person in _people)
            {
                if (person.GetCurrentBalance() > highestCurrentBalance)
                {
                    highestCurrentBalance = person.GetCurrentBalance();
                    richestPerson = person;
                }
            }

            string informationOnRichestPerson = $"Richest person currently is {richestPerson.GetName()}: {highestCurrentBalance}";
            return informationOnRichestPerson;
        }

        public string FindPoorestPerson()
        {
            double lowestCurrentBalance = double.MaxValue;
            Person poorestPerson = new Person(NotFound);


            foreach (Person person in _people)
            {
                if (person.GetCurrentBalance() < lowestCurrentBalance)
                {
                    lowestCurrentBalance = person.GetCurrentBalance();
                    poorestPerson = person;
                }
            }

            string informationOnPoorestPerson = $"Poorest person currently is {poorestPerson.GetName()}: {lowestCurrentBalance}";
            return informationOnPoorestPerson;
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


    }
}
