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
        public static bool IsA(Person person)
        {
            int personAge = person.GetAgeInYears();

            if (personAge <= 18 || person.Country == "UK" || person.SureName.ToLower().Contains('a'))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person)
        {
            int personAge = person.GetAgeInYears();

            if (personAge >= 18 || person.Country == "UK" || person.SureName.ToLower().Contains('a'))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// c) who do not live in UK, whose surename and name does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsC(Person person)
        {
            if (person.Country == "UK" || person.SureName.ToLower().Contains('a') || person.Name.ToLower().Contains('a'))
            {
                return false;
            }

            return true;
        }

        private static int GetAgeInYears(this Person person)
        {
            var currentAgeSpan = DateTime.Today - person.Birthday.Date;

            return (int)currentAgeSpan.TotalDays / 365;
        }
    }
}
