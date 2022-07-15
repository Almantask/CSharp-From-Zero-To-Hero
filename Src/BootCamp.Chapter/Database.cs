using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BootCamp.Chapter;

public class Database
{
    private List<Person> _people = new List<Person>();

    /// <summary>
    /// Creates a list of people out of a string array of peoples balances
    /// </summary>
    /// <param name="rawBalances"> Must be in the format of "Name, Balance1, Balance2, Balance3..."</param>
    public Database(string[] rawBalances)
    {
        foreach (var personHistory in rawBalances)
        {
            var array = personHistory.Split(", ");
            
            var name = array[0];
            var intArray = Array.ConvertAll(array[1..], int.Parse);

            _people.Add(new Person(name, intArray));
        }
    }

    public List<Person> getPeople()
    {
        return _people;
    }

    public List<Person> getPoorestPeople()
    {
        List<Person> poorestPeople = new List<Person>{_people.First()};
        
        foreach (var person in _people.Skip(1))
        {
            if (person.GetCurrentBalance() < poorestPeople.First().GetCurrentBalance()) poorestPeople = new List<Person>{person};
            else if (person.GetCurrentBalance() == poorestPeople.First().GetCurrentBalance()) poorestPeople.Add(person);
        }
        
        return poorestPeople;
    }
    
    public List<Person> getRichestPeople()
    {
        List<Person> richestPeople = new List<Person>{_people.First()};
        
        foreach (var person in _people.Skip(1))
        {
            if (person.GetCurrentBalance() > richestPeople.First().GetCurrentBalance()) richestPeople = new List<Person>{person};
            else if (person.GetCurrentBalance() == richestPeople.First().GetCurrentBalance()) richestPeople.Add(person);
        }
        
        return richestPeople;
    }

    public Tuple<Person, int> getPersonWithBiggestLoss()
    {
        Person personWithBiggestLoss = _people.First();
        var biggestLoss = 0;
        
        foreach (Person person in _people)
        {
            var previousAmount = person.GetAllBalances().First();
            foreach (var amount in person.GetAllBalances().Skip(1))
            {
                if (previousAmount - amount > biggestLoss)
                {
                    personWithBiggestLoss = person;
                    biggestLoss = previousAmount - amount;
                }
                previousAmount = amount;
            }
        }

        if (biggestLoss == 0) throw new InvalidBalancesException();
        return Tuple.Create(personWithBiggestLoss, biggestLoss);
    }
    
    public List<Person> getPersonWithHighestHistoricBalance()
    {
        List<Person> richestPeople = new List<Person>{_people.First()};
        
        foreach (var person in _people.Skip(1))
        {
            if (person.GetHighestBalance() > richestPeople.First().GetHighestBalance()) richestPeople = new List<Person>{person};
            else if (person.GetHighestBalance() == richestPeople.First().GetHighestBalance()) richestPeople.Add(person);
        }
        
        return richestPeople;
    }
}