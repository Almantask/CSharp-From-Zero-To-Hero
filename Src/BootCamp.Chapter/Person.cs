using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        public static string GetClassName()
        {
            return "Person";
        }

        private string _name;
        // Only this method makes it readonly
        public string GetName()
        {
            return _name;
        }

        // Only this method makes it write-only
        private void SetName(string name)
        {
            _name = name;
        }

        private string _surename;

        public void SetSurename(string surename)
        {
            _surename = surename;
        }

        public string GetSurename()
        {
            return _surename;
        }

        public string GetFullName()
        {
            return $"{_name} {_surename}";
        }

        private DateTime _birthday;

        public int GetAge()
        {
            return (int)(DateTime.Now - _birthday).TotalDays / 365;
        }

        // Parameterised constructor
        public Person(string name, DateTime birthday)
        {
            _name = name;
            _birthday = birthday;
        }

        // ctor- short for constructor
        // this is a default constructor
        // every class has one, unless a custom ctor is defined.
        public Person()
        {
        }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
