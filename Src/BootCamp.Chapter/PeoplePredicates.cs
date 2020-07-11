using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        public static bool IsA(Person person)
        {
            return ((person.Age > 18) && (person.Country != "United Kingdom" && person.Country != "UK") && (!person.Surename.Contains('a')));
        }

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person)
        {
            return person.Age < 18 && (person.Country != "United Kingdom" && person.Country != "UK") && !person.Surename.Contains('a');
        }

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsC(Person person)
        {
            return (person.Country != "United Kingdom" && person.Country != "UK") && !person.Surename.Contains('a') && !person.Firstname.Contains('a');
        }
    }
}
