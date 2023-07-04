using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public static class PeopleDemo
	{
		const string INPUT_FILE = @"Input/MOCK_DATA.csv";
		public static event EventHandler OnStart;
		public static event EventHandler OnStop;
		public static event EventHandler OnPredicate;

		public static void Run()
		{
			OnStart?.Invoke(null, new EventArgs());

			ContactsCenter center = new ContactsCenter(INPUT_FILE);

			PeoplePredicates.OnPredicate += OnPredicate;
			Predicate<Person> predicate = (person) => PeoplePredicates.IsA(person);
			predicate += (person) => PeoplePredicates.IsB(person);
			predicate += (person) => PeoplePredicates.IsC(person);

			center.Filter(predicate);

			OnStop?.Invoke(null, new EventArgs());
		}
	}
}
