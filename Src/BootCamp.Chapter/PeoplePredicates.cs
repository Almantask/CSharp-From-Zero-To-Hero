using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        private const string country = "United Kingdom";
        private const int ageBarrier = 18;
        private const char letter = 'a';

        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        public static bool IsA(Person person)
        {
            var condittionsMet = !person.SureName.Contains(letter) && GetAge(person.Birthdate) > ageBarrier && person.Country != country;
            return condittionsMet;
        }

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person)
        {
            var condittionsMet = !person.SureName.Contains(letter) && GetAge(person.Birthdate) < ageBarrier && person.Country != country;
            return condittionsMet;
        }

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsC(Person person)
        {
            var condittionsMet = !person.SureName.Contains(letter) && person.Country != country;
            return condittionsMet;
        }

        private static int GetAge(DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }
    }
}