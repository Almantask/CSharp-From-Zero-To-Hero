using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        public static bool IsA(Person person) => person.Age > 18 && person.Country != "UK" && !SurnameContainA(person);

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person) => person.Age < 18 && person.Country != "UK" && !SurnameContainA(person);

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsC(Person person) => person.Country != "UK" && !SurnameContainA(person) && !NameContainA(person);
        public static bool NameContainA(Person person) => person.Name.Contains('a');
        public static bool SurnameContainA(Person person) => person.Surname.Contains('a');
    }
}
