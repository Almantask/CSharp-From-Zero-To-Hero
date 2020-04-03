using System;
using System.Collections;
using System.Collections.Generic;

namespace BootCamp.Chapter.Tests
{
    public class PersonPredicatesAndExpectations : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { (Predicate<Person>)PeoplePredicates.IsA, 1 };
            yield return new object[] { (Predicate<Person>)PeoplePredicates.IsB, 1 };
            yield return new object[] { (Predicate<Person>)PeoplePredicates.IsC, 1 };
            yield return new object[] { (Predicate<Person>)((person) => PeoplePredicates.IsA(person)
                            && PeoplePredicates.IsB(person)), 0 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}