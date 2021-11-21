using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person("Pete", "R", "12/18/1990", "male", "Poland", "mail@mail.com", "some address");

            if(p.Gender == Gender.male)
            {
                Console.WriteLine($"{p.Name} is male");
            }

            ContactsCenter contacts = new ContactsCenter(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");

            for ( int i = 0; i < contacts.People.Count; i++)
            {
                Predicate<Person> isOverEighteen = (person) => person.Age > 18 && person.Country != "UK";
                isOverEighteen(contacts.People[i]);
            }



            Console.ReadKey();
        }
    }
}
