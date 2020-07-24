using System;
using System.Collections.Generic;
using System.Text;

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
            List<Person> peopleWithHighestBalance = new List<Person>();


            foreach (Person person in _people)
            {
                if (person.GetHighestBalanceEver() > highestBalance)
                {
                    highestBalance = person.GetHighestBalanceEver();
                    peopleWithHighestBalance.Clear();
                    peopleWithHighestBalance.Add(person);
                }
                else if (person.GetHighestBalanceEver() == highestBalance)
                {
                    peopleWithHighestBalance.Add(person);
                }
            }

            string informationOnHighestBalance = "";
            string fullMessage = $"had the most money ever. ¤{highestBalance}.";
            if (peopleWithHighestBalance.Count == 0)
            {
                informationOnHighestBalance = "N/A.";
            }
            else if (peopleWithHighestBalance.Count == 1)
            {
                informationOnHighestBalance = $"{peopleWithHighestBalance[0].GetName()} {fullMessage}";
            }
            else if (peopleWithHighestBalance.Count == 2)
            {
                informationOnHighestBalance = $"{peopleWithHighestBalance[0].GetName()} and {peopleWithHighestBalance[1].GetName()} {fullMessage}";
            }
            else
            {
                var allPeopleWithHighestBalance = new StringBuilder();
                allPeopleWithHighestBalance.Append(peopleWithHighestBalance[0].GetName());
                for (int i = 1; i <= peopleWithHighestBalance.Count -2; i++)
                {
                    allPeopleWithHighestBalance.Append($", {peopleWithHighestBalance[i].GetName()}");
                }
                allPeopleWithHighestBalance.Append($" and {peopleWithHighestBalance[^1].GetName()}");

                informationOnHighestBalance = $"{allPeopleWithHighestBalance.ToString()} {fullMessage}";
            }

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
            if (String.IsNullOrEmpty(informationOnPeopleBalances)) return new List<Person>();

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
