using System;

namespace BootCamp.Chapter
{
    public class Person
    {
        public readonly int Age;
        public readonly string Birthday;
        public readonly string Firstname;
        public readonly string Surename;
        public readonly string Gender;
        public readonly string Country;
        public readonly string Email;
        public readonly string StreetAddress;

        public Person(string firstname, string surename, string birthday, string gender, string country, string email, string streetAddress, int age)
        {
            Birthday = birthday;
            Firstname = firstname;
            Surename = surename;
            Gender = gender;
            Country = country;
            Email = email;
            StreetAddress = streetAddress;
            Age = age;
        }

        // test function to check that the persons contact details were correctly parsed.
        public void TestContactDetailsDisplayer()
        {
            Console.WriteLine($"-----------\nName: {Firstname} {Surename}\nDate of Birth: {Birthday}\nGender: {Gender}\nCountry: {Country}\nEmail Address: {Email}\nStreet Address: {StreetAddress}\nAge: {Age}\n-----------");
        }
    }
}