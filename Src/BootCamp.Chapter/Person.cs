using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        private string personName;
        private List<string> personBalance;
        private static int totalPersonCount;

        public Person()
        {
            this.personBalance = new List<string>();
            totalPersonCount++;
        }
        public Person(string name)
        {
            this.personName = name;
            this.personBalance = new List<string>();
            totalPersonCount++;
        }

        public void UpdatePersonBalance(string balance)
        {
            this.PersonBalance.Add(balance);
        }

        public override string ToString()
        {
            return this.PersonName;
        }

        public string PersonName
        {
            get { return personName; }
            set { this.personName = value; }
        }

        public List<string> PersonBalance
        {
            get { return personBalance; }
            set { this.personBalance = value; }
        }

    }
}
