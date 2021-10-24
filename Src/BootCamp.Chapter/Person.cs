using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        private string personName;
        private string[] personBalance;
        private static int totalPersonCount;

        public Person(string name, string[] balance)
        {
            this.personName = name;
            this.personBalance = balance;
            totalPersonCount++;
        }

        public string PersonName
        {
            get { return personName; }
        }

        public string[] PersonBalance
        {
            get { return personBalance; }
        }

    }
}
