using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        private const string country = "UK";
        private const int ageBarrier = 18;
        private const char letter = 'a';

        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        public static bool IsA(Person person)
        {
            return person.Age > ageBarrier
                && person.Country != country
                && !person.SureName.Contains(letter);
        }

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person)
        {
            return person.Age < ageBarrier
                && person.Country != country
                && !person.SureName.Contains(letter);
        }

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsC(Person person)
        {
            return person.Country != country
                && !person.Name.Contains(letter)
                && !person.SureName.Contains(letter);
        }
    }
}