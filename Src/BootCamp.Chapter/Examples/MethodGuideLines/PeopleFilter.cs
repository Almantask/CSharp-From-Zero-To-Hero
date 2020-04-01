using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.MethodGuideLines
{
    static class PeopleFilter
    {
        // Any collection goes in
        // And generalized collection goes out.
        public static IEnumerable<Person> Filter(
            IEnumerable<Person> people, 
            Predicate<Person> predicate)
        {
            var qualified = new List<Person>();

            foreach (var person in people)
            {
                if (predicate(person))
                {
                    qualified.Add(person);
                }
            }

            return qualified;
        }
    }
}
