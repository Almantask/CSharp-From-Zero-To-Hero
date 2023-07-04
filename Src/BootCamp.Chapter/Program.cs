using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
	class Program
	{
		public static event EventHandler OnAppClose;
		static void Main(string[] args)
		{
			//Set events
			PeopleDemo.OnStart += PeopleDemoStarted;
			PeopleDemo.OnStop += PeopleDemoFinished;
			PeopleDemo.OnPredicate += PeoplePredicateTriggered;
			OnAppClose += AppClosed;

			PeopleDemo.Run();

			OnAppClose?.Invoke(null, new EventArgs());
			Console.ReadLine();
		}

		public static void PeopleDemoStarted(object sender, EventArgs e)
		{
			Console.WriteLine("Demo Started.");
		}
		public static void PeopleDemoFinished(object sender, EventArgs e)
		{
			Console.WriteLine("Demo Finished.");
		}
		public static void PeoplePredicateTriggered(object sender, EventArgs e)
		{
			Console.WriteLine("People Predicate Triggered.");
		}
		public static void AppClosed(object sender, EventArgs e)
		{
			Console.WriteLine("Program Finished Running.");
		}
	}
}
