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

            string messageAddition = $"had the most money ever. ¤{highestBalance}.";
            string informationOnHighestBalance = CreateMessage(peopleWithHighestBalance, messageAddition);

            return informationOnHighestBalance;
        }

        public string FindPersonWithBiggestLoss()
        {
            double biggestLoss = double.MinValue;
            List<Person> peopleWithBiggestLoss = new List<Person>();


            foreach (Person person in _people)
            {
                if (person.GetBiggestLoss() > biggestLoss)
                {
                    biggestLoss = person.GetBiggestLoss();
                    peopleWithBiggestLoss.Clear();
                    peopleWithBiggestLoss.Add(person);
                }
                else if (person.GetBiggestLoss() == biggestLoss && person.GetBiggestLoss() != double.MinValue)
                {
                    peopleWithBiggestLoss.Add(person);
                }
            }

            string messageAddition = $"lost the most money. -¤{biggestLoss}.";
            string informationOnBiggestLoss = CreateMessage(peopleWithBiggestLoss, messageAddition);
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

        private string CreateMessage(List<Person> people, string message)
        {
            if (people.Count == 0)
            {
                return "N/A.";
            }
            else if (people.Count == 1)
            {
                return $"{people[0].GetName()} {message}";
            }
            else if (people.Count == 2)
            {
                return $"{people[0].GetName()} and {people[1].GetName()} {message}";
            }
            else
            {
                var allPeopleWithHighestBalance = new StringBuilder();
                allPeopleWithHighestBalance.Append(people[0].GetName());
                for (int i = 1; i <= people.Count - 2; i++)
                {
                    allPeopleWithHighestBalance.Append($", {people[i].GetName()}");
                }
                allPeopleWithHighestBalance.Append($" and {people[^1].GetName()}");

                return $"{allPeopleWithHighestBalance.ToString()} {message}";
            }
        }


    }
}
